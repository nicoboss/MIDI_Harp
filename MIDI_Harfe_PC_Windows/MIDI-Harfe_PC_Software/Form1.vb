' -----------------------------------------------------------------------
' <copyright file="Form1.vb">
' Nico Bosshard
' </copyright>
' -----------------------------------------------------------------------


Option Explicit On 'Prüfen aller Variabeln während des Kompilierens
#Disable Warning BC42356 'This async method lacks 'Await' operators and so will run synchronously
#Disable Warning BC42358 'Because this call is not awaited, execution of the current method continues before the call is completed


'Importieren der benötigten Bibliotheken
Imports System.IO.Ports.SerialPort
Imports System.Runtime.InteropServices
Imports System.Threading.Tasks
Imports Sanford.Multimedia.Midi
Imports libmidi.net.Events
Imports libmidi.net.Enums
Imports libmidi.net.Base
'Imports MetaEvent = NAudio.Midi.MetaEvent
'Imports NAudio.Wave


Public Class Form1

    'Deklarieren globaler Variabeln und Systemfunktionen.
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

    'Erstellen und Inizialisieren einer Variabel mit allen verbundenen seriellen Geräten
    Public ports As String() = GetPortNames()
    Public port As String = ""
    Declare Sub Beep Lib "kernel32.dll" (ByVal tone As Integer, ByVal dauer As Integer)

    'Versionsinformationen
    Dim Version As String = "V2.1.7"
    Dim PublishDate As Date = "18.02.2017"

    'Nur dummy Wert. Wird später sowieso überschrieben.
    Dim Lizenz As String = "PWTMD-YBGSG-QMLRT-MEZUO-PYXQO"
    Dim Sprache = "DE"

    'Vaiabeln für MIDI-Out deklarieren.
    'In eventCollection werden alle MIDI-Events für die spätere Speicherung zwischengespeichert
    '480=PPQ (Ticks pro Viertelnote)
    Dim MIDI_Out_Connected As Boolean = False
    Dim eventCollection As New MidiEventCollection(1, 480)

    Dim TaktNr As Short
    Dim Takt_32stel As Byte
    Dim ADC(40) As Integer
    Dim Notenlaege(127) As Single
    Dim Note_Play(127) As Boolean
    Dim Note_Volume(127) As Byte
    Dim Button_Note_Play(127) As Boolean
    'Dim Verschiebung(255) As Byte

    Dim MIDI_Pos As Integer = 0
    Dim MIDI_Tracklist As New List(Of Byte)
    Dim MIDI_TrackNr As Integer = 1
    Dim MIDI_Speed As Integer = 48

    Dim SendKey_key(127) As Byte
    Dim SendKey_Oktave As Byte = 4

    Dim Metronom_alt As Byte

    Dim Aufnahme_gestartet As Boolean = False
    Dim Messung_Pause As Boolean = False

    Dim AnzMessungen_alt As ULong
    Dim Messintervall_Zahl As ULong
    Dim Anz_Messungen As ULong = 0
    Dim Anz_Messungen_alt As ULong = 0
    Dim Anz_Verbindungsfehler As ULong

    Dim SerialPort1_Stop As Boolean = False

    Dim Noten_Verschiebung(35) As TextBox
    Dim Noten_VerticalProgessBar(35) As MTech010VerticalProgessBar
    Dim Noten_Wert(35) As TextBox
    Dim Noten_Startwert(35) As TextBox
    Dim Noten_Stoppwert(35) As TextBox
    Dim Noten_StartW(35) As Integer
    Dim Noten_StoppW(35) As Integer
    Dim Noten_Versch(35) As Integer
    Dim Halbtonversch As Integer

    'Definieren der Notenreihenfolge zur korrekten Zuordnung einer Harfensaite
    Dim MidiNoteNr = {
        32, 34,
        36, 38, 39, 41, 43, 44, 46,
        48, 50, 51, 53, 55, 56, 58,
        60, 62, 63, 65, 67, 68, 70,
        72, 74, 75, 77, 79, 80, 82,
        84, 86, 87, 89, 91, 92, 94}

    'Definieren der Notennamen zur korrekten Beschriftung der gespielten Saiten
    Dim Notennamen = {{"ces", "des", "d", "fes", "ges", "g", "a", "ces"},
                  {"c", "d", "es", "f", "g", "as", "b", "c"},
                  {"cis", "dis", "e", "fis", "gis", "a", "h", "cis"}}

    Dim C1_Klappe_alt As SByte
    Dim D1_Klappe_alt As SByte
    Dim E1_Klappe_alt As SByte
    Dim F1_Klappe_alt As SByte
    Dim G1_Klappe_alt As SByte
    Dim A1_Klappe_alt As SByte
    Dim H1_Klappe_alt As SByte

    Dim Tastenkombination_FirstKey As Boolean
    Dim Tastenkombination_KeyAlt As Byte
    Dim Costom_Tastenkombinationen_Counter As UShort
    Dim Start_Tastenkombination_Key As New List(Of Byte)
    Dim Pause_Tastenkombination_Key As New List(Of Byte)
    Dim Save_Tastenkombination_Key As New List(Of Byte)
    Dim Tastenkombination_Alt As String
    Dim Tastenkombination_Key As New List(Of Byte)
    Dim Tastenkonbination_Klappenverschiebung As SByte

    Dim Messwerte As New List(Of List(Of Integer))
    Dim Integralwerte As New List(Of List(Of Integer))
    Dim Ableitung1werte As New List(Of List(Of Integer))
    Dim Ableitung2werte As New List(Of List(Of Integer))
    'Dim Ableitung3werte As New List(Of List(Of Integer))

    'Deaktivierte Funktion zur Audio-Ausgabe der gespielten Saiten
    'Dim bufferedWaveProvider(35) As BufferedWaveProvider
    'Dim player(35) As WaveOut

    'Form1_Load_main wird beim Laden des Hauptprogramms ausgeführt.
    Private Sub Form1_Load_main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Deklarieren von Arreys aus GUI Steuerelementen zur indexbasierenden Ansprechung gewisser Steuerelementgruppen
        Noten_VerticalProgessBar = {
            A1_VerticalProgessBar, H1_VerticalProgessBar,
            C2_VerticalProgessBar, D2_VerticalProgessBar, E2_VerticalProgessBar, F2_VerticalProgessBar, G2_VerticalProgessBar, A2_VerticalProgessBar, H2_VerticalProgessBar,
            C3_VerticalProgessBar, D3_VerticalProgessBar, E3_VerticalProgessBar, F3_VerticalProgessBar, G3_VerticalProgessBar, A3_VerticalProgessBar, H3_VerticalProgessBar,
            C4_VerticalProgessBar, D4_VerticalProgessBar, E4_VerticalProgessBar, F4_VerticalProgessBar, G4_VerticalProgessBar, A4_VerticalProgessBar, H4_VerticalProgessBar,
            C5_VerticalProgessBar, D5_VerticalProgessBar, E5_VerticalProgessBar, F5_VerticalProgessBar, G5_VerticalProgessBar, A5_VerticalProgessBar, H5_VerticalProgessBar,
            C6_VerticalProgessBar, D6_VerticalProgessBar, E6_VerticalProgessBar, F6_VerticalProgessBar, G6_VerticalProgessBar}

        Noten_Wert = {
            A1_Wert, H1_Wert,
            C2_Wert, D2_Wert, E2_Wert, F2_Wert, G2_Wert, A2_Wert, H2_Wert,
            C3_Wert, D3_Wert, E3_Wert, F3_Wert, G3_Wert, A3_Wert, H3_Wert,
            C4_Wert, D4_Wert, E4_Wert, F4_Wert, G4_Wert, A4_Wert, H4_Wert,
            C5_Wert, D5_Wert, E5_Wert, F5_Wert, G5_Wert, A5_Wert, H5_Wert,
            C6_Wert, D6_Wert, E6_Wert, F6_Wert, G6_Wert}

        Noten_Verschiebung = {
            A1_Verschiebung, H1_Verschiebung,
            C2_Verschiebung, D2_Verschiebung, E2_Verschiebung, F2_Verschiebung, G2_Verschiebung, A2_Verschiebung, H2_Verschiebung,
            C3_Verschiebung, D3_Verschiebung, E3_Verschiebung, F3_Verschiebung, G3_Verschiebung, A3_Verschiebung, H3_Verschiebung,
            C4_Verschiebung, D4_Verschiebung, E4_Verschiebung, F4_Verschiebung, G4_Verschiebung, A4_Verschiebung, H4_Verschiebung,
            C5_Verschiebung, D5_Verschiebung, E5_Verschiebung, F5_Verschiebung, G5_Verschiebung, A5_Verschiebung, H5_Verschiebung,
            C6_Verschiebung, D6_Verschiebung, E6_Verschiebung, F6_Verschiebung, G6_Verschiebung}

        Noten_Startwert = {
            A1_Startwert, H1_Startwert,
            C2_Startwert, D2_Startwert, E2_Startwert, F2_Startwert, G2_Startwert, A2_Startwert, H2_Startwert,
            C3_Startwert, D3_Startwert, E3_Startwert, F3_Startwert, G3_Startwert, A3_Startwert, H3_Startwert,
            C4_Startwert, D4_Startwert, E4_Startwert, F4_Startwert, G4_Startwert, A4_Startwert, H4_Startwert,
            C5_Startwert, D5_Startwert, E5_Startwert, F5_Startwert, G5_Startwert, A5_Startwert, H5_Startwert,
            C6_Startwert, D6_Startwert, E6_Startwert, F6_Startwert, G6_Startwert}

        Noten_Stoppwert = {
            A1_Stoppwert, H1_Stoppwert,
            C2_Stoppwert, D2_Stoppwert, E2_Stoppwert, F2_Stoppwert, G2_Stoppwert, A2_Stoppwert, H2_Stoppwert,
            C3_Stoppwert, D3_Stoppwert, E3_Stoppwert, F3_Stoppwert, G3_Stoppwert, A3_Stoppwert, H3_Stoppwert,
            C4_Stoppwert, D4_Stoppwert, E4_Stoppwert, F4_Stoppwert, G4_Stoppwert, A4_Stoppwert, H4_Stoppwert,
            C5_Stoppwert, D5_Stoppwert, E5_Stoppwert, F5_Stoppwert, G5_Stoppwert, A5_Stoppwert, H5_Stoppwert,
            C6_Stoppwert, D6_Stoppwert, E6_Stoppwert, F6_Stoppwert, G6_Stoppwert}

        'Einfüllen der vordefinierten Tastenkombinationen.
        With Tastenkombinationen_DataGridView.Rows
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

        For Each col As DataGridViewColumn In Tastenkombinationen_DataGridView.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            col.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        Display_Refresh()

        'Scannen aller mit dem PC verbundenen Serial-Ports
        Com_Search()

        'Buttons sperren
        Button_Disconnect.Enabled = False
        Button_Connect.Enabled = False

    End Sub


    'Auffüllen der COM-Port Liste bei jedem Com_Search_Timer Tick
    Sub Com_Search() Handles Com_Search_Timer.Tick

        ports = GetPortNames()
        ComboBox_Comport.Items.Clear()

        'Comports suchen
        For Each Me.port In ports
            ComboBox_Comport.Items.Add(port)
        Next port

        ComboBox_Comport.Sorted = True

        If (ComboBox_Comport.Items.Count > 0) Then
            ComboBox_Comport.SelectedIndex = ComboBox_Comport.Items.Count - 1
        End If
    End Sub


    'Button_Connect_Click verbindet sich mit dem momentan ausgewählten Serial-Port
    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click

        If Lizenz_Activated = False Then
            MessageBox.Show("Das Programm wurde nicht ordnungsgemäss aktiviert." _
                            & vbCrLf & "Dies kann beispielsweise bei einer Modifizierung der Fall sein." _
                            & vbCrLf & "Bitte srarten Sie das Programm neu. Sollte diese Meldung nicht" _
                            & vbCrLf & "verschwinden kontaktieren Sie bitte den Support per mail unter" _
                            & vbCrLf & "nico@bosshome.ch. Diese Meldung existiert um Modder von meinem" _
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
                .BaudRate = 115200 '230400 '460800 'Baudrate
                .DataBits = 8
                .Encoding = System.Text.Encoding.Default
                .Open()
            End With

            Com_Search_Timer.Enabled = False
            Messgeschwindigkeitsberechnung_Timer.Enabled = True
            Display_Refresh_Timer.Enabled = True
            Dim task = New Task(AddressOf SerialPort1_DataReceived)
            task.Start()
            'Serial_BackgroundWorker.RunWorkerAsync()
            'SerialPort1_DataReceived(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            'Fehlermeldung
            MessageBox.Show("Unter dem gewählten COM Port wurde kein Mikrokontroller erkannt. " _
            & vbCrLf & "Stellen Sie sicher, dass Sie den richtigen Port gewählt haben und der" _
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


    'Trennen der Verbindung mit dem Mikrocontroller
    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click, Me.FormClosing

        SerialPort1_Stop = True
        Serial_BackgroundWorker.CancelAsync()

        'Trennen
        Display_Refresh_Timer.Enabled = False
        Messgeschwindigkeitsberechnung_Timer.Enabled = False
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


    'Mainloop des Mikrocontrollerempfängers und dessen Datenauswerung
    'Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Serial_BackgroundWorker.DoWork
    Async Sub SerialPort1_DataReceived()
        Dim i As Integer
        Messintervall_Zahl = 0
        Anz_Messungen = 0
        AnzMessungen_alt = 0
        Anz_Verbindungsfehler = 0
        Anz_Messungen_TextBox.Text = "0"
        Anz_Verbindungsfehler_TextBox.Text = "0"

        'Deaktivierte SaveRawDate-File Funktion.
        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\nico\Desktop\logs\MIDI_Harp " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt", True)
        Dim messarrey(32) As Integer

        'Auffüllen der noch leeren Messlisten mit 0
        Dim zero_array(10000) As Integer
        Messwerte.Clear()
        Integralwerte.Clear()
        Ableitung1werte.Clear()
        For i = 0 To 31
            Messwerte.Add(New List(Of Integer))
            Messwerte(i).AddRange(zero_array)
            Integralwerte.Add(New List(Of Integer))
            Integralwerte(i).AddRange(zero_array)
            Ableitung1werte.Add(New List(Of Integer))
            Ableitung1werte(i).AddRange(zero_array)
            Ableitung2werte.Add(New List(Of Integer))
            Ableitung2werte(i).AddRange(zero_array)
            'Ableitung3werte.Add(New List(Of Integer))
            'Ableitung3werte(i).AddRange(zero_array)
        Next
        zero_array = Nothing

        'Auslesen gewisser GUI Werte zur Performanceverbesserung da
        'Variabelnzugriffe wesentlich schneller sind als GUI Zugriffe
        Halbtonversch = Halbtonverschiebung.Value
        For i = 0 To 34
            Noten_StartW(i) = Noten_Startwert(i).Text * 1000
            Noten_StoppW(i) = Noten_Stoppwert(i).Text * 1000
            Noten_Versch(i) = Noten_Verschiebung(i).Text
        Next

        Control.CheckForIllegalCrossThreadCalls = False

        'Die ersten 14 Messungen(14x65) überspringen, da unsaubere PC-Kommunikation am Anfang
        For i = 1 To 910
            SerialPort1.ReadByte()
        Next

        'Warten auf die richtige Startposition
        SerialPort1_WaitForSync()
        SerialPort1.ReadByte()

        'Definieren der zur Messdatenverarbeitung benutzten Variabeln
        Dim messungen(70) As Byte
        Dim messung As Byte

        Dim ADC_now As Integer
        Dim NotenNr As Integer
        Dim calibration(70) As Integer
        Dim Integralwert(70) As Integer
        Dim Ableitung1(70) As Integer
        Dim Ableitung2(70) As Integer
        'Dim Ableitung3(70) As Integer
        Dim NotenNr_real As Integer
        Dim MidiNoteNrReal As Integer
        Dim second_trigger_count As Integer
        Dim third_trigger_count As Integer
        Dim trigger_value As Integer

        'Deaktivierte Funktion zur Audio-Ausgabe
        'Dim waveForamt As New WaveFormat(6000, 16, 1)
        'For i=0 To 35
        '    bufferedWaveProvider(i) = New BufferedWaveProvider(waveForamt)
        '    player(i) = New WaveOut()
        '    player(i).Init(bufferedWaveProvider(i))
        '    player(i).Play()
        'Next

        'My.Computer.Audio.Play(Audio_stream, AudioPlayMode.Background)

        'Messloop - Ein GoTo-label ist wunderschön schnell!
next_messung:
        Try
            messung = 1 'Setzen der aktuellen Messung auf 1
            NotenNr = 1 'Setzen der aktuellen Notennummer auf 1
            SerialPort1.Read(messungen, 0, 65) 'Lesen eines 65 byte chunks aus dem Serial-Port Buffers
            i = 0 'Reseten der Zählvariabel i
            If (messungen(62) = 128 And messungen(63) > 127) Then
                messungen(62) = messungen(63) - 128
                messungen(63) = messungen(64)
            Else
                Anz_Verbindungsfehler += 1
                Anz_Verbindungsfehler_TextBox.Text = Anz_Verbindungsfehler & " E"
                SerialPort1_WaitForSync()
                SerialPort1.ReadByte()
                messung = 1
                GoTo next_messung
            End If
next_value:
            If (i > 62) Then
                GoTo next_value_exit
            End If

            'Vereinigung des High- und Low-Bytes
            ADC_now = 256 * messungen(i) + messungen(i + 1)

            'Mittelwertsannäherung
            If (ADC_now + calibration(i) > 16383) Then
                calibration(i) -= 1
            Else
                calibration(i) += 1
            End If
            ADC_now += calibration(i) - 16383

            'Reale Note berechnen
            If messung And 1& Then
                NotenNr_real = NotenNr + 15
            Else
                NotenNr_real = NotenNr
                NotenNr += 1
            End If

            'Deaktivierte Audio-Out Funktion
            'Audio_stream.WriteByte(random.Next(0,255))
            'Dim deb as String = Messwerte(NotenNr_real)(Messwerte(NotenNr_real).Count - 2).ToString() + "?=" + ADC_old.ToString()
            'Debug.WriteLine(deb)

            Messwerte(NotenNr_real).Add(ADC_now)

            'Berechnen des Integralwerts
            Integralwert(NotenNr_real) += Math.Abs(ADC_now) - Math.Abs(Messwerte(NotenNr_real)(Messwerte(NotenNr_real).Count - 20))
            Integralwerte(NotenNr_real).Add(Integralwert(NotenNr_real))

            'Berechnen der 1. Ableitung
            Ableitung1(NotenNr_real) = ADC_now - Messwerte(NotenNr_real)(Messwerte(NotenNr_real).Count - 2)
            Ableitung1werte(NotenNr_real).Add(Ableitung1(NotenNr_real))

            'Berechnen der 2. Ableitung
            Ableitung2(NotenNr_real) = Ableitung1werte(NotenNr_real).Last - Ableitung1werte(NotenNr_real)(Ableitung1werte(NotenNr_real).Count - 2)
            Ableitung2werte(NotenNr_real).Add(Ableitung2(NotenNr_real))

            'Deaktivierte Berechnung der 3. Ableitung
            'Ableitung3(NotenNr_real) = Ableitung2werte(NotenNr_real).Last - Ableitung2werte(NotenNr_real)(Ableitung2werte(NotenNr_real).Count - 2)
            'Ableitung3werte(NotenNr_real).Add(Ableitung3(NotenNr_real))

            'Wenn alle 3 Bedingungen erfüllt sind wird ein NotenON-Event ausgelöst
            If Integralwert(NotenNr_real) > Noten_StartW(NotenNr_real) And Note_Play(NotenNr_real) = False Then
                second_trigger_count = 0
                For Each wert In Ableitung2werte(NotenNr_real).Skip(Ableitung2werte(NotenNr_real).Count - 20)
                    If (wert < -7000 Or wert > 7000) Then
                        second_trigger_count += 1
                    End If
                Next

                third_trigger_count = 0
                For Each wert In Messwerte(NotenNr_real).Skip(Messwerte(NotenNr_real).Count - 20)
                    If (wert < -8000 Or wert > 8000) Then
                        third_trigger_count += 1
                    End If
                Next

                trigger_value = 1 + NotenNr_real >> 3
                If (second_trigger_count > trigger_value And third_trigger_count > trigger_value) Then
                    MidiNoteNrReal = MidiNoteNr(NotenNr_real) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(NotenNr_real).Text)
                    'My.Computer.Keyboard.SendKeys("p", True)
                    'MessageBox.Show(wert)
                    Note_Play(NotenNr_real) = True
                    Note_Volume(NotenNr_real) = 100
                    'MessageBox.Show(MidiNoteNr(NotenNr_real) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(NotenNr_real).Text))
                    PlayMIDINote(MidiNoteNrReal + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(NotenNr_real).Text), Note_Volume(NotenNr_real))
                    If MIDI_SpecialMode.Checked = True And Aufnahme_gestartet = True Then Takt_Tick()
                    If SendKeys_ON.Checked = True Then keybd_event(SendKey_key(MidiNoteNrReal), 0, 0, 0)
                End If
            Else
                'Wird der Stoppintegralwert einer Note unterschritten so wird ein Stopp Event ausgelöst. 
                If Integralwert(NotenNr_real) < Noten_StoppW(NotenNr_real) And Note_Play(NotenNr_real) = True Then
                    MidiNoteNrReal = MidiNoteNr(NotenNr_real) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(NotenNr_real).Text)
                    'MessageBox.Show(NotenNr & " off")
                    Note_Play(NotenNr_real) = False
                    STOPMIDINote(MidiNoteNrReal + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(NotenNr_real).Text))
                    If MIDI_SpecialMode.Checked = True And Aufnahme_gestartet = True Then Takt_Tick()
                    If SendKeys_ON.Checked = True Then keybd_event(SendKey_key(MidiNoteNrReal), 0, KEYEVENTF_KEYUP, 0)
                End If
            End If

            ADC(NotenNr_real) = ADC_now
            messarrey(NotenNr_real) = ADC_now

            'Deaktivierte Audio-Out Funktion
            'bufferedWaveProvider(NotenNr_real).AddSamples(BitConverter.GetBytes(ADC_now >> 7), 0, 1)

            messung += 1

            If messung = 32 Then
                messung = 0
                NotenNr = 0
            End If
            i += 2
            GoTo next_value
next_value_exit:

        Catch ex As System.Exception
            Debug.WriteLine(ex)
            Anz_Verbindungsfehler += 1
            Anz_Verbindungsfehler_TextBox.Text = "Error"
            Try
                SerialPort1_WaitForSync()
            Catch
                Anz_Verbindungsfehler_TextBox.Text = "Verbindungsfehler"
            End Try
        End Try

        'Deaktivierte SaveRawDate-File Funktion.
        'file.WriteLine(messarrey(10))

        Anz_Messungen += 1
        'Anz_Messungen_TextBox.Text = Anz_Messungen

        If SerialPort1_Stop = True Then
            SerialPort1_Stop = False
            Exit Sub
        End If

        GoTo next_messung

        'Deaktivierte SaveRawDate-File Funktion.
        'file.Close()

    End Sub


    'Liest so lange aus dem SerialPort1 Buffer bis er ein Synchbyte = 128 mit einem nachfolgendem modifiziertem Highbyte > 127 empfängt.
    'Wird dieses als Lowbyte empfangen werden High- und Lowbyte getauscht
    'Zurückgegeben wird das korrigierte Highbyte (Highbyte - 128)
    'Alle anderen gelesenen Bytes werden verworfen
    Function SerialPort1_WaitForSync()
        Dim high_value
        Dim low_value = SerialPort1.ReadByte
        Do
            high_value = SerialPort1.ReadByte
            If (low_value = 128 And high_value > 127) Then
                high_value -= 128
                Exit Do
            End If
            low_value = SerialPort1.ReadByte
            If (high_value = 128 And low_value > 127) Then
                high_value = low_value - 128
                Exit Do
            End If
        Loop
        Return high_value
    End Function

    'Comport auswählen
    Private Sub ComboBox_Comport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Comport.SelectedIndexChanged
        If ComboBox_Comport.SelectedItem <> "" Then
            Button_Connect.Enabled = True
        End If
    End Sub


    'Im folgenden Programmabschnitt befindet sich die MIDI-File-Save-Funktion
#Region " MIDI "
    'MIDI-Aufnahmestart
    Private Sub MIDI_Start() Handles MIDI_Start_Button.Click
        MIDI_Start_Button.Enabled = False
        MIDI_Pause_Button.Enabled = True
        MIDI_Save_Button.Enabled = True

        TaktNr = 0
        Takt_32stel = 0

        Takt_Ausgabefenster.Text = ("1  1")

        eventCollection.Clear()
        MIDI_TrackNr = 1
        MIDI_Pos = 0

        'Wissensquelle: http://www.deluge.co/?q=midi-tempo-bpm, http://midi.mathewvp.com/aboutMidi.htm
        Dim TimeSign As String = Chr(Takt_Zaehler_Input.Value) & Chr(Takt_Naenner_Input.Value) & Chr(24) & Chr(8)
        eventCollection.AddEvent(New TextEvent(TimeSign, MetaEventType.TimeSignature, 0), MIDI_TrackNr) 'Takt

        'Spurname
        If META_Spurname_Input.Text = "" Then
            eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedItem, MetaEventType.SequenceTrackName, 0), MIDI_TrackNr)
        Else
            eventCollection.AddEvent(New TextEvent(META_Spurname_Input.Text, MetaEventType.SequenceTrackName, 0), MIDI_TrackNr)
        End If

        'Unbenutzte Wissensquelle: http://www.recordingblogs.com/sa/Wiki?topic=MIDI+Key+Signature+meta+message

        'Instrumentenname sowie Track Text
        eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedText, MetaEventType.TrackInstrumentName, 0), MIDI_TrackNr)
        eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedText, MetaEventType.TextEvent, 0), MIDI_TrackNr)

        'Tempo in Anzahl Mikrosekunden pro Viertelnote
        Dim Tempo As String = Chr(&H0F) & Chr(&H42) & Chr(&H40)
        eventCollection.AddEvent(New TextEvent(Tempo, MetaEventType.SetTempo, 0), MIDI_TrackNr)

        'Unbenutzt da automatisch gesetzt
        'eventCollection.AddEvent(new Events.MetaEvent(MetaEventType.EndTrack,0,0), MIDI_TrackNr)

        'Sollte die maximale von MIDI unterstützte Takt/Channel Anzahl von 16 überschritten sein => Abbruch
        'Ansonsten einen neuen Track hinzufügen und ihn mit den benötigten META Daten auffüllen
        If MIDI_TrackNr >= 16 Then Exit Sub
        MIDI_TrackNr += 1
        eventCollection.AddTrack()
        eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedItem, MetaEventType.SequenceTrackName, MIDI_Pos), MIDI_TrackNr)
        eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedText, MetaEventType.TrackInstrumentName, 0), MIDI_TrackNr)
        eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedText, MetaEventType.TextEvent, 0), MIDI_TrackNr)
        eventCollection.AddEvent(New PatchChangeEvent(MIDI_Pos, MIDI_TrackNr, cboInstruments.SelectedIndex), MIDI_TrackNr)

        'Deaktivieren der Takt-Eingabefelder da diese während einer Aufnahme nicht verändert werden sollen
        Takt_Zaehler_Input.Enabled = False
        Takt_Naenner_Input.Enabled = False

        'Takt Timer einschalten falls normaler Aufzeichnungsmodus.
        If MIDI_NormalMode.Checked = True Then Takt.Enabled = True
        Aufnahme_gestartet = True
    End Sub


    'Aufnahmepausenfunktion
    Private Sub MIDI_Pause() Handles MIDI_Pause_Button.Click
        If Aufnahme_gestartet = True Then
            Takt.Enabled = False
            Aufnahme_gestartet = False
            Messung_Pause = True
            MIDI_Pause_Button.Text = "Aufnahme fortsetzen"
        Else
            If MIDI_NormalMode.Checked = True Then Takt.Enabled = True
            Aufnahme_gestartet = True
            Messung_Pause = False
            MIDI_Pause_Button.Text = "Aufnahme pausieren"
        End If
    End Sub


    'Aufnahmespeicherungsfunktion
    Private Sub MIDI_Save() Handles MIDI_Save_Button.Click
        MIDI_Pause_Button.Enabled = False
        MIDI_Save_Button.Enabled = False
        Takt.Enabled = False
        Aufnahme_gestartet = False

        TaktNr = 0
        Takt_32stel = 0

        Takt_Ausgabefenster.Text = ("1  1")

        Dim MIDI_Dateiname As String
        If META_Dateiname_Input.Text = "" Then
            MIDI_Dateiname = "Untitled.mid"
        Else
            MIDI_Dateiname = META_Dateiname_Input.Text & ".mid"
        End If

        Me.SaveMIDIDialog.DefaultExt = "MID"
        Me.SaveMIDIDialog.FileName = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyDocuments, MIDI_Dateiname)
        Me.SaveMIDIDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.SaveMIDIDialog.Filter = "VB MIDI files (*.MID)|*.MID"

        Dim result As DialogResult = Me.SaveMIDIDialog.ShowDialog
        If result = DialogResult.OK Then
            eventCollection.PrepareForExport()
            MidiFile.Export(SaveMIDIDialog.FileName, eventCollection)
            eventCollection.Clear()
        End If

        Takt_Zaehler_Input.Enabled = True
        Takt_Naenner_Input.Enabled = True

        MIDI_Start_Button.Enabled = True
    End Sub

#End Region


    'Speichern der ausgelösten MIDI-Events sowie auslösen des Metronoms falls aktiviert
    Private Sub Takt_Tick() Handles Takt.Tick
        Dim Note_gespielt As Boolean = False

        MIDI_Pos += MIDI_Speed

        For i = 0 To 31 Step 1
            If Note_Play(i) = True Or Button_Note_Play(i) = True Then
                If Notenlaege(i) = 0 Then
                    eventCollection.AddEvent(New NoteEvent(MIDI_Pos, MIDI_TrackNr, MidiCommandCode.NoteOn, MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text), 100), MIDI_TrackNr)
                End If
                Notenlaege(i) += 0.125
                Note_gespielt = True
            Else
                If Notenlaege(i) > 0 Then
                    eventCollection.AddEvent(New NoteEvent(MIDI_Pos, MIDI_TrackNr, MidiCommandCode.NoteOff, MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text), 0), MIDI_TrackNr)
                    Notenlaege(i) = 0
                End If
            End If
        Next

        Takt_32stel = Takt_32stel + 1

        If Takt_32stel = 32 Then
            If Metronom_ON.Checked Then
                SetCurrentInstrument(GeneralMidiInstrument.Woodblock)
                PlayMIDINote(70, 100, 0.1)
                SetCurrentInstrument(cboInstruments.SelectedIndex)
            ElseIf Metronom_Betont.Checked Then
                SetCurrentInstrument(GeneralMidiInstrument.Woodblock)
                PlayMIDINote(72, 120, 0.1)
                SetCurrentInstrument(cboInstruments.SelectedIndex)
            End If
            TaktNr = TaktNr + 1
            Takt_32stel = 0
        End If

        If Not Metronom_alt = Fix(Takt_32stel * Takt_Naenner_Input.Value / 32) Then
            If Metronom_ON.Checked Or Metronom_Betont.Checked Then
                SetCurrentInstrument(GeneralMidiInstrument.Woodblock)
                PlayMIDINote(70, 100, 0.1)
                SetCurrentInstrument(cboInstruments.SelectedIndex)
            End If
        End If

        Metronom_alt = Fix(Takt_32stel * Takt_Naenner_Input.Value / 32)
        Takt_Ausgabefenster.Text = (TaktNr + 1 & "  " & Fix(Takt_32stel * Takt_Naenner_Input.Value / 32) + 1) 'Math.Round

    End Sub

    'Wenn der MIDI-Speed verändert wurde, so wird diese Änderung in einer Variabel gespeichert um durch schnelle Variabelnzugriffe die Performance zu steigern
    Private Sub Speed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Speed.ValueChanged
        MIDI_Speed = Speed.Value
    End Sub


    'Halbton-/Oktavenverschiebung zum Ändern der Gesamttonhöhe
#Region " Halbtonverschiebung "
    Private Sub Oktavenverschiebung_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Oktavenverschiebung.SelectedIndexChanged
        Halbtonverschiebung.Value = 12 * (3 - Oktavenverschiebung.SelectedIndex)
        Halbtonversch = Halbtonverschiebung.Value
        If Halbtonversch < -32 Then MessageBox.Show("Warnung: Durch eine Halbtonverschiebung von <-32 sind die tiefsten Töne einfach alle Note 0 da MIDI  tiefere Töne nicht unterstützt.",
                                                    "Warnung: Zu tiefe Töne möglich", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If Halbtonversch < -32 Then MessageBox.Show("Warnung: Durch eine Halbtonverschiebung von <-32 sind die tiefsten Töne einfach alle Note 0 da MIDI  tiefere Töne nicht unterstützt.",
                                                    "Warnung: Zu tiefe Töne möglich", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
#End Region



    'Aktualisierungsfunktion aller Diagramme
    Private Sub Display_Refresh() Handles Display_Refresh_Timer.Tick
        Try
            'Display_Refresh_Timer.Enabled = False
            'Exit Sub
            Dim LetzteMesswerte As List(Of Integer) = New List(Of Integer)()
            Dim LetzteIntegralwerte As List(Of Integer) = New List(Of Integer)()
            Dim LetzteAbleitung1werte As List(Of Integer) = New List(Of Integer)()
            Dim LetzteAbleitung2werte As List(Of Integer) = New List(Of Integer)()

            Dim Anz_neue_Messungen As Long
            'Dim LetzteAbleitung3werte As List(Of Integer)

            Anz_Messungen_TextBox.Text = Anz_Messungen
            If (Messwerte.Count = 0)
                Exit Sub
            End If

            Anz_neue_Messungen = Anz_Messungen - Anz_Messungen_alt - 1
            'Debug.WriteLine(Anz_neue_Messungen)

            Anz_Messungen_alt = Anz_Messungen

            If Anz_neue_Messungen < 5 Then
                Exit Sub
            End If

            Dim TriggerNr As New List(Of UShort)
            Dim genauzeit As UShort = 0
            Dim integralwert As Long
            'Long und nicht ULong da in ganz speziellen Fällen (ganz oft 0 danach hoher Messwert) negative Zahlen auftreten können
            Dim integralwert_avg As Long

            Messwerte_Chart.ChartAreas(0).AxisY.Minimum = -40000
            Messwerte_Chart.ChartAreas(0).AxisY.Maximum = 40000

            Integral_Chart.ChartAreas(0).AxisY.Minimum = 0
            Integral_Chart.ChartAreas(0).AxisY.Maximum = 400000

            Ableitung2_Chart.ChartAreas(0).AxisY.Minimum = -25000
            Ableitung2_Chart.ChartAreas(0).AxisY.Maximum = 25000

            Dim Cart_Points_Display As UInteger = 100

            For i = 0 To 31 Step 1
                integralwert = 0

                'Entfernen nicht mehr benutzter Listenelemente zur Performanceverbesserung
                If (Messwerte(i).Count - Cart_Points_Display > 0) Then
                    Messwerte(i).RemoveRange(0, Messwerte(i).Count - Cart_Points_Display)
                End If

                If (Integralwerte(i).Count - Cart_Points_Display > 0) Then
                    Integralwerte(i).RemoveRange(0, Integralwerte(i).Count - Cart_Points_Display)
                End If

                If (Ableitung1werte(i).Count - Cart_Points_Display > 0) Then
                    Ableitung1werte(i).RemoveRange(0, Ableitung1werte(i).Count - Cart_Points_Display)
                End If

                If (Ableitung2werte(i).Count - Cart_Points_Display > 0) Then
                    Ableitung2werte(i).RemoveRange(0, Ableitung2werte(i).Count - Cart_Points_Display)
                End If

                LetzteMesswerte.Clear()
                LetzteIntegralwerte.Clear()
                LetzteAbleitung1werte.Clear()
                LetzteAbleitung2werte.Clear()
                LetzteMesswerte.AddRange(Messwerte(i).ToArray())
                LetzteIntegralwerte.AddRange(Integralwerte(i).ToArray())
                LetzteAbleitung1werte.AddRange(Ableitung1werte(i).ToArray())
                LetzteAbleitung2werte.AddRange(Ableitung2werte(i).ToArray())

                For Each wert As Long In LetzteMesswerte
                    Messwerte_Chart.Series(i).Points.Add(wert)
                    If Messwerte_Chart.Series(i).Points.Count > Cart_Points_Display Then
                        Messwerte_Chart.Series(i).Points.RemoveAt(0)
                    End If
                Next

                For Each wert As Long In LetzteIntegralwerte
                    integralwert_avg += wert
                    Integral_Chart.Series(i).Points.Add(wert)
                    If Integral_Chart.Series(i).Points.Count > Cart_Points_Display Then
                        Integral_Chart.Series(i).Points.RemoveAt(0)
                    End If
                Next
                integralwert_avg /= LetzteIntegralwerte.Count * 500

                For Each wert As Long In LetzteAbleitung2werte
                    Ableitung2_Chart.Series(i).Points.Add(wert)
                    If Ableitung2_Chart.Series(i).Points.Count > Cart_Points_Display Then
                        Ableitung2_Chart.Series(i).Points.RemoveAt(0)
                    End If
                Next

                If (integralwert_avg > 255) Then
                    integralwert_avg = 255
                End If

                'If (integralwert_avg < 0) Then
                '    integralwert_avg = 0
                'End If

                Noten_VerticalProgessBar(i).Value = integralwert_avg
                Noten_Wert(i).Text = integralwert_avg
                LetzteMesswerte.Clear()
            Next

            'Alle auftretende Fehler werden aus stabilitätstechnischen Gründen ignoriert 
        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try
    End Sub


    'Ermitteln des Maximas eines Zahlenarrays
    Public Function MaxValOfIntArray(ByRef TheArray As Array) As Integer
        Dim i As Integer
        Dim MaxIntegersIndex As Integer
        MaxIntegersIndex = 0

        For i = 1 To UBound(TheArray)
            If TheArray(i) > TheArray(MaxIntegersIndex) Then
                MaxIntegersIndex = i
            End If
        Next

        MaxValOfIntArray = TheArray(MaxIntegersIndex)
    End Function


    'Folgender Programmteil dient zur MIDI-Out-live-Wiedergabe
#Region " Sanford.Multimedia.Midi "
    Private outDevice As OutputDevice
    Private outDeviceID As Integer = 0
    'Private outDialog As New OutputDeviceDialog()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillInstrumentCombo()
        If OutputDevice.DeviceCount = 0 Then
            MIDI_Out_Connected = False
            MIDI_Out_Connect_Button.Text = "MIDI-Out Verbinden"
            'MessageBox.Show("Error: Kein MIDI-Out Gerät verfügbar.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            For i As Integer = 0 To OutputDevice.DeviceCount - 1
                MIDI_Out_ComboBox.Items.Add(OutputDevice.GetDeviceCapabilities(i).name)
            Next
            MIDI_Out_ComboBox.SelectedIndex = outDeviceID
            Try
                outDevice = New OutputDevice(outDeviceID)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End Try

            MIDI_Out_Connect_Button.Text = "MIDI-Out Trennen"
            MIDI_Out_Connected = True

            hsbVolume_ValueChanged()
            hsbPan_ValueChanged()
            hsbModWheel_ValueChanged()
        End If
    End Sub

    'Auffüllen der cboInstruments-Listen mit allen MIDI-Instrumenten
    Private Sub FillInstrumentCombo()
        Dim items() As String = [Enum].GetNames(GetType(GeneralMidiInstrument))
        For Each item In items
            cboInstruments.Items.Add(item)
            MIDI_cboInstruments.Items.Add(item)
        Next
        cboInstruments.SelectedIndex = 0
        MIDI_cboInstruments.SelectedIndex = 0
    End Sub

    'Wechseln des MIDI-Instrumentes
    Private Sub cboInstruments_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInstruments.SelectedIndexChanged
        SetCurrentInstrument(cboInstruments.SelectedIndex)
        MIDI_cboInstruments.SelectedIndex = cboInstruments.SelectedIndex
        If Aufnahme_gestartet = True Or Messung_Pause = True Then

            Dim pos As Integer = MIDI_Tracklist.IndexOf(cboInstruments.SelectedIndex)
            If pos = -1 Then
                If MIDI_TrackNr >= 16 Then Exit Sub
                MIDI_Tracklist.Add(cboInstruments.SelectedIndex)
                MIDI_TrackNr = MIDI_Tracklist.Count '=> MIDI_TrackNr+=1
                eventCollection.AddTrack()
                eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedItem, MetaEventType.SequenceTrackName, MIDI_Pos), MIDI_TrackNr)
                eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedText, MetaEventType.TrackInstrumentName, 0), MIDI_TrackNr)
                eventCollection.AddEvent(New TextEvent(cboInstruments.SelectedText, MetaEventType.TextEvent, 0), MIDI_TrackNr)
                eventCollection.AddEvent(New PatchChangeEvent(MIDI_Pos, MIDI_TrackNr, cboInstruments.SelectedIndex), MIDI_TrackNr)
            Else
                MIDI_TrackNr = pos + 1
            End If

        End If
    End Sub

    'Synchronisieren des MIDI-Outs mit dem Aufnahmeinstrument
    Private Sub MIDI_cboInstruments_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MIDI_cboInstruments.SelectedIndexChanged
        cboInstruments.SelectedIndex = MIDI_cboInstruments.SelectedIndex
    End Sub

    'Wechseln des Midi-Ausgangs
    Private Sub MIDI_Out_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MIDI_Out_ComboBox.SelectedIndexChanged
        MIDI_Out_Connected = False
        MIDI_Out_Connect_Button.Text = "MIDI-Out Verbinden"
        Try
            If outDevice IsNot Nothing Then
                outDevice.Dispose()
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Verbinden des ausgewählten MIDI-Out-Ausganges
    Private Sub MIDI_Out_Connect_Button_Click(sender As Object, e As EventArgs) Handles MIDI_Out_Connect_Button.Click
        If MIDI_Out_Connected = True
            MIDI_Out_ComboBox_SelectedIndexChanged(Nothing, Nothing)
            Exit Sub
        End If

        Try
            outDevice = New OutputDevice(MIDI_Out_ComboBox.SelectedIndex)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try

        MIDI_Out_Connect_Button.Text = "MIDI-Out Trennen"
        MIDI_Out_Connected = True

        hsbVolume_ValueChanged()
        hsbPan_ValueChanged()
        hsbModWheel_ValueChanged()
        SetCurrentInstrument(cboInstruments.SelectedIndex)
    End Sub

    'Beim Beenden des Programmes den MIDI-Port wieder freigeben
    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Closed
        If outDevice IsNot Nothing Then
            outDevice.Dispose()
        End If
        'outDialog.Dispose()
    End Sub

    'MIDI-Ausgabefunktion
    Private Sub PlayMIDINote(ByVal Note As Integer, ByVal Velocity As Integer)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        If Latenz_NumericUpDown.Value = 0 Then
            outDevice.Send(New ChannelMessage(ChannelCommand.NoteOn, 0, Note, Velocity))
        Else
            PlayMIDINote_Async(Note, Velocity, Latenz_NumericUpDown.Value)
        End If
    End Sub

    'MIDI-Ausgabefunktion mit vordefinierter Notendauer
    Private Sub PlayMIDINote(ByVal Note As Integer, ByVal Velocity As Integer, ByVal Duration As Double)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        If Latenz_NumericUpDown.Value = 0 Then
            outDevice.Send(New ChannelMessage(ChannelCommand.NoteOn, 0, Note, Velocity))
            STOPMIDINote_Async(Note, Duration * 1000)
        Else
            PlayMIDINote_Async(Note, Velocity, Latenz_NumericUpDown.Value)
            STOPMIDINote_Async(Note, (Duration * 1000) + Latenz_NumericUpDown.Value)
        End If
    End Sub

    'Task zur verzögerten MIDI-Ausgabe
    Private Async Function PlayMIDINote_Async(ByVal Note As Integer, ByVal Velocity As Integer, ByVal ms As Integer) As Task
        Await Task.Delay(ms)
        outDevice.Send(New ChannelMessage(ChannelCommand.NoteOn, 0, Note, Velocity))
    End Function

    'Stoppen einer gespielten Note
    Private Sub STOPMIDINote(ByVal Note As Integer)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        If Latenz_NumericUpDown.Value = 0 Then
            outDevice.Send(New ChannelMessage(ChannelCommand.NoteOff, 0, Note))
        Else
            STOPMIDINote_Async(Note, Latenz_NumericUpDown.Value)
        End If
    End Sub

    'Task für verzögertes Stoppen einer Note
    Private Async Function STOPMIDINote_Async(ByVal Note As Integer, ByVal ms As Integer) As Task
        Await Task.Delay(ms)
        outDevice.Send(New ChannelMessage(ChannelCommand.NoteOff, 0, Note))
    End Function

    'Funktion zum Stoppen aller Noten
    Private Sub STOPAllMIDINotes()
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        outDevice.Send(New ChannelMessage(ChannelCommand.Controller, 0, 123))
    End Sub

    'Setzen des aktuellen MIDI-Instruments
    Private Sub SetCurrentInstrument(ByVal InstrumentNr As Integer)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        outDevice.Send(New ChannelMessage(ChannelCommand.ProgramChange, 0, InstrumentNr))
    End Sub

    'Setzen der MIDI-Lautstärke
    Private Sub SetVolume(Volume As Integer)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        outDevice.Send(New ChannelMessage(ChannelCommand.Controller, 0, 7, Volume))
    End Sub

    'Setzen der MIDI-Balance
    Private Sub SetPan(ByVal Balance As Integer)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        outDevice.Send(New ChannelMessage(ChannelCommand.Controller, 0, 8, Balance))
    End Sub

    'Stärkebestimmung des MIDI-ModWheeleffekts
    Private Sub SetModWheel(ByVal ModWheelValue As Integer)
        If MIDI_Out_Connected = False Then Exit Sub
        If outDevice Is Nothing Then Exit Sub
        outDevice.Send(New ChannelMessage(ChannelCommand.Controller, 0, 1, ModWheelValue))
    End Sub

#Region " Volume Control "
    Private Sub hsbVolume_ValueChanged() Handles hsbVolume.ValueChanged
        SetVolume(hsbVolume.Value)
    End Sub
#End Region

#Region " Pan Control "
    Private Sub hsbPan_ValueChanged() Handles hsbPan.ValueChanged
        SetPan(hsbPan.Value)
    End Sub
#End Region

#Region " ModWheel Control "
    Private Sub hsbModWheel_ValueChanged() Handles hsbModWheel.ValueChanged
        SetModWheel(hsbModWheel.Value)
    End Sub
#End Region

#End Region



#Region " Button Note "

#Region "   Buttons Events "

    'Maus- und Tastatursteuerbefehle für das virtuelle Piano
    Private Sub Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        C2_Button.MouseDown, D2_Button.MouseDown, E2_Button.MouseDown, F2_Button.MouseDown, G2_Button.MouseDown, A2_Button.MouseDown, H2_Button.MouseDown,
        C3_Button.MouseDown, D3_Button.MouseDown, E3_Button.MouseDown, F3_Button.MouseDown, G3_Button.MouseDown, A3_Button.MouseDown, H3_Button.MouseDown,
        C4_Button.MouseDown, D4_Button.MouseDown, E4_Button.MouseDown, F4_Button.MouseDown, G4_Button.MouseDown, A4_Button.MouseDown, H4_Button.MouseDown,
        C5_Button.MouseDown, D5_Button.MouseDown, E5_Button.MouseDown, F5_Button.MouseDown, G5_Button.MouseDown, A5_Button.MouseDown, H5_Button.MouseDown,
        C6_Button.MouseDown, D6_Button.MouseDown, E6_Button.MouseDown, F6_Button.MouseDown, G6_Button.MouseDown, A1_Button.MouseDown, H1_Button.MouseDown,
        C2_Button.KeyDown, D2_Button.KeyDown, E2_Button.KeyDown, F2_Button.KeyDown, G2_Button.KeyDown, A2_Button.KeyDown, H2_Button.KeyDown,
        C3_Button.KeyDown, D3_Button.KeyDown, E3_Button.KeyDown, F3_Button.KeyDown, G3_Button.KeyDown, A3_Button.KeyDown, H3_Button.KeyDown,
        C4_Button.KeyDown, D4_Button.KeyDown, E4_Button.KeyDown, F4_Button.KeyDown, G4_Button.KeyDown, A4_Button.KeyDown, H4_Button.KeyDown,
        C5_Button.KeyDown, D5_Button.KeyDown, E5_Button.KeyDown, F5_Button.KeyDown, G5_Button.KeyDown, A5_Button.KeyDown, H5_Button.KeyDown,
        C6_Button.KeyDown, D6_Button.KeyDown, E6_Button.KeyDown, F6_Button.KeyDown, G6_Button.KeyDown, A1_Button.KeyDown, H1_Button.KeyDown
        Button_Note(sender.Tag)
    End Sub

    Private Sub Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        C2_Button.MouseUp, D2_Button.MouseUp, E2_Button.MouseUp, F2_Button.MouseUp, G2_Button.MouseUp, A2_Button.MouseUp, H2_Button.MouseUp,
        C3_Button.MouseUp, D3_Button.MouseUp, E3_Button.MouseUp, F3_Button.MouseUp, G3_Button.MouseUp, A3_Button.MouseUp, H3_Button.MouseUp,
        C4_Button.MouseUp, D4_Button.MouseUp, E4_Button.MouseUp, F4_Button.MouseUp, G4_Button.MouseUp, A4_Button.MouseUp, H4_Button.MouseUp,
        C5_Button.MouseUp, D5_Button.MouseUp, E5_Button.MouseUp, F5_Button.MouseUp, G5_Button.MouseUp, A5_Button.MouseUp, H5_Button.MouseUp,
        C6_Button.MouseUp, D6_Button.MouseUp, E6_Button.MouseUp, F6_Button.MouseUp, G6_Button.MouseUp, A1_Button.MouseUp, H1_Button.MouseUp,
        C2_Button.KeyUp, D2_Button.KeyUp, E2_Button.KeyUp, F2_Button.KeyUp, G2_Button.KeyUp, A2_Button.KeyUp, H2_Button.KeyUp,
        C3_Button.KeyUp, D3_Button.KeyUp, E3_Button.KeyUp, F3_Button.KeyUp, G3_Button.KeyUp, A3_Button.KeyUp, H3_Button.KeyUp,
        C4_Button.KeyUp, D4_Button.KeyUp, E4_Button.KeyUp, F4_Button.KeyUp, G4_Button.KeyUp, A4_Button.KeyUp, H4_Button.KeyUp,
        C5_Button.KeyUp, D5_Button.KeyUp, E5_Button.KeyUp, F5_Button.KeyUp, G5_Button.KeyUp, A5_Button.KeyUp, H5_Button.KeyUp,
        C6_Button.KeyUp, D6_Button.KeyUp, E6_Button.KeyUp, F6_Button.KeyUp, G6_Button.KeyUp, A1_Button.KeyUp, H1_Button.KeyUp
        Button_Stop_Note(sender.Tag)
    End Sub

#End Region

    'Auslösen der Tastenevents des virtuellen Pianos
    Private Sub Button_Note(ByVal TastenNr As Byte)
        Dim NotenNr As Integer
        NotenNr = MidiNoteNr(TastenNr) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(TastenNr).Text)
        If Button_Note_Play(TastenNr) = True Then Exit Sub
        If NotenNr < 0 Then NotenNr = 0
        If NotenNr > 127 Then NotenNr = 127
        PlayMIDINote(NotenNr, 100)
        Button_Note_Play(TastenNr) = True
        If MIDI_SpecialMode.Checked = True Then Takt_Tick()
    End Sub

    'Stoppen der Tastenevents des virtuellen Pianos
    Private Sub Button_Stop_Note(ByVal TastenNr As Byte)
        Dim NotenNr As Integer

        NotenNr = MidiNoteNr(TastenNr) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(TastenNr).Text)
        If NotenNr < 0 Then NotenNr = 0
        If NotenNr > 127 Then NotenNr = 127
        STOPMIDINote(NotenNr)
        Button_Note_Play(TastenNr) = False
        If MIDI_SpecialMode.Checked = True Then Takt_Tick()
    End Sub

#End Region


#Region " Grenzwerte "

    'Events zur Festlegung der oberen und unteren Grenzwerte für die Harfensaitenerkennung 
    Private Sub Grenzwerte_KeyPress(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        C2_Startwert.KeyPress, D2_Startwert.KeyPress, E2_Startwert.KeyPress, F2_Startwert.KeyPress, G2_Startwert.KeyPress, A2_Startwert.KeyPress, H2_Startwert.KeyPress,
        C3_Startwert.KeyPress, D3_Startwert.KeyPress, E3_Startwert.KeyPress, F3_Startwert.KeyPress, G3_Startwert.KeyPress, A3_Startwert.KeyPress, H3_Startwert.KeyPress,
        C4_Startwert.KeyPress, D4_Startwert.KeyPress, E4_Startwert.KeyPress, F4_Startwert.KeyPress, G4_Startwert.KeyPress, A4_Startwert.KeyPress, H4_Startwert.KeyPress,
        C5_Startwert.KeyPress, D5_Startwert.KeyPress, E5_Startwert.KeyPress, F5_Startwert.KeyPress, G5_Startwert.KeyPress, A5_Startwert.KeyPress, H5_Startwert.KeyPress,
        C6_Startwert.KeyPress, D6_Startwert.KeyPress, E6_Startwert.KeyPress, F6_Startwert.KeyPress, G6_Startwert.KeyPress, A1_Startwert.KeyPress, H1_Startwert.KeyPress,
        C2_Stoppwert.KeyPress, D2_Stoppwert.KeyPress, E2_Stoppwert.KeyPress, F2_Stoppwert.KeyPress, G2_Stoppwert.KeyPress, A2_Stoppwert.KeyPress, H2_Stoppwert.KeyPress,
        C3_Stoppwert.KeyPress, D3_Stoppwert.KeyPress, E3_Stoppwert.KeyPress, F3_Stoppwert.KeyPress, G3_Stoppwert.KeyPress, A3_Stoppwert.KeyPress, H3_Stoppwert.KeyPress,
        C4_Stoppwert.KeyPress, D4_Stoppwert.KeyPress, E4_Stoppwert.KeyPress, F4_Stoppwert.KeyPress, G4_Stoppwert.KeyPress, A4_Stoppwert.KeyPress, H4_Stoppwert.KeyPress,
        C5_Stoppwert.KeyPress, D5_Stoppwert.KeyPress, E5_Stoppwert.KeyPress, F5_Stoppwert.KeyPress, G5_Stoppwert.KeyPress, A5_Stoppwert.KeyPress, H5_Stoppwert.KeyPress,
        C6_Stoppwert.KeyPress, D6_Stoppwert.KeyPress, E6_Stoppwert.KeyPress, F6_Stoppwert.KeyPress, G6_Stoppwert.KeyPress, A1_Stoppwert.KeyPress, H1_Stoppwert.KeyPress

        'Filtern der für die Grenzwertsetzung erlaubten Eingabezeichen 
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8 ', 45=Minus ', 46=Punkt (Hier als Komma)
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub

    'Events zur Festlegung der Werte der Halbtonverschiebung
    Private Sub Verschiebung_KeyPress(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
    C2_Verschiebung.KeyPress, D2_Verschiebung.KeyPress, E2_Verschiebung.KeyPress, F2_Verschiebung.KeyPress, G2_Verschiebung.KeyPress, A2_Verschiebung.KeyPress, H2_Verschiebung.KeyPress,
    C3_Verschiebung.KeyPress, D3_Verschiebung.KeyPress, E3_Verschiebung.KeyPress, F3_Verschiebung.KeyPress, G3_Verschiebung.KeyPress, A3_Verschiebung.KeyPress, H3_Verschiebung.KeyPress,
    C4_Verschiebung.KeyPress, D4_Verschiebung.KeyPress, E4_Verschiebung.KeyPress, F4_Verschiebung.KeyPress, G4_Verschiebung.KeyPress, A4_Verschiebung.KeyPress, H4_Verschiebung.KeyPress,
    C5_Verschiebung.KeyPress, D5_Verschiebung.KeyPress, E5_Verschiebung.KeyPress, F5_Verschiebung.KeyPress, G5_Verschiebung.KeyPress, A5_Verschiebung.KeyPress, H5_Verschiebung.KeyPress,
    C6_Verschiebung.KeyPress, D6_Verschiebung.KeyPress, E6_Verschiebung.KeyPress, F6_Verschiebung.KeyPress, G6_Verschiebung.KeyPress, A1_Verschiebung.KeyPress, H1_Verschiebung.KeyPress

        'Filtern der für die Halbtonverschiebung erlaubten Eingabezeichen
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 45 ', 46=Punkt (Hier als Komma)
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub

    'Events zur Speicherung der Start- und Stoppwerte
    Private Sub Grenzwerte_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles _
        C2_Startwert.LostFocus, D2_Startwert.LostFocus, E2_Startwert.LostFocus, F2_Startwert.LostFocus, G2_Startwert.LostFocus, A2_Startwert.LostFocus, H2_Startwert.LostFocus,
        C3_Startwert.LostFocus, D3_Startwert.LostFocus, E3_Startwert.LostFocus, F3_Startwert.LostFocus, G3_Startwert.LostFocus, A3_Startwert.LostFocus, H3_Startwert.LostFocus,
        C4_Startwert.LostFocus, D4_Startwert.LostFocus, E4_Startwert.LostFocus, F4_Startwert.LostFocus, G4_Startwert.LostFocus, A4_Startwert.LostFocus, H4_Startwert.LostFocus,
        C5_Startwert.LostFocus, D5_Startwert.LostFocus, E5_Startwert.LostFocus, F5_Startwert.LostFocus, G5_Startwert.LostFocus, A5_Startwert.LostFocus, H5_Startwert.LostFocus,
        C6_Startwert.LostFocus, D6_Startwert.LostFocus, E6_Startwert.LostFocus, F6_Startwert.LostFocus, G6_Startwert.LostFocus, A1_Startwert.LostFocus, H1_Startwert.LostFocus,
        C2_Stoppwert.LostFocus, D2_Stoppwert.LostFocus, E2_Stoppwert.LostFocus, F2_Stoppwert.LostFocus, G2_Stoppwert.LostFocus, A2_Stoppwert.LostFocus, H2_Stoppwert.LostFocus,
        C3_Stoppwert.LostFocus, D3_Stoppwert.LostFocus, E3_Stoppwert.LostFocus, F3_Stoppwert.LostFocus, G3_Stoppwert.LostFocus, A3_Stoppwert.LostFocus, H3_Stoppwert.LostFocus,
        C4_Stoppwert.LostFocus, D4_Stoppwert.LostFocus, E4_Stoppwert.LostFocus, F4_Stoppwert.LostFocus, G4_Stoppwert.LostFocus, A4_Stoppwert.LostFocus, H4_Stoppwert.LostFocus,
        C5_Stoppwert.LostFocus, D5_Stoppwert.LostFocus, E5_Stoppwert.LostFocus, F5_Stoppwert.LostFocus, G5_Stoppwert.LostFocus, A5_Stoppwert.LostFocus, H5_Stoppwert.LostFocus,
        C6_Stoppwert.LostFocus, D6_Stoppwert.LostFocus, E6_Stoppwert.LostFocus, F6_Stoppwert.LostFocus, G6_Stoppwert.LostFocus, A1_Stoppwert.LostFocus, H1_Stoppwert.LostFocus

        'Verifizierung der Eingabewerte
        If sender.Text = "" Then sender.Text = 0
        If sender.Text > 255 Then sender.Text = 255

        For i = 0 To 34
            Try
                Noten_StartW(i) = Noten_Startwert(i).Text * 1000
            Catch ex As Exception
                Noten_StartW(i) = 0
                MessageBox.Show("Error: " & ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Try
                Noten_StoppW(i) = Noten_Stoppwert(i).Text * 1000
            Catch ex As Exception
                Noten_StoppW(i) = 0
                MessageBox.Show("Error: " & ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        'MessageBox.Show(sender.Text)
    End Sub

    'Events zur Speicherung der Werte der Halbtonverschiebung
    Private Sub Verschiebung_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles _
    C2_Verschiebung.LostFocus, D2_Verschiebung.LostFocus, E2_Verschiebung.LostFocus, F2_Verschiebung.LostFocus, G2_Verschiebung.LostFocus, A2_Verschiebung.LostFocus, H2_Verschiebung.LostFocus,
    C3_Verschiebung.LostFocus, D3_Verschiebung.LostFocus, E3_Verschiebung.LostFocus, F3_Verschiebung.LostFocus, G3_Verschiebung.LostFocus, A3_Verschiebung.LostFocus, H3_Verschiebung.LostFocus,
    C4_Verschiebung.LostFocus, D4_Verschiebung.LostFocus, E4_Verschiebung.LostFocus, F4_Verschiebung.LostFocus, G4_Verschiebung.LostFocus, A4_Verschiebung.LostFocus, H4_Verschiebung.LostFocus,
    C5_Verschiebung.LostFocus, D5_Verschiebung.LostFocus, E5_Verschiebung.LostFocus, F5_Verschiebung.LostFocus, G5_Verschiebung.LostFocus, A5_Verschiebung.LostFocus, H5_Verschiebung.LostFocus,
    C6_Verschiebung.LostFocus, D6_Verschiebung.LostFocus, E6_Verschiebung.LostFocus, F6_Verschiebung.LostFocus, G6_Verschiebung.LostFocus, A1_Verschiebung.LostFocus, H1_Verschiebung.LostFocus

        'Verifizierung der Eingabewerte
        If sender.Text = "" Then sender.Text = 0
        If sender.Text > 127 Then sender.Text = 127
        If sender.Text < -127 Then sender.Text = -127

        For i = 0 To 34
            Noten_Versch(i) = Noten_Verschiebung(i).Text
        Next
        'MessageBox.Show(sender.Text)
    End Sub


#End Region

    'Funktion zum Aktivieren/Deaktivieren des speziellen MIDI-Aufnahmemodus
#Region " Special MIDI-Mode"

    Private Sub MIDI_SpecialMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_SpecialMode.CheckedChanged

        If MIDI_SpecialMode.Checked = True Then
            'Takt_Zaehler_Temp = Takt_Zaehler_Input.Value
            'Takt_Naenner_Temp = Takt_Naenner_Input.Value
            Takt_Zaehler_Input.Value = 4
            Takt_Naenner_Input.Value = 4
            Speed.Visible = False
            Speed_Label.Text = "Aufnahme Speed:     Dynamisch"
            Takt.Enabled = False
            Tempo_GroupBox.Enabled = False
        Else
            Tempo_GroupBox.Enabled = True
            'Takt_Zaehler_Input.Value = Takt_Zaehler_Temp
            'Takt_Naenner_Input.Value = Takt_Naenner_Temp
            Speed.Visible = True
            Speed_Label.Text = "Aufnahme Speed:"
            If Aufnahme_gestartet = True Then
                Takt.Enabled = True
            End If
        End If

    End Sub

#End Region

    'Funktion zur Ein/Ausschaltung der ToolTip Hilfe
    Private Sub ToolTip_ON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolTip_ON.CheckedChanged, MyBase.Load
        If ToolTip_ON.Checked = True Then
            ToolTip1.Active = True
        Else
            ToolTip1.Active = False
        End If
    End Sub


    'Funktionen zur virtuellen Harfenklappeneinstellung
#Region "Klappen"

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

        A1_Verschiebung.Text += A1_Klappe_Differenz
        A2_Verschiebung.Text += A1_Klappe_Differenz
        A3_Verschiebung.Text += A1_Klappe_Differenz
        A4_Verschiebung.Text += A1_Klappe_Differenz
        A5_Verschiebung.Text += A1_Klappe_Differenz

        A1_Klappe_alt = A1_Klappe.Value
    End Sub

    Private Sub H_Klappe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H1_Klappe.ValueChanged
        Dim H1_Klappe_Differenz As SByte = H1_Klappe.Value - H1_Klappe_alt
        H1_Klappe_Text.Text = Notennamen(H1_Klappe.Value + 1, 6)

        H1_Verschiebung.Text += H1_Klappe_Differenz
        H2_Verschiebung.Text += H1_Klappe_Differenz
        H3_Verschiebung.Text += H1_Klappe_Differenz
        H4_Verschiebung.Text += H1_Klappe_Differenz
        H5_Verschiebung.Text += H1_Klappe_Differenz

        H1_Klappe_alt = H1_Klappe.Value
    End Sub

#End Region



    'In der folgenden Funktion werden die Tastenkombinationen ermittelt und deren Funktion ausgeführt.
#Region "Tastenkombinationen"

    Private Sub KeyState_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetAsyncKeyState_Timer.Tick

        If Costom_Tastenkombinationen_Counter = 0 Then
            If Tastenkonbination_Press(Start_Tastenkombination_Key) = True Then
                Costom_Tastenkombinationen_Counter = 20
                If Aufnahme_gestartet = True Or Messung_Pause = True Then
                    MIDI_Save()
                    Exit Sub
                Else
                    MIDI_Start()
                    Exit Sub
                End If
            End If

            If Tastenkonbination_Press(Pause_Tastenkombination_Key) = True Then
                Costom_Tastenkombinationen_Counter = 20
                MIDI_Pause()
            End If

            If Tastenkonbination_Press(Save_Tastenkombination_Key) = True Then
                Costom_Tastenkombinationen_Counter = 20
                If Aufnahme_gestartet = True Or Messung_Pause = True Then
                    MIDI_Save()
                    Exit Sub
                Else
                    MIDI_Start()
                    Exit Sub
                End If
            End If
        Else
            Costom_Tastenkombinationen_Counter -= 1
        End If

        Select Case -32767
            Case GetAsyncKeyState(107)  'Plus (Nomblock)
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
            MIDI_Out_Connect_Button_Click(Nothing, Nothing)
        ElseIf GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(84) = -32767 Then 'Ctrl + Shift + T
            ToolTip_YesNo_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If


        Select Case -32767
            Case GetAsyncKeyState(38)  'Pfeiltaste hoch
                Tastenkonbination_Klappenverschiebung = 1
            Case GetAsyncKeyState(40)  'Pfeiltaste runter
                Tastenkonbination_Klappenverschiebung = -1
            Case GetAsyncKeyState(107)  'Plus (Nomblock)
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
        If Tastenkombination.Count = 0 Then Return False

        'Kein Plan, wieso die For schleife umgekehrt werden muss!
        'Ansonsten sind alle Tastenkombinationen spiegelverkehrt!
        For i = Tastenkombination.Count - 1 To 0 Step -1
            If Not GetAsyncKeyState(Tastenkombination(i)) <= -32767 Then Return False
        Next

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

                    Case 32 :
                        If Tastenkombination_Alt = "- Nicht belegt -" Then
                            .Text += "Leert."
                        Else
                            .Text = "- Nicht belegt -"
                        End If

                    Case Else : .Text += e.KeyCode.ToString
                End Select
            End With

            'META_Bemerkung_Input.Text = e.KeyCode
            Tastenkombination_Key.Add(e.KeyCode)

        End If

        Tastenkombination_KeyAlt = e.KeyCode
    End Sub


    'Es wurde hier absichtlich den Buttontext verwendet
    Private Sub Start_Tastenkombination_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Tastenkombination.LostFocus
        If Start_Tastenkombination.Text = "- Nicht belegt -" Then
            Start_Tastenkombination_Key.Clear()
        Else
            If Start_Tastenkombination.Text = Pause_Tastenkombination.Text Then
                MessageBox.Show("Die Startkonbination darf nicht der Pausenkonbination entsprechen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Start_Tastenkombination.Text = Tastenkombination_Alt
            Else
                Start_Tastenkombination_Key.Clear()
                For Each item As Byte In Tastenkombination_Key
                    Start_Tastenkombination_Key.Add(item)
                    'MessageBox.Show(item)
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
                MessageBox.Show("Die Pausenkonbination darf nicht der Strat und/oder der Save Kombination entsprechen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Pause_Tastenkombination.Text = Tastenkombination_Alt
            Else
                Pause_Tastenkombination_Key.Clear()
                For Each item As Byte In Tastenkombination_Key
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
                For Each item As Byte In Tastenkombination_Key
                    Save_Tastenkombination_Key.Add(item)
                Next
            End If
        End If
        GetAsyncKeyState_Timer.Enabled = True
    End Sub

#End Region



    'Funktion zum Senden der MIDI-Noten als Tastatur-Event
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


    'Wechseln der Send-Key-Funktion auf die vorhergehende Oktave
    Private Sub SendKey_OM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendKey_OM.Click
        If SendKey_Oktave > 0 Then
            SendKey_Oktave -= 1
            SendKey_Butons_refresh()
            SendKey_GroupBox.Text = "SendKey to Virtual MIDI Piano Okt " & SendKey_Oktave - 2
        End If
    End Sub

    'Wechseln der Send-Key-Funktion auf die nächste Oktave
    Private Sub SendKey_OP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendKey_OP.Click
        If SendKey_Oktave < 10 Then
            SendKey_Oktave += 1
            SendKey_Butons_refresh()
            SendKey_GroupBox.Text = "SendKey to Virtual MIDI Piano Okt " & SendKey_Oktave - 2
        End If
    End Sub

    'Laden der Send-Key-Einstellungen der zu einstellenden Oktave
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


    'Funktion zur Konvertierung der Tastaturcodes zu verständlichen Tastennamen
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

                'Case 48 To 90 : Return Chr(KeyCode).ToString 'Normalzeichen
                'Case 48 To 90 : Return Chr(KeyCode).ToString 'Sonderzeichen

            Case Else : Return kc.ConvertToString(KeyCode)
        End Select
    End Function

#End Region



    'Funktion zur Onlineaktivierung meines Programmes
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
        'Return (C = T) 'Kommentarzeichen entfernen um Onlineaktivierung zu aktivieren!
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


    'Wissensquelle: http://www.vbarchiv.net/workshop/workshop_119-einfacher-kopierschutz-mit-online-aktivierung.html
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
                    'Beispielslizenzkey: PLMMD-YNOJG-EBJET-MEBXU-YLEJX

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


    'Funktion zur Benachrichtigung aller Benutzer meines Programms
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

    'Funktion zum Laden aller wichtigen GUI-Einstellungen
    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown 'Wichtig: MyBase.Load geht nicht, da zu früh!
        With My.Settings
            ' Aufnahmemodus
            MIDI_NormalMode.Checked = .MIDI_NormalMode
            'Absichtlicher Overflow
            'Alternative: SpecialMode statt NormalMode speichern!
            'MIDI_SpecialMode.Checked = .MIDI_NormalMode + 1
            cboInstruments.SelectedIndex = .cboInstruments

            ' Lautstärke
            Volume_Steps_NumericUpDown.Value = .Volume_Steps_Save
            Volume_min_NumericUpDown.Value = .Volume_min_Save
            Volume_max_NumericUpDown.Value = .Volume_max_Save

            ' Tempo
            Takt_Zaehler_Input.Value = .Takt_Zaehler_Input
            Takt_Naenner_Input.Value = .Takt_Naenner_Input
            Speed.Value = .Speed

            ' Tonhöhenverschiebung
            Halbtonverschiebung.Value = .Halbtonverschiebung

            ' META
            META_Dateiname_Input.Text = .META_Dateiname_Input
            META_Autor_Input.Text = .META_Autor_Input
            META_Spurname_Input.Text = .META_Spurname_Input
            META_Copyright_Input.Text = .META_Copyright_Input
            META_Bemerkung_Input.Text = .META_Bemerkung_Input

            ' Metronom
            Metronom_Betont.Checked = .Metronom_Betont
            Metronom_ON.Checked = .Metronom_ON

            ' MIDI-Out
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
            H1_Klappe.Value = .H_Klappe

            ' Startwert, Stoppwert und Halbtonverschiebung
            Dim Noten_Startwert_byte As Byte
            Dim Noten_Stoppwert_byte As Byte
            Dim Noten_Verschiebung_byte As SByte
            For i = 0 To 34
                If Byte.TryParse(Noten_Startwert(i).Text, Noten_Startwert_byte) Then
                    Noten_Startwert(i).Text = .Startwert_Save(i)
                End If
                If Byte.TryParse(Noten_Stoppwert(i).Text, Noten_Stoppwert_byte) Then
                    Noten_Stoppwert(i).Text = .Stoppwert_Save(i)
                End If
                If SByte.TryParse(Noten_Verschiebung(i).Text, Noten_Verschiebung_byte) Then
                    Noten_Verschiebung(i).Text = .Verschiebung_Save(i)
                End If
            Next

            ' Tastenkombinationen
            Start_Tastenkombination.Text = .Start_Tastenkombination_Save
            Start_Tastenkombination_Key.Clear()
            For Each item As String In .Start_Tastenkombination_Key_Save
                Start_Tastenkombination_Key.Add(item)
                'MessageBox.Show(item)
            Next

            Pause_Tastenkombination.Text = .Pause_Tastenkombination_Save
            Pause_Tastenkombination_Key.Clear()
            For Each item As String In .Pause_Tastenkombination_Key_Save
                Pause_Tastenkombination_Key.Add(item)
            Next

            Save_Tastenkombination.Text = .Save_Tastenkombination_Save
            Save_Tastenkombination_Key.Clear()
            For Each item As String In .Save_Tastenkombination_Key_Save
                Save_Tastenkombination_Key.Add(item)
            Next

            'Ist SendKeys an?
            SendKeys_ON.Checked = .SendKeys_ON_Save

            'SendKey Einstellungen
            For i = 0 To 127
                SendKey_key(i) = .SendKey_Save(i)
            Next

            SendKey_Oktave = 4
            SendKey_Butons_refresh()

        End With
    End Sub


    'Funktion zum Speichern aller wichtigen GUI-Einstellungen
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
            .Takt_Zaehler_Input = Takt_Zaehler_Input.Value
            .Takt_Naenner_Input = Takt_Naenner_Input.Value
            .Speed = Speed.Value

            ' Tonhöhenverschiebung
            .Halbtonverschiebung = Halbtonverschiebung.Value

            ' META
            .META_Dateiname_Input = META_Dateiname_Input.Text
            .META_Autor_Input = META_Autor_Input.Text
            .META_Spurname_Input = META_Spurname_Input.Text
            .META_Copyright_Input = META_Copyright_Input.Text
            .META_Bemerkung_Input = META_Bemerkung_Input.Text

            ' Metronom
            .Metronom_Betont = Metronom_Betont.Checked
            .Metronom_ON = Metronom_ON.Checked

            ' Direct Play
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

            ' Startwert, Stoppwert und Halbtonverschiebung
            .Startwert_Save.Clear()
            .Stoppwert_Save.Clear()
            .Verschiebung_Save.Clear()
            For i = 0 To 34
                .Startwert_Save.Add(Noten_Startwert(i).Text)
                .Stoppwert_Save.Add(Noten_Stoppwert(i).Text)
                .Verschiebung_Save.Add(Noten_Verschiebung(i).Text)
                'MessageBox.Show(Noten_Startwert(i).Text)
            Next


            ' Tastenkombinationen
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


    'Funktion zum Berechnen der Messgeschwindigkeit
    Private Sub Messgeschwindigkeitsberechnung_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Messgeschwindigkeitsberechnung_Timer.Tick
        Try
            Messintervall_Zahl = (Anz_Messungen - AnzMessungen_alt) * 4 'Achtung: Divison durch 0 wenn AnzMessungen_alt > Anz_Messungen
            MessungenProS_TexBox.Text = Format(Messintervall_Zahl, "000") & " M/s"
            Messintervall_TextBox.Text = Format(1000 / Messintervall_Zahl, "00.0") & " ms"
            AnzMessungen_alt = Anz_Messungen
        Catch ' Für Devision durch 0 Error der aber eigentlich durch AnzMessungen_alt=0 bei Messdatenverarbeitung behoben wurde
            Messintervall_Zahl = 0
            Anz_Messungen = 0
            AnzMessungen_alt = 0
            Anz_Verbindungsfehler = 0
            Anz_Messungen_TextBox.Text = "0"
            Anz_Verbindungsfehler_TextBox.Text = "0"
        End Try
    End Sub

    'Beim Ändern der Fenstergrösse wird AdjustFormToScreen in einem neuen Task aufgerufen
    Private Sub MyBase_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        Dim wait As Task = AdjustFormToScreen(5)
    End Sub

    'Passt die GUI möglichst gut an das Programmfenster an
    Private Async Function AdjustFormToScreen(ByVal ms As Integer) As Task
        Await Task.Delay(ms)
        Dim Width = MyBase.Size.Width 'rc.Right - rc.Left
        Dim Height = MyBase.Size.Height 'rc.Bottom - rc.Top
        'MessageBox.Show(Width & "/" & Height)
        If Width < 1280 And Height < 810 Then
            Panel1.Location = New Point(0, 0)
            Panel1.Width = Width - 17 + 15
            Panel1.Height = Height - 40 + 15
        ElseIf Width < 1290 Then
            Panel1.Location = New Point(0, (Height - 772 - 40) / 2)
            Panel1.Width = Width - 17 + 15
            Panel1.Height = 772 + 15
        ElseIf Height < 810 Then
            Panel1.Location = New Point((Width - 1264 - 17) / 2, 0)
            Panel1.Width = 1264 + 150
            Panel1.Height = Height - 40 + 15
        Else
            Panel1.Location = New Point((Width - 1264 - 17) / 2, (Height - 772 - 40) / 2)
            Panel1.Width = 1264 + 15
            Panel1.Height = 772 + 20 + 15
        End If

        Panel1.Location = New Point(Panel1.Location.X, 0)
        Panel1.Height = Height
    End Function

    'Nachfragen ob das Programm während einer MIDI-Aufzeichnung ungespeichert beendet werden soll
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As _
          System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Takt.Enabled Then
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
        'Alle Selectionen aufheben.
        Einstellungen_GroupBox.Focus()
    End Sub

    'Anzeigen des Hilfe-Dialogs
    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help_Button.Click
        Help_Button.Enabled = False 'Sieht schöner aus
        MessageBox.Show("Es ist momentan noch keine Hilfe ausser die eigentlich völlig ausreichende ToolTip Funktion für mein Programm verfügbar." _
                        & vbCrLf & vbCrLf & "Sollten Sie irgendwelche Fragen haben, melden Sie sich bitte per Mail an nico@bosshome.ch",
                        "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Help_Button.Enabled = True
    End Sub

    'Anzeigen des About-Dialogs
    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About_Button.Click
        About_Button.Enabled = False 'Sieht schöner aus
        MessageBox.Show("MIDI-Harfe" & Version & vbCrLf & "©2017 Nico Bosshard" _
            & vbCrLf & vbCrLf & "Ich verbiete hiermit ausdrücklich jegliche Modifikation am Lizenzierungs- und Aktivierungssystem!" _
            & vbCrLf & "Ideenvorschläge und sonstige Mods sind jederzeit erwünscht. :D" _
            & vbCrLf & "Bei Fragen bin ich per E-Mail unter nico@bosshome.ch erreichbar." _
            & vbCrLf & vbCrLf & "Version " & Version & vbCrLf & "Lizenzstatus: Aktiviert" & vbCrLf & "Veröffentlichung: " & PublishDate.Date & vbCrLf & "OS: Windows, Virtual machine" _
            & vbCrLf & "Programmiert mit Visual Basic 2015 .NET Framework 4.6" _
            & vbCrLf & "OS: Windews XP SP2 bis Windows 10" _
            & vbCrLf & "Programmiert von Nico Bosshard", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
        About_Button.Enabled = True
    End Sub

End Class

'-----Programmende-----