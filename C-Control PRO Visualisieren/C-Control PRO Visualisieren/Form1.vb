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


    Private Sub Form1_Load_main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Chart()

        'Comports suchen
        For Each Me.port In ports
            ComboBox_Comport.Items.Add(port)
        Next port

        ComboBox_Comport.Sorted = True

        'Buttons sperren
        Button_Disconnect.Enabled = False
        Button_Connect.Enabled = False


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

        'MessageBox.Show("")

        For i = 1 To 29
            Serial_Read = SerialPort1.ReadByte
            ADC(i) = Serial_Read
        Next

        ListBox1.Items.Add(ADC(1) & ", " & ADC(2) & ", " & ADC(3) & ", " & ADC(4) & ", " & ADC(5) & ", " & ADC(6))

        'MessageBox.Show("")

        'If Not SerialPort1.ReadByte = 0 Then
        'MessageBox.Show("Error")
        'Do
        'If SerialPort1.ReadByte = 0 Then Exit Do
        'Loop
        'End If

        'ListBox1.Items.Add(Serial_Bin)
        'ListBox1.Items.Add(SerialPort1.ReadByte)

        'MessageBox.Show(Serial_Bin)
        'Empfangene Daten entschlüsseln
        'For i1 = 0 To ADC_Anzahl
        'For i2 = 0 To 3
        'Serial_Entschluesselt = BinToInt(Microsoft.VisualBasic.Mid(Serial_Bin, (i1 * 10 + i2 * 10) + 1, 10))
        'Serial_Entschluesselt = Format(5 / 1023 * Serial_Entschluesselt, "0.000")
        'ADC(i1) = BinToInt(Microsoft.VisualBasic.Mid(Serial_Bin, (i1 * 10) + (i2 * 10) + 1, 10))
        'ListBox1.Items.Add(ADC(i1))
        'Next
        'Next

        'ListBox1.Items.Add(ADC(1))

        Dim NoteP As Boolean

        If ADC(0) > 99 Then
            NoteP = True
            Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
        End If


        If ADC(0) < 100 And NoteP = True Then
            NoteP = False
            Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)
        End If


        MTech010VerticalProgessBar2.Value = ADC(1)
        TextBox2.Text = (ADC(1))
        'Klavierdiagramm_Refresh()

    End Sub


    Private Sub ComboBox_Comport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Comport.SelectedIndexChanged

        'Comport auswählen
        If ComboBox_Comport.SelectedItem <> "" Then
            Button_Connect.Enabled = True
        End If

    End Sub


    Private Sub MTech010VerticalProgessBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTech010VerticalProgessBar1.Click
        'MessageBox.Show(MousePosition.X)
        'LineShape1.X1 = MousePosition.X
        'LineShape1.Y1 = MousePosition.Y

        'LineShape1.X2 = MousePosition.X + 1000
        'LineShape1.Y2 = MousePosition.Y + 1000
        'LineShape1.BringToFront()
        'LineShape1.
        'LineShape1.Refresh()
    End Sub



    Function IntToBin(ByVal IntegerNumber As Long)
        Dim BinValue As Object = Nothing
        Dim TempValue As Object = Nothing
        Dim IntNum = IntegerNumber
        Do
            'Use the Mod operator to get the current binary digit from the

            TempValue = IntNum Mod 2
            BinValue = CStr(TempValue) + BinValue

            'Divide the current number by 2 and get the integer result
            IntNum = IntNum \ 2
        Loop Until IntNum = 0

        Return BinValue

    End Function


    Function BinToInt(ByVal BinaryNumber As String)
        Dim TempValue As Object = Nothing
        Dim Length

        'Get the length of the binary string
        Length = Len(BinaryNumber)

        'Convert each binary digit to its corresponding integer value
        'and add the value to the previous sum
        'The string is parsed from the right (LSB - Least Significant Bit)
        'to the left (MSB - Most Significant Bit)
        For x = 1 To Length
            TempValue = TempValue + Val(Mid(BinaryNumber, Length - x + 1, 1)) * 2 ^ (x - 1)
        Next

        Return TempValue

    End Function












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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Song.AddTrack()
        Song.AddTrack()
        Song.AddTrack()
        Song.AddTrack()

        InitializeNotes()
    End Sub

    Private Sub Midi_Write(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

        Tackt.Enabled = False

        Me.SaveMIDIDialog.DefaultExt = "MID"
        Me.SaveMIDIDialog.FileName = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Untitled.mid")
        Me.SaveMIDIDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.SaveMIDIDialog.Filter = "VB MIDI files (*.MID)|*.MID"

        Dim result As DialogResult = Me.SaveMIDIDialog.ShowDialog
        If result = DialogResult.OK Then
            Song.Save(SaveMIDIDialog.FileName)
        End If

    End Sub

    Private Sub Tackt_Tick() Handles Tackt.Tick

        'Song.Tracks(1).AddRange(0.125)
        Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOn, CByte(NumberOfNotes), 0)

        Tackt_Achtel = Tackt_Achtel + 1

        If Tackt_Achtel = 8 Then
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


        Tackt_Ausgabefenster.Text = (TacktNr + 1 & "  " & Tackt_Viertel)

    End Sub


    Private Sub Start_Sound() Handles MIDI_Start.Click
        Song.Tracks(1).Channel = 0

        If Not Song.Tracks(1).ValidTrack Then
            MessageBox.Show("Error")
        End If

        Song.Tracks(1).TrackData.Clear()

        Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
        Song.Tracks(1).AddNoteOnOffEvent(1, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)

        Tackt.Enabled = True
    End Sub



    'Song.Tracks(index).AddNoteOnOffEvent(restBeats, MIDI.Track.NoteEvent.NoteOn, CByte(note), CByte(volume))
    'Song.Tracks(index).AddNoteOnOffEvent(beats, MIDI.Track.NoteEvent.NoteOff, CByte(note), 0)

    Private Sub StartN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteC.MouseDown
        Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOn, CByte(50), CByte(100))
    End Sub

    Private Sub StopN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteC.MouseUp
        Song.Tracks(1).AddNoteOnOffEvent(0.125, MIDI.Track.NoteEvent.NoteOff, CByte(50), 0)
    End Sub



















    Private Sub Klavierdiagramm_Refresh()
        MTech010VerticalProgessBar1.Value = ADC(0)
        TextBox1.Text = ADC(0)
        MTech010VerticalProgessBar2.Value = ADC(1)
        TextBox2.Text = ADC(1)
        MTech010VerticalProgessBar3.Value = ADC(2)
        TextBox3.Text = ADC(2)
        MTech010VerticalProgessBar4.Value = ADC(3)
        TextBox4.Text = ADC(3)
        MTech010VerticalProgessBar5.Value = ADC(4)
        TextBox5.Text = ADC(4)
        MTech010VerticalProgessBar6.Value = ADC(5)
        TextBox6.Text = ADC(5)
        MTech010VerticalProgessBar7.Value = ADC(6)
        TextBox7.Text = ADC(6)

        MTech010VerticalProgessBar8.Value = ADC(7)
        TextBox8.Text = ADC(7)
        MTech010VerticalProgessBar9.Value = ADC(8)
        TextBox9.Text = ADC(8)
        MTech010VerticalProgessBar1.Value = ADC(9)
        TextBox10.Text = ADC(9)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)

        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)

        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)

        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
        MTech010VerticalProgessBar1.Value = ADC(0)
    End Sub






    Dim Chanched_Unlooked As Boolean 'Chart1_Chanched Fehlerschutz! Wichtig!

    Dim Chart1_Art_Index_2D As Byte() = {10, 11, 12, 7, 8, 9, 14, 15, 16, 3, 4, 5, 13, 28}

    Dim Chart1_Art_Index_3D As Byte() = {10, 11, 12, 7, 8, 9, 13, 14, 15, 16, 28} 'Numärische Reihenfolge: 7, 8, 9, 10, 11, 12, 20, 24, 25, 26, 28

    Dim CHa As Short
    Dim Chart1_Art_Beschreibung = _
            {"Punktdiagramm", "FastPoint-Diagramm", "Blasendiagramm", "Liniendiagramm", "Splinediagramm", "StepLine-Diagramm", "FastLine-Diagramm", _
             "Balkendiagramm", "Stapel Balkendiagramm", "Stapel Balkendiagramm (100 %)", "Säulendiagramm", "Stapel Säulendiagramm", "Stapel Säulendiagramm (100 %)", _
             "Flächendiagramm", "Splineflächendiagramm", "Stapel Flächendiagramm", "Stapel Flächendiagramm (100 %)", "Kreisdiagramm", "Ringdiagramm", "Kursdiagramm", _
             "Kerzendiagramm", "Bereichsdiagramm", "Splinebereichsdiagramm", "RangeBar-Diagramm", "Bereichssäulendiagramm", "Netzdiagramm", "Polardiagramm", "Fehlerindikatorendiagramm", _
             "Boxplotdiagramm", "Renko-Diagramm", "ThreeLineBreak-Diagramm", "Kagi-Diagramm", "PointAndFigure-Diagramm", "Trichterdiagramm", "Pyramidendiagramm"}


    'Dim Chart1_Art_Index(40)
    'Dim Chart1_Art_Beschreibung(40) As String

    Dim ArialDiaT As Font = New Font("Arial", 11, FontStyle.Bold) 'Diagrammtitel
    Dim Chart1_Titles_BGrondC1 As Color = Color.FromArgb(192, 255, 255)

    Dim Chart_Noten As Byte() = {24, 2, 32, 4}
    Dim Chart_Max = 4
    Dim III = 0


    Private Sub Chart() Handles Chart1.Click

        Chart1.Series.Clear()


        For i1 = 0 To 15
            Chart1.Series.Add(i1)
            Chart1.Series(i1).ChartType = DataVisualization.Charting.SeriesChartType.Column
            For i2 = 0 To 32
                If 10 * Rnd() > 8 Then Chart1.Series(i1).Points.AddY(60 * Rnd()) Else Chart1.Series(i1).Points.AddY(0)
            Next
        Next


        'Chart1.Series(0).Points.AddXY(0, 0)
        'Chart1.Series(0).Points.AddXY(1, 1)
        'Chart1.Series(0).Points.AddXY(2, 6)
        'Chart1.Series(0).Points.AddXY(3, 3)
        'Chart1.Series(0).Points.AddXY(4, 4)

        'Chart1.Series(0).Points.AddXY(0, 0)
        'Chart1.Series(0).Points.AddXY(0, 0)
        'Chart1.Series(0).Points.AddXY(0, 0)
        'Chart1.Series(0).Points.AddXY(0, 0)
        'Chart1.Series(0).Points.AddXY(0, 0)
        'Chart1.Series(0).Points.AddXY(0, 0)

        'Chart1.Series(0).Points.AddXY(0, 60 * Rnd())
        'Chart1.Series(0).Points.AddXY(0, 60 * Rnd())
        'Chart1.Series(0).Points.AddXY(0, 60 * Rnd())
        'Chart1.Series(0).Points.AddXY(0, 60 * Rnd())

        For i = 0 To Chart1.ChartAreas.Count - 1 Step 1
            Chart1.ChartAreas(i).Area3DStyle.Enable3D = True
            Chart1.ChartAreas(i).Area3DStyle.PointDepth = Chart1_3D_PointDepth.Value
            Chart1.ChartAreas(i).Area3DStyle.PointGapDepth = Chart1_3D_PointGrabDepth.Value
            Chart1.ChartAreas(i).Area3DStyle.Inclination = Chart1_3D_Neigungswinkel.Value
            Chart1.ChartAreas(i).Area3DStyle.Rotation = Chart1_3D_Rotation.Value
            'Chart1.ChartAreas(i).Area3DStyle.WallWidth = 5
            'Chart1.ChartAreas(i).Area3DStyle.LightStyle = LightStyle.Realistic
        Next

    End Sub

    Private Sub Funk_Chart1_3D_Neigungswinkel() Handles Chart1_3D_Neigungswinkel.ValueChanged
        For i = 0 To Chart1.ChartAreas.Count - 1 Step 1
            Chart1.ChartAreas(i).Area3DStyle.Inclination = Chart1_3D_Neigungswinkel.Value
        Next
    End Sub

    Private Sub Funk_Chart1_3D_Chart1_3D_Rotation() Handles Chart1_3D_Rotation.ValueChanged
        For i = 0 To Chart1.ChartAreas.Count - 1 Step 1
            Chart1.ChartAreas(i).Area3DStyle.Rotation = Chart1_3D_Rotation.Value
        Next
    End Sub

    Private Sub Funk_Chart1_3D_Chart1_3D_PountDepth() Handles Chart1_3D_PointDepth.ValueChanged
        For i = 0 To Chart1.ChartAreas.Count - 1 Step 1
            Chart1.ChartAreas(i).Area3DStyle.PointDepth = Chart1_3D_PointDepth.Value
        Next
    End Sub

    Private Sub Funk_Chart1_3D_Chart1_3D_PountGrabDepth() Handles Chart1_3D_PointGrabDepth.ValueChanged
        For i = 0 To Chart1.ChartAreas.Count - 1 Step 1
            Chart1.ChartAreas(i).Area3DStyle.PointGapDepth = Chart1_3D_PointGrabDepth.Value
        Next
    End Sub

    Private Sub Funk_Chart1_3D_Chart1_3D_LightStyle() Handles Chart1_3D_LightStyle.CheckStateChanged
        For i = 0 To Chart1.ChartAreas.Count - 1 Step 1
            Chart1.ChartAreas(i).Area3DStyle.LightStyle = Chart1_3D_LightStyle.CheckState
        Next
    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    SerialPort1.Write(1)
    '    ListBox1.Items.Add("Hallo")
    'End Sub
End Class







