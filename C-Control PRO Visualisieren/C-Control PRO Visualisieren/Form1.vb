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

        COM_Search()

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
        Tackt.Enabled = True
    End Sub

    Private Sub Form1_Load1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        META_Copyright_Input.Text = My.Settings.Save_Settings
    End Sub

    Private Sub Form1_FormClosing1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        With My.Settings

            ' Aufnahmemodus
            .Save_Settings = MIDI_NormalMode.Checked
            .Save_Settings = cboInstruments.SelectedIndex

            ' Tempo
            .Save_Settings = Tackt_Zaehler_Input.Value
            .Save_Settings = Tackt_Naenner_Input.Value
            .Save_Settings = BPM.Value

            ' Messintervall
            .Save_Settings = Messintervall_NumericUpDown.Value

            ' Tonhöhenverschiebung
            .Save_Settings = Halbtohnverschiebung.Value

            ' META
            .Save_Settings = META_Dateinamen_Input.Text
            .Save_Settings = META_Autor_Input.Text
            .Save_Settings = META_Spurnamen_Input.Text
            .Save_Settings = META_Copyright_Input.Text
            .Save_Settings = META_Bemerkung_Input.Text

            ' Metronom

            ' Direct Play
            .Save_Settings =
            .Save_Settings = hsbVolume.Value
            .Save_Settings = hsbPan.Value
            .Save_Settings = hsbModWheel.Value

            ' ToolTip
            .Save_Settings = ToolTip_ON.Checked

            ' Tonart Klappen
            .Save_Settings = C_Klappe.Value
            .Save_Settings = D_Klappe.Value
            .Save_Settings = E_Klappe
            .Save_Settings = F_Klappe
            .Save_Settings = G_Klappe
            .Save_Settings = A_Klappe
            .Save_Settings = H_Klappe


            ' Einstellungen speichern
            .Save()

        End With

    End Sub


    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click, Me.FormClosing

        'trennen
        Tackt.Enabled = False
        Com_Search_Timer.Enabled = True
        Button_Connect.Enabled = True
        Button_Disconnect.Enabled = False
        ComboBox_Comport.Enabled = True
        SerialPort1.Close()

    End Sub

    'ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs
    Private Sub SerialPort1_DataReceived() Handles Messintervall.Tick 'SerialPort1.DataReceived

        Dim MidiNoteNr = { _
            16, 18, 20, 21, 23, 25, 27, _
            28, 30, 32, 33, 35, 37, 39, _
            40, 42, 44, 45, 47, 49, 51, _
            52, 54, 56, 57, 59, 61, 63, _
            64, 66, 68, 69, 71, 73, 75}


        Dim Noten_Grenzwert() As TextBox = { _
            C2_Grenzwert, D2_Grenzwert, E2_Grenzwert, F2_Grenzwert, G2_Grenzwert, A2_Grenzwert, H2_Grenzwert, _
            C3_Grenzwert, D3_Grenzwert, E3_Grenzwert, F3_Grenzwert, G3_Grenzwert, A3_Grenzwert, H3_Grenzwert, _
            C4_Grenzwert, D4_Grenzwert, E4_Grenzwert, F4_Grenzwert, G4_Grenzwert, A4_Grenzwert, H4_Grenzwert, _
            C5_Grenzwert, D5_Grenzwert, E5_Grenzwert, F5_Grenzwert, G5_Grenzwert, A5_Grenzwert, H5_Grenzwert, _
            C6_Grenzwert, D6_Grenzwert, E6_Grenzwert, F6_Grenzwert, G6_Grenzwert, A6_Grenzwert, H6_Grenzwert}


        Dim Noten_Verschiebung() As TextBox = { _
            C2_Verschiebung, D2_Verschiebung, E2_Verschiebung, F2_Verschiebung, G2_Verschiebung, A2_Verschiebung, H2_Verschiebung, _
            C3_Verschiebung, D3_Verschiebung, E3_Verschiebung, F3_Verschiebung, G3_Verschiebung, A3_Verschiebung, H3_Verschiebung, _
            C4_Verschiebung, D4_Verschiebung, E4_Verschiebung, F4_Verschiebung, G4_Verschiebung, A4_Verschiebung, H4_Verschiebung, _
            C5_Verschiebung, D5_Verschiebung, E5_Verschiebung, F5_Verschiebung, G5_Verschiebung, A5_Verschiebung, H5_Verschiebung, _
            C6_Verschiebung, D6_Verschiebung, E6_Verschiebung, F6_Verschiebung, G6_Verschiebung, A6_Verschiebung, H6_Verschiebung}



        Dim Serial_Read As String = ""

        'Hier werden die Daten empfangen
        In_Buffer = 0
        Control.CheckForIllegalCrossThreadCalls = False

        SerialPort1.Write(1)

        For i = 0 To 31
            Serial_Read = SerialPort1.ReadByte
            ADC(i) = Serial_Read
        Next


        For i = 0 To 31
            If ADC(i) >= CInt(Noten_Grenzwert(i).Text) Then
                Note_Play(MidiNoteNr(i) + Halbtohnverschiebung.Value + CInt(Noten_Verschiebung(i).Text)) = True
                Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
            End If


            If ADC(i) < 100 And Note_Play(255) = True Then
                Note_Play(MidiNoteNr(i) + Halbtohnverschiebung.Value + CInt(Noten_Verschiebung(i).Text)) = False
                Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)
            End If
        Next

        If MIDI_SpecialMode.Checked = True Then Tackt_Tick()


        'MTech010VerticalProgessBar2.Value = ADC(1)
        D2_Wert.Text = (ADC(1))
        Klavierdiagramm_Refresh()

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


#End Region




    Private Sub Tackt_Tick() Handles Tackt.Tick


        Dim Note_gespielt As Boolean = False

        For i = 16 To 77 Step 1

            If Note_Play(i) = True Then
                If Notenlaege(i) = 0 Then
                    m.PlayMIDINote(i + Halbtohnverschiebung.Value, 100, 0)
                    Song.Tracks(1).AddNoteOnOffEvent(Notenlaege(i), MIDI.Track.NoteEvent.NoteOn, CByte(i), CByte(100))        ' Notenlaege(50)
                End If

                Notenlaege(i) += 0.25
                Note_gespielt = True
                'Notenlaege(0) = 0

            Else

                If Notenlaege(i) > 0 Then
                    m.STOPMIDINote(i + Halbtohnverschiebung.Value)
                    Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOff, CByte(i + Halbtohnverschiebung.Value), 0)
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


        Dim Noten_Wert() As TextBox = { _
            C2_Wert, D2_Wert, E2_Wert, F2_Wert, G2_Wert, A2_Wert, H2_Wert, _
            C3_Wert, D3_Wert, E3_Wert, F3_Wert, G3_Wert, A3_Wert, H3_Wert, _
            C4_Wert, D4_Wert, E4_Wert, F4_Wert, G4_Wert, A4_Wert, H4_Wert, _
            C5_Wert, D5_Wert, E5_Wert, F5_Wert, G5_Wert, A5_Wert, H5_Wert, _
            C6_Wert, D6_Wert, E6_Wert, F6_Wert, G6_Wert, A6_Wert, H6_Wert}



        For i = 0 To 34 Step 1
            Noten_VerticalProgessBar(i).Value = ADC(i) 'rnd.Next(12, 255) 'ADC(i)
            Noten_Wert(i).Text = ADC(i)
        Next


    End Sub





    Private Sub Oktavenverschiebung_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Oktavenverschiebung.SelectedIndexChanged
        Halbtohnverschiebung.Value = 12 * (3 - Oktavenverschiebung.SelectedIndex)
    End Sub




#Region " cls MIDI "

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
            & vbCrLf & "Die laufende Aufnahme wird dadurch gelöscht!", "Wirklich beenden?", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub


#End Region



#Region " Buttons Events "


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



    Private Sub C5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5_Button.Click
        Button_Note(52)
    End Sub

    Private Sub D5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5_Button.Click
        Button_Note(54)
    End Sub

    Private Sub E5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5_Button.Click
        Button_Note(56)
    End Sub

    Private Sub F5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5_Button.Click
        Button_Note(57)
    End Sub

    Private Sub G5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5_Button.Click
        Button_Note(59)
    End Sub

    Private Sub A5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5_Button.Click
        Button_Note(61)
    End Sub

    Private Sub H5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5_Button.Click
        Button_Note(63)
    End Sub



    Private Sub C6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6_Button.Click
        Button_Note(64)
    End Sub

    Private Sub D6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6_Button.Click
        Button_Note(66)
    End Sub

    Private Sub E6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6_Button.Click
        Button_Note(68)
    End Sub

    Private Sub F6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6_Button.Click
        Button_Note(69)
    End Sub

    Private Sub G6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6_Button.Click
        Button_Note(71)
    End Sub

    Private Sub A6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6_Button.Click
        Button_Note(73)
    End Sub

    Private Sub H6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6_Button.Click
        Button_Note(75)
    End Sub

#End Region


    Private Sub Button_Note(ByVal NoteNr As Byte)
        m.PlayMIDINote(NoteNr + Halbtohnverschiebung.Value + Verschiebung(NoteNr), 100, 0)
        Note_Play(NoteNr) = True
    End Sub






    Private Sub C2_Grenzwert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C2_Grenzwert.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 32, 46
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select
    End Sub





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


#Region "Spetial MIDI-Mode"


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


End Class










