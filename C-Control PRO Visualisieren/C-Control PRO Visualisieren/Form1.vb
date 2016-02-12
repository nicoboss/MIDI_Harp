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
    Dim Tackt_Achtel As Byte

    Dim Tackt_Viertel As Byte = 1
    Dim Tackt_Viertel_Counter As Byte

    'Annahme: Maaximal 43 ADC Sygnale! Auf dem Form können jedoch nur 35 angezeigt werden!
    Dim ADC_Anzahl As Byte = 28
    Dim ADC_Read As Byte
    Dim ADC(43) As Byte

    Dim Notenlaege(255) As Single
    Dim Note_Play(255) As Boolean
    Dim Button_Note_Play(255) As Boolean
    Dim Verschiebung(255) As Byte

    Dim Metronom As Byte
    Dim Metronom_alt As Byte

    Dim Messung_gestartet As Boolean


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


        Diagramm_Refresh()
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
            SerialPort1.BaudRate = 115200 'Baudrate
            SerialPort1.DataBits = 8
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.Open()

        Catch ex As Exception

            'Fehlermeldung 
            MessageBox.Show("Achtung die Schnittstelle konnte nicht geöffnet werden! " + e.ToString _
                          , "Ausnahmefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button_Connect.Enabled = True
            Button_Disconnect.Enabled = False
            ComboBox_Comport.Enabled = True

        End Try

        Com_Search_Timer.Enabled = False
        Messintervall.Enabled = True
        'Tackt.Enabled = True
    End Sub

    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click, Me.FormClosing

        'trennen
        Messintervall.Enabled = False
        'Tackt.Enabled = False
        Com_Search_Timer.Enabled = True
        Button_Connect.Enabled = True
        Button_Disconnect.Enabled = False
        ComboBox_Comport.Enabled = True
        SerialPort1.Close()

    End Sub

    'Private Sub SerialPort1_BW(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Messintervall.Tick
    'BackgroundWorker1.CancelAsync()
    'BackgroundWorker1.RunWorkerAsync()
    'End Sub


    'Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Messintervall.Tick 'BackgroundWorker1.DoWork
    Private Sub SerialPort1_DataReceived() Handles Messintervall.Tick 'BackgroundWorker1.DoWork

        'ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs
        Dim Serial_Read As String = ""

        'Hier werden die Daten empfangen
        In_Buffer = 0
        Control.CheckForIllegalCrossThreadCalls = False


        SerialPort1.Write(1)


        Serial_Read = SerialPort1.ReadByte
        ADC(0) = Serial_Read

        Dim ADC_Temp As Integer

        For i = 1 To 31 'Anz_ADC - 1
            'MessageBox.Show("gh")
            Serial_Read = SerialPort1.ReadByte
            ADC_Temp = Serial_Read - (ADC(i - 1) / 4)
            If ADC_Temp < 0 Then ADC_Temp = 0
            ADC(i) = ADC_Temp
        Next


        Dim NotenNr As Byte

        For i = 0 To Anz_ADC - 29

            NotenNr = MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text)

            If ADC(i) >= CInt(Noten_Grenzwert(i).Text) And Note_Play(NotenNr) = False Then
                Note_Play(NotenNr) = True
                m.PlayMIDINote(NotenNr, 100, 0)
            End If

            If ADC(i) < CInt(Noten_Grenzwert(i).Text) And Note_Play(NotenNr) = True Then
                Note_Play(NotenNr) = False
                m.STOPMIDINote(NotenNr)
            End If


            'If ADC(i) < CInt(Noten_Grenzwert(i).Text) And Note_Play(MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text)) = True Then
            'If ADC(i) < 100 And Note_Play(255) = True Then
            'Note_Play(MidiNoteNr(i) + Halbtonverschiebung.Value + CInt(Noten_Verschiebung(i).Text)) = False
            'Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)
            'End If
        Next


        If Messung_gestartet = True And MIDI_SpecialMode.Checked = True Then
            Tackt_Tick()
        End If

        Diagramm_Refresh()

    End Sub

    Private Sub ComboBox_Comport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Comport.SelectedIndexChanged

        'Comport auswählen
        If ComboBox_Comport.SelectedItem <> "" Then
            Button_Connect.Enabled = True
        End If

    End Sub

    'Private Sub MTech010VerticalProgessBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTech010VerticalProgessBar1.Click
    'MessageBox.Show(MousePosition.X)
    'LineShape1.X1 = MousePosition.X
    'LineShape1.Y1 = MousePosition.Y

    'LineShape1.X2 = MousePosition.X + 1000
    'LineShape1.Y2 = MousePosition.Y + 1000
    'LineShape1.BringToFront()
    'LineShape1.
    'LineShape1.Refresh()
    'End Sub

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




    Private Sub Start_Sound() Handles MIDI_Start.Click
        MIDI_Start.Enabled = False
        MIDI_Pausieren.Enabled = True
        MIDI_Save.Enabled = True
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

        'Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
        'Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)

        Tackt.Enabled = True
        Messung_gestartet = True
    End Sub

    Private Sub MIDI_Pausieren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_Pausieren.Click
        If Einstellungen_GroupBox.Enabled = False Then
            Tackt.Enabled = False
            Messung_gestartet = False
            Einstellungen_GroupBox.Enabled = True
            MIDI_Pausieren.Text = "Aufnahme fortsetzen"
        Else
            Tackt.Enabled = True
            Messung_gestartet = True
            Einstellungen_GroupBox.Enabled = False
            MIDI_Pausieren.Text = "Aufnahme pausieren"
        End If
    End Sub

    Private Sub Midi_Write(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_Save.Click

        MIDI_Pausieren.Enabled = False
        MIDI_Save.Enabled = False
        Tackt.Enabled = False
        Messung_gestartet = False

        TacktNr = 0
        Tackt_Achtel = 0
        Tackt_Viertel = 1
        Tackt_Viertel_Counter = 0

        Tackt_Ausgabefenster.Text = ("1  1")

        Me.SaveMIDIDialog.DefaultExt = "MID"
        Me.SaveMIDIDialog.FileName = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Untitled.mid")
        Me.SaveMIDIDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.SaveMIDIDialog.Filter = "VB MIDI files (*.MID)|*.MID"

        Dim result As DialogResult = Me.SaveMIDIDialog.ShowDialog
        If result = DialogResult.OK Then
            Song.Save(SaveMIDIDialog.FileName)
        End If

        Einstellungen_GroupBox.Enabled = True
        MIDI_Start.Enabled = True

    End Sub


#End Region



    Private Sub Tackt_Tick() Handles Tackt.Tick

        'MessageBox.Show(Messintervall.Enabled)

        Dim Note_gespielt As Boolean = False

        For i = 16 To 77 Step 1

            If Note_Play(i) = True Or Button_Note_Play(i) = True Then
                If Notenlaege(i) = 0 Then
                    If DirectPlay_ON.Checked = True Then m.PlayMIDINote(i + Halbtonverschiebung.Value, 100, 0)
                    Song.Tracks(1).AddNoteOnOffEvent(Notenlaege(i), MIDI.Track.NoteEvent.NoteOn, CByte(i), CByte(100))        ' Notenlaege(50)
                End If

                Notenlaege(i) += 0.25
                Note_gespielt = True
                'Notenlaege(0) = 0

            Else

                If Notenlaege(i) > 0 Then
                    m.STOPMIDINote(i + Halbtonverschiebung.Value)
                    Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOff, CByte(i + Halbtonverschiebung.Value), 0)
                    Notenlaege(i) = 0
                End If
            End If

        Next

        If Note_gespielt = False Then Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, 0, 0) ' Notenlaege(0) += 0.125

        Tackt_Achtel = Tackt_Achtel + 1

        If Tackt_Achtel = 8 Then
            If Metronom_ON.Checked Then
                m.CurrentInstrument = "Woodblock"
                m.PlayMIDINote(70, 75, 0.1)
                m.CurrentInstrument = cboInstruments.Text
            ElseIf Metronom_Betont.Checked Then
                m.CurrentInstrument = "Woodblock"
                m.PlayMIDINote(70, 100, 0.1)
                m.CurrentInstrument = cboInstruments.Text
            End If
            TacktNr = TacktNr + 1
            Tackt_Achtel = 0
            Tackt_Viertel = 0
        End If


        Tackt_Viertel_Counter = Tackt_Viertel_Counter + 1

        If Tackt_Viertel_Counter = 2 Then
            Tackt_Viertel = Tackt_Viertel + 1
            Tackt_Viertel_Counter = 0
        End If

        'MessageBox.Show(Tackt_Achtel)


        If Not Metronom_alt = Fix(Tackt_Achtel * Tackt_Naenner_Input.Value / 8) Then
            If Metronom_ON.Checked Or Metronom_Betont.Checked Then
                m.CurrentInstrument = "Woodblock"
                m.PlayMIDINote(70, 50, 0.1)
                m.CurrentInstrument = cboInstruments.Text
            End If
        End If



        Metronom_alt = Fix(Tackt_Achtel * Tackt_Naenner_Input.Value / 8)

        Tackt_Ausgabefenster.Text = (TacktNr + 1 & "  " & Fix(Tackt_Achtel * Tackt_Naenner_Input.Value / 8) + 1) 'Math.Round

    End Sub


    Private Sub BPM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPM.ValueChanged
        Tackt.Interval = (60 / BPM.Value / 4) * 1000
    End Sub

    Private Sub Oktavenverschiebung_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Oktavenverschiebung.SelectedIndexChanged
        Halbtonverschiebung.Value = 12 * (3 - Oktavenverschiebung.SelectedIndex)
    End Sub



    Private Sub Diagramm_Refresh() ' Handles Tackt.Tick

        Dim rnd As New Random

        For i = 0 To 34 Step 1
            Noten_VerticalProgessBar(i).Value = ADC(i) 'rnd.Next(12, 255) 'ADC(i)
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


#Region " Messintervall des Mikrokontrollers "

    ' Obwohl die zwei folgenden Subs sich immer wieder gegenseitig abrufen, gibt es nie eine Endlosschleife, da der Event ValueChanged nur ausgeführt wird, falls wirklich eine Änderung stadtgefunden hat.
    ' Nicht aber wenn man einfach den gleichen Wert mit dem Gleichem ersetzt. Trotz allem kann es vorkommen, da eine Funktion bei einem Value Wechsel 2mal aufgerufen wird.
    ' Jedenfalls Wirklich coole Umrechnung. 2mal das Selbe und doch verschieden. Cooler "Zufall", das gerade beide dieselbe Umrechnungsformel haben.
    ' Ach übrigens: Die NumericUpDowns werden vor allem beim Messintervall, absichtlich stark auf eine Ganzzahl gerundet

    Private Sub Messintervall_NumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Messintervall_NumericUpDown.ValueChanged
        MessungenProS_NumericUpDown.Value = 1000 / Messintervall_NumericUpDown.Value ' Da MessungenProS_NumericUpDown verändert wird, wird automatisch der MessungenProS_NumericUpDown.ValueChanged Event ausgelöst
        Messintervall.Interval = Messintervall_NumericUpDown.Value
    End Sub


    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessungenProS_NumericUpDown.ValueChanged
        Messintervall_NumericUpDown.Value = 1000 / MessungenProS_NumericUpDown.Value ' Da Messintervall_NumericUpDown verändert wird, wird automatisch der Messintervall_NumericUpDown.ValueChanged Event ausgelöst
    End Sub

#End Region


#Region " Special MIDI-Mode"

    Dim Messintervall_Temp As UShort
    Dim Tackt_Zaehler_Temp As Byte
    Dim Tackt_Naenner_Temp As Byte

    Private Sub MIDI_SpecialMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_SpecialMode.CheckedChanged

        If MIDI_SpecialMode.Checked = True Then
            Messintervall_Temp = Messintervall_NumericUpDown.Value
            Tackt_Zaehler_Temp = Tackt_Zaehler_Input.Value
            Tackt_Naenner_Temp = Tackt_Naenner_Input.Value
            Messintervall_NumericUpDown.Value = 20
            Tackt_Zaehler_Input.Value = 4
            Tackt_Naenner_Input.Value = 4
            BPM.Visible = False
            BPM_Label.Text = "Aufnahme BPM:     Möglichst scnell!"
            cboInstruments.Enabled = False
            Tempo_GroupBox.Enabled = False
            Messintervall_GroupBox.Enabled = False
        Else
            cboInstruments.Enabled = True
            Tempo_GroupBox.Enabled = True
            Messintervall_GroupBox.Enabled = True
            Messintervall_NumericUpDown.Value = Messintervall_Temp
            Tackt_Zaehler_Input.Value = Tackt_Zaehler_Temp
            Tackt_Naenner_Input.Value = Tackt_Naenner_Temp
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


#Region "Einstellungsspeicherungsfunktion"

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown    'Wichtig: MyBase.Load geht nicht, da zu früh!

        With My.Settings
            ' Aufnahmemodus
            MIDI_NormalMode.Checked = .MIDI_NormalMode
            'Absichtlicher Overflow
            'Alternative: SpecialMode stadt NormalMode speichern!
            MIDI_SpecialMode.Checked = .MIDI_NormalMode + 1
            cboInstruments.SelectedIndex = .cboInstruments

            ' Tempo
            Tackt_Zaehler_Input.Value = .Tackt_Zaehler_Input
            Tackt_Naenner_Input.Value = .Tackt_Naenner_Input
            BPM.Value = .BPM

            ' Messintervall
            Messintervall_NumericUpDown.Value = .Messintervall_NumericUpDown

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

            ' Messintervall
            .Messintervall_NumericUpDown = Messintervall_NumericUpDown.Value

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


            ' Einstellungen speichern
            .Save()

        End With

    End Sub

#End Region


End Class
