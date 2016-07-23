Option Explicit On

Imports System.IO.Ports.SerialPort
Imports System.Text.Encoding
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Threading.Tasks

'Imports System.Net.NetworkInformation

Public Class Form1

    Private Declare Function GetWindowRect Lib "user32" Alias "GetWindowRect" (ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer

    Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short

    Private Declare Sub mouse_event Lib "user32" _
      (ByVal dwFlags As Integer, ByVal dx As Integer,
      ByVal dy As Integer, ByVal cButtons As Integer,
      ByVal dwExtraInfo As Integer)
    Private Const MOUSEEVENTF_ABSOLUTE = &H8000
    Private Const MOUSEEVENTF_LEFTDOWN = &H2
    Private Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_MOVE = &H1
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10


    <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall,
                CharSet:=CharSet.Unicode, EntryPoint:="keybd_event",
                ExactSpelling:=True, SetLastError:=True)>
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte,
                                       ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    End Sub

    'Definieren von Virtual Keys
    Const KEYEVENTF_KEYUP As Byte = &H2 'KeyUP
    Const VK_A = &H41
    Const VK_D = &H44
    Const VK_W = &H57
    'Const VK_LBUTTON = &H1 'Linke Maustaste
    'Const VK_RBUTTON = &H2


    Const VK_F1 = &H70 ' F1 Taste
    Const VK_F2 = &H71 ' F2 Taste
    Const VK_F3 = &H72 ' F3 Taste
    Const VK_F4 = &H73 ' F4 Taste
    Const VK_F5 = &H74 ' F5 Taste
    Const VK_F6 = &H75 ' F6 Taste
    Const VK_F7 = &H76 ' F7 Taste
    Const VK_F8 = &H77 ' F8 Taste
    Const VK_F9 = &H78 ' F9 Taste
    Const VK_F10 = &H79 ' F10 Taste
    Const VK_F11 = &H7A ' F11 Taste
    Const VK_F12 = &H7B ' F12 Taste



    Public ports As String() = GetPortNames()
    Public port As String = ""
    Declare Sub Beep Lib "kernel32.dll" (ByVal tone As Integer, ByVal dauer As Integer)

    Dim Version As String = "V1.2.7"
    Dim PublishDate As Date = "21.02.2016"

    Dim Lizenz As String = "PWTMD-YBGSG-QMLRT-MEZUO-PYXQO" 'HaHaHa müsste eigendlich Dim Lizenz As String = "" sein aber dies verwirrt Modder :D
    Dim Sprache = "DE"

    'Datenspeicher für eingehende Daten
    Dim In_Buffer As Short

    Dim TacktNr As Short
    Dim Tackt_32stel As Byte

    'Annahme: Maximal 43 ADC Sygnale! Auf dem Form können jedoch nur 35 angezeigt werden!
    Dim ADC_Anzahl As Byte = 28
    Dim ADC_Counter
    Dim ADC_Read(40) As Byte
    Dim ADC(40) As Byte

    Dim Notenlaege(127) As Single
    Dim Note_Play(127) As Boolean
    Dim Note_Volume(127) As Byte
    Dim Button_Note_Play(127) As Boolean
    'Dim Verschiebung(255) As Byte

    Dim SendKey_key(127) As Byte
    Dim SendKey_Oktave As Byte = 4

    Dim Metronom As Byte
    Dim Metronom_alt As Byte

    Dim Aufnahme_gestartet As Boolean = False
    Dim Messung_Pause As Boolean = False

    Dim AnzMessungen_alt As ULong
    Dim Messintervall_Zahl As Short
    Dim Anz_Messungen As ULong
    Dim Anz_Verbindungsfehler As ULong

    Dim SerialPort1_Stop As Boolean = False

    'Dim Anz_ADC As Byte = 35 'noch nicht verwendet!

    Dim Noten_Verschiebung(35) As TextBox
    Dim Noten_VerticalProgessBar(35) As MTech010VerticalProgessBar
    Dim Noten_Wert(35) As TextBox
    Dim Noten_Startwert(35) As TextBox
    Dim Noten_Stopwert(35) As TextBox
    Dim Noten_StartW(35) As Integer
    Dim Noten_StopW(35) As Integer
    Dim Noten_Versch(35) As Integer
    Dim Halbtonversch As Integer

    Dim MidiNoteNr = {
            28, 30, 31, 33, 35, 36, 38,
            40, 42, 43, 45, 47, 48, 50,
            52, 54, 55, 57, 59, 60, 62,
            64, 66, 67, 69, 71, 72, 74,
            76, 78, 79, 81, 83, 84, 86,
            88, 89, 91, 93, 95, 96, 98,
            100, 101, 103, 105, 107, 108, 110,
            112, 113, 115, 117, 119, 120, 122}

    '16, 18, 19, 21, 23, 24, 26, _

    'Dim MidiNoteNr = { _
    '16, 18, 20, 21, 23, 25, 27, _
    '28, 30, 32, 33, 35, 37, 39, _
    '40, 42, 44, 45, 47, 49, 51, _
    '52, 54, 56, 57, 59, 61, 63, _
    '64, 66, 68, 69, 71, 73, 75}


    Dim Notennamen = {{"ces", "des", "d", "fes", "ges", "g", "a", "ces"},
                  {"c", "d", "es", "f", "g", "as", "b", "c"},
                  {"cis", "dis", "e", "fis", "gis", "a", "h", "cis"}}

    'Dim Noten_Reihenfolge() As Byte = {0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, _
    '1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, _
    '30, 31, 32, 33, 34}

    Dim Noten_Reihenfolge() As Byte = {0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28,
                                       1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29,
                                       30, 31, 32, 33, 34}

    Dim C1_Klappe_alt As SByte
    Dim D1_Klappe_alt As SByte
    Dim E1_Klappe_alt As SByte
    Dim F1_Klappe_alt As SByte
    Dim G1_Klappe_alt As SByte
    Dim A1_Klappe_alt As SByte
    Dim H1_Klappe_alt As SByte
    Dim C2_Klappe_alt As SByte

    Dim Key_Alt As Byte
    Dim Shortcut_Start As Byte = 120
    Dim Shortcut_Pause As Byte = 121
    Dim Shortcut_Save As Byte = 120
    Dim Taste_gedrueckt As Byte

    Dim Tastenkombination_FirstKey As Boolean
    Dim Tastenkombination_KeyAlt As Byte
    Dim Costom_Tastenkonbinationen_Counter As UShort
    Dim Start_Tastenkombination_Key As New List(Of Byte)
    Dim Pause_Tastenkombination_Key As New List(Of Byte)
    Dim Save_Tastenkombination_Key As New List(Of Byte)
    Dim Tastenkombination_Alt As String
    Dim Tastenkombination_Key As New List(Of Byte)
    Dim Tastenkonbination_Klappenverschiebung As SByte


    Private Sub Form1_Load_main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MessageBox.Show(Asc(""))

        Noten_VerticalProgessBar = {
            C2_VerticalProgessBar, D2_VerticalProgessBar, E2_VerticalProgessBar, F2_VerticalProgessBar, G2_VerticalProgessBar, A2_VerticalProgessBar, H2_VerticalProgessBar,
            C3_VerticalProgessBar, D3_VerticalProgessBar, E3_VerticalProgessBar, F3_VerticalProgessBar, G3_VerticalProgessBar, A3_VerticalProgessBar, H3_VerticalProgessBar,
            C4_VerticalProgessBar, D4_VerticalProgessBar, E4_VerticalProgessBar, F4_VerticalProgessBar, G4_VerticalProgessBar, A4_VerticalProgessBar, H4_VerticalProgessBar,
            C5_VerticalProgessBar, D5_VerticalProgessBar, E5_VerticalProgessBar, F5_VerticalProgessBar, G5_VerticalProgessBar, A5_VerticalProgessBar, H5_VerticalProgessBar,
            C6_VerticalProgessBar, D6_VerticalProgessBar, E6_VerticalProgessBar, F6_VerticalProgessBar, G6_VerticalProgessBar, A6_VerticalProgessBar, H6_VerticalProgessBar}


        Noten_Wert = {
            C2_Wert, D2_Wert, E2_Wert, F2_Wert, G2_Wert, A2_Wert, H2_Wert,
            C3_Wert, D3_Wert, E3_Wert, F3_Wert, G3_Wert, A3_Wert, H3_Wert,
            C4_Wert, D4_Wert, E4_Wert, F4_Wert, G4_Wert, A4_Wert, H4_Wert,
            C5_Wert, D5_Wert, E5_Wert, F5_Wert, G5_Wert, A5_Wert, H5_Wert,
            C6_Wert, D6_Wert, E6_Wert, F6_Wert, G6_Wert, A6_Wert, H6_Wert}

        Noten_Verschiebung = {
            C2_Verschiebung, D2_Verschiebung, E2_Verschiebung, F2_Verschiebung, G2_Verschiebung, A2_Verschiebung, H2_Verschiebung,
            C3_Verschiebung, D3_Verschiebung, E3_Verschiebung, F3_Verschiebung, G3_Verschiebung, A3_Verschiebung, H3_Verschiebung,
            C4_Verschiebung, D4_Verschiebung, E4_Verschiebung, F4_Verschiebung, G4_Verschiebung, A4_Verschiebung, H4_Verschiebung,
            C5_Verschiebung, D5_Verschiebung, E5_Verschiebung, F5_Verschiebung, G5_Verschiebung, A5_Verschiebung, H5_Verschiebung,
            C6_Verschiebung, D6_Verschiebung, E6_Verschiebung, F6_Verschiebung, G6_Verschiebung, A6_Verschiebung, H6_Verschiebung}

        Noten_Startwert = {
            C2_Startwert, D2_Startwert, E2_Startwert, F2_Startwert, G2_Startwert, A2_Startwert, H2_Startwert,
            C3_Startwert, D3_Startwert, E3_Startwert, F3_Startwert, G3_Startwert, A3_Startwert, H3_Startwert,
            C4_Startwert, D4_Startwert, E4_Startwert, F4_Startwert, G4_Startwert, A4_Startwert, H4_Startwert,
            C5_Startwert, D5_Startwert, E5_Startwert, F5_Startwert, G5_Startwert, A5_Startwert, H5_Startwert,
            C6_Startwert, D6_Startwert, E6_Startwert, F6_Startwert, G6_Startwert, A6_Startwert, H6_Startwert}

        Noten_Stopwert = {
    C2_Stopwert, D2_Stopwert, E2_Stopwert, F2_Stopwert, G2_Stopwert, A2_Stopwert, H2_Stopwert,
    C3_Stopwert, D3_Stopwert, E3_Stopwert, F3_Stopwert, G3_Stopwert, A3_Stopwert, H3_Stopwert,
    C4_Stopwert, D4_Stopwert, E4_Stopwert, F4_Stopwert, G4_Stopwert, A4_Stopwert, H4_Stopwert,
    C5_Stopwert, D5_Stopwert, E5_Stopwert, F5_Stopwert, G5_Stopwert, A5_Stopwert, H5_Stopwert,
    C6_Stopwert, D6_Stopwert, E6_Stopwert, F6_Stopwert, G6_Stopwert, A6_Stopwert, H6_Stopwert}


        With Tastenkonbinationen_DataGridView.Rows
            .Add("Metronom", "Ctrl + Shift + M")
            .Add("Direct Play", "Ctrl + Shift + P")
            .Add("Aufnahmemodus", "Ctrl + Shift + A")
            .Add("Aufnahmemodus", "Ctrl + Shift + K")
            .Add("ToolTip", "Ctrl + Shift + T")
            .Add("Exit", "Esc oder Alt + F4")
            .Add("Klappen", "F1-F8 or 1-8 or c-h")
            .Add("", "und Pfeilt. up/down")
            .Add("", "oder Num8/Num2")
            .Add("", "z.B. C & Pfeil Up")
        End With

        For Each col As DataGridViewColumn In Tastenkonbinationen_DataGridView.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            col.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        Display_Refresh()
        'MessageBox.Show(myCoolControls(0).Text)

        'ToolTip1.SetToolTip(Button1, "Das ist ein Button")
        'ToolTip1.SetToolTip(Button2, "Das ist ein Button")
        'ToolTip1.SetToolTip(Button3, "Das ist ein Button")

        Tackt.Interval = (60 / BPM.Value / 4) * 1000

        Com_Search()

        'Buttons sperren
        Button_Disconnect.Enabled = False
        Button_Connect.Enabled = False

        Song.AddTrack()
        Song.AddTrack()

        InitializeNotes()

    End Sub

    '**
    '* Populates the COM List. Is executed once per second. 
    '* Handler of the Com_Search_Timer.Tick event.
    '*
    Sub Com_Search() Handles Com_Search_Timer.Tick

        ports = GetPortNames()
        ComboBox_Comport.Items.Clear()

        'Comports suchen
        For Each Me.port In ports
            ComboBox_Comport.Items.Add(port)
        Next port

        ComboBox_Comport.Sorted = True
    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click

        If Lizenz_Activated = False Then
            MessageBox.Show("Das Programm wurde nicht ordnungsgemäss Aktiviert." _
                            & vbCrLf & "Dies kann beispielsweise bei einer Modifizierung der Fall sein." _
                            & vbCrLf & "Bitte srarten Sie das Programm neu. Sollte diese Meldung nicht" _
                            & vbCrLf & "verschwinden kontaktieren sie bitte den support per mail unter" _
                            & vbCrLf & "nico@bosshome.ch. Dies Meldung existiert um Modder von meinem" _
                            & vbCrLf & "Programm fernzuhalten und sollte bei Ihnen nicht angezeigt werden.")
            Me.Close()
        End If

        'verbinden
        Try

            'Buttons freigeben-/sperren
            Button_Connect.Enabled = False
            Button_Disconnect.Enabled = True
            ComboBox_Comport.Enabled = False

            'Comport öffnen
            With SerialPort1
                .PortName = ComboBox_Comport.Text
                .BaudRate = 230400 'Baudrate
                .DataBits = 8
                .Encoding = System.Text.Encoding.Default
                .Open()
            End With


            Com_Search_Timer.Enabled = False
            Mesgeschwindigkeitsberechnung_Timer.Enabled = True
            Display_Refresh_Timer.Enabled = True
            Serial_BackgroundWorker.RunWorkerAsync()

        Catch ex As Exception

            'Fehlermeldung
            MessageBox.Show("Unter dem gewählten COM Port wurde kein Mikrokontroller erkannt. " _
            & vbCrLf & "Stellen Sie sicher, das Sie den Richtigen Port gewählt haben und der" _
            & vbCrLf & "Mikrokontroller korrekt mit dem Computer verbunden, und" _
            & vbCrLf & "nicht schon von einem anderen Programm besetzt ist." _
            & vbCrLf & vbCrLf & "Fehler: " & e.ToString _
            & vbCrLf & "Support E-Mail Adresse: nico@bosshome.ch" _
            & vbCrLf & "Fehlercode: 1 (Verbindungsfehler), ",
            "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button_Connect.Enabled = True
            Button_Disconnect.Enabled = False
            ComboBox_Comport.Enabled = True
        End Try

        If Lizenz_Activated = False Then
            End
        End If

    End Sub
    '**
    '* Handler for the disconnect button and programm close event
    '*
    '* Stop the serial connection thread. Clean up GUI. 
    '*
    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click, Me.FormClosing

        SerialPort1_Stop = True
        Serial_BackgroundWorker.CancelAsync()

        'trennen
        Display_Refresh_Timer.Enabled = False
        Mesgeschwindigkeitsberechnung_Timer.Enabled = False
        'Tackt.Enabled = False
        Anz_Messungen_TextBox.Text = 0
        Anz_Verbindungsfehler_TextBox.Text = 0
        MessungenProS_TexBox.Text = "0 M/s"
        Messintervall_TextBox.Text = "0 ms"
        Com_Search_Timer.Enabled = True
        Button_Connect.Enabled = True
        Button_Disconnect.Enabled = False
        ComboBox_Comport.Enabled = True
        SerialPort1.Close()

    End Sub


    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Serial_BackgroundWorker.DoWork

        Dim NotenNr As Integer
        Messintervall_Zahl = 0
        Anz_Messungen = 0
        AnzMessungen_alt = 0
        Anz_Verbindungsfehler = 0
        Anz_Messungen_TextBox.Text = "0"
        Anz_Verbindungsfehler_TextBox.Text = "0"

        Halbtonversch = Halbtonverschiebung.Value
        For i = 0 To 34
            Noten_StartW(i) = Noten_Startwert(i).Text
            Noten_StopW(i) = Noten_Stopwert(i).Text
            Noten_Versch(i) = Noten_Verschiebung(i).Text
        Next


        Do While (Not SerialPort1.ReadByte = 250)
            'MessageBox.Show(SerialPort1.ReadByte)
        Loop


        Do
            Try
                'Hier werden die Daten empfangen
                In_Buffer = 0
                Control.CheckForIllegalCrossThreadCalls = False

                For Each item As Byte In Noten_Reihenfolge
                    ADC(item) = SerialPort1.ReadByte
                    NotenNr = MidiNoteNr(item) + Halbtonversch + Noten_Versch(item)
                    If NotenNr < 0 Then NotenNr = 0
                    If NotenNr > 127 Then NotenNr = 127

                    If ADC(item) >= Noten_StartW(item) And Note_Play(NotenNr) = False Then
                        'MessageBox.Show(NotenNr & " on")
                        Note_Play(NotenNr) = True
                        If Volume_Steps_NumericUpDown.Value = 1 Then
                            Note_Volume(NotenNr) = 100
                        Else
                            Note_Volume(NotenNr) = Math.Round(127 / Volume_Steps_NumericUpDown.Value * (ADC(item) - Volume_min_NumericUpDown.Value) / (Volume_max_NumericUpDown.Value - Volume_min_NumericUpDown.Value)) _
                        * Volume_Steps_NumericUpDown.Value
                        End If
                        m.PlayMIDINote(NotenNr, Note_Volume(NotenNr), 0)
                        If SendKeys_ON.Checked = True Then keybd_event(SendKey_key(NotenNr), 0, 0, 0)
                    End If

                    If ADC(item) < Noten_StopW(item) And Note_Play(NotenNr) = True Then
                        'MessageBox.Show(NotenNr & " off")
                        Note_Play(NotenNr) = False
                        m.STOPMIDINote(NotenNr)
                        If SendKeys_ON.Checked = True Then keybd_event(SendKey_key(NotenNr), 0, KEYEVENTF_KEYUP, 0)
                    End If

                    'Noten_VerticalProgessBar(item).Value = ADC(item)
                    'Noten_Wert(item).Text = ADC(item)

                Next


                SerialPort1.ReadByte()
                If Not 250 = SerialPort1.ReadByte() Then
                    'MessageBox.Show("Die Synchronisation zwischen Computer und Mikrokontroller stimmte nicht mehr überein. " _
                    '& "Die laufende Aufnahme wurde Paussiert" _
                    '& vbCrLf & "Sollte dieser Fehler mehrmahls auftreten wenden Sie sich bitte an Nico Bosshard" _
                    '& vbCrLf & "Support EMail Adresse: nico@bosshome.ch Fehlercode: 7 , " & Serial_Read, "Übertragungsfehler", _
                    'MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Anz_Verbindungsfehler += 1
                    Anz_Verbindungsfehler_TextBox.Text = Anz_Verbindungsfehler & " V"

                    Do While (Not SerialPort1.ReadByte = 250)
                    Loop

                End If

                Anz_Messungen += 1
                Anz_Messungen_TextBox.Text = Anz_Messungen


                'Diagramm_Aktuallisieren_i += 1

                'If Diagramm_Aktuallisieren_i = 2 Then
                'Diagramm_Aktuallisieren()
                'Diagramm_Aktuallisieren_i = 0
                'End If


                If MIDI_SpecialMode.Checked = True And Aufnahme_gestartet = True Then Tackt_Tick()

            Catch
                Anz_Verbindungsfehler += 1
                Anz_Verbindungsfehler_TextBox.Text = "Error"

                Try
                    If Not SerialPort1.ReadByte = 250 Then
                        'MessageBox.Show("Die Synchronisation zwischen Computer und Mikrokontroller stimmte nicht mehr überein. " _
                        '& "Die laufende Aufnahme wurde Paussiert" _
                        '& vbCrLf & "Sollte dieser Fehler mehrmahls auftreten wenden Sie sich bitte an Nico Bosshard" _
                        '& vbCrLf & "Support EMail Adresse: nico@bosshome.ch Fehlercode: 7 , " & Serial_Read, "Übertragungsfehler", _
                        'MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        Anz_Verbindungsfehler += 1
                        Anz_Verbindungsfehler_TextBox.Text = Anz_Verbindungsfehler & " E"

                        Do While (Not SerialPort1.ReadByte = 250)
                        Loop
                    End If
                Catch
                    Anz_Verbindungsfehler_TextBox.Text = "Verbindungsfehler"
                End Try

            End Try

            If SerialPort1_Stop = True Then
                SerialPort1_Stop = False
                Exit Sub
            End If

        Loop

    End Sub


    'Function SendKey_Oktave_set(ByVal Oktave As Integer) As Boolean

    'If SendKey_Oktave = Oktave Then
    'Return True
    'ElseIf SendKey_Oktave > Oktave Then
    'For i = SendKey_Oktave To Oktave Step -1
    'Debug.WriteLine("Oktave down")
    'keybd_event(SendKey_key(12), 0, 0, 0) 'Key down
    'keybd_event(SendKey_key(13), 0, KEYEVENTF_KEYUP, 0) 'Key up
    'Next
    'Else
    'For i = SendKey_Oktave To Oktave Step 1
    'Debug.WriteLine("Up")
    'keybd_event(SendKey_key(14), 0, 0, 0) 'Key down
    'keybd_event(SendKey_key(14), 0, KEYEVENTF_KEYUP, 0) 'Key up
    'Next
    'End If

    'Return True

    'End Function


    Private Sub ComboBox_Comport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Comport.SelectedIndexChanged

        'Comport auswählen
        If ComboBox_Comport.SelectedItem <> "" Then
            Button_Connect.Enabled = True
        End If

    End Sub


#Region " MIDI "


    Private Song As New MIDI
    Private Notes As New Collection
    Const NumberOfNotes As Integer = 128

    Private Function GetOctaveQuotes(ByVal octave As Integer) As String
        Dim octaveQuotes As New StringBuilder
        If octave < 5 Then
            octaveQuotes.Append("'", 5 - octave)
        Else
            octaveQuotes.Append("'", octave - 5)
        End If
        Return octaveQuotes.ToString
    End Function

    Private Sub AddNote(ByVal value As Integer, ByVal octave As Integer, ByVal noteName As String)
        Dim octaveQuotes As String = GetOctaveQuotes(octave)
        If octave < 5 Then
            Notes.Add(value, octaveQuotes & noteName)
        ElseIf octave > 5 Then
            Notes.Add(value, noteName & octaveQuotes)
        Else
            Notes.Add(value, noteName)
        End If

    End Sub

    Private Sub InitializeNotes()
        For i As Integer = 0 To NumberOfNotes - 1
            Dim octave As Integer = i \ 12
            Dim tone As Integer = i Mod 12

            Select Case tone
                Case 0
                    AddNote(i, octave, "C")
                    AddNote(i, octave - 1, "B#") ' A sharped B is technically in the next lower octave
                Case 1
                    AddNote(i, octave, "C#")
                    AddNote(i, octave, "Db")
                Case 2
                    AddNote(i, octave, "D")
                Case 3
                    AddNote(i, octave, "D#")
                    AddNote(i, octave, "Eb")
                Case 4
                    AddNote(i, octave, "E")
                    AddNote(i, octave, "Fb")
                Case 5
                    AddNote(i, octave, "F")
                    AddNote(i, octave, "E#")
                Case 6
                    AddNote(i, octave, "F#")
                    AddNote(i, octave, "Gb")
                Case 7
                    AddNote(i, octave, "G")
                Case 8
                    AddNote(i, octave, "G#")
                    AddNote(i, octave, "Ab")
                Case 9
                    AddNote(i, octave, "A")
                Case 10
                    AddNote(i, octave, "A#")
                    AddNote(i, octave, "Bb")
                Case 11
                    AddNote(i, octave, "B")
                    AddNote(i, octave + 1, "Cb") ' A flatted C is technically in the next higher octave
            End Select
        Next
        Notes.Add(NumberOfNotes, "R") ' Pause (z.B. 2.2P)
    End Sub


    Private Sub MIDI_Start() Handles MIDI_Start_Button.Click
        MIDI_Start_Button.Enabled = False
        MIDI_Pause_Button.Enabled = True
        MIDI_Save_Button.Enabled = True
        Einstellungen_GroupBox.Enabled = False
        Song.Tracks(1).Channel = 0

        If Not Song.Tracks(1).ValidTrack Then
            MessageBox.Show("Error")
        End If

        'In Trackt 0 gehören keine META Daten!!!
        'Ansonsten kommt Track 0 in einigen Musikprogrammen als Leehre Spur.
        Song.Tracks(0).TrackData.Clear()
        If MIDI_NormalMode.Checked = True Then Song.Tracks(0).AddTackt(Tackt_Zaehler_Input.Value, Tackt_Naenner_Input.Value)

        Song.Tracks(1).TrackData.Clear()
        Song.Tracks(1).Zuordnung(1)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(1).Text(1, cboInstruments.SelectedText)
        If Not META_Spurnamen_Input.Text = "" Then Song.Tracks(1).Text(3, META_Spurnamen_Input.Text)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(1).Text(4, cboInstruments.SelectedText)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(1).Add_Instrument(cboInstruments.SelectedIndex)

        If MIDI_NormalMode.Checked = True Then Tackt.Enabled = True
        Aufnahme_gestartet = True
    End Sub


    Private Sub MIDI_Pause() Handles MIDI_Pause_Button.Click
        If Einstellungen_GroupBox.Enabled = False Then
            Tackt.Enabled = False
            Aufnahme_gestartet = False
            Messung_Pause = True
            Einstellungen_GroupBox.Enabled = True
            MIDI_Pause_Button.Text = "Aufnahme fortsetzen"
        Else
            Tackt.Enabled = True
            Messung_Pause = False
            Aufnahme_gestartet = True
            Einstellungen_GroupBox.Enabled = False
            MIDI_Pause_Button.Text = "Aufnahme pausieren"
        End If
    End Sub

    Private Sub MIDI_Save() Handles MIDI_Save_Button.Click

        MIDI_Pause_Button.Enabled = False
        MIDI_Save_Button.Enabled = False
        Tackt.Enabled = False
        Aufnahme_gestartet = False

        TacktNr = 0
        Tackt_32stel = 0

        Tackt_Ausgabefenster.Text = ("1  1")

        Dim MIDI_Dateinamen As String
        If META_Dateinamen_Input.Text = "" Then
            MIDI_Dateinamen = "Untitled.mid"
        Else
            MIDI_Dateinamen = META_Dateinamen_Input.Text & ".mid"
        End If

        Me.SaveMIDIDialog.DefaultExt = "MID"
        Me.SaveMIDIDialog.FileName = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyDocuments, MIDI_Dateinamen)
        Me.SaveMIDIDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.SaveMIDIDialog.Filter = "VB MIDI files (*.MID)|*.MID"

        Dim result As DialogResult = Me.SaveMIDIDialog.ShowDialog
        If result = DialogResult.OK Then
            Song.Save(SaveMIDIDialog.FileName)
        End If

        Einstellungen_GroupBox.Enabled = True
        MIDI_Start_Button.Enabled = True

    End Sub

#End Region


    Private Sub Tackt_Tick() Handles Tackt.Tick

        Dim Note_gespielt As Boolean = False

        For i = 16 To 77 Step 1
            If Note_Play(i) = True Or Button_Note_Play(i) = True Then
                If Notenlaege(i) = 0 Then
                    Song.Tracks(1).AddNoteOnOffEvent(0, MIDI.Track.NoteEvent.NoteOn, CByte(i), Note_Volume(i)) '0=Länge => 0=Wichtig!!!!
                End If
                Notenlaege(i) += 0.125
                Note_gespielt = True

            Else

                If Notenlaege(i) > 0 Then
                    Song.Tracks(1).AddNoteOnOffEvent(Notenlaege(i), MIDI.Track.NoteEvent.NoteOff, CByte(i), 0)
                    Notenlaege(i) = 0
                End If
            End If

        Next

        If Note_gespielt = False Then
            Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, 0, 0) ' Notenlaege(0) += 0.125
            m.PlayMIDINote(70, 50, 0.1)
        End If


        Tackt_32stel = Tackt_32stel + 1

        If Tackt_32stel = 32 Then
            If Metronom_ON.Checked Then
                m.CurrentInstrument = "Woodblock"
                m.PlayMIDINote(70, 50, 0.1)
                m.CurrentInstrument = cboInstruments.Text
            ElseIf Metronom_Betont.Checked Then
                m.CurrentInstrument = "Woodblock"
                m.PlayMIDINote(72, 70, 0.1)
                m.CurrentInstrument = cboInstruments.Text
            End If
            TacktNr = TacktNr + 1
            Tackt_32stel = 0
        End If

        If Not Metronom_alt = Fix(Tackt_32stel * Tackt_Naenner_Input.Value / 32) Then
            If Metronom_ON.Checked Or Metronom_Betont.Checked Then
                m.CurrentInstrument = "Woodblock"
                m.PlayMIDINote(70, 50, 0.1)
                m.CurrentInstrument = cboInstruments.Text
            End If
        End If

        Metronom_alt = Fix(Tackt_32stel * Tackt_Naenner_Input.Value / 32)
        Tackt_Ausgabefenster.Text = (TacktNr + 1 & "  " & Fix(Tackt_32stel * Tackt_Naenner_Input.Value / 32) + 1) 'Math.Round

    End Sub


    Private Sub BPM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPM.ValueChanged
        Tackt.Interval = (60 / BPM.Value / 4) * 1000
    End Sub

    Private Sub Oktavenverschiebung_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Oktavenverschiebung.SelectedIndexChanged
        Halbtonverschiebung.Value = 12 * (3 - Oktavenverschiebung.SelectedIndex)
        Halbtonversch = Halbtonverschiebung.Value
        If Halbtonversch < -32 Then MessageBox.Show("Warnung: Durch eine Halbtoniverschiebung von <-32 sind die Tiefsten töne einfach alle Note 0 da MIDI  tiefere Töne nicht unterstützt.",
                                                    "Warnung: Zu tife Töne möglich", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub


    Private Sub Halbtonverschiebung_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Halbtonverschiebung.Click ', Halbtonverschiebung.Leave
        Halbtonversch = Halbtonverschiebung.Value
        Select Case Halbtonversch
            Case 36 : Oktavenverschiebung.SelectedIndex = 0
            Case 24 To 36 : Oktavenverschiebung.SelectedIndex = 1
            Case 12 To 24 : Oktavenverschiebung.SelectedIndex = 2
            Case 0 To 12 : Oktavenverschiebung.SelectedIndex = 3
            Case -12 To 0 : Oktavenverschiebung.SelectedIndex = 4
            Case -24 To -12 : Oktavenverschiebung.SelectedIndex = 5
            Case -36 To -24 : Oktavenverschiebung.SelectedIndex = 6
            Case Else : Oktavenverschiebung.SelectedIndex = 4
        End Select
        If Halbtonversch < -32 Then MessageBox.Show("Warnung: Durch eine Halbtoniverschiebung von <-32 sind die Tiefsten töne einfach alle Note 0 da MIDI  tiefere Töne nicht unterstützt.",
                                                    "Warnung: Zu tife Töne möglich", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub



    Private Sub Display_Refresh() Handles Display_Refresh_Timer.Tick

        For i = 0 To 34 Step 1
            Noten_VerticalProgessBar(i).Value = ADC(i)
            Noten_Wert(i).Text = ADC(i)
        Next

    End Sub




#Region " cls MIDI "

    Dim m As New clsMIDI

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillInstrumentCombo()
    End Sub
    Private Sub lblClickMe_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            m.PlayMIDINote(e.Y, 127) 'Play MIDI Sounds
        Else
            m.STOPAllMIDINotes() 'Stops All MIDI notes
        End If
    End Sub

#Region " Instrument Control "
    Private Sub FillInstrumentCombo()
        For i = 0 To 128
            cboInstruments.Items.Add(Instrument.GMInstrumentNames(i))
        Next
        cboInstruments.SelectedIndex = 0
    End Sub
    Private Sub cboInstruments_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInstruments.SelectedIndexChanged
        m.CurrentInstrument = cboInstruments.Text
    End Sub
#End Region

#Region " Volume Control "
    Private Sub hsbVolume_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsbVolume.ValueChanged
        m.Volume = hsbVolume.Value
    End Sub
#End Region

#Region " Pan Control "
    Private Sub hsbPan_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsbPan.ValueChanged
        m.Pan = hsbPan.Value
    End Sub
#End Region

#Region " ModWheel Control "
    Private Sub hsbModWheel_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsbModWheel.ValueChanged
        m.ModWheel = hsbModWheel.Value
    End Sub
#End Region

#End Region



#Region " Button Note "

#Region "   Buttons Events "

#Region "   MouseDown Events"
    Private Sub C2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2_Button.MouseDown, C2_Button.KeyDown
        Button_Note(0)
    End Sub

    Private Sub D2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2_Button.MouseDown, D2_Button.KeyDown
        Button_Note(1)
    End Sub

    Private Sub E2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2_Button.MouseDown, E2_Button.KeyDown
        Button_Note(2)
    End Sub

    Private Sub F2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2_Button.MouseDown, F2_Button.KeyDown
        Button_Note(3)
    End Sub

    Private Sub G2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2_Button.MouseDown, G2_Button.KeyDown
        Button_Note(4)
    End Sub

    Private Sub A2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2_Button.MouseDown, A2_Button.KeyDown
        Button_Note(5)
    End Sub

    Private Sub H2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2_Button.MouseDown, H2_Button.KeyDown
        Button_Note(6)
    End Sub



    Private Sub C3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3_Button.MouseDown, C3_Button.KeyDown
        Button_Note(7)
    End Sub

    Private Sub D3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3_Button.MouseDown, D3_Button.KeyDown
        Button_Note(8)
    End Sub

    Private Sub E3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3_Button.MouseDown, E3_Button.KeyDown
        Button_Note(9)
    End Sub

    Private Sub F3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3_Button.MouseDown, F3_Button.KeyDown
        Button_Note(10)
    End Sub

    Private Sub G3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3_Button.MouseDown, G3_Button.KeyDown
        Button_Note(11)
    End Sub

    Private Sub A3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3_Button.MouseDown, A3_Button.KeyDown
        Button_Note(12)
    End Sub

    Private Sub H3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3_Button.MouseDown, H3_Button.KeyDown
        Button_Note(13)
    End Sub



    Private Sub C4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4_Button.MouseDown, C4_Button.KeyDown
        Button_Note(14)
    End Sub

    Private Sub D4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4_Button.MouseDown, D4_Button.KeyDown
        Button_Note(15)
    End Sub

    Private Sub E4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4_Button.MouseDown, E4_Button.KeyDown
        Button_Note(16)
    End Sub

    Private Sub F4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4_Button.MouseDown, F4_Button.KeyDown
        Button_Note(17)
    End Sub

    Private Sub G4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4_Button.MouseDown, G4_Button.KeyDown
        Button_Note(18)
    End Sub

    Private Sub A4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4_Button.MouseDown, A4_Button.KeyDown
        Button_Note(19)
    End Sub

    Private Sub H4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4_Button.MouseDown, H4_Button.KeyDown
        Button_Note(20)
    End Sub



    Private Sub C5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5_Button.MouseDown, C5_Button.KeyDown
        Button_Note(21)
    End Sub

    Private Sub D5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5_Button.MouseDown, D5_Button.KeyDown
        Button_Note(22)
    End Sub

    Private Sub E5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5_Button.MouseDown, E5_Button.KeyDown
        Button_Note(23)
    End Sub

    Private Sub F5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5_Button.MouseDown, F5_Button.KeyDown
        Button_Note(24)
    End Sub

    Private Sub G5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5_Button.MouseDown, G5_Button.KeyDown
        Button_Note(25)
    End Sub

    Private Sub A5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5_Button.MouseDown, A5_Button.KeyDown
        Button_Note(26)
    End Sub

    Private Sub H5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5_Button.MouseDown, H5_Button.KeyDown
        Button_Note(27)
    End Sub



    Private Sub C6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6_Button.MouseDown, C6_Button.KeyDown
        Button_Note(28)
    End Sub

    Private Sub D6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6_Button.MouseDown, D6_Button.KeyDown
        Button_Note(29)
    End Sub

    Private Sub E6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6_Button.MouseDown, E6_Button.KeyDown
        Button_Note(30)
    End Sub

    Private Sub F6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6_Button.MouseDown, F6_Button.KeyDown
        Button_Note(31)
    End Sub

    Private Sub G6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6_Button.MouseDown, G6_Button.KeyDown
        Button_Note(32)
    End Sub

    Private Sub A6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6_Button.MouseDown, A6_Button.KeyDown
        Button_Note(33)
    End Sub

    Private Sub H6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6_Button.MouseDown, H6_Button.KeyDown
        Button_Note(34)
    End Sub
#End Region


#Region "   MouseUp Events"

    Private Sub C2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2_Button.MouseUp, C2_Button.KeyUp
        Button_Stop_Note(0)
    End Sub

    Private Sub D2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2_Button.MouseUp, D2_Button.KeyUp
        Button_Stop_Note(1)
    End Sub

    Private Sub E2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2_Button.MouseUp, E2_Button.KeyUp
        Button_Stop_Note(2)
    End Sub

    Private Sub F2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2_Button.MouseUp, F2_Button.KeyUp
        Button_Stop_Note(3)
    End Sub

    Private Sub G2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2_Button.MouseUp, G2_Button.KeyUp
        Button_Stop_Note(4)
    End Sub

    Private Sub A2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2_Button.MouseUp, A2_Button.KeyUp
        Button_Stop_Note(5)
    End Sub

    Private Sub H2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2_Button.MouseUp, H2_Button.KeyUp
        Button_Stop_Note(6)
    End Sub



    Private Sub C3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3_Button.MouseUp, C3_Button.KeyUp
        Button_Stop_Note(7)
    End Sub

    Private Sub D3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3_Button.MouseUp, D3_Button.KeyUp
        Button_Stop_Note(8)
    End Sub

    Private Sub E3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3_Button.MouseUp, E3_Button.KeyUp
        Button_Stop_Note(9)
    End Sub

    Private Sub F3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3_Button.MouseUp, F3_Button.KeyUp
        Button_Stop_Note(10)
    End Sub

    Private Sub G3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3_Button.MouseUp, G3_Button.KeyUp
        Button_Stop_Note(11)
    End Sub

    Private Sub A3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3_Button.MouseUp, A3_Button.KeyUp
        Button_Stop_Note(12)
    End Sub

    Private Sub H3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3_Button.MouseUp, H3_Button.KeyUp
        Button_Stop_Note(13)
    End Sub



    Private Sub C4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4_Button.MouseUp, C4_Button.KeyUp
        Button_Stop_Note(14)
    End Sub

    Private Sub D4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4_Button.MouseUp, D4_Button.KeyUp
        Button_Stop_Note(15)
    End Sub

    Private Sub E4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4_Button.MouseUp, E4_Button.KeyUp
        Button_Stop_Note(16)
    End Sub

    Private Sub F4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4_Button.MouseUp, F4_Button.KeyUp
        Button_Stop_Note(17)
    End Sub

    Private Sub G4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4_Button.MouseUp, G4_Button.KeyUp
        Button_Stop_Note(18)
    End Sub

    Private Sub A4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4_Button.MouseUp, A4_Button.KeyUp
        Button_Stop_Note(19)
    End Sub

    Private Sub H4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4_Button.MouseUp, H4_Button.KeyUp
        Button_Stop_Note(20)
    End Sub



    Private Sub C5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5_Button.MouseUp, C5_Button.KeyUp
        Button_Stop_Note(21)
    End Sub

    Private Sub D5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5_Button.MouseUp, D5_Button.KeyUp
        Button_Stop_Note(22)
    End Sub

    Private Sub E5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5_Button.MouseUp, E5_Button.KeyUp
        Button_Stop_Note(23)
    End Sub

    Private Sub F5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5_Button.MouseUp, F5_Button.KeyUp
        Button_Stop_Note(24)
    End Sub

    Private Sub G5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5_Button.MouseUp, G5_Button.KeyUp
        Button_Stop_Note(25)
    End Sub

    Private Sub A5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5_Button.MouseUp, A5_Button.KeyUp
        Button_Stop_Note(26)
    End Sub

    Private Sub H5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5_Button.MouseUp, H5_Button.KeyUp
        Button_Stop_Note(27)
    End Sub



    Private Sub C6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6_Button.MouseUp, C6_Button.KeyUp
        Button_Stop_Note(28)
    End Sub

    Private Sub D6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6_Button.MouseUp, D6_Button.KeyUp
        Button_Stop_Note(29)
    End Sub

    Private Sub E6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6_Button.MouseUp, E6_Button.KeyUp
        Button_Stop_Note(30)
    End Sub

    Private Sub F6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6_Button.MouseUp, F6_Button.KeyUp
        Button_Stop_Note(31)
    End Sub

    Private Sub G6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6_Button.MouseUp, G6_Button.KeyUp
        Button_Stop_Note(32)
    End Sub

    Private Sub A6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6_Button.MouseUp, A6_Button.KeyUp
        Button_Stop_Note(33)
    End Sub

    Private Sub H6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6_Button.MouseUp, H6_Button.KeyUp
        Button_Stop_Note(34)
    End Sub

#End Region

#End Region

    Private Sub Button_Note(ByVal TastenNr As Byte)
        Dim NotenNr As Integer

        NotenNr = MidiNoteNr(TastenNr) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(TastenNr).Text)
        If NotenNr < 0 Then NotenNr = 0
        If NotenNr > 127 Then NotenNr = 127
        m.PlayMIDINote(NotenNr, 100, 0)
        Button_Note_Play(NotenNr) = True
        If MIDI_SpecialMode.Checked = True Then Tackt_Tick()
    End Sub


    Private Sub Button_Stop_Note(ByVal TastenNr As Byte)
        Dim NotenNr As Integer

        NotenNr = MidiNoteNr(TastenNr) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(TastenNr).Text)
        If NotenNr < 0 Then NotenNr = 0
        If NotenNr > 127 Then NotenNr = 127
        m.STOPMIDINote(NotenNr)
        Button_Note_Play(NotenNr) = False
        If MIDI_SpecialMode.Checked = True Then Tackt_Tick()
    End Sub

#End Region


#Region " Grenzwerte "

    Private Sub Grenzwerte_KeyPress(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        C2_Startwert.KeyPress, D2_Startwert.KeyPress, E2_Startwert.KeyPress, F2_Startwert.KeyPress, G2_Startwert.KeyPress, A2_Startwert.KeyPress, H2_Startwert.KeyPress,
        C3_Startwert.KeyPress, D3_Startwert.KeyPress, E3_Startwert.KeyPress, F3_Startwert.KeyPress, G3_Startwert.KeyPress, A3_Startwert.KeyPress, H3_Startwert.KeyPress,
        C4_Startwert.KeyPress, D4_Startwert.KeyPress, E4_Startwert.KeyPress, F4_Startwert.KeyPress, G4_Startwert.KeyPress, A4_Startwert.KeyPress, H4_Startwert.KeyPress,
        C5_Startwert.KeyPress, D5_Startwert.KeyPress, E5_Startwert.KeyPress, F5_Startwert.KeyPress, G5_Startwert.KeyPress, A5_Startwert.KeyPress, H5_Startwert.KeyPress,
        C6_Startwert.KeyPress, D6_Startwert.KeyPress, E6_Startwert.KeyPress, F6_Startwert.KeyPress, G6_Startwert.KeyPress, A6_Startwert.KeyPress, H6_Startwert.KeyPress,
        C2_Stopwert.KeyPress, D2_Stopwert.KeyPress, E2_Stopwert.KeyPress, F2_Stopwert.KeyPress, G2_Stopwert.KeyPress, A2_Stopwert.KeyPress, H2_Stopwert.KeyPress,
        C3_Stopwert.KeyPress, D3_Stopwert.KeyPress, E3_Stopwert.KeyPress, F3_Stopwert.KeyPress, G3_Stopwert.KeyPress, A3_Stopwert.KeyPress, H3_Stopwert.KeyPress,
        C4_Stopwert.KeyPress, D4_Stopwert.KeyPress, E4_Stopwert.KeyPress, F4_Stopwert.KeyPress, G4_Stopwert.KeyPress, A4_Stopwert.KeyPress, H4_Stopwert.KeyPress,
        C5_Stopwert.KeyPress, D5_Stopwert.KeyPress, E5_Stopwert.KeyPress, F5_Stopwert.KeyPress, G5_Stopwert.KeyPress, A5_Stopwert.KeyPress, H5_Stopwert.KeyPress,
        C6_Stopwert.KeyPress, D6_Stopwert.KeyPress, E6_Stopwert.KeyPress, F6_Stopwert.KeyPress, G6_Stopwert.KeyPress, A6_Stopwert.KeyPress, H6_Stopwert.KeyPress

        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8 ', 45=Minus ', 46=Punkt (Hier als Komma)
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub


    Private Sub Verschiebung_KeyPress(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
    C2_Verschiebung.KeyPress, D2_Verschiebung.KeyPress, E2_Verschiebung.KeyPress, F2_Verschiebung.KeyPress, G2_Verschiebung.KeyPress, A2_Verschiebung.KeyPress, H2_Verschiebung.KeyPress,
    C3_Verschiebung.KeyPress, D3_Verschiebung.KeyPress, E3_Verschiebung.KeyPress, F3_Verschiebung.KeyPress, G3_Verschiebung.KeyPress, A3_Verschiebung.KeyPress, H3_Verschiebung.KeyPress,
    C4_Verschiebung.KeyPress, D4_Verschiebung.KeyPress, E4_Verschiebung.KeyPress, F4_Verschiebung.KeyPress, G4_Verschiebung.KeyPress, A4_Verschiebung.KeyPress, H4_Verschiebung.KeyPress,
    C5_Verschiebung.KeyPress, D5_Verschiebung.KeyPress, E5_Verschiebung.KeyPress, F5_Verschiebung.KeyPress, G5_Verschiebung.KeyPress, A5_Verschiebung.KeyPress, H5_Verschiebung.KeyPress,
    C6_Verschiebung.KeyPress, D6_Verschiebung.KeyPress, E6_Verschiebung.KeyPress, F6_Verschiebung.KeyPress, G6_Verschiebung.KeyPress, A6_Verschiebung.KeyPress, H6_Verschiebung.KeyPress

        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 45 ', 46=Punkt (Hier als Komma)
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub


    Private Sub Grenzwerte_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles _
        C2_Startwert.LostFocus, D2_Startwert.LostFocus, E2_Startwert.LostFocus, F2_Startwert.LostFocus, G2_Startwert.LostFocus, A2_Startwert.LostFocus, H2_Startwert.LostFocus,
        C3_Startwert.LostFocus, D3_Startwert.LostFocus, E3_Startwert.LostFocus, F3_Startwert.LostFocus, G3_Startwert.LostFocus, A3_Startwert.LostFocus, H3_Startwert.LostFocus,
        C4_Startwert.LostFocus, D4_Startwert.LostFocus, E4_Startwert.LostFocus, F4_Startwert.LostFocus, G4_Startwert.LostFocus, A4_Startwert.LostFocus, H4_Startwert.LostFocus,
        C5_Startwert.LostFocus, D5_Startwert.LostFocus, E5_Startwert.LostFocus, F5_Startwert.LostFocus, G5_Startwert.LostFocus, A5_Startwert.LostFocus, H5_Startwert.LostFocus,
        C6_Startwert.LostFocus, D6_Startwert.LostFocus, E6_Startwert.LostFocus, F6_Startwert.LostFocus, G6_Startwert.LostFocus, A6_Startwert.LostFocus, H6_Startwert.LostFocus,
        C2_Stopwert.LostFocus, D2_Stopwert.LostFocus, E2_Stopwert.LostFocus, F2_Stopwert.LostFocus, G2_Stopwert.LostFocus, A2_Stopwert.LostFocus, H2_Stopwert.LostFocus,
        C3_Stopwert.LostFocus, D3_Stopwert.LostFocus, E3_Stopwert.LostFocus, F3_Stopwert.LostFocus, G3_Stopwert.LostFocus, A3_Stopwert.LostFocus, H3_Stopwert.LostFocus,
        C4_Stopwert.LostFocus, D4_Stopwert.LostFocus, E4_Stopwert.LostFocus, F4_Stopwert.LostFocus, G4_Stopwert.LostFocus, A4_Stopwert.LostFocus, H4_Stopwert.LostFocus,
        C5_Stopwert.LostFocus, D5_Stopwert.LostFocus, E5_Stopwert.LostFocus, F5_Stopwert.LostFocus, G5_Stopwert.LostFocus, A5_Stopwert.LostFocus, H5_Stopwert.LostFocus,
        C6_Stopwert.LostFocus, D6_Stopwert.LostFocus, E6_Stopwert.LostFocus, F6_Stopwert.LostFocus, G6_Stopwert.LostFocus, A6_Stopwert.LostFocus, H6_Stopwert.LostFocus

        If sender.Text > 255 Then sender.Text = 255

        For i = 0 To 34
            Noten_StartW(i) = Noten_Startwert(i).Text
            Noten_StopW(i) = Noten_Stopwert(i).Text
        Next
        'MessageBox.Show(sender.Text)
    End Sub


    Private Sub Verschiebung_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles _
    C2_Verschiebung.LostFocus, D2_Verschiebung.LostFocus, E2_Verschiebung.LostFocus, F2_Verschiebung.LostFocus, G2_Verschiebung.LostFocus, A2_Verschiebung.LostFocus, H2_Verschiebung.LostFocus,
    C3_Verschiebung.LostFocus, D3_Verschiebung.LostFocus, E3_Verschiebung.LostFocus, F3_Verschiebung.LostFocus, G3_Verschiebung.LostFocus, A3_Verschiebung.LostFocus, H3_Verschiebung.LostFocus,
    C4_Verschiebung.LostFocus, D4_Verschiebung.LostFocus, E4_Verschiebung.LostFocus, F4_Verschiebung.LostFocus, G4_Verschiebung.LostFocus, A4_Verschiebung.LostFocus, H4_Verschiebung.LostFocus,
    C5_Verschiebung.LostFocus, D5_Verschiebung.LostFocus, E5_Verschiebung.LostFocus, F5_Verschiebung.LostFocus, G5_Verschiebung.LostFocus, A5_Verschiebung.LostFocus, H5_Verschiebung.LostFocus,
    C6_Verschiebung.LostFocus, D6_Verschiebung.LostFocus, E6_Verschiebung.LostFocus, F6_Verschiebung.LostFocus, G6_Verschiebung.LostFocus, A6_Verschiebung.LostFocus, H6_Verschiebung.LostFocus

        If sender.Text > 127 Then sender.Text = 127
        If sender.Text < -127 Then sender.Text = -127

        For i = 0 To 34
            Noten_Versch(i) = Noten_Verschiebung(i).Text
        Next
        'MessageBox.Show(sender.Text)
    End Sub


#End Region


#Region " Special MIDI-Mode"

    Dim Messintervall_Temp As UShort
    Dim Tackt_Zaehler_Temp As Byte
    Dim Tackt_Naenner_Temp As Byte

    Private Sub MIDI_SpecialMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_SpecialMode.CheckedChanged

        If MIDI_SpecialMode.Checked = True Then
            'Tackt_Zaehler_Temp = Tackt_Zaehler_Input.Value
            'Tackt_Naenner_Temp = Tackt_Naenner_Input.Value
            Tackt_Zaehler_Input.Value = 4
            Tackt_Naenner_Input.Value = 4
            BPM.Visible = False
            BPM_Label.Text = "Aufnahme BPM:     Möglichst scnell!"
            cboInstruments.Enabled = False
            Tempo_GroupBox.Enabled = False
        Else
            cboInstruments.Enabled = True
            Tempo_GroupBox.Enabled = True
            'Tackt_Zaehler_Input.Value = Tackt_Zaehler_Temp
            'Tackt_Naenner_Input.Value = Tackt_Naenner_Temp
            BPM.Visible = True
            BPM_Label.Text = "Aufnahme BPM:"
        End If

    End Sub

#End Region


    Private Sub ToolTip_ON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolTip_ON.CheckedChanged, MyBase.Load
        If ToolTip_ON.Checked = True Then
            ToolTip1.Active = True
        Else
            ToolTip1.Active = False
        End If
    End Sub


#Region " Klappen"

#Region " Key Events"
    'Private Sub C_Key(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_Klappe.ValueChanged
#End Region


#Region " Klappen verändert"

    Private Sub C1_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_Klappe.ValueChanged
        C2_Klappe.Value = C1_Klappe.Value

        Dim C1_Klappe_Differenz As SByte = C1_Klappe.Value - C1_Klappe_alt
        C1_Klappe_Text.Text = Notennamen(C1_Klappe.Value + 1, 0)

        C2_Verschiebung.Text += C1_Klappe_Differenz
        C3_Verschiebung.Text += C1_Klappe_Differenz
        C4_Verschiebung.Text += C1_Klappe_Differenz
        C5_Verschiebung.Text += C1_Klappe_Differenz
        C6_Verschiebung.Text += C1_Klappe_Differenz

        C1_Klappe_alt = C1_Klappe.Value
    End Sub

    Private Sub C2_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2_Klappe.ValueChanged
        C1_Klappe.Value = C2_Klappe.Value

        Dim C2_Klappe_Differenz As SByte = C2_Klappe.Value - C2_Klappe_alt
        C2_Klappe_Text.Text = Notennamen(C2_Klappe.Value + 1, 0)

        C2_Verschiebung.Text += C2_Klappe_Differenz
        C3_Verschiebung.Text += C2_Klappe_Differenz
        C4_Verschiebung.Text += C2_Klappe_Differenz
        C5_Verschiebung.Text += C2_Klappe_Differenz
        C6_Verschiebung.Text += C2_Klappe_Differenz

        C1_Klappe_alt = C1_Klappe.Value
    End Sub

    Private Sub D_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1_Klappe.ValueChanged
        Dim D1_Klappe_Differenz As SByte = D1_Klappe.Value - D1_Klappe_alt
        D1_Klappe_Text.Text = Notennamen(D1_Klappe.Value + 1, 1)

        D2_Verschiebung.Text += D1_Klappe_Differenz
        D3_Verschiebung.Text += D1_Klappe_Differenz
        D4_Verschiebung.Text += D1_Klappe_Differenz
        D5_Verschiebung.Text += D1_Klappe_Differenz
        D6_Verschiebung.Text += D1_Klappe_Differenz

        D1_Klappe_alt = D1_Klappe.Value
    End Sub

    Private Sub E_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1_Klappe.ValueChanged
        Dim E1_Klappe_Differenz As SByte = E1_Klappe.Value - E1_Klappe_alt
        E1_Klappe_Text.Text = Notennamen(E1_Klappe.Value + 1, 2)

        E2_Verschiebung.Text += E1_Klappe_Differenz
        E3_Verschiebung.Text += E1_Klappe_Differenz
        E4_Verschiebung.Text += E1_Klappe_Differenz
        E5_Verschiebung.Text += E1_Klappe_Differenz
        E6_Verschiebung.Text += E1_Klappe_Differenz

        E1_Klappe_alt = E1_Klappe.Value

    End Sub

    Private Sub F_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1_Klappe.ValueChanged
        Dim F1_Klappe_Differenz As SByte = F1_Klappe.Value - F1_Klappe_alt
        F1_Klappe_Text.Text = Notennamen(F1_Klappe.Value + 1, 3)

        F2_Verschiebung.Text += F1_Klappe_Differenz
        F3_Verschiebung.Text += F1_Klappe_Differenz
        F4_Verschiebung.Text += F1_Klappe_Differenz
        F5_Verschiebung.Text += F1_Klappe_Differenz
        F6_Verschiebung.Text += F1_Klappe_Differenz

        F1_Klappe_alt = F1_Klappe.Value

    End Sub

    Private Sub G_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1_Klappe.ValueChanged
        Dim G1_Klappe_Differenz As SByte = G1_Klappe.Value - G1_Klappe_alt
        G1_Klappe_Text.Text = Notennamen(G1_Klappe.Value + 1, 4)

        G2_Verschiebung.Text += G1_Klappe_Differenz
        G3_Verschiebung.Text += G1_Klappe_Differenz
        G4_Verschiebung.Text += G1_Klappe_Differenz
        G5_Verschiebung.Text += G1_Klappe_Differenz
        G6_Verschiebung.Text += G1_Klappe_Differenz

        G1_Klappe_alt = G1_Klappe.Value

    End Sub

    Private Sub A_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1_Klappe.ValueChanged
        Dim A1_Klappe_Differenz As SByte = A1_Klappe.Value - A1_Klappe_alt
        A1_Klappe_Text.Text = Notennamen(A1_Klappe.Value + 1, 5)

        A2_Verschiebung.Text += A1_Klappe_Differenz
        A3_Verschiebung.Text += A1_Klappe_Differenz
        A4_Verschiebung.Text += A1_Klappe_Differenz
        A5_Verschiebung.Text += A1_Klappe_Differenz
        A6_Verschiebung.Text += A1_Klappe_Differenz

        A1_Klappe_alt = A1_Klappe.Value

    End Sub

    Private Sub H_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H1_Klappe.ValueChanged
        Dim H1_Klappe_Differenz As SByte = H1_Klappe.Value - H1_Klappe_alt
        H1_Klappe_Text.Text = Notennamen(H1_Klappe.Value + 1, 6)

        H2_Verschiebung.Text += H1_Klappe_Differenz
        H3_Verschiebung.Text += H1_Klappe_Differenz
        H4_Verschiebung.Text += H1_Klappe_Differenz
        H5_Verschiebung.Text += H1_Klappe_Differenz
        H6_Verschiebung.Text += H1_Klappe_Differenz

        H1_Klappe_alt = H1_Klappe.Value

    End Sub

#End Region

#End Region




#Region "Tastenkonbinationen"

    ' Im folgenden Sub werden die Tastenkonbinationen ermittelt und deren Funktion ausgeführt.
    'Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles 
    'If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.End Then Me.Close()
    'If e.KeyCode = Keys.F9 Then MessageBox.Show("")

    'If e.KeyData = (Keys.Control Or Keys.F) Then
    'MessageBox.Show("")
    'End If

    'End Sub


    Dim key As Integer

    Private Sub KeyState_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetAsyncKeyState_Timer.Tick


        If Costom_Tastenkonbinationen_Counter = 0 Then

            If Tastenkonbination_Press(Start_Tastenkombination_Key) = True Then
                Costom_Tastenkonbinationen_Counter = 20
                If Aufnahme_gestartet = True Or Messung_Pause = True Then
                    MIDI_Save()
                    Exit Sub
                Else
                    MIDI_Start()
                    Exit Sub
                End If
            End If

            If Tastenkonbination_Press(Pause_Tastenkombination_Key) = True Then
                Costom_Tastenkonbinationen_Counter = 20
                MIDI_Pause()
            End If

            If Tastenkonbination_Press(Save_Tastenkombination_Key) = True Then
                Costom_Tastenkonbinationen_Counter = 20
                If Aufnahme_gestartet = True Or Messung_Pause = True Then
                    MIDI_Save()
                    Exit Sub
                Else
                    MIDI_Start()
                    Exit Sub
                End If
            End If
        Else
            Costom_Tastenkonbinationen_Counter -= 1
        End If


        'If Tastenkonbination_Press(New List(Of Byte) From {49}) = True Then MessageBox.Show(Chr(Pause_Tastenkombination_Key(0)))

        Select Case -32767
            Case GetAsyncKeyState(107)  'Pluss (Nomblock)
                If hsbVolume.Value + 10 <= 127 Then hsbVolume.Value += 10
            Case GetAsyncKeyState(109)  'Minus (Nomblock)
                If hsbVolume.Value - 10 >= 0 Then hsbVolume.Value -= 10
                'Case GetAsyncKeyState(77) And GetAsyncKeyState(17) 'Ctrl + M

        End Select

        If GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(65) = -32767 Then     'Ctrl + Shift + A
            MIDI_Aufnahmemodus_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        ElseIf GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(75) = -32767 Then 'Ctrl + Shift + K
            SendKeys_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        ElseIf GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(77) = -32767 Then 'Ctrl + Shift + M
            Metronom_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        ElseIf GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(80) = -32767 Then 'Ctrl + Shift + P
            DirectPlay_YesNo_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        ElseIf GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(84) = -32767 Then 'Ctrl + Shift + T
            ToolTip_YesNo_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If


        Select Case -32767
            Case GetAsyncKeyState(38)  'Pfeiltaste hoch
                Tastenkonbination_Klappenverschiebung = 1
            Case GetAsyncKeyState(40)  'Pfeiltaste runter
                Tastenkonbination_Klappenverschiebung = -1
            Case GetAsyncKeyState(107)  'Pluss (Nomblock)
                Tastenkonbination_Klappenverschiebung = 1
            Case GetAsyncKeyState(109)  'Minus (Nomblock)
                Tastenkonbination_Klappenverschiebung = -1
            Case GetAsyncKeyState(104)  'Pfeiltaste hoch (Numblock 8)
                Tastenkonbination_Klappenverschiebung = 1
            Case GetAsyncKeyState(98)   'Pfeiltaste runter (Numblock 2)
                Tastenkonbination_Klappenverschiebung = -1
            Case Else
                Tastenkonbination_Klappenverschiebung = 0
        End Select

        If Not Tastenkonbination_Klappenverschiebung = 0 Then
            Select Case 0   '-32767 oder -32768 => Immer falls Taste gedrückt!
                Case Is > GetAsyncKeyState(112) Or GetAsyncKeyState(49) Or GetAsyncKeyState(67) 'F1, 1, C
                    If C1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And C1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then C1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(113) Or GetAsyncKeyState(50) Or GetAsyncKeyState(68) 'F2, 2, D
                    If D1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And D1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then D1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(114) Or GetAsyncKeyState(51) Or GetAsyncKeyState(69) 'F3, 3, E
                    If E1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And E1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then E1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(115) Or GetAsyncKeyState(52) Or GetAsyncKeyState(70) 'F4, 4, F
                    If F1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And F1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then F1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(116) Or GetAsyncKeyState(53) Or GetAsyncKeyState(71) 'F5, 5, G
                    If G1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And G1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then G1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(117) Or GetAsyncKeyState(54) Or GetAsyncKeyState(65) 'F6, 6, A
                    If A1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And A1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then A1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(118) Or GetAsyncKeyState(55) Or GetAsyncKeyState(72) Or GetAsyncKeyState(66) 'F7, 7, H, B (Englisches Notensystem)
                    If H1_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And H1_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then H1_Klappe.Value += Tastenkonbination_Klappenverschiebung
                Case Is > GetAsyncKeyState(119) Or GetAsyncKeyState(56) 'F8, 8, C
                    If C2_Klappe.Value + Tastenkonbination_Klappenverschiebung <= 1 And C2_Klappe.Value + Tastenkonbination_Klappenverschiebung >= -1 Then C2_Klappe.Value += Tastenkonbination_Klappenverschiebung
            End Select
        End If

    End Sub




    Function Tastenkonbination_Press(ByVal Tastenkombination As List(Of Byte))
        'MessageBox.Show(Tastenkombination.Count)
        If Tastenkombination.Count = 0 Then Return False

        'Kein Plan, wieso die For schleife umgekehrt werden muss!
        'Ansonsten sind alle Tastenkonbinationen spiegelverkehrt!
        For i = Tastenkombination.Count - 1 To 0 Step -1
            If Not GetAsyncKeyState(Tastenkombination(i)) <= -32767 Then Return False
        Next

        'For Each item In Tastenkombination
        'If Not GetAsyncKeyState(item) <= -32767 Then Return False
        'Next


        Return True
    End Function



    Private Sub Tastenkombination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Tastenkombination.GotFocus, Start_Tastenkombination.Click, Start_Tastenkombination.KeyUp,
                                                                                                                Pause_Tastenkombination.GotFocus, Pause_Tastenkombination.Click, Pause_Tastenkombination.KeyUp,
                                                                                                                Save_Tastenkombination.GotFocus, Save_Tastenkombination.Click, Save_Tastenkombination.KeyUp
        GetAsyncKeyState_Timer.Enabled = False
        Tastenkombination_FirstKey = True
    End Sub


    Private Sub Tastenkombination_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Start_Tastenkombination.KeyDown,
                                                                                                                                Pause_Tastenkombination.KeyDown,
                                                                                                                                Save_Tastenkombination.KeyDown

        If e.KeyCode <> Tastenkombination_KeyAlt And Tastenkombination_Key.Count < 3 Or Tastenkombination_FirstKey = True Then
            If Tastenkombination_FirstKey = True Then
                Tastenkombination_Alt = sender.Text
                Tastenkombination_Key.Clear()
                sender.Text = ""
                Tastenkombination_KeyAlt = 0
                Tastenkombination_FirstKey = False
            Else
                sender.Text += " + "
            End If


            With sender
                Select Case e.KeyCode
                    Case 16 : .Text += "Shift"
                    Case 17 : .Text += "Ctrl"
                    Case 18 : .Text += "Alt"
                    Case 27 : .Text += "Esc"

                    Case 48 : .Text += "0"
                    Case 49 : .Text += "1"
                    Case 50 : .Text += "2"
                    Case 51 : .Text += "3"
                    Case 52 : .Text += "4"
                    Case 53 : .Text += "5"
                    Case 54 : .Text += "6"
                    Case 55 : .Text += "7"
                    Case 56 : .Text += "8"
                    Case 57 : .Text += "9"

                    Case 96 : .Text += "Num0"
                    Case 97 : .Text += "Num1"
                    Case 98 : .Text += "Num2"
                    Case 99 : .Text += "Num3"
                    Case 100 : .Text += "Num4"
                    Case 101 : .Text += "Num5"
                    Case 102 : .Text += "Num6"
                    Case 103 : .Text += "Num7"
                    Case 104 : .Text += "Num8"
                    Case 105 : .Text += "Num9"

                    Case 32
                        If .Text = "" Then .Text = "- Nicht belegt -" Else .Text += "Leert."


                    Case Else : .Text += e.KeyCode.ToString
                End Select
            End With

            'META_Bemerkung_Input.Text = e.KeyCode
            Tastenkombination_Key.Add(e.KeyCode)

        End If

        Tastenkombination_KeyAlt = e.KeyCode
    End Sub


    'Es wurde hier Absichtlich den Buttontext verwendet, da ich dass andere nicht schafte! So wie es jetzt ist, ist supper und warscheinlich erst noch schneller!
    Private Sub Start_Tastenkombination_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Tastenkombination.LostFocus
        If Start_Tastenkombination.Text = "- Nicht belegt -" Then
            Start_Tastenkombination_Key.Clear()
        Else
            If Start_Tastenkombination.Text = Pause_Tastenkombination.Text Then
                MessageBox.Show("Die Startkonbination darf nicht der Pausenkonbination entsprechen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Start_Tastenkombination.Text = Tastenkombination_Alt
            Else
                Start_Tastenkombination_Key.Clear()
                For Each item As String In Tastenkombination_Key
                    Start_Tastenkombination_Key.Add(item)
                Next
            End If
        End If
        GetAsyncKeyState_Timer.Enabled = True
    End Sub

    Private Sub Pause_Tastenkombination_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pause_Tastenkombination.LostFocus
        If Pause_Tastenkombination.Text = "- Nicht belegt -" Then
            Pause_Tastenkombination_Key.Clear()
        Else
            If Pause_Tastenkombination.Text = Start_Tastenkombination.Text Or Pause_Tastenkombination.Text = Save_Tastenkombination.Text Then
                MessageBox.Show("Die Pausenkonbination darf nicht der Strat und/oder der Save Konbination entsprechen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Pause_Tastenkombination.Text = Tastenkombination_Alt
            Else
                Pause_Tastenkombination_Key.Clear()
                For Each item As String In Tastenkombination_Key
                    Pause_Tastenkombination_Key.Add(item)
                Next
            End If
        End If
        GetAsyncKeyState_Timer.Enabled = True
    End Sub

    Private Sub Save_Tastenkombination_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Tastenkombination.LostFocus
        If Save_Tastenkombination.Text = "- Nicht belegt -" Then
            Save_Tastenkombination_Key.Clear()
        Else
            If Save_Tastenkombination.Text = Pause_Tastenkombination.Text Then
                MessageBox.Show("Die Savekonbination darf nicht der Pausenkonbination entsprechen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Save_Tastenkombination.Text = Tastenkombination_Alt
            Else
                Save_Tastenkombination_Key.Clear()
                For Each item As String In Tastenkombination_Key
                    Save_Tastenkombination_Key.Add(item)
                Next
            End If
        End If
        GetAsyncKeyState_Timer.Enabled = True
    End Sub

#End Region




#Region "SendKey"
    Private Sub SendKey_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SendKey_c.PreviewKeyDown, SendKey_d.PreviewKeyDown, SendKey_e.PreviewKeyDown,
                                                                                                                SendKey_f.PreviewKeyDown, SendKey_g.PreviewKeyDown, SendKey_a.PreviewKeyDown,
                                                                                                                SendKey_h.PreviewKeyDown, SendKey_cis.PreviewKeyDown, SendKey_dis.PreviewKeyDown,
                                                                                                                SendKey_fis.PreviewKeyDown, SendKey_gis.PreviewKeyDown, SendKey_ais.PreviewKeyDown

        sender.text = KeyCode_toName(e.KeyCode)

        Select Case sender.name
            Case "SendKey_c" : SendKey_key(SendKey_Oktave * 11) = e.KeyCode
            Case "SendKey_cis" : SendKey_key((SendKey_Oktave * 11) + 1) = e.KeyCode
            Case "SendKey_d" : SendKey_key((SendKey_Oktave * 11) + 2) = e.KeyCode
            Case "SendKey_dis" : SendKey_key((SendKey_Oktave * 11) + 3) = e.KeyCode
            Case "SendKey_e" : SendKey_key((SendKey_Oktave * 11) + 4) = e.KeyCode
            Case "SendKey_f" : SendKey_key((SendKey_Oktave * 11) + 5) = e.KeyCode
            Case "SendKey_fis" : SendKey_key((SendKey_Oktave * 11) + 6) = e.KeyCode
            Case "SendKey_g" : SendKey_key((SendKey_Oktave * 11) + 7) = e.KeyCode
            Case "SendKey_gis" : SendKey_key((SendKey_Oktave * 11) + 8) = e.KeyCode
            Case "SendKey_a" : SendKey_key((SendKey_Oktave * 11) + 9) = e.KeyCode
            Case "SendKey_ais" : SendKey_key((SendKey_Oktave * 11) + 10) = e.KeyCode
            Case "SendKey_h" : SendKey_key((SendKey_Oktave * 11) + 11) = e.KeyCode
            Case Else : MessageBox.Show("Error beim setzen des SendKeys")
        End Select

    End Sub



    Private Sub SendKey_OM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendKey_OM.Click
        If SendKey_Oktave > 0 Then
            SendKey_Oktave -= 1
            SendKey_Butons_refresh()
            SendKey_GroupBox.Text = "SendKey to Virtual MIDI Piano Okt " & SendKey_Oktave - 2
        End If
    End Sub

    Private Sub SendKey_OP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendKey_OP.Click
        If SendKey_Oktave < 10 Then
            SendKey_Oktave += 1
            SendKey_Butons_refresh()
            SendKey_GroupBox.Text = "SendKey to Virtual MIDI Piano Okt " & SendKey_Oktave - 2
        End If
    End Sub

    Sub SendKey_Butons_refresh()
        SendKey_c.Text = KeyCode_toName(SendKey_key(SendKey_Oktave * 11))
        SendKey_cis.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 1))
        SendKey_d.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 2))
        SendKey_dis.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 3))
        SendKey_e.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 4))
        SendKey_f.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 5))
        SendKey_fis.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 6))
        SendKey_g.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 7))
        SendKey_gis.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 8))
        SendKey_a.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 9))
        SendKey_ais.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 10))
        SendKey_h.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + 11))
    End Sub



    Function KeyCode_toName(ByVal KeyCode As Integer) As String 'Wichtig: Bei Byte kommen bei ConvertToString Falschresultate!!!

        Dim kc As New KeysConverter

        Select Case KeyCode
            Case 9 : Return "Tab"
            Case 16 : Return "Shft"
            Case 17 : Return "Ctrl"
            Case 18 : Return "Alt"
            Case 19 : Return "Pause"
            Case 27 : Return "Esc"

            Case 48 : Return "0"
            Case 49 : Return "1"
            Case 50 : Return "2"
            Case 51 : Return "3"
            Case 52 : Return "4"
            Case 53 : Return "5"
            Case 54 : Return "6"
            Case 55 : Return "7"
            Case 56 : Return "8"
            Case 57 : Return "9"

            Case 96 : Return "N0"
            Case 97 : Return "N1"
            Case 98 : Return "N2"
            Case 99 : Return "N3"
            Case 100 : Return "N4"
            Case 101 : Return "N5"
            Case 102 : Return "N6"
            Case 103 : Return "N7"
            Case 104 : Return "N8"
            Case 105 : Return "N9"

                'Case 112 : Return "F1"
                'Case 113 : Return "F2"
                'Case 114 : Return "F3"
                'Case 115 : Return "F4"
                'Case 116 : Return "F5"
                'Case 117 : Return "F6"
                'Case 118 : Return "F7"
                'Case 119 : Return "F8"
                'Case 120 : Return "F9"
                'Case 121 : Return "F10"
                'Case 122 : Return "F11"
                'Case 123 : Return "F12"


                'Case 37 : Return "Left"
                'Case 38 : Return "Up"
                'Case 39 : Return "Right"
                'Case 40 : Return "Down"
                'Case 40 : Return "Del"

                'Case 48 To 90 : Return Chr(KeyCode).ToString 'Normahlzeichen
                'Case 48 To 90 : Return Chr(KeyCode).ToString 'Sonderzeichen


            Case Else : Return kc.ConvertToString(KeyCode)
        End Select
    End Function


#End Region




#Region "Onlineaktivierung"


    Dim Lizenz_Activated As Boolean = False

    Public Shared Sub Main()
        'nAntiCopy.ShowDialog()
        'If Not Activated Then End
        Form1.Show()
        End
    End Sub


    Function Hex(ByVal I As Integer) As String
        Dim S As String
        S = Conversion.Hex(I)
        While S.Length < 8
            S &= "0"
        End While
        Return S
    End Function


    Function GetHash() As String
        Dim H As String = ""
        H &= Hex(My.Computer.Info.InstalledUICulture.GetHashCode)
        H &= Hex(My.Computer.FileSystem.GetDriveInfo(Environ("SYSTEMDRIVE")).TotalSize.GetHashCode)
        H &= Hex(My.Computer.Info.OSFullName.GetHashCode)
        H &= Hex(My.Computer.Info.OSPlatform.GetHashCode)
        H &= Hex(My.Computer.Info.OSVersion.GetHashCode)
        'H &= Hex(My.Computer.Info.TotalPhysicalMemory.GetHashCode)
        'H &= Hex(My.Computer.Mouse.WheelExists.GetHashCode)
        H &= Hex(My.User.Name.GetHashCode)
        H &= Hex(My.User.IsAuthenticated.GetHashCode)
        H &= Hex(My.User.CurrentPrincipal.Identity.Name.GetHashCode)
        H &= Hex(Environ("PROCESSOR_ARCHITECTURE").GetHashCode)
        H &= Hex(Environ("SYSTEMROOT").GetHashCode)
        H &= Hex(Environ("NUMBER_OF_PROCESSORS").GetHashCode)
        H &= Hex(My.Computer.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\CentralProcessor\0\").GetValue("~MHZ").GetHashCode)
        H &= Hex(My.Computer.Registry.LocalMachine.OpenSubKey(
            "HARDWARE\DESCRIPTION\System\BIOS\").GetValue("SystemManufacturer").GetHashCode)
        H &= Hex(H.GetHashCode)
        Return (LCase(H))
    End Function


    Sub Generate()
        Dim P() As Byte = Nothing, C As String, X() As Byte = Nothing, Z As Integer
        P = My.Computer.FileSystem.ReadAllBytes(Application.ExecutablePath)
        ReDim X(KeyLen() \ 8)
        C = GetHash()
        Z = 0
        For I As Integer = 0 To 111
            X(Z) = P(I) Xor Asc(C(I))
            Z += 1
            Randomize()
            For J As Integer = Z To Z + P(I + 112)
                X(J) = CInt(Rnd() * 254)
            Next
            Z += P(I + 112)
        Next
        My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\anticopy.y", X, False)
    End Sub

    Function KeyLen() As Integer
        Dim P() As Byte, Z As Integer
        P = My.Computer.FileSystem.ReadAllBytes(Application.ExecutablePath)
        Z = 0
        For I As Integer = 0 To 111
            Z += 1
            Z += P(I + 112)
        Next
        Return (Z * 8)
    End Function

    Function Check() As Boolean
        Dim P() As Byte = Nothing, T As String, C As String, X() As Byte = Nothing, Z As Integer
        Try
            P = My.Computer.FileSystem.ReadAllBytes(Application.ExecutablePath)
            X = My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\anticopy.y")
            Z = 0
        Catch ex As Exception
        End Try
        T = ""
        Try
            For I As Integer = 0 To 111
                T = T & Chr(P(I) Xor X(Z))
                Z += 1
                Z += P(I + 112)
            Next
        Catch ex As Exception
        End Try
        C = GetHash()
        'MessageBox.Show(C)
        'MessageBox.Show(C.Length)
        'MessageBox.Show(T)
        'MessageBox.Show(C = T)
        '''Return (C = T)
        Return True
    End Function

    Private Sub Registrierung()

        Application.DoEvents()
        Try
            Dim S As String = My.Computer.FileSystem.GetTempFileName()
            My.Computer.FileSystem.DeleteFile(S)
            If My.Computer.FileSystem.FileExists(S) = True Then
                MsgBox("Die Datei """ & S & """ konnte nicht überschrieben werden!" & vbCrLf & vbCrLf &
                        "Starten sie das Programm bitte neu. Sollte diese Meldung erneut erscheinen, vergewissern Sie sich ob sie " &
                        "schreibgeschützt ist und löschen Sie sie bei weiteren Problememen einfach manuell. ", MsgBoxStyle.Critical)
                End
            End If
            My.Computer.Network.DownloadFile(
                "http://www.nicobosshard.ch/MIDI_Harfe/nanticopykeys.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
            If My.Computer.FileSystem.FileExists(S) = False Then
                My.Computer.Network.DownloadFile(
                    "http://www.nicobosshard.ch/nanticopykeys.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                If My.Computer.FileSystem.FileExists(S) = False Then
                    My.Computer.Network.DownloadFile(
                        "http://www.bosshome.ch/MIDI_Harfe/nanticopykeys.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                    If My.Computer.FileSystem.FileExists(S) = False Then
                        My.Computer.Network.DownloadFile(
                                "http://www.bosshome.ch/nanticopykeys.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                        If My.Computer.FileSystem.FileExists(S) = False Then
                            My.Computer.Network.DownloadFile(
                                    "http://www.eldercraft.ddns.net/MIDI_Harfe/nanticopykeys.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                            If My.Computer.FileSystem.FileExists(S) = False Then
                                My.Computer.Network.DownloadFile(
                                        "http://www.eldercraft.ddns.net/nanticopykeys.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                            End If
                        End If
                    End If
                End If
            End If


            Dim X As String = My.Computer.FileSystem.ReadAllText(S)
            If CInt(X.Split(";")(0)) > 0 Then
                If CInt(X.Split(";")(1)) > 0 Then
                    Generate()
                    Lizenz_Activated = True
                    If Check() Then
                        MsgBox("Der Schlüssel ist gültig. Das Programm wurde erfolgreich aktiviert. " &
                          "Sie dürfen diesen Schlüssel noch " &
                          (CInt(X.Split(";")(1)) - 1) &
                          " mal für eine Neuinstallation verwenden." & vbCrLf & vbCrLf &
                          "Die Aktivierung erfolgt auch bei jedem Softwaireupdate. " &
                          "Machen Sie sich deswegen keine Sorgen, da auch bei jedem Update " &
                          "Ihre Anzahl verbleibenden Aktivierungen um eins erhöht werden.")
                    Else
                        Lizenz = ""
                        MsgBox("Der Schlüssel ist gültig. Das Programm konnte allerdings " &
                          "nicht aktiviert werden. " &
                          "Bitte überprüfen Sie, ob der Installationsordner schreibgeschützt ist. " &
                          "Sollte dieses Problem weiterhin bestehen, melden Sie sich per E-Mail an nicho@bosshome.ch",
                          MsgBoxStyle.Exclamation)
                        Me.Close()
                    End If
                Else
                    MsgBox("Ihr Schlüssel ist gültig, aber die maximale Anzahl der " &
                      "Aktivierungen für diesen Schlüssel wurde überschritten. " &
                      "Bitte melden sich per E-Mail an nico@bosshome.ch um mit " &
                      "plausiebelr Begründung (z.B. 6 Computer, Merfache " &
                      "neuinstallation wegen Softwaireproblem, Neuaktivierung wegen" &
                      "grösseren Hardwairänderungen am Computer, Lizenzspeicherungsfehler " &
                      "usw.) gratis erneute Lizenzen auf diesen Schlüssel zu erhalten " &
                      "oder weitere zu erwerben.", MsgBoxStyle.Exclamation)
                    Me.Close()
                End If
            Else
                Lizenz = ""
                MsgBox("Der Lizenzschlüssel ist ungültig. Bitte überprüfen Sie ihn auf " &
                  "Tippfehler. Bei Problemen wenden Sie sich bitte per E-Mail an nico@bosshome.ch! " &
                  "Der Lizenzschlüssel sollten Sie zur gekauften Hardwaire zusammen mit dem " &
                  "Downloadlink erhalten haben.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            Lizenz = ""
            MsgBox("Das Programm konnte aufgrund eines Fehlers nicht aktiviert werden. Eine Aktivierung " &
                   "ist nur beim ersten Programmstart und nach jedem Update erforderlich. " &
                    "Bitte überprüfen Sie ihre Internetverbindung. Sollte dieser Fehler weiterhin" &
                    "bestehen bleiben, melden sie Sich bitte umgehend per E-Mail an nico@bosshome.ch",
                    MsgBoxStyle.Critical)
        End Try
        'Me.Close()
    End Sub


    'http://www.vbarchiv.net/workshop/workshop_119-einfacher-kopierschutz-mit-online-aktivierung.html
    Private Sub AntiCopy_Load() Handles MyBase.Load

        Lizenz = My.Settings.Lizenz_Save

        If Check() = True Then
            Lizenz_Activated = True
            'MessageBox.Show("Activated")
        Else
            Do
                Do Until Lizenz.Length = 29
                    If Not Lizenz.Length = 0 Then MessageBox.Show("Die Länge ihrer Eingabe entspringt nicht der," _
                                                                    & vbCrLf & "für den Schlüssel vorgesehenen Länge." _
                                                                    & vbCrLf & "Vergewissern Sie sich, dass sie alle '-' eingegeben, sowie keinen" _
                                                                    & vbCrLf & "Buchstaben vegessen oder mehrfach verwendet haben.",
                                                                    "Falscher Lizenzschlüssel", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Lizenz = Nothing
                    Lizenz = InputBox("Bitte geben Sie Ihr Lizenzschlüssel ein." _
                                        & vbCrLf & vbCrLf & "Format: XXXXX-XXXXX-XXXXX-XXXXX-XXXXX" _
                                        & vbCrLf & "- Nur Grossbuchstaben ohne Zahelen, Zeichen" _
                                        & vbCrLf & "- Trennungsstriche nicht vergessen!", "Aktivierung")

                    If Lizenz = "" Then
                        Dim result As DialogResult = MessageBox.Show("Möchten Sie die Lizenzaktivierung und somit das Programm wirklich beenden?", "Programm wirklich beenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If Windows.Forms.DialogResult.Yes Then
                            End
                        End If
                    End If

                    'PLMMD-YNOJG-EBJET-MEBXU-YLEJX

                Loop

                MsgBox("Die Aktivierung kann, abhängig von verschiedensten Faktoren von wenigen " &
                        "Sekunden bis hin zu einer Minute dauern! Haben sie bitte ein bisschen Geduld." &
                        vbCrLf & vbCrLf & "Die Aktivierung wird mit einem Klick auf OK gestartet.")
                Registrierung()

                If Check() = True Then
                    Lizenz_Activated = True
                Else
                    Lizenz = ""
                End If
            Loop Until Lizenz_Activated = True
        End If

        Nachrichtsfunktion()

    End Sub
#End Region



#Region "Nachrichtsfunktion"
    Private Sub Nachrichtsfunktion()

        'MsgBox("http://www.nicobosshard.ch/MIDI_Harfe/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows")

        Try
            Dim S As String = My.Computer.FileSystem.GetTempFileName()
            My.Computer.FileSystem.DeleteFile(S)
            If My.Computer.FileSystem.FileExists(S) = True Then
                MsgBox("Die Datei """ & S & """ konnte nicht überschrieben werden!" & vbCrLf & vbCrLf &
                        "Starten sie das Programm bitte neu. Sollte diese Meldung erneut erscheinen, vergewissern Sie sich ob sie " &
                        "schreibgeschützt ist und löschen Sie sie bei weiteren Problememen einfach manuell. ", MsgBoxStyle.Critical)
                End
            End If
            My.Computer.Network.DownloadFile(
                    "http://www.nicobosshard.ch/MIDI_Harfe/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
            If My.Computer.FileSystem.FileExists(S) = False Then
                My.Computer.Network.DownloadFile(
                    "http://www.nicobosshard.ch/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                If My.Computer.FileSystem.FileExists(S) = False Then
                    My.Computer.Network.DownloadFile(
                            "http://www.bosshome.ch/MIDI_Harfe/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                    If My.Computer.FileSystem.FileExists(S) = False Then
                        My.Computer.Network.DownloadFile(
                                "http://www.bosshome.ch/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                        If My.Computer.FileSystem.FileExists(S) = False Then
                            My.Computer.Network.DownloadFile(
                                    "http://www.eldercraft.ddns.net/MIDI_Harfe/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                            If My.Computer.FileSystem.FileExists(S) = False Then
                                My.Computer.Network.DownloadFile(
                                        "http://www.eldercraft.ddns.net/Update.php?app=MIDIHarfe&key=" & Lizenz & "&os=Windows" & "&version=" & Version & "&language=" & Sprache, S)
                            End If
                        End If
                    End If
                End If
            End If


            Dim CutPos As Integer
            Dim lines() As String = System.IO.File.ReadAllLines(S)

            For Each line In lines

                'MsgBox(line)
                'MsgBox(line.ElementAt(0))

                If line = "Reactivating" Then
                    Lizenz_Activated = False
                    Lizenz = ""
                    My.Settings.Lizenz_Save = ""
                    AntiCopy_Load()
                    Exit Sub
                End If

                If line = "End" Then
                    End
                End If

                Select Case line.ElementAt(0)
                    Case "="
                        If line.Substring(1, line.Length - 1) <> Version Then
                            Exit Sub
                        End If
                    Case "!"
                        If line.Substring(1, line.Length - 1) = Version Then
                            Exit Sub
                        End If
                    Case "-"
                        If line.Substring(1, line.Length - 1) >= Version Then
                            Exit Sub
                        End If
                    Case "+"
                        If line.Substring(1, line.Length - 1) <= Version Then
                            Exit Sub
                        End If
                    Case "@"
                        CutPos = line.LastIndexOf("|")
                        MessageBox.Show(line.Substring(1, CutPos - 1).Replace("%n", Environment.NewLine), line.Substring(CutPos + 1, line.Length - CutPos - 1), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case "$"
                        CutPos = line.LastIndexOf("|")
                        Dim Prozess As New Process
                        Try
                            Prozess.StartInfo.WindowStyle = line.Substring(CutPos + 1, line.Length - CutPos - 1)
                        Catch
                            Prozess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        End Try

                        Prozess.StartInfo.FileName = "cmd.exe"
                        Prozess.StartInfo.Arguments = "/c " & line.Substring(1, line.Length - 1).Replace("%n", Environment.NewLine)
                        Prozess.Start()
                    Case "?"
                        CutPos = line.LastIndexOf("|")
                        Dim result As DialogResult = MessageBox.Show(line.Substring(1, CutPos - 1).Replace("%n", Environment.NewLine), line.Substring(CutPos + 1, line.Length - CutPos - 1), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.No Then
                            Exit Sub
                        End If
                End Select
            Next

        Catch ex As Exception
        End Try
    End Sub
#End Region



#Region "Einstellungsspeicherungsfunktion"

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown    'Wichtig: MyBase.Load geht nicht, da zu früh!

        With My.Settings

            'Lizens wird wegen Handles MyBase.Load in eigenem Sub geladen.

            ' Aufnahmemodus
            MIDI_NormalMode.Checked = .MIDI_NormalMode
            'Absichtlicher Overflow
            'Alternative: SpecialMode stadt NormalMode speichern!
            'MIDI_SpecialMode.Checked = .MIDI_NormalMode + 1
            cboInstruments.SelectedIndex = .cboInstruments

            ' Lautstärke
            Volume_Steps_NumericUpDown.Value = .Volume_Steps_Save
            Volume_min_NumericUpDown.Value = .Volume_min_Save
            Volume_max_NumericUpDown.Value = .Volume_max_Save

            ' Tempo
            Tackt_Zaehler_Input.Value = .Tackt_Zaehler_Input
            Tackt_Naenner_Input.Value = .Tackt_Naenner_Input
            BPM.Value = .BPM

            ' Tonhöhenverschiebung
            Halbtonverschiebung.Value = .Halbtonverschiebung

            ' META
            META_Dateinamen_Input.Text = .META_Dateinamen_Input
            META_Autor_Input.Text = .META_Autor_Input
            META_Spurnamen_Input.Text = .META_Spurnamen_Input
            META_Copyright_Input.Text = .META_Copyright_Input
            META_Bemerkung_Input.Text = .META_Bemerkung_Input

            ' Metronom
            Metronom_Betont.Checked = .Metronom_Betont
            Metronom_ON.Checked = .Metronom_ON

            ' Direct Play
            DirectPlay_ON.Checked = .DirectPlay_ON
            hsbVolume.Value = .hsbVolume
            hsbPan.Value = .hsbPan
            hsbModWheel.Value = .hsbModWheel

            ' ToolTip
            ToolTip_ON.Checked = .ToolTip_ON

            ' Tonart Klappen
            C1_Klappe.Value = .C_Klappe
            D1_Klappe.Value = .D_Klappe
            E1_Klappe.Value = .E_Klappe
            F1_Klappe.Value = .F_Klappe
            G1_Klappe.Value = .G_Klappe
            A1_Klappe.Value = .A_Klappe
            H1_Klappe.Value = .G_Klappe

            ' Startwert, Stopwert und Halbtonverschiebung
            Try
                For i = 0 To 34
                    Noten_Startwert(i).Text = .Startwert_Save(i)
                    Noten_Stopwert(i).Text = .Stopwert_Save(i)
                    Noten_Verschiebung(i).Text = .Verschiebung_Save(i)
                Next
            Catch
            End Try



            ' Tastenkonbinationen
            'Try
            Start_Tastenkombination.Text = .Start_Tastenkombination_Save
            For Each item As String In .Start_Tastenkombination_Key_Save
                Start_Tastenkombination_Key.Add(item)
                'MessageBox.Show(item)
            Next

            Pause_Tastenkombination.Text = .Pause_Tastenkombination_Save
            .Pause_Tastenkombination_Key_Save.Clear()
            For Each item As String In .Pause_Tastenkombination_Key_Save
                Pause_Tastenkombination_Key.Add(item)
            Next

            Save_Tastenkombination.Text = .Save_Tastenkombination_Save
            .Save_Tastenkombination_Key_Save.Clear()
            For Each item As String In .Save_Tastenkombination_Key_Save
                Save_Tastenkombination_Key.Add(item)
            Next
            'Catch
            'End Try


            'Ist SendKeys an?
            SendKeys_ON.Checked = .SendKeys_ON_Save

            'SendKey Einstellungen
            Try
                For i = 0 To 127
                    SendKey_key(i) = .SendKey_Save(i)
                Next
            Catch
            End Try

            For i = 0 To 11
                SendKey_h.Text = KeyCode_toName(SendKey_key((SendKey_Oktave * 11) + i))
            Next


        End With
    End Sub



    Private Sub Form1_FormClosing1(ByVal sender As System.Object, ByVal e As Object) Handles MyBase.FormClosing ', SendKey_OM.Click '(Als Testhandle da keine MsgBox bei Close Event ohne anderes Event)
        With My.Settings

            'Lizenz
            .Lizenz_Save = Lizenz

            ' Aufnahmemodus
            .MIDI_NormalMode = MIDI_NormalMode.Checked
            .cboInstruments = cboInstruments.SelectedIndex

            ' Lautstärke
            .Volume_Steps_Save = Volume_Steps_NumericUpDown.Value
            .Volume_min_Save = Volume_min_NumericUpDown.Value
            .Volume_max_Save = Volume_max_NumericUpDown.Value

            ' Tempo
            .Tackt_Zaehler_Input = Tackt_Zaehler_Input.Value
            .Tackt_Naenner_Input = Tackt_Naenner_Input.Value
            .BPM = BPM.Value

            ' Tonhöhenverschiebung
            .Halbtonverschiebung = Halbtonverschiebung.Value

            ' META
            .META_Dateinamen_Input = META_Dateinamen_Input.Text
            .META_Autor_Input = META_Autor_Input.Text
            .META_Spurnamen_Input = META_Spurnamen_Input.Text
            .META_Copyright_Input = META_Copyright_Input.Text
            .META_Bemerkung_Input = META_Bemerkung_Input.Text

            ' Metronom
            .Metronom_Betont = Metronom_Betont.Checked
            .Metronom_ON = Metronom_ON.Checked

            ' Direct Play
            .DirectPlay_ON = DirectPlay_ON.Checked
            .hsbVolume = hsbVolume.Value
            .hsbPan = hsbPan.Value
            .hsbModWheel = hsbModWheel.Value

            ' ToolTip
            .ToolTip_ON = ToolTip_ON.Checked

            ' Tonart Klappen
            .C_Klappe = C1_Klappe.Value
            .D_Klappe = D1_Klappe.Value
            .E_Klappe = E1_Klappe.Value
            .F_Klappe = F1_Klappe.Value
            .G_Klappe = G1_Klappe.Value
            .A_Klappe = A1_Klappe.Value
            .H_Klappe = H1_Klappe.Value

            ' Halbtonverschiebung

            ' Startwert, Stopwert und Halbtonverschiebung
            .Startwert_Save.Clear()
            .Stopwert_Save.Clear()
            .Verschiebung_Save.Clear()
            For i = 0 To 34
                .Startwert_Save.Add(Noten_Startwert(i).Text)
                .Stopwert_Save.Add(Noten_Stopwert(i).Text)
                .Verschiebung_Save.Add(Noten_Verschiebung(i).Text)
                'MessageBox.Show(Noten_Startwert(i).Text)
            Next


            ' Tastenkonbinationen
            .Start_Tastenkombination_Save = Start_Tastenkombination.Text
            .Start_Tastenkombination_Key_Save.Clear()
            For Each item As Byte In Start_Tastenkombination_Key
                .Start_Tastenkombination_Key_Save.Add(item)
                'MessageBox.Show(item)
            Next

            .Pause_Tastenkombination_Save = Pause_Tastenkombination.Text
            .Pause_Tastenkombination_Key_Save.Clear()
            For Each item As Byte In Pause_Tastenkombination_Key
                .Pause_Tastenkombination_Key_Save.Add(item)
            Next

            .Save_Tastenkombination_Save = Save_Tastenkombination.Text
            .Save_Tastenkombination_Key_Save.Clear()
            For Each item As Byte In Save_Tastenkombination_Key
                .Save_Tastenkombination_Key_Save.Add(item)
            Next


            'Ist SendKeys an?
            .SendKeys_ON_Save = SendKeys_ON.Checked()

            'SendKey Einstellungen
            .SendKey_Save.Clear()
            For i = 0 To 127
                .SendKey_Save.Add(SendKey_key(i))
            Next



            ' Einstellungen speichern
            .Save()

        End With

    End Sub

#End Region



    Private Sub Mesgeschwindigkeitsberechnung_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mesgeschwindigkeitsberechnung_Timer.Tick
        Try
            Messintervall_Zahl = (Anz_Messungen - AnzMessungen_alt) * 4 'Achtung: Komischerweise Divison durch 0 wenn AnzMessungen_alt > Anz_Messungen! Wieso habe ich keine Ahnung.
            MessungenProS_TexBox.Text = Format(Messintervall_Zahl, "000") & " M/s"
            Messintervall_TextBox.Text = Format(1000 / Messintervall_Zahl, "00.0") & " ms"
            AnzMessungen_alt = Anz_Messungen
        Catch ' Für Devision durch 0 Error der aber eigendlich durch AnzMessungen_alt=0 bei DoBackgroundWorker behoben wurde.
            Messintervall_Zahl = 0
            Anz_Messungen = 0
            AnzMessungen_alt = 0
            Anz_Verbindungsfehler = 0
            Anz_Messungen_TextBox.Text = "0"
            Anz_Verbindungsfehler_TextBox.Text = "0"
        End Try
    End Sub


    Private Sub MyBase_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        Dim wait As Task = fade_out(5)
    End Sub


    Private Async Function fade_out(ByVal ms As Integer) As Task
        Await Task.Delay(ms)
        'Dim rc As RECT
        'GetWindowRect(Process.GetCurrentProcess().MainWindowHandle, rc)
        'MessageBox.Show(rc.Right.ToString())
        Dim Width = MyBase.Size.Width 'rc.Right - rc.Left
        Dim Height = MyBase.Size.Height 'rc.Bottom - rc.Top
        'MessageBox.Show(Width & " != " & MyBase.Size.Width)
        'MessageBox.Show(Width & "/" & Height)
        If Width < 1290 And Height < 810 Then
            'MessageBox.Show("1")
            Panel1.Location = New Point(0, 0)
            Panel1.Width = Width - 17
            Panel1.Height = Height - 40
        ElseIf Width < 1290 Then
            'MessageBox.Show("2")
            Panel1.Location = New Point(0, (Height - 771 - 40) / 2)
            Panel1.Width = 1274
            Panel1.Height = 771
        ElseIf Height < 810 Then
            'MessageBox.Show("3")
            Panel1.Location = New Point((Width - 1274 - 17) / 2, 0)
            Panel1.Width = Width - 17
            Panel1.Height = Height - 40
        Else
            'MessageBox.Show("4")
            Panel1.Location = New Point((Width - 1274 - 17) / 2, (Height - 771 - 40) / 2)
            Panel1.Width = 1274
            Panel1.Height = 771
        End If
    End Function

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As _
          System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Tackt.Enabled Then
            Dim result As DialogResult = MessageBox.Show("Wollen Sie das Programm wirklich beenden?" _
            & vbCrLf & "Die laufende Aufnahme wird dadurch gelöscht!", "Wirklich beenden?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub Help_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help_Button.Click
        'Alle selection aufheben.
        Einstellungen_GroupBox.Focus()
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help_Button.Click
        Help_Button.Enabled = False 'Sieht schöner aus
        MessageBox.Show("Es ist momentan noch keine Hilfe ausser die eigendlich völlig ausreichende ToolTip Funktion für mein Programm verfügbar." _
                        & vbCrLf & vbCrLf & "Sollten sie irgendwelche Fragen haben, melden Sie sich bitte per Mail an nico@bosshome.ch",
                        "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Help_Button.Enabled = True
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About_Button.Click
        About_Button.Enabled = False 'Sieht schöner aus
        MessageBox.Show("MIDI Harfe" & Version & vbCrLf & "©2014 Nico Bosshard" _
            & vbCrLf & vbCrLf & "Ich verbiete hirmit ausdrücklich jegliche modifikation am Lizenzierungs- und Aktivierungssystem!" _
            & vbCrLf & "Ideenverschläge und sonstige  Mods sind jederzeit erwünscht. :D" _
            & vbCrLf & "Bei Fragen bin ich per E-Mail unter nico@bosshome.ch erreichbar." _
            & vbCrLf & vbCrLf & "Version " & Version & vbCrLf & "Lizenzstatus: Aktiviert" & vbCrLf & "Veröffentlichung: " & PublishDate.Date & vbCrLf & "OS: Windows, VirtualBox" _
            & vbCrLf & "Programmiert mit Visual Basic 2010 .NET Framework 4.0" _
            & vbCrLf & "OS: Windews XP SP2 bis Windows 8.1" _
            & vbCrLf & "Programmiert von Nico Bosshard", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
        About_Button.Enabled = True
    End Sub

End Class


