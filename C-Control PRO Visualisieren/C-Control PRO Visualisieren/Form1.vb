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

    'Datenspeicher f�r eingehende Daten
    Dim In_Buffer As Short

    Dim TacktNr As Short
    Dim Tackt_Achtel As Byte

    Dim Tackt_Viertel As Byte = 1
    Dim Tackt_Viertel_Counter As Byte

    'Annahme: Maaximal 43 ADC Sygnale! Auf dem Form k�nnen jedoch nur 35 angezeigt werden!
    Dim ADC_Anzahl As Byte = 28
    Dim ADC(43) As UShort

    Dim Notenlaege(255) As Single
    Dim Note_Play(255) As Boolean
    Dim Verschiebung(255) As Byte

    Dim Metronom As Byte
    Dim Metronom_alt As Byte


    Private Sub Form1_Load_main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Klavierdiagramm_Refresh()
        'MessageBox.Show(myCoolControls(0).Text)

        'ToolTip1.SetToolTip(Button1, "Das ist ein Button")
        'ToolTip1.SetToolTip(Button2, "Das ist ein Button")
        'ToolTip1.SetToolTip(Button3, "Das ist ein Button")

        Tackt.Interval = (60 / BPM.Value / 4) * 1000

        'Comports suchen
        For Each Me.port In ports
            ComboBox_Comport.Items.Add(port)
        Next port

        ComboBox_Comport.Sorted = True

        'Buttons sperren
        Button_Disconnect.Enabled = False
        Button_Connect.Enabled = False

        Song.AddTrack()
        Song.AddTrack()

        InitializeNotes()


    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click

        'verbinden
        Try

            'Buttons freigeben-/sperren
            Button_Connect.Enabled = False
            Button_Disconnect.Enabled = True
            ComboBox_Comport.Enabled = False

            'Comport �ffnen
            SerialPort1.PortName = ComboBox_Comport.Text
            SerialPort1.BaudRate = 115200 'Baudrate
            SerialPort1.DataBits = 8
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.Open()

        Catch ex As Exception

            'Fehlermeldung 
            MessageBox.Show("Achtung die Schnittstelle konnte nicht ge�ffnet werden! " + e.ToString _
                          , "Ausnahmefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button_Connect.Enabled = True
            Button_Disconnect.Enabled = False
            ComboBox_Comport.Enabled = True

        End Try

        Timer1.Enabled = True
        'SerialPort1_DataReceived()
        'SerialPort1.Write(1)
    End Sub


    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click, Me.FormClosing

        'trennen
        Button_Connect.Enabled = True
        Button_Disconnect.Enabled = False
        ComboBox_Comport.Enabled = True
        SerialPort1.Close()

    End Sub

    'ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs
    Private Sub SerialPort1_DataReceived() Handles Timer1.Tick 'SerialPort1.DataReceived

        Dim Serial_Read As String = ""

        'Hier werden die Daten empfangen
        In_Buffer = 0
        Control.CheckForIllegalCrossThreadCalls = False

        SerialPort1.Write(1)

        For i = 1 To 29
            Serial_Read = SerialPort1.ReadByte
            ADC(i) = Serial_Read
        Next

        Dim NoteP As Boolean

        If ADC(0) > 99 Then
            NoteP = True
            Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
        End If


        If ADC(0) < 100 And NoteP = True Then
            NoteP = False
            Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)
        End If


        'MTech010VerticalProgessBar2.Value = ADC(1)
        D2_Wert.Text = (ADC(1))
        Klavierdiagramm_Refresh()

    End Sub


    Private Sub ComboBox_Comport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Comport.SelectedIndexChanged

        'Comport ausw�hlen
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


    Private Sub Tackt_Tick() Handles Tackt.Tick

        Dim Note_gespielt As Boolean = False

        For i = 16 To 77 Step 1

            If Note_Play(i) = True Then
                If Notenlaege(i) = 0 Then
                    m.PlayMIDINote(i + NumericUpDown1.Value, 100, 0)
                    Song.Tracks(1).AddNoteOnOffEvent(0, MIDI.Track.NoteEvent.NoteOn, CByte(i + NumericUpDown1.Value), CByte(100))
                End If

                Notenlaege(i) += 0.25
                Note_gespielt = True
                'Notenlaege(0) = 0

            Else

                If Notenlaege(i) > 0 Then
                    m.STOPMIDINote(i + NumericUpDown1.Value)
                    Song.Tracks(1).AddNoteOnOffEvent(Notenlaege(50), MIDI.Track.NoteEvent.NoteOff, CByte(i + NumericUpDown1.Value), 0)
                    Notenlaege(i) = 0
                End If
            End If

        Next

        If Note_gespielt = False Then Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, 0, 0) 'Notenlaege(0) += 0.125

        'If Notenlaege(50) = 0 Then
        'If NoteC_Klick = True Then
        'Song.Tracks(1).AddNoteOnOffEvent(0, MIDI.Track.NoteEvent.NoteOn, CByte(50 + NumericUpDown1.Value), CByte(100))
        'End If

        'Else
        'If NoteC_Klick = False Then
        'Song.Tracks(1).AddNoteOnOffEvent(Notenlaege(50), MIDI.Track.NoteEvent.NoteOff, CByte(50 + NumericUpDown1.Value), 0)
        'Notenlaege(50) = 0
        'End If
        'End If

        'Song.Tracks(1).AddRange(0.125)
        'Song.Tracks(1).AddNoteOnOffEvent(0.25, MIDI.Track.NoteEvent.NoteOn, CByte(NumberOfNotes), 0)

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
        Song.Tracks(0).Text(1, META_Dateiname_Input.Text)
        Song.Tracks(0).Text(1, META_Autor_Input.Text)
        Song.Tracks(0).Text(2, META_Copyright_Input.Text)
        Song.Tracks(0).Text(1, META_Bemerkung_Input.Text)
        Song.Tracks(0).AddTackt(Tackt_Zaehler_Input.Value, Tackt_Naenner_Input.Value)

        Song.Tracks(1).TrackData.Clear()
        Song.Tracks(1).Zuordnung(1)
        Song.Tracks(1).Text(1, cboInstruments.SelectedText)
        Song.Tracks(1).Text(3, META_SpurnamenRH_Input.Text)
        Song.Tracks(1).Text(4, cboInstruments.SelectedText)
        Song.Tracks(1).Add_Instrument(cboInstruments.SelectedIndex)

        'Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
        'Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)

        Tackt.Enabled = True
    End Sub

    Private Sub MIDI_Pausieren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_Pausieren.Click
        If Einstellungen_GroupBox.Enabled = False Then
            Tackt.Enabled = False
            Einstellungen_GroupBox.Enabled = True
            MIDI_Pausieren.Text = "Aufnahme fortsetzen"
        Else
            Tackt.Enabled = True
            Einstellungen_GroupBox.Enabled = False
            MIDI_Pausieren.Text = "Aufnahme pausieren"
        End If
    End Sub

    Private Sub Midi_Write(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_Save.Click

        MIDI_Pausieren.Enabled = False
        MIDI_Save.Enabled = False
        Tackt.Enabled = False

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

    'Song.Tracks(index).AddNoteOnOffEvent(restBeats, MIDI.Track.NoteEvent.NoteOn, CByte(note), CByte(volume))
    'Song.Tracks(index).AddNoteOnOffEvent(beats, MIDI.Track.NoteEvent.NoteOff, CByte(note), 0)

    Private Sub StartN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteC.MouseDown
        Note_Play(40) = True
        '    Notenlaege(50) = Environment.TickCount()
        '   'Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOn, CByte(50 + NumericUpDown1.Value), CByte(100))
    End Sub

    Private Sub StopN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteC.MouseUp
        Note_Play(40) = False
        '    Song.Tracks(1).AddNoteOnOffEvent(0, MIDI.Track.NoteEvent.NoteOn, CByte(50 + NumericUpDown1.Value), CByte(100))
        '    Song.Tracks(1).AddNoteOnOffEvent((Environment.TickCount() - Notenlaege(50)) / 250, MIDI.Track.NoteEvent.NoteOff, CByte(50 + NumericUpDown1.Value), 0)
    End Sub



    Private Sub BPM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPM.ValueChanged
        Tackt.Interval = (60 / BPM.Value / 4) * 1000
    End Sub















    Private Sub Klavierdiagramm_Refresh() Handles Tackt.Tick

        Dim rnd As New Random

        Dim Noten_VerticalProgessBar() As MTech010VerticalProgessBar = { _
            C2_VerticalProgessBar, D2_VerticalProgessBar, E2_VerticalProgessBar, F2_VerticalProgessBar, G2_VerticalProgessBar, A2_VerticalProgessBar, H2_VerticalProgessBar, _
            C3_VerticalProgessBar, D3_VerticalProgessBar, E3_VerticalProgessBar, F3_VerticalProgessBar, G3_VerticalProgessBar, A3_VerticalProgessBar, H3_VerticalProgessBar, _
            C4_VerticalProgessBar, D4_VerticalProgessBar, E4_VerticalProgessBar, F4_VerticalProgessBar, G4_VerticalProgessBar, A4_VerticalProgessBar, H4_VerticalProgessBar, _
            C5_VerticalProgessBar, D5_VerticalProgessBar, E5_VerticalProgessBar, F5_VerticalProgessBar, G5_VerticalProgessBar, A5_VerticalProgessBar, H5_VerticalProgessBar, _
            C6_VerticalProgessBar, D6_VerticalProgessBar, E6_VerticalProgessBar, F6_VerticalProgessBar, G6_VerticalProgessBar, A6_VerticalProgessBar, H6_VerticalProgessBar}


        For i = 0 To 34 Step 1
            Noten_VerticalProgessBar(i).Value = rnd.Next(12, 255) 'ADC(i)
            C2_Wert.Text = ADC(i)
        Next


    End Sub




    Private Sub Tonhoehenverschiebung_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tonhoehenverschiebung.SelectedIndexChanged
        NumericUpDown1.Value = 12 * (Tonhoehenverschiebung.SelectedIndex - 4)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Start_Sound(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIDI_Start.Click

    End Sub






    Dim m As New clsMIDI

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillInstrumentCombo()
    End Sub
    Private Sub lblClickMe_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblClickMe.MouseDown
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

#Region " Play and Stop Specific Note "
    'This is an example of how to Play a Specific Note and then stop it
    Private Sub btnPlay1Note_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay1Note.Click
        m.CurrentInstrument = "Woodblock"
        m.PlayMIDINote(70, 127, CInt(cboDuration.Text))
        'm.CurrentInstrument = 1
        'm.NoteDuration = 1
    End Sub
    Private Sub btnStopNoteAbove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopNoteAbove.Click
        m.STOPMIDINote(70) 'Stop Note 70
    End Sub
#End Region

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As  _
          System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Tackt.Enabled Then
            Dim result As DialogResult = MessageBox.Show("Wollen Sie das Programm wirklich beenden?" _
            & vbCrLf & "Die laufende Aufnahme wird dadurch gel�scht!", "Wirklich beenden?", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub







































    Private Sub C2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2_Button.Click
        Button_Note(16)
    End Sub

    Private Sub D2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2_Button.Click
        Button_Note(18)
    End Sub

    Private Sub E2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2_Button.Click
        Button_Note(20)
    End Sub

    Private Sub F2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2_Button.Click
        Button_Note(21)
    End Sub

    Private Sub G2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2_Button.Click
        Button_Note(23)
    End Sub

    Private Sub A2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2_Button.Click
        Button_Note(25)
    End Sub

    Private Sub H2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2_Button.Click
        Button_Note(27)
    End Sub


    Private Sub C3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3_Button.Click
        Button_Note(28)
    End Sub

    Private Sub D3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3_Button.Click
        Button_Note(30)
    End Sub

    Private Sub E3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3_Button.Click
        Button_Note(32)
    End Sub

    Private Sub F3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3_Button.Click
        Button_Note(33)
    End Sub

    Private Sub G3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3_Button.Click
        Button_Note(35)
    End Sub

    Private Sub A3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3_Button.Click
        Button_Note(37)
    End Sub

    Private Sub H3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3_Button.Click
        Button_Note(39)
    End Sub


    Private Sub C4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4_Button.Click
        Button_Note(40)
    End Sub

    Private Sub D4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4_Button.Click
        Button_Note(42)
    End Sub

    Private Sub E4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4_Button.Click
        Button_Note(44)
    End Sub

    Private Sub F4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4_Button.Click
        Button_Note(45)
    End Sub

    Private Sub G4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4_Button.Click
        Button_Note(47)
    End Sub

    Private Sub A4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4_Button.Click
        Button_Note(49)
    End Sub

    Private Sub H4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4_Button.Click
        Button_Note(51)
    End Sub




    Private Sub Button_Note(ByVal NoteNr As Byte)
        m.PlayMIDINote(NoteNr + NumericUpDown1.Value + Verschiebung(NoteNr), 100, 0)
        Note_Play(NoteNr) = True
    End Sub






    Private Sub C2_Grenzwert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C2_Grenzwert.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 32, 46
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdr�cken
                e.Handled = True
        End Select
    End Sub










End Class










