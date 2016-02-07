''' <summary>
''' 
''' </summary>
''' <remarks>Thanks to http://www.skytopia.com/project/articles/midi.html for the crash course on MIDI formats!</remarks>
Public Class MIDI
    ' These are fixed data:
    Dim MIDIHeader() As Byte = {&H4D, &H54, &H68, &H64, &H0, &H0, &H0, &H6}
    Dim SubFormatType() As Byte = {&H0, &H1} ' Type-1 MIDI file (as opposed to Type-0)

    Const ticksPerBeat = &H80
    ' These could be changed (in theory) by the program
    Dim Speed() As Byte = {&H0, ticksPerBeat} ' Default to 128

    Public Tracks As New List(Of Track)
    Public Function AddTrack() As Track
        Dim t As New Track
        Tracks.Add(t)
        Return t
    End Function

    Public Sub Load(ByVal filepath As String)
        ' Maybe later...
    End Sub
    Public Sub Save(ByVal filepath As String)
        Try
            My.Computer.FileSystem.WriteAllBytes(filepath, MIDIHeader, False)
            My.Computer.FileSystem.WriteAllBytes(filepath, SubFormatType, True)

            Dim numTracks As UShort = 0
            For Each t In Tracks
                If t.ValidTrack Then
                    numTracks += 1
                End If
            Next

            Dim byteTracks(0 To 1) As Byte
            byteTracks(0) = CByte((numTracks >> 8) And &HFF)
            byteTracks(1) = CByte((numTracks And &HFF))
            My.Computer.FileSystem.WriteAllBytes(filepath, byteTracks, True)

            My.Computer.FileSystem.WriteAllBytes(filepath, Speed, True)

            For Each t In Tracks
                t.Save(filepath)
            Next
        Catch ex As Exception
            MsgBox("Unable to save the file due to the following error:" & vbCrLf & ex.Message)
            Return
        End Try

    End Sub

    Public Class Track

        Public Enum NoteEvent
            NoteOff = &H8
            NoteOn = &H9

            ' Advanced
            AfterTouch = &HA
            ControlChange = &HB
            ProgramChange = &HC
            ChannelPressure = &HD
            PitchWheel = &HE
        End Enum

        ' These are fixed data
        Dim TrackHeader() As Byte = {&H4D, &H54, &H72, &H6B}
        Dim TrackOut() As Byte = {&H0, &HFF, &H2F, &H0}

        ' These can be changed by the program
        Public TrackData As New List(Of Byte)
        Dim TrackMetadata As New List(Of Byte)
        Public Channel As SByte = -1
        Public Function ValidTrack() As Boolean
            Return True 'Channel >= 0
        End Function


        Public Sub Save(ByVal filepath As String)
            If ValidTrack() Then
                My.Computer.FileSystem.WriteAllBytes(filepath, TrackHeader, True)

                Dim TrackSize As UInt32 = TrackData.Count() + TrackMetadata.Count() + TrackOut.Count()
                Dim byteTrackSize(0 To 3) As Byte
                byteTrackSize(0) = CByte((TrackSize >> 24) And &HFF)
                byteTrackSize(1) = CByte((TrackSize >> 16) And &HFF)
                byteTrackSize(2) = CByte((TrackSize >> 8) And &HFF)
                byteTrackSize(3) = CByte((TrackSize And &HFF))
                My.Computer.FileSystem.WriteAllBytes(filepath, byteTrackSize, True)
                My.Computer.FileSystem.WriteAllBytes(filepath, TrackMetadata.ToArray, True)
                My.Computer.FileSystem.WriteAllBytes(filepath, TrackData.ToArray, True)
                My.Computer.FileSystem.WriteAllBytes(filepath, TrackOut, True)
            End If
        End Sub


        Public Sub AddNoteOnOffEvent(ByVal beatOffset As Double, ByVal ev As NoteEvent, ByVal note As Byte, ByVal volume As Byte)
            If Not ValidTrack() Then Return
            Dim tickOffset As UInt32 = CType(beatOffset * ticksPerBeat, UInt32)
            If ev = NoteEvent.NoteOn OrElse ev = NoteEvent.NoteOff Then
                TrackData.AddRange(TranslateTickTime(tickOffset))
                TrackData.Add((ev << 4) Or (CByte(Channel) And &HF))
                TrackData.Add(note)
                TrackData.Add(volume)
            Else
                ' Error handling here, or other handling
            End If
        End Sub

        Public Sub AddTackt(ByVal Tackt_Zaehler As Byte, ByVal Tackt_Nenner As Byte)

            Dim Tackt_Data() As Byte = {&H0, &HFF, &H58, &H8, &HC, &H2, &H18, &H8}
            Tackt_Data(4) = Hex(Tackt_Zaehler)
            Tackt_Data(3) = Hex(Tackt_Nenner)

            'If Not ValidTrack() Then Return

            For i = 0 To Tackt_Data.Count - 1
                TrackData.Add(CByte(Tackt_Data(i)))
            Next

        End Sub

        Public Sub Add_Instrument(ByVal Instrument As Byte)

            Dim Tackt_Data() As Byte = {&H0, &HC1, &H10, &H0}
            'Tackt_Data(4) = Hex(Tackt_Zaehler)
            'Tackt_Data(3) = Hex(Tackt_Nenner)

            'If Not ValidTrack() Then Return

            For i = 0 To Tackt_Data.Count - 1
                TrackData.Add(CByte(Tackt_Data(i)))
            Next

        End Sub

        Private Function TranslateTickTime(ByVal ticks As UInt32) As Byte()
            Dim value As UInt32 = ticks
            Dim buffer As UInt32
            buffer = ticks And &H7F
            value = value >> 7
            While value > 0
                buffer = buffer << 8
                buffer = buffer Or ((value And &H7F) Or &H80)
                value = value >> 7
            End While

            ' The encoded values are now in the buffer backwards, so retrieve them...
            Dim blist As New List(Of Byte)
            While True
                blist.Add(CByte(&HFF And buffer))
                If (buffer And &H80) > 0 Then
                    buffer = buffer >> 8
                Else
                    Exit While
                End If
            End While

            Return blist.ToArray
        End Function
    End Class

End Class
