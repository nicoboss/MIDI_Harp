Option Explicit On

Imports System.IO.Ports.SerialPort
Imports System.Text.Encoding
Imports System.IO
Imports System.Text


Public Class Form1

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Public ports As String() = GetPortNames()
    Public port As String = ""
    Declare Sub Beep Lib "kernel32.dll" (ByVal tone As Integer, ByVal dauer As Integer)

    'Datenspeicher für eingehende Daten
    Dim In_Buffer As Short

    Dim TacktNr As Short
    Dim Tackt_32stel As Byte


    'Annahme: Maaximal 43 ADC Sygnale! Auf dem Form können jedoch nur 35 angezeigt werden!
    Dim ADC_Anzahl As Byte = 28
    Dim ADC_Counter
    Dim ADC_Read(40) As Byte
    Dim ADC(40) As Byte

    Dim Notenlaege(255) As Single
    Dim Note_Play(255) As Boolean
    Dim Button_Note_Play(255) As Boolean
    Dim Verschiebung(255) As Byte

    Dim Metronom As Byte
    Dim Metronom_alt As Byte

    Dim Messung_gestartet As Boolean = False
    Dim Messung_Pause As Boolean = False

    Dim AnzMessungen_alt As ULong
    Dim Messintervall_Zahl As UShort

    Dim SerialPort1_Stop As Boolean = False

    'Dim Diagramm_Aktuallisieren_i As Byte

    Dim Anz_ADC As Byte = 32

    Dim Noten_Verschiebung(35) As TextBox
    Dim Noten_VerticalProgessBar(35) As MTech010VerticalProgessBar
    Dim Noten_Wert(35) As TextBox
    Dim Noten_Grenzwert(35) As TextBox

    Dim MidiNoteNr = { _
            16, 18, 19, 21, 23, 24, 26, _
            28, 30, 31, 33, 35, 36, 38, _
            40, 42, 43, 45, 47, 48, 50, _
            52, 54, 55, 57, 59, 60, 62, _
            64, 66, 67, 69, 71, 72, 74}

    'Dim MidiNoteNr = { _
    '16, 18, 20, 21, 23, 25, 27, _
    '28, 30, 32, 33, 35, 37, 39, _
    '40, 42, 44, 45, 47, 49, 51, _
    '52, 54, 56, 57, 59, 61, 63, _
    '64, 66, 68, 69, 71, 73, 75}


    Dim Notennamen = {{"ces", "des", "d", "fes", "ges", "g", "a", "ces"}, _
                  {"c", "d", "es", "f", "g", "as", "b", "c"}, _
                  {"cis", "dis", "e", "fis", "gis", "a", "h", "cis"}}

    Dim C1_Klappe_alt As SByte
    Dim D1_Klappe_alt As SByte
    Dim E1_Klappe_alt As SByte
    Dim F1_Klappe_alt As SByte
    Dim G1_Klappe_alt As SByte
    Dim A1_Klappe_alt As SByte
    Dim H1_Klappe_alt As SByte
    Dim C2_Klappe_alt As SByte

    Dim TTT


    Dim Key_Alt As Byte
    Dim Shortcut_Start As Byte = 120
    Dim Shortcut_Pause As Byte = 121
    Dim Shortcut_Save As Byte = 120
    Dim Taste_gedrueckt As Byte

    Dim Tastenkombination_FirstKey As Boolean
    Dim Tastenkombination_KeyAlt As Byte
    Dim Start_Tastenkombination_Key As New List(Of Byte)
    Dim Pause_Tastenkombination_Key As New List(Of Byte)
    Dim Save_Tastenkombination_Key As New List(Of Byte)
    Dim Tastenkombination_Alt As String
    Dim Tastenkombination_Key As New List(Of Byte)
    Dim Tastenkonbination_Klappenverschiebung As SByte


    Private Sub Form1_Load_main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Noten_VerticalProgessBar = { _
            C2_VerticalProgessBar, D2_VerticalProgessBar, E2_VerticalProgessBar, F2_VerticalProgessBar, G2_VerticalProgessBar, A2_VerticalProgessBar, H2_VerticalProgessBar, _
            C3_VerticalProgessBar, D3_VerticalProgessBar, E3_VerticalProgessBar, F3_VerticalProgessBar, G3_VerticalProgessBar, A3_VerticalProgessBar, H3_VerticalProgessBar, _
            C4_VerticalProgessBar, D4_VerticalProgessBar, E4_VerticalProgessBar, F4_VerticalProgessBar, G4_VerticalProgessBar, A4_VerticalProgessBar, H4_VerticalProgessBar, _
            C5_VerticalProgessBar, D5_VerticalProgessBar, E5_VerticalProgessBar, F5_VerticalProgessBar, G5_VerticalProgessBar, A5_VerticalProgessBar, H5_VerticalProgessBar, _
            C6_VerticalProgessBar, D6_VerticalProgessBar, E6_VerticalProgessBar, F6_VerticalProgessBar, G6_VerticalProgessBar, A6_VerticalProgessBar, H6_VerticalProgessBar}


        Noten_Wert = { _
            C2_Wert, D2_Wert, E2_Wert, F2_Wert, G2_Wert, A2_Wert, H2_Wert, _
            C3_Wert, D3_Wert, E3_Wert, F3_Wert, G3_Wert, A3_Wert, H3_Wert, _
            C4_Wert, D4_Wert, E4_Wert, F4_Wert, G4_Wert, A4_Wert, H4_Wert, _
            C5_Wert, D5_Wert, E5_Wert, F5_Wert, G5_Wert, A5_Wert, H5_Wert, _
            C6_Wert, D6_Wert, E6_Wert, F6_Wert, G6_Wert, A6_Wert, H6_Wert}

        Noten_Verschiebung = { _
            C2_Verschiebung, D2_Verschiebung, E2_Verschiebung, F2_Verschiebung, G2_Verschiebung, A2_Verschiebung, H2_Verschiebung, _
            C3_Verschiebung, D3_Verschiebung, E3_Verschiebung, F3_Verschiebung, G3_Verschiebung, A3_Verschiebung, H3_Verschiebung, _
            C4_Verschiebung, D4_Verschiebung, E4_Verschiebung, F4_Verschiebung, G4_Verschiebung, A4_Verschiebung, H4_Verschiebung, _
            C5_Verschiebung, D5_Verschiebung, E5_Verschiebung, F5_Verschiebung, G5_Verschiebung, A5_Verschiebung, H5_Verschiebung, _
            C6_Verschiebung, D6_Verschiebung, E6_Verschiebung, F6_Verschiebung, G6_Verschiebung, A6_Verschiebung, H6_Verschiebung}

        Noten_Grenzwert = { _
            C2_Grenzwert, D2_Grenzwert, E2_Grenzwert, F2_Grenzwert, G2_Grenzwert, A2_Grenzwert, H2_Grenzwert, _
            C3_Grenzwert, D3_Grenzwert, E3_Grenzwert, F3_Grenzwert, G3_Grenzwert, A3_Grenzwert, H3_Grenzwert, _
            C4_Grenzwert, D4_Grenzwert, E4_Grenzwert, F4_Grenzwert, G4_Grenzwert, A4_Grenzwert, H4_Grenzwert, _
            C5_Grenzwert, D5_Grenzwert, E5_Grenzwert, F5_Grenzwert, G5_Grenzwert, A5_Grenzwert, H5_Grenzwert, _
            C6_Grenzwert, D6_Grenzwert, E6_Grenzwert, F6_Grenzwert, G6_Grenzwert, A6_Grenzwert, H6_Grenzwert}


        Diagramm_Aktuallisieren()
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

        'verbinden
        Try

            'Buttons freigeben-/sperren
            Button_Connect.Enabled = False
            Button_Disconnect.Enabled = True
            ComboBox_Comport.Enabled = False

            'Comport öffnen
            SerialPort1.PortName = ComboBox_Comport.Text
            SerialPort1.BaudRate = 230400 'Baudrate
            SerialPort1.DataBits = 8
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.Open()

            Com_Search_Timer.Enabled = False
            Mesgeschwindigkeitsberechnung_Timer.Enabled = True
            Serial_BackgroundWorker.RunWorkerAsync()

        Catch ex As Exception

            'Fehlermeldung
            MessageBox.Show("Unter dem gewählten COM Port wurde kein Mikrokontroller erkannt. " _
            & vbCrLf & "Stellen Sie sicher, das Sie den Richtigen Port gewählt haben und der" _
            & vbCrLf & "Mikrokontroller korrekt mit dem Computer verbunden, und" _
            & vbCrLf & "nicht schon von einem anderen Programm besetzt ist." _
            & vbCrLf & vbCrLf & "Fehler: " & e.ToString _
            & vbCrLf & "Support E-Mail Adresse: nico@bosshome.ch" _
            & vbCrLf & "Fehlercode: 1 (Verbindungsfehler), ", _
            "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button_Connect.Enabled = True
            Button_Disconnect.Enabled = False
            ComboBox_Comport.Enabled = True
        End Try

    End Sub

    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click, Me.FormClosing

        SerialPort1_Stop = True
        Serial_BackgroundWorker.CancelAsync()

        'trennen
        Mesgeschwindigkeitsberechnung_Timer.Enabled = False
        'Tackt.Enabled = False
        AnzMessungen.Text = 0
        AnzMessfehler.Text = 0
        MessungenProS_TexBox.Text = "0 M/s"
        Messintervall_TextBox.Text = "0 ms"
        Com_Search_Timer.Enabled = True
        Button_Connect.Enabled = True
        Button_Disconnect.Enabled = False
        ComboBox_Comport.Enabled = True
        SerialPort1.Close()

    End Sub



    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Serial_BackgroundWorker.DoWork

        Dim Sync_Error As Int32

        Do While (Not SerialPort1.ReadByte = 250)
            'MessageBox.Show(SerialPort1.ReadByte)
        Loop

        Do
            Try
                'ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs
                Dim Serial_Read As String = ""

                'Hier werden die Daten empfangen
                In_Buffer = 0
                Control.CheckForIllegalCrossThreadCalls = False


                For i = 0 To 35
                    ADC_Read(i) = SerialPort1.ReadByte
                    'MessageBox.Show(ADC_Read(i))
                Next

                Serial_Read = SerialPort1.ReadByte
                If Not Serial_Read = 250 Then
                    'MessageBox.Show("Die Synchronisation zwischen Computer und Mikrokontroller stimmte nicht mehr überein. " _
                    '& "Die laufende Aufnahme wurde Paussiert" _
                    '& vbCrLf & "Sollte dieser Fehler mehrmahls auftreten wenden Sie sich bitte an Nico Bosshard" _
                    '& vbCrLf & "Support EMail Adresse: nico@bosshome.ch Fehlercode: 7 , " & Serial_Read, "Übertragungsfehler", _
                    'MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Sync_Error += 1
                    AnzMessfehler.Text = Sync_Error

                    Do While (Not SerialPort1.ReadByte = 250)
                    Loop

                End If

                ADC_Counter = 0
                For i = 0 To 30 Step 2
                    ADC_Counter = ADC_Counter + 1
                    ADC(i) = ADC_Read(i)
                Next

                For i = 1 To 31 Step 2
                    ADC_Counter = ADC_Counter + 1
                    ADC(i) = ADC_Read(i)
                Next

                TTT = TTT + 1
                AnzMessungen.Text = TTT


                Dim NotenNr As Byte

                For i = 0 To 31 'Anz_ADC - 29

                    'NotenNr = MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text)
                    NotenNr = MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text)

                    If ADC(i) >= CInt(Noten_Grenzwert(i).Text) And Note_Play(NotenNr) = False Then
                        'MessageBox.Show(NotenNr & " on")
                        Note_Play(NotenNr) = True
                        m.PlayMIDINote(NotenNr, 100, 0)
                    End If

                    If ADC(i) < CInt(Noten_Grenzwert(i).Text) And Note_Play(NotenNr) = True Then
                        'MessageBox.Show(NotenNr & " off")
                        Note_Play(NotenNr) = False
                        m.STOPMIDINote(NotenNr)
                    End If

                Next


                'Diagramm_Aktuallisieren_i += 1

                'If Diagramm_Aktuallisieren_i = 2 Then
                Diagramm_Aktuallisieren()
                'Diagramm_Aktuallisieren_i = 0
                'End If


                If MIDI_SpecialMode.Checked = True Then Tackt_Tick()

            Catch
            End Try

            If SerialPort1_Stop = True Then
                SerialPort1_Stop = False
                Exit Sub
            End If

        Loop

    End Sub


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

        Song.Tracks(0).TrackData.Clear()
        If Not META_Dateinamen_Input.Text = "" Then Song.Tracks(0).Text(1, META_Dateinamen_Input.Text)
        If Not META_Autor_Input.Text = "" Then Song.Tracks(0).Text(1, META_Autor_Input.Text)
        If Not META_Copyright_Input.Text = "" Then Song.Tracks(0).Text(2, META_Copyright_Input.Text)
        If Not META_Bemerkung_Input.Text = "" Then Song.Tracks(0).Text(1, META_Bemerkung_Input.Text)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(0).AddTackt(Tackt_Zaehler_Input.Value, Tackt_Naenner_Input.Value)

        Song.Tracks(1).TrackData.Clear()
        Song.Tracks(1).Zuordnung(1)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(1).Text(1, cboInstruments.SelectedText)
        If Not META_Spurnamen_Input.Text = "" Then Song.Tracks(1).Text(3, META_Spurnamen_Input.Text)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(1).Text(4, cboInstruments.SelectedText)
        If MIDI_NormalMode.Checked = True Then Song.Tracks(1).Add_Instrument(cboInstruments.SelectedIndex)

        If MIDI_NormalMode.Checked = True Then Tackt.Enabled = True
        Messung_gestartet = True
    End Sub


    Private Sub MIDI_Pause() Handles MIDI_Pause_Button.Click
        If Einstellungen_GroupBox.Enabled = False Then
            Tackt.Enabled = False
            Messung_gestartet = False
            Messung_Pause = True
            Einstellungen_GroupBox.Enabled = True
            MIDI_Pause_Button.Text = "Aufnahme fortsetzen"
        Else
            Tackt.Enabled = True
            Messung_Pause = False
            Messung_gestartet = True
            Einstellungen_GroupBox.Enabled = False
            MIDI_Pause_Button.Text = "Aufnahme pausieren"
        End If
    End Sub

    Private Sub MIDI_Save() Handles MIDI_Save_Button.Click

        MIDI_Pause_Button.Enabled = False
        MIDI_Save_Button.Enabled = False
        Tackt.Enabled = False
        Messung_gestartet = False

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
                    Song.Tracks(1).AddNoteOnOffEvent(0, MIDI.Track.NoteEvent.NoteOn, CByte(i), CByte(100))
                End If

                Notenlaege(i) += 0.125
                Note_gespielt = True

            Else

                If Notenlaege(i) > 0 Then
                    Song.Tracks(1).AddNoteOnOffEvent(0, MIDI.Track.NoteEvent.NoteOff, CByte(i), 0)
                    Notenlaege(i) = 0
                End If
            End If

        Next

        If Note_gespielt = False Then Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, 0, 0) ' Notenlaege(0) += 0.125

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
    End Sub



    Private Sub Diagramm_Aktuallisieren() ' Handles Tackt.Tick

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



#Region "Button Note"

#Region "   Buttons Events "

#Region "   MouseDown Events"
    Private Sub C2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2_Button.MouseDown
        Button_Note(0)
    End Sub

    Private Sub D2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2_Button.MouseDown
        Button_Note(1)
    End Sub

    Private Sub E2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2_Button.MouseDown
        Button_Note(2)
    End Sub

    Private Sub F2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2_Button.MouseDown
        Button_Note(3)
    End Sub

    Private Sub G2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2_Button.MouseDown
        Button_Note(4)
    End Sub

    Private Sub A2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2_Button.MouseDown
        Button_Note(5)
    End Sub

    Private Sub H2_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2_Button.MouseDown
        Button_Note(6)
    End Sub



    Private Sub C3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3_Button.MouseDown
        Button_Note(7)
    End Sub

    Private Sub D3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3_Button.MouseDown
        Button_Note(8)
    End Sub

    Private Sub E3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3_Button.MouseDown
        Button_Note(9)
    End Sub

    Private Sub F3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3_Button.MouseDown
        Button_Note(10)
    End Sub

    Private Sub G3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3_Button.MouseDown
        Button_Note(11)
    End Sub

    Private Sub A3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3_Button.MouseDown
        Button_Note(12)
    End Sub

    Private Sub H3_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3_Button.MouseDown
        Button_Note(13)
    End Sub



    Private Sub C4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4_Button.MouseDown
        Button_Note(14)
    End Sub

    Private Sub D4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4_Button.MouseDown
        Button_Note(15)
    End Sub

    Private Sub E4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4_Button.MouseDown
        Button_Note(16)
    End Sub

    Private Sub F4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4_Button.MouseDown
        Button_Note(17)
    End Sub

    Private Sub G4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4_Button.MouseDown
        Button_Note(18)
    End Sub

    Private Sub A4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4_Button.MouseDown
        Button_Note(19)
    End Sub

    Private Sub H4_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4_Button.MouseDown
        Button_Note(20)
    End Sub



    Private Sub C5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5_Button.MouseDown
        Button_Note(21)
    End Sub

    Private Sub D5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5_Button.MouseDown
        Button_Note(22)
    End Sub

    Private Sub E5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5_Button.MouseDown
        Button_Note(23)
    End Sub

    Private Sub F5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5_Button.MouseDown
        Button_Note(24)
    End Sub

    Private Sub G5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5_Button.MouseDown
        Button_Note(25)
    End Sub

    Private Sub A5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5_Button.MouseDown
        Button_Note(26)
    End Sub

    Private Sub H5_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5_Button.MouseDown
        Button_Note(27)
    End Sub



    Private Sub C6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6_Button.MouseDown
        Button_Note(28)
    End Sub

    Private Sub D6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6_Button.MouseDown
        Button_Note(29)
    End Sub

    Private Sub E6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6_Button.MouseDown
        Button_Note(30)
    End Sub

    Private Sub F6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6_Button.MouseDown
        Button_Note(31)
    End Sub

    Private Sub G6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6_Button.MouseDown
        Button_Note(32)
    End Sub

    Private Sub A6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6_Button.MouseDown
        Button_Note(33)
    End Sub

    Private Sub H6_Button_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6_Button.MouseDown
        Button_Note(34)
    End Sub
#End Region

#Region "   MouseUp Events"

    Private Sub C2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2_Button.MouseUp
        Button_Stop_Note(0)
    End Sub

    Private Sub D2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2_Button.MouseUp
        Button_Stop_Note(1)
    End Sub

    Private Sub E2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2_Button.MouseUp
        Button_Stop_Note(2)
    End Sub

    Private Sub F2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2_Button.MouseUp
        Button_Stop_Note(3)
    End Sub

    Private Sub G2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2_Button.MouseUp
        Button_Stop_Note(4)
    End Sub

    Private Sub A2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2_Button.MouseUp
        Button_Stop_Note(5)
    End Sub

    Private Sub H2_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2_Button.MouseUp
        Button_Stop_Note(6)
    End Sub



    Private Sub C3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3_Button.MouseUp
        Button_Stop_Note(7)
    End Sub

    Private Sub D3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3_Button.MouseUp
        Button_Stop_Note(8)
    End Sub

    Private Sub E3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3_Button.MouseUp
        Button_Stop_Note(9)
    End Sub

    Private Sub F3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3_Button.MouseUp
        Button_Stop_Note(10)
    End Sub

    Private Sub G3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3_Button.MouseUp
        Button_Stop_Note(11)
    End Sub

    Private Sub A3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3_Button.MouseUp
        Button_Stop_Note(12)
    End Sub

    Private Sub H3_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3_Button.MouseUp
        Button_Stop_Note(13)
    End Sub



    Private Sub C4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4_Button.MouseUp
        Button_Stop_Note(14)
    End Sub

    Private Sub D4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4_Button.MouseUp
        Button_Stop_Note(15)
    End Sub

    Private Sub E4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4_Button.MouseUp
        Button_Stop_Note(16)
    End Sub

    Private Sub F4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4_Button.MouseUp
        Button_Stop_Note(17)
    End Sub

    Private Sub G4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4_Button.MouseUp
        Button_Stop_Note(18)
    End Sub

    Private Sub A4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4_Button.MouseUp
        Button_Stop_Note(19)
    End Sub

    Private Sub H4_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4_Button.MouseUp
        Button_Stop_Note(20)
    End Sub



    Private Sub C5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5_Button.MouseUp
        Button_Stop_Note(21)
    End Sub

    Private Sub D5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5_Button.MouseUp
        Button_Stop_Note(22)
    End Sub

    Private Sub E5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5_Button.MouseUp
        Button_Stop_Note(23)
    End Sub

    Private Sub F5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5_Button.MouseUp
        Button_Stop_Note(24)
    End Sub

    Private Sub G5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5_Button.MouseUp
        Button_Stop_Note(25)
    End Sub

    Private Sub A5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5_Button.MouseUp
        Button_Stop_Note(26)
    End Sub

    Private Sub H5_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5_Button.MouseUp
        Button_Stop_Note(27)
    End Sub



    Private Sub C6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6_Button.MouseUp
        Button_Stop_Note(28)
    End Sub

    Private Sub D6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6_Button.MouseUp
        Button_Stop_Note(29)
    End Sub

    Private Sub E6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6_Button.MouseUp
        Button_Stop_Note(30)
    End Sub

    Private Sub F6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6_Button.MouseUp
        Button_Stop_Note(31)
    End Sub

    Private Sub G6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6_Button.MouseUp
        Button_Stop_Note(32)
    End Sub

    Private Sub A6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6_Button.MouseUp
        Button_Stop_Note(33)
    End Sub

    Private Sub H6_Button_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6_Button.MouseUp
        Button_Stop_Note(34)
    End Sub

#End Region

#End Region


    Private Sub Button_Note(ByVal TastenNr As Byte)
        Dim NotenNr As Byte

        NotenNr = MidiNoteNr(TastenNr) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(TastenNr).Text)
        m.PlayMIDINote(NotenNr, 100, 0)
        Button_Note_Play(NotenNr) = True
    End Sub


    Private Sub Button_Stop_Note(ByVal TastenNr As Byte)
        Dim NotenNr As Byte

        NotenNr = MidiNoteNr(TastenNr) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(TastenNr).Text)
        m.STOPMIDINote(NotenNr)
        Button_Note_Play(NotenNr) = False
    End Sub


#End Region

#Region "Grenzwerte"

    Private Sub C2_Grenzwert_KeyPress(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        C2_Grenzwert.KeyPress, D2_Grenzwert.KeyPress, E2_Grenzwert.KeyPress, F2_Grenzwert.KeyPress, G2_Grenzwert.KeyPress, A2_Grenzwert.KeyPress, H2_Grenzwert.KeyPress, _
        C3_Grenzwert.KeyPress, D3_Grenzwert.KeyPress, E3_Grenzwert.KeyPress, F3_Grenzwert.KeyPress, G3_Grenzwert.KeyPress, A3_Grenzwert.KeyPress, H3_Grenzwert.KeyPress, _
        C4_Grenzwert.KeyPress, D4_Grenzwert.KeyPress, E4_Grenzwert.KeyPress, F4_Grenzwert.KeyPress, G4_Grenzwert.KeyPress, A4_Grenzwert.KeyPress, H4_Grenzwert.KeyPress, _
        C5_Grenzwert.KeyPress, D5_Grenzwert.KeyPress, E5_Grenzwert.KeyPress, F5_Grenzwert.KeyPress, G5_Grenzwert.KeyPress, A5_Grenzwert.KeyPress, H5_Grenzwert.KeyPress, _
        C6_Grenzwert.KeyPress, D6_Grenzwert.KeyPress, E6_Grenzwert.KeyPress, F6_Grenzwert.KeyPress, G6_Grenzwert.KeyPress, A6_Grenzwert.KeyPress, H6_Grenzwert.KeyPress

        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 32, 46
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub


    Private Sub C2_Grenzwert_TextChanged(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles _
        C2_Grenzwert.LostFocus, D2_Grenzwert.LostFocus, E2_Grenzwert.LostFocus, F2_Grenzwert.LostFocus, G2_Grenzwert.LostFocus, A2_Grenzwert.LostFocus, H2_Grenzwert.LostFocus, _
        C3_Grenzwert.LostFocus, D3_Grenzwert.LostFocus, E3_Grenzwert.LostFocus, F3_Grenzwert.LostFocus, G3_Grenzwert.LostFocus, A3_Grenzwert.LostFocus, H3_Grenzwert.LostFocus, _
        C4_Grenzwert.LostFocus, D4_Grenzwert.LostFocus, E4_Grenzwert.LostFocus, F4_Grenzwert.LostFocus, G4_Grenzwert.LostFocus, A4_Grenzwert.LostFocus, H4_Grenzwert.LostFocus, _
        C5_Grenzwert.LostFocus, D5_Grenzwert.LostFocus, E5_Grenzwert.LostFocus, F5_Grenzwert.LostFocus, G5_Grenzwert.LostFocus, A5_Grenzwert.LostFocus, H5_Grenzwert.LostFocus, _
        C6_Grenzwert.LostFocus, D6_Grenzwert.LostFocus, E6_Grenzwert.LostFocus, F6_Grenzwert.LostFocus, G6_Grenzwert.LostFocus, A6_Grenzwert.LostFocus, H6_Grenzwert.LostFocus

        If sender.Text > 255 Then sender.Text = 255
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


#Region "Einstellungsspeicherungsfunktion"

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown    'Wichtig: MyBase.Load geht nicht, da zu früh!

        With My.Settings
            ' Aufnahmemodus
            'MIDI_NormalMode.Checked = .MIDI_NormalMode
            'Absichtlicher Overflow
            'Alternative: SpecialMode stadt NormalMode speichern!
            'MIDI_SpecialMode.Checked = .MIDI_NormalMode + 1
            cboInstruments.SelectedIndex = .cboInstruments

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

            ' Halbtonverschiebung
            C2_Grenzwert.Text = .C2_Grenzwert_Save
            D2_Grenzwert.Text = .D2_Grenzwert_Save
            E2_Grenzwert.Text = .E2_Grenzwert_Save
            F2_Grenzwert.Text = .F2_Grenzwert_Save
            G2_Grenzwert.Text = .G2_Grenzwert_Save
            A2_Grenzwert.Text = .A2_Grenzwert_Save
            H2_Grenzwert.Text = .H2_Grenzwert_Save

            C3_Grenzwert.Text = .C3_Grenzwert_Save
            D3_Grenzwert.Text = .D3_Grenzwert_Save
            E3_Grenzwert.Text = .E3_Grenzwert_Save
            F3_Grenzwert.Text = .F3_Grenzwert_Save
            G3_Grenzwert.Text = .G3_Grenzwert_Save
            A3_Grenzwert.Text = .A3_Grenzwert_Save
            H3_Grenzwert.Text = .H3_Grenzwert_Save

            C4_Grenzwert.Text = .C4_Grenzwert_Save
            D4_Grenzwert.Text = .D4_Grenzwert_Save
            E4_Grenzwert.Text = .E4_Grenzwert_Save
            F4_Grenzwert.Text = .F4_Grenzwert_Save
            G4_Grenzwert.Text = .G4_Grenzwert_Save
            A4_Grenzwert.Text = .A4_Grenzwert_Save
            H4_Grenzwert.Text = .H4_Grenzwert_Save

            C5_Grenzwert.Text = .C5_Grenzwert_Save
            D5_Grenzwert.Text = .D5_Grenzwert_Save
            E5_Grenzwert.Text = .E5_Grenzwert_Save
            F5_Grenzwert.Text = .F5_Grenzwert_Save
            G5_Grenzwert.Text = .G5_Grenzwert_Save
            A5_Grenzwert.Text = .A5_Grenzwert_Save
            H5_Grenzwert.Text = .H5_Grenzwert_Save

            C6_Grenzwert.Text = .C6_Grenzwert_Save
            D6_Grenzwert.Text = .D6_Grenzwert_Save
            E6_Grenzwert.Text = .E6_Grenzwert_Save
            F6_Grenzwert.Text = .F6_Grenzwert_Save
            G6_Grenzwert.Text = .G6_Grenzwert_Save
            A6_Grenzwert.Text = .A6_Grenzwert_Save
            H6_Grenzwert.Text = .H6_Grenzwert_Save

            ' Tastenkonbinationen
            'MessageBox.Show(.Start_Tastenkombination_Save)
            Start_Tastenkombination.Text = .Start_Tastenkombination_Save
            If Not .Start_Tastenkombination_Key1_Save = 0 Then Start_Tastenkombination_Key.Add(.Start_Tastenkombination_Key1_Save)
            If Not .Start_Tastenkombination_Key2_Save = 0 Then Start_Tastenkombination_Key.Add(.Start_Tastenkombination_Key2_Save)
            If Not .Start_Tastenkombination_Key3_Save = 0 Then Start_Tastenkombination_Key.Add(.Start_Tastenkombination_Key3_Save)

            Pause_Tastenkombination.Text = .Pause_Tastenkombination_Save
            If Not .Pause_Tastenkombination_Key1_Save = 0 Then Pause_Tastenkombination_Key.Add(.Pause_Tastenkombination_Key1_Save)
            If Not .Pause_Tastenkombination_Key2_Save = 0 Then Pause_Tastenkombination_Key.Add(.Pause_Tastenkombination_Key2_Save)
            If Not .Pause_Tastenkombination_Key3_Save = 0 Then Pause_Tastenkombination_Key.Add(.Pause_Tastenkombination_Key3_Save)


            Save_Tastenkombination.Text = .Save_Tastenkombination_Save
            If Not .Save_Tastenkombination_Key1_Save = 0 Then Save_Tastenkombination_Key.Add(.Save_Tastenkombination_Key1_Save)
            If Not .Save_Tastenkombination_Key2_Save = 0 Then Save_Tastenkombination_Key.Add(.Save_Tastenkombination_Key2_Save)
            If Not .Save_Tastenkombination_Key3_Save = 0 Then Save_Tastenkombination_Key.Add(.Save_Tastenkombination_Key3_Save)


        End With
    End Sub


    Private Sub Form1_FormClosing1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        With My.Settings

            ' Aufnahmemodus
            .MIDI_NormalMode = MIDI_NormalMode.Checked
            .cboInstruments = cboInstruments.SelectedIndex

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
            .C2_Grenzwert_Save = C2_Grenzwert.Text
            .D2_Grenzwert_Save = D2_Grenzwert.Text
            .E2_Grenzwert_Save = E2_Grenzwert.Text
            .F2_Grenzwert_Save = F2_Grenzwert.Text
            .G2_Grenzwert_Save = G2_Grenzwert.Text
            .A2_Grenzwert_Save = A2_Grenzwert.Text
            .H2_Grenzwert_Save = H2_Grenzwert.Text

            .C3_Grenzwert_Save = C3_Grenzwert.Text
            .D3_Grenzwert_Save = D3_Grenzwert.Text
            .E3_Grenzwert_Save = E3_Grenzwert.Text
            .F3_Grenzwert_Save = F3_Grenzwert.Text
            .G3_Grenzwert_Save = G3_Grenzwert.Text
            .A3_Grenzwert_Save = A3_Grenzwert.Text
            .H3_Grenzwert_Save = H3_Grenzwert.Text

            .C4_Grenzwert_Save = C4_Grenzwert.Text
            .D4_Grenzwert_Save = D4_Grenzwert.Text
            .E4_Grenzwert_Save = E4_Grenzwert.Text
            .F4_Grenzwert_Save = F4_Grenzwert.Text
            .G4_Grenzwert_Save = G4_Grenzwert.Text
            .A4_Grenzwert_Save = A4_Grenzwert.Text
            .H4_Grenzwert_Save = H4_Grenzwert.Text

            .C5_Grenzwert_Save = C5_Grenzwert.Text
            .D5_Grenzwert_Save = D5_Grenzwert.Text
            .E5_Grenzwert_Save = E5_Grenzwert.Text
            .F5_Grenzwert_Save = F5_Grenzwert.Text
            .G5_Grenzwert_Save = G5_Grenzwert.Text
            .A5_Grenzwert_Save = A5_Grenzwert.Text
            .H5_Grenzwert_Save = H5_Grenzwert.Text

            .C6_Grenzwert_Save = C6_Grenzwert.Text
            .D6_Grenzwert_Save = D6_Grenzwert.Text
            .E6_Grenzwert_Save = E6_Grenzwert.Text
            .F6_Grenzwert_Save = F6_Grenzwert.Text
            .G6_Grenzwert_Save = G6_Grenzwert.Text
            .A6_Grenzwert_Save = A6_Grenzwert.Text
            .H6_Grenzwert_Save = H6_Grenzwert.Text

            ' Tastenkonbinationen
            .Start_Tastenkombination_Save = Start_Tastenkombination.Text
            If Start_Tastenkombination_Key.Count > 0 Then .Start_Tastenkombination_Key1_Save = Start_Tastenkombination_Key(0) Else .Start_Tastenkombination_Key1_Save = 0
            If Start_Tastenkombination_Key.Count > 1 Then .Start_Tastenkombination_Key2_Save = Start_Tastenkombination_Key(1) Else .Start_Tastenkombination_Key2_Save = 0
            If Start_Tastenkombination_Key.Count > 2 Then .Start_Tastenkombination_Key3_Save = Start_Tastenkombination_Key(2) Else .Start_Tastenkombination_Key3_Save = 0

            .Pause_Tastenkombination_Save = Pause_Tastenkombination.Text
            If Pause_Tastenkombination_Key.Count > 0 Then .Pause_Tastenkombination_Key1_Save = Pause_Tastenkombination_Key(0) Else .Pause_Tastenkombination_Key1_Save = 0
            If Pause_Tastenkombination_Key.Count > 1 Then .Pause_Tastenkombination_Key2_Save = Pause_Tastenkombination_Key(1) Else .Pause_Tastenkombination_Key2_Save = 0
            If Pause_Tastenkombination_Key.Count > 2 Then .Pause_Tastenkombination_Key3_Save = Pause_Tastenkombination_Key(2) Else .Pause_Tastenkombination_Key3_Save = 0

            .Save_Tastenkombination_Save = Save_Tastenkombination.Text
            If Save_Tastenkombination_Key.Count > 0 Then .Save_Tastenkombination_Key1_Save = Save_Tastenkombination_Key(0) Else .Save_Tastenkombination_Key1_Save = 0
            If Save_Tastenkombination_Key.Count > 1 Then .Save_Tastenkombination_Key2_Save = Save_Tastenkombination_Key(1) Else .Save_Tastenkombination_Key2_Save = 0
            If Save_Tastenkombination_Key.Count > 2 Then .Save_Tastenkombination_Key3_Save = Save_Tastenkombination_Key(2) Else .Save_Tastenkombination_Key3_Save = 0


            ' Einstellungen speichern
            .Save()

        End With

    End Sub

#End Region


    'Private Sub Diagramm_Reload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Diagramm_Reload.Tick
    'Diagramm_Aktuallisieren()
    'End Sub



    Private Sub Mesgeschwindigkeitsberechnung_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mesgeschwindigkeitsberechnung_Timer.Tick
        Messintervall_Zahl = (AnzMessungen.Text - AnzMessungen_alt) * 4
        MessungenProS_TexBox.Text = Format(Messintervall_Zahl, "000") & " M/s"
        Messintervall_TextBox.Text = Format(1000 / Messintervall_Zahl, "00.0") & " ms"
        AnzMessungen_alt = AnzMessungen.Text
    End Sub


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
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short
    Private Sub KeyState_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If Tastenkonbination_Press(Start_Tastenkombination_Key) = True Then MessageBox.Show("Start") : MIDI_Start()
        If Tastenkonbination_Press(Pause_Tastenkombination_Key) = True Then MessageBox.Show("Pause") : MIDI_Pause()
        If Tastenkonbination_Press(Save_Tastenkombination_Key) = True Then MessageBox.Show("Save") : MIDI_Save()

        'If Tastenkonbination_Press(New List(Of Byte) From {49}) = True Then MessageBox.Show(Chr(Pause_Tastenkombination_Key(0)))

        Select Case -32767
            Case GetAsyncKeyState(107)  'Pluss (Nomblock)
                If hsbVolume.Value + 10 <= 127 Then hsbVolume.Value += 10
            Case GetAsyncKeyState(109)  'Minus (Nomblock)
                If hsbVolume.Value - 10 >= 0 Then hsbVolume.Value -= 10
                'Case GetAsyncKeyState(77) And GetAsyncKeyState(17) 'Ctrl + M

        End Select

        If GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(65) = -32767 Then 'Ctrl + Shift + A
            MIDI_Aufnahmemodus_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If

        If GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(77) = -32767 Then 'Ctrl + Shift + M
            Metronom_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If

        If GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(80) = -32767 Then 'Ctrl + Shift + P
            DirectPlay_YesNo_GroupBox.SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If

        If GetAsyncKeyState(17) <= -32767 And GetAsyncKeyState(16) <= -32767 And GetAsyncKeyState(84) = -32767 Then 'Ctrl + Shift + T
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
            If Not GetAsyncKeyState(Tastenkombination(i)) = -32767 Then Return False
        Next

        Return True
    End Function



    Private Sub Tastenkombination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Tastenkombination.GotFocus, Start_Tastenkombination.Click, Start_Tastenkombination.KeyUp, _
                                                                                                                Pause_Tastenkombination.GotFocus, Pause_Tastenkombination.Click, Pause_Tastenkombination.KeyUp, _
                                                                                                                Save_Tastenkombination.GotFocus, Save_Tastenkombination.Click, Save_Tastenkombination.KeyUp
        Timer1.Enabled = False
        Tastenkombination_FirstKey = True
    End Sub


    Private Sub Tastenkombination_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Start_Tastenkombination.KeyDown, _
                                                                                                                                Pause_Tastenkombination.KeyDown, _
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


                    Case Else : .Text += e.KeyCode.ToString : MessageBox.Show(e.KeyCode)
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
        Timer1.Enabled = True
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
        Timer1.Enabled = True
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
        Timer1.Enabled = True
    End Sub

#End Region




#Region "Onlineaktivierung"


    Dim Activated As Boolean

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
        H &= Hex(My.Computer.Info.TotalPhysicalMemory.GetHashCode)
        H &= Hex(My.Computer.Mouse.WheelExists.GetHashCode)
        H &= Hex(My.User.Name.GetHashCode)
        H &= Hex(My.User.IsAuthenticated.GetHashCode)
        H &= Hex(My.User.CurrentPrincipal.Identity.Name.GetHashCode)
        H &= Hex(Environ("PROCESSOR_ARCHITECTURE").GetHashCode)
        H &= Hex(Environ("SYSTEMROOT").GetHashCode)
        H &= Hex(Environ("NUMBER_OF_PROCESSORS").GetHashCode)
        H &= Hex(My.Computer.Registry.LocalMachine.OpenSubKey( _
          "HARDWARE\DESCRIPTION\System\CentralProcessor\0\").GetValue("~MHZ").GetHashCode)
        H &= Hex(My.Computer.Registry.LocalMachine.OpenSubKey( _
          "HARDWARE\DESCRIPTION\System\BIOS\").GetValue("SystemManufacturer").GetHashCode)
        H &= Hex(H.GetHashCode)
        Return (LCase(H))
    End Function

    Sub Generate()
        Dim P() As Byte, C As String, X() As Byte, Z As Integer
        P = My.Computer.FileSystem.ReadAllBytes(Application.ExecutablePath)
        ReDim X(KeyLen() \ 8)
        C = GetHash()
        Z = 0
        For I As Integer = 0 To 127
            X(Z) = P(I) Xor Asc(C(I))
            Z += 1
            Randomize()
            For J As Integer = Z To Z + P(I + 128)
                X(J) = CInt(Rnd() * 254)
            Next
            Z += P(I + 128)
        Next
        My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\nanticop.y", X, False)
    End Sub

    Function KeyLen() As Integer
        Dim P() As Byte, Z As Integer
        P = My.Computer.FileSystem.ReadAllBytes(Application.ExecutablePath)
        Z = 0
        For I As Integer = 0 To 127
            Z += 1
            Z += P(I + 128)
        Next
        Return (Z * 8)
    End Function

    Function Check() As Boolean
        Dim P() As Byte, T As String, C As String, X() As Byte, Z As Integer
        Try
            P = My.Computer.FileSystem.ReadAllBytes(Application.ExecutablePath)
            X = My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\nanticop.y")
            Z = 0
        Catch ex As Exception
        End Try
        T = ""
        Try
            For I As Integer = 0 To 127
                T = T & Chr(P(I) Xor X(Z))
                Z += 1
                Z += P(I + 128)
            Next
        Catch ex As Exception
        End Try
        C = GetHash()
        Return (C = T)
    End Function

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Aktivierung_Label.Show()
        Application.DoEvents()
        Try
            Dim S As String = My.Computer.FileSystem.GetTempFileName()
            My.Computer.FileSystem.DeleteFile(S)
            My.Computer.Network.DownloadFile( _
                "http://www.nicobosshard.ch/nanticopykeys.php?app=[Programm]&key=" & "rfe", S)

            ' "http://www.nicobosshard.ch/nanticopykeys.php?app=[Programm]&key=" & m.Text, S)
            Dim X As String = My.Computer.FileSystem.ReadAllText(S)
            If CInt(X.Split(";")(0)) > 0 Then
                If CInt(X.Split(";")(1)) > 0 Then
                    Generate()
                    Activated = True
                    If Check() Then
                        MsgBox("Der Schlüssel ist gültig. [Programm] wurde aktiviert. " & _
                          "Sie dürfen diesen Schlüssel noch " & _
                          (CInt(X.Split(";")(1)) - 1) & _
                          " Mal für eine Neuinstallation auf diesem PC verwenden.")
                    Else
                        MsgBox("Der Schlüssel ist gültig. [Programm] konnte allerdings " & _
                          "nicht aktiviert werden. " & _
                          "Bitte überprüfen Sie, ob der Ordner schreibgeschützt ist.", _
                          MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Der Schlüssel ist gültig, aber die maximale Anzahl der " & _
                      "Aktivierungen für diesen " & _
                      "Schlüssel wurde überschritten.", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Der Lizenzschlüssel ist ungültig. Bitte überprüfen Sie ihn auf " & _
                  "Tippfehler und wenden " & _
                  "Sie sich an Ihren Software-Händler.", MsgBoxStyle.Critical)
                Aktivierung_Label.Hide()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("[Programm] konnte aufgrund eines Fehlers nicht aktiviert werden. " & _
              "Bitte überprüfen Sie ihre Internetverbindung.", MsgBoxStyle.Critical)
            Aktivierung_Label.Hide()
            Exit Sub
        End Try
        Aktivierung_Label.Hide()
        Me.Close()
    End Sub

    Private Sub AntiCopy_Load(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles MyBase.Load
        If Check() Then
            Activated = True
            Me.Close()
        End If
    End Sub

#End Region








    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As  _
          System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Tackt.Enabled Then
            Dim result As DialogResult = MessageBox.Show("Wollen Sie das Programm wirklich beenden?" _
            & vbCrLf & "Die laufende Aufnahme wird dadurch gelöscht!", "Wirklich beenden?", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub



    Private Sub MyBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.Click
        'Alle selection aufheben.
        Einstellungen_GroupBox.Focus()
    End Sub

End Class


