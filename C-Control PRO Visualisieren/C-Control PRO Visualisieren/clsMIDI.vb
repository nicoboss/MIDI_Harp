Option Strict Off
Option Explicit On
Imports System.Runtime.InteropServices

Public Class clsMIDI

#Region " MIDI "
    'Inst.PlayNote(60 + e.X, 53)
    Private insts() As String = Instrument.OutDeviceNames
    Private WithEvents Inst As New Instrument
    Dim xInstrument As String
    ''' <summary>
    ''' Gets or sets the Current Instrument.  For a list of the instrument names, search for GMInstrumentNames in clsMIDI.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CurrentInstrument() As String
        Get
            Return xInstrument
        End Get
        Set(ByVal Value As String)
            xInstrument = Value
        End Set
    End Property
    Dim iVolume As Integer  '(0 - 127) Low to High Volume
    ''' <summary>
    ''' Gets or sets Volume.  Volume - (0 - 127) Low to High Volume. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Volume() As Integer
        Get
            Return iVolume
        End Get
        Set(ByVal value As Integer)
            iVolume = value
            Inst.Volume = value
        End Set
    End Property
    Dim iNoteDuration As Int32
    ''' <summary>
    ''' Gets or sets Note Duration.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NoteDuration() As Int32
        Get
            Return iNoteDuration
        End Get
        Set(ByVal value As Int32)
            iNoteDuration = value
            Inst.NoteDuration = value
        End Set
    End Property

    Dim iModWheel As Integer '(0 - 255) Low to High Modulation
    ''' <summary>
    ''' Gets or sets Modulation.  ModWheel - (0 - 255) Low to High Modulation. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ModWheel() As Integer
        Get
            Return iModWheel
        End Get
        Set(ByVal value As Integer)
            iModWheel = value
        End Set
    End Property
    Dim iPan As Integer '(0 - 50 - 100) Left(0) to Middle(50) to Right(100) speaker
    ''' <summary>
    ''' Gets or sets Speaker Panning.  Pan - (0 - 50 - 100) Left(0) to Middle(50) to Right(100) speaker. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Pan() As Integer
        Get
            Return iPan
        End Get
        Set(ByVal value As Integer)
            iPan = value
            Inst.SendControllerChange(MIDIControllers.Pan, CByte(value))
        End Set
    End Property
    'Play a note by number (0-127), specifying a velocity value (0-127)
    ''' <summary>
    ''' Plays a note by Velocity (0 - 127) and Note Number (0 - 127).
    ''' </summary>
    ''' <param name="Note">Value from (0 - 127)</param>
    ''' <param name="Velocity">Value from (0 - 127)</param>
    ''' <remarks></remarks>
    Sub PlayMIDINote(ByVal Note As Integer, ByVal Velocity As Integer)
        Try
            If Inst.Engaged = False Then OpenDevice()
            Inst.ChangePatchGM(CurrentInstrument)
            Inst.SendControllerChange(MIDIControllers.ModWheel, CByte(ModWheel))
            Inst.SendControllerChange(MIDIControllers.Pan, CByte(Pan))
            Inst.PlayNote(Note, Velocity)
        Catch ex As Exception
        End Try
    End Sub
    'Play a note by number (0-127), specifying a velocity value (0-127)
    ''' <summary>
    ''' Plays a note by Velocity (0 - 127) and Note Number (0 - 127).
    ''' </summary>
    ''' <param name="Note">Value from (0 - 127)</param>
    ''' <param name="Velocity">Value from (0 - 127)</param>
    ''' <param name="Duration">Length note is played (in seconds)</param>
    ''' <remarks></remarks>
    Sub PlayMIDINote(ByVal Note As Integer, ByVal Velocity As Integer, ByVal Duration As Int32)
        Try
            If Inst.Engaged = False Then OpenDevice()
            Inst.NoteDuration = Duration
            Inst.ChangePatchGM(CurrentInstrument)
            Inst.SendControllerChange(MIDIControllers.ModWheel, CByte(ModWheel))
            Inst.SendControllerChange(MIDIControllers.Pan, CByte(Pan))
            Inst.PlayNote(Note, Velocity)
        Catch ex As Exception
        End Try
    End Sub

    Sub STOPAllMIDINotes()
        Inst.AllNotesOff()
        'Inst.StopNote(70)  'To stop a single note, just remember what the Note number is that is being played
    End Sub
    Sub STOPMIDINote(ByVal Note As Integer)
        Inst.StopNote(Note)
    End Sub

#End Region

#Region " Device Control "
    Sub OpenDevice()
        With Inst
            If .Engaged = False Then
                .OutputDeviceName = insts(0) 'Use the first instrument
                .OutputChannel = 0
                .Open()
                .PatchNumber = 0
                .Volume = 127 'Set volume to full volume
            End If
        End With
    End Sub
    Sub CloseDevice()
        If Inst.Engaged = True Then Inst.Close()
    End Sub
#End Region

End Class
'-----Instrument Class------
<Serializable()> Public Class Instrument
    Inherits System.ComponentModel.Component

#Region " Private Declarations and Events "
    Private _Engaged As Boolean = False
    Private _OutputDeviceID As Int32 = -1
    Private _InputDeviceID As Int32 = -1
    Private hMidiOUT As Integer
    Private hMidiIN As Integer
    Private notesToTurnOff As New ArrayList
    Public Structure NotesOff
        Public Note As Byte
        Public ShutoffTime As DateTime
    End Structure
    Public Event Receive(ByRef Channel As Byte, ByRef Status As Byte, ByRef Data1 As Byte, ByRef Data2 As Byte, ByRef Data3 As Byte)
    Public Event NoteOn(ByRef Channel As Byte, ByRef Note As Byte, ByRef Velocity As Byte, ByRef Cancel As Boolean)
    Public Event NoteOff(ByRef Channel As Byte, ByRef Note As Byte, ByRef Velocity As Byte, ByRef Cancel As Boolean)
#End Region

#Region " Open, Close, and MIDI Exception "
    Private dlgMIDIIn As New MidiDelegate(AddressOf MidiInProc)
    Private Function OpenMIDIInPort(ByRef DeviceID As Integer, ByVal Open As Boolean) As Int32
        Dim midiError As Integer
        If Open = True Then
            midiError = midiInOpen(hMidiIN, DeviceID, dlgMIDIIn, 0, CALLBACK_FUNCTION)
            If midiError <> MMSYSERR_NOERROR Then
                ThrowMidiException("midiIN_Open", midiError)
            Else
                midiError = midiInStart(hMidiIN)
                If midiError <> MMSYSERR_NOERROR Then ThrowMidiException("midiIN_Start", midiError)
            End If
        Else
            If hMidiIN <> 0 Then
                midiError = midiInStop(hMidiIN)
                If midiError <> MMSYSERR_NOERROR Then
                    ThrowMidiException("midiIN_Start", midiError)
                Else
                    midiError = midiInClose(hMidiIN)
                    If midiError <> MMSYSERR_NOERROR Then
                        ThrowMidiException("midiIN_Close", midiError)
                    Else
                        hMidiIN = 0
                    End If
                End If
            End If
        End If
        Return hMidiIN
    End Function
    Private Function OpenMIDIOutPort(ByRef DeviceID As Integer, ByVal Open As Boolean) As Int32
        Dim midiError As Integer
        If Open = True Then
            midiError = midiOutOpen(hMidiOUT, DeviceID, VariantType.Null, 0, CALLBACK_NULL)
            If midiError <> MMSYSERR_NOERROR Then ThrowMidiException("midiOUT_Open", midiError)
        Else
            If hMidiOUT <> 0 Then
                midiError = midiOutClose(hMidiOUT)
                hMidiOUT = 0
                If midiError <> MMSYSERR_NOERROR Then ThrowMidiException("midiOUT_Close", midiError)
            End If
        End If
        Return hMidiOUT
    End Function
    Private Sub ThrowMidiException(ByRef InFunct As String, ByRef MMErr As Int32)
        Dim Msg As String = Space(255)
        If InStr(1, InFunct, "out", CompareMethod.Text) = 0 Then
            midiInGetErrorText(MMErr, Msg, 255)
        Else
            midiOutGetErrorText(MMErr, Msg, 255)
        End If
        Msg = InFunct & vbCrLf & Msg & vbCrLf
        Select Case MMErr
            Case MMSYSERR_NOERROR : Msg = Msg & "no error"
            Case MMSYSERR_ERROR : Msg = Msg & "unspecified error"
            Case MMSYSERR_BADDEVICEID : Msg = Msg & "device ID out of range"
            Case MMSYSERR_NOTENABLED : Msg = Msg & "driver failed enable"
            Case MMSYSERR_ALLOCATED : Msg = Msg & "device already allocated"
            Case MMSYSERR_INVALHANDLE : Msg = Msg & "device handle is invalid"
            Case MMSYSERR_NODRIVER : Msg = Msg & "no device driver present"
            Case MMSYSERR_NOMEM : Msg = Msg & "memory allocation error"
            Case MMSYSERR_NOTSUPPORTED : Msg = Msg & "function isn't supported"
            Case MMSYSERR_BADERRNUM : Msg = Msg & "error value out of range"
            Case MMSYSERR_INVALFLAG : Msg = Msg & "invalid flag passed"
            Case MMSYSERR_INVALPARAM : Msg = Msg & "invalid parameter passed"
            Case MMSYSERR_HANDLEBUSY : Msg = Msg & "handle being used simultaneously on another thread (eg callback)"
            Case MMSYSERR_INVALIDALIAS : Msg = Msg & "Specified alias not found in WIN.INI"
            Case MMSYSERR_LASTERROR : Msg = Msg & "last error in range"
        End Select
        Throw New Exception(Msg)
    End Sub
#End Region

#Region " Callbacks and Finalizer "
    Protected Sub MidiInProc(ByVal MidiInHandle As Int32, ByVal NewMsg As Int32, ByVal Instance As Int32, ByVal wParam As Int32, ByVal lParam As Int32)
        Dim chan As Byte
        Dim Msg As Byte
        Dim Status As Byte
        Dim Data1 As Byte
        Dim Data2 As Byte
        Dim Data3 As Byte
        Dim Cancel As Boolean
        If NewMsg = MM_MIM_DATA Then
            SplitInt32(wParam, Msg, Data1, Data2, Data3)
            SplitByte(Msg, chan, Status)
            If chan = _InputChannel Then
                Select Case Status
                    Case NOTE_ON, NOTE_OFF
                        Dim DTest As Int32 = CInt(Data1) + Transpose
                        If DTest < 0 Then
                            DTest = 0
                        ElseIf DTest > 127 Then
                            DTest = 127
                        End If
                        Data1 = GetByte(DTest)
                        If hMidiOUT = 0 Then
                            If Status = NOTE_ON Then
                                RaiseEvent NoteOn(chan, Data1, Data2, Cancel)
                            ElseIf Status = NOTE_OFF Then
                                RaiseEvent NoteOff(chan, Data1, Data2, Cancel)
                            End If
                        Else
                            chan = _OutputChannel
                        End If
                    Case CHANNEL_PRESSURE
                        If FilterAfterTouch = True Then
                            Cancel = True
                        ElseIf hMidiOUT = 0 Then
                            RaiseEvent Receive(chan, Status, Data1, Data2, Data3)
                        Else
                            chan = _OutputChannel
                        End If
                    Case Else
                        If hMidiOUT = 0 Then
                            RaiseEvent Receive(chan, Status, Data1, Data2, Data3)
                        Else
                            chan = _OutputChannel
                        End If
                End Select
            End If
            NewMsg = StuffByte(Status, chan)
            lParam = StuffInt32(CByte(NewMsg), Data1, Data2, Data3)
            If Cancel = False Then If hMidiOUT <> 0 Then midiOutShortMsg(hMidiOUT, lParam)
        End If
    End Sub
    Protected Sub ShutoffNoteCallback()
        Dim no As NotesOff
        Dim there As Boolean
        Dim Msg As Byte
        Dim MidiMsg As Int32
        Try
            Do Until _Engaged = False
                SyncLock notesToTurnOff
                    If notesToTurnOff.Count > 0 Then
                        no = CType(notesToTurnOff(0), NotesOff)
                        there = True
                    Else
                        there = False
                    End If
                End SyncLock
                If there Then
                    Do Until Now >= no.ShutoffTime
                        Threading.Thread.Sleep(1)
                        If _Engaged = False Then
                            notesToTurnOff.Clear()
                            ev.Set()
                            Exit Sub
                        End If
                    Loop
                    Msg = StuffByte(GetByte(MIDIStatusMessages.NoteOff), _OutputChannel)
                    MidiMsg = StuffInt32(Msg, no.Note, 64, 0)
                    Try
                        midiOutShortMsg(hMidiOUT, MidiMsg)
                    Catch ex As Exception
                        Exit Do
                    End Try
                    SyncLock notesToTurnOff
                        notesToTurnOff.RemoveAt(0)
                    End SyncLock
                End If
                Threading.Thread.Sleep(1)
            Loop
            notesToTurnOff.Clear()
            ev.Set()
        Catch ex As Exception
            'Just Skip this annoying error
        End Try
    End Sub
    Protected Overrides Sub Finalize()
        GC.KeepAlive(dlgMIDIIn)
        MyBase.Finalize()
    End Sub
#End Region

#Region " Numeric Conversion Utilities "
    Public Function StuffByte(ByVal nib1 As Byte, ByVal nib2 As Byte) As Byte
        Dim _16 As Byte = 16
        Return (nib1 * _16) + nib2
    End Function
    Public Sub SplitByte(ByVal OneByte As Byte, ByRef nib1 As Byte, ByRef nib2 As Byte)
        Dim _15 As Byte = 15
        Dim _16 As Byte = 16
        nib1 = OneByte And _15
        nib2 = OneByte \ _16
    End Sub
    Public Function StuffInt32(ByVal B1 As Byte, ByVal B2 As Byte, ByVal B3 As Byte, ByVal B4 As Byte) As Int32
        Dim ret As Integer
        Dim b() As Byte = {B1, B2, B3, B4}
        ret = BitConverter.ToInt32(b, 0)
        Return ret
    End Function
    Public Sub SplitInt32(ByVal Data As Integer, ByRef B1 As Byte, ByRef B2 As Byte, ByRef B3 As Byte, ByRef B4 As Byte)
        Dim b() As Byte = BitConverter.GetBytes(Data)
        B1 = b(0)
        B2 = b(1)
        B3 = b(2)
        B4 = b(3)
    End Sub
#End Region

#Region " Public Methods "
    Public Function GetSettings() As InstrumentData
        Dim Data As New InstrumentData
        With Data
            .FilterAftertouch = Me.FilterAfterTouch
            .InputChannel = Me.InputChannel
            .InputDeviceName = Me.InputDeviceName
            .LocalControl = Me.LocalControl
            .NoteDuration = Me.NoteDuration
            .OutputChannel = Me.OutputChannel
            .OutputDeviceName = Me.OutputDeviceName
            .PatchNumber = Me.PatchNumber
            .SendPatchChangeOnOpen = Me.SendPatchChangeOnOpen
            .Transpose = Me.Transpose
            .Volume = Me.Volume
        End With
        Return Data
    End Function
    Public Sub SetSettings(ByVal Instrument As InstrumentData)
        Dim Open As Boolean = _Engaged
        Close()
        With Instrument
            Me.FilterAfterTouch = .FilterAftertouch
            Me.InputChannel = .InputChannel
            Me.InputDeviceName = .InputDeviceName
            Me.LocalControl = .LocalControl
            Me.NoteDuration = .NoteDuration
            Me.OutputChannel = .OutputChannel
            Me.OutputDeviceName = .OutputDeviceName
            Me.PatchNumber = .PatchNumber
            Me.Transpose = .Transpose
            Me.SendPatchChangeOnOpen = .SendPatchChangeOnOpen
            Me.Volume = .Volume
        End With
        If Open = True Then
            Try
                Me.Open()
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Public Sub Open()
        If _OutputDeviceID = -1 And _InputDeviceID = -1 Then Throw New Exception("You must specify an Input Device, Output Device, or both")
        Try
            If _Engaged = True Then Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
        Try
            If _Engaged = False Then
                If _InputDeviceID <> -1 Then hMidiIN = OpenMIDIInPort(_InputDeviceID, True)
                If _OutputDeviceID <> -1 Then hMidiOUT = OpenMIDIOutPort(_OutputDeviceID, True)
                _Engaged = True
                LocalControl = _LocalControl
                If _sendPatchChangeOnOpen = True Then PatchNumber = _PatchNumber
                Volume = _Volume
            End If
        Catch ex As Exception
            Throw New Exception("Error opening MIDI port" & vbCrLf & ex.Message, ex)
        End Try
    End Sub
    Public Sub Close()
        Try
            If _Engaged = True Then
                AllNotesOff()
                If _NoteDuration > 0 Then ev.WaitOne()
                If hMidiIN <> 0 Then hMidiIN = OpenMIDIInPort(_InputDeviceID, False)
                If hMidiOUT <> 0 Then hMidiOUT = OpenMIDIOutPort(_OutputDeviceID, False)
                _Engaged = False
            End If
        Catch ex As Exception
            Throw New Exception("Error closing MIDI Port" & vbCrLf & ex.Message, ex)
        End Try
    End Sub
    Public Sub Send(ByVal Channel As Byte, ByVal Status As Byte, Optional ByVal Data1 As Byte = 0, Optional ByVal Data2 As Byte = 0, Optional ByVal Data3 As Byte = 0)
        Dim MidiMsg As Integer
        Dim CmdAndChannel As Byte
        CmdAndChannel = StuffByte(Status, Channel)
        MidiMsg = StuffInt32(CmdAndChannel, Data1, Data2, Data3)
        midiOutShortMsg(hMidiOUT, MidiMsg)
    End Sub
    Public Sub SendMessage(ByVal Msg As MIDIStatusMessages, Optional ByRef Data1 As Byte = 0, Optional ByVal Data2 As Byte = 0, Optional ByVal Data3 As Byte = 0)
        Dim MidiMsg As Integer
        Dim CmdAndChannel As Byte
        CmdAndChannel = StuffByte(GetByte(Msg), OutputChannel)
        MidiMsg = StuffInt32(CmdAndChannel, Data1, Data2, Data3)
        midiOutShortMsg(hMidiOUT, MidiMsg)
    End Sub
    Public Sub SendControllerChange(ByVal Controller As MIDIControllers, ByRef Data1 As Byte, Optional ByVal Data2 As Byte = 0)
        Dim MidiMsg As Integer
        Dim CmdAndChannel As Byte
        CmdAndChannel = StuffByte(GetByte(MIDIStatusMessages.ControllerChange), OutputChannel)
        MidiMsg = StuffInt32(CmdAndChannel, GetByte(Controller), Data1, Data2)
        midiOutShortMsg(hMidiOUT, MidiMsg)
    End Sub
    Public Shared Function InDeviceNames() As String()
        Dim num As Integer
        Dim i As Integer
        Dim Caps As MIDIINCAPS = Nothing
        Dim names() As String = Nothing
        num = midiInGetNumDevs
        If num > 0 Then
            ReDim names(num - 1)
            For i = 0 To num - 1
                midiInGetDevCaps(i, Caps, Len(Caps))
                names(i) = Caps.szPname
            Next
        End If
        Return names
    End Function
    Public Shared Function OutDeviceNames() As String()
        Dim num As Integer
        Dim i As Integer
        Dim Caps As MIDIOUTCAPS = Nothing
        Dim names() As String = Nothing
        num = midiOutGetNumDevs
        If num > 0 Then
            ReDim names(num - 1)
            For i = 0 To num - 1
                midiOutGetDevCaps(i, Caps, Len(Caps))
                names(i) = Caps.szPname
            Next
        End If
        Return names
    End Function
    Public Sub ChangePatchGM(ByVal Instrument As GMInstruments)
        Try
            Me.PatchNumber = GetByte(Instrument)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ChangePatchGM(ByVal GMPatchName As String)
        Try
            Me.PatchNumber = GetByte(Array.IndexOf(Instrument.GMInstrumentNames, GMPatchName))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AllSoundOff()
        Dim Msg As Byte
        Dim MidiMsg As Int32
        If _Engaged = False Then Exit Sub
        Try
            Msg = StuffByte(GetByte(MIDIStatusMessages.ChannelModeMessage), _OutputChannel)
            MidiMsg = StuffInt32(Msg, &H78, 0, 0)
            midiOutShortMsg(hMidiOUT, MidiMsg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ResetAllControllers()
        Dim Msg As Byte
        Dim MidiMsg As Int32
        If _Engaged = False Then Exit Sub
        Try
            Msg = StuffByte(GetByte(MIDIStatusMessages.ChannelModeMessage), _OutputChannel)
            MidiMsg = StuffInt32(Msg, &H79, 0, 0)
            midiOutShortMsg(hMidiOUT, MidiMsg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AllNotesOff()
        Dim Msg As Byte
        Dim MidiMsg As Int32
        If _Engaged = False Then Exit Sub
        Try
            Msg = StuffByte(GetByte(MIDIStatusMessages.ChannelModeMessage), _OutputChannel)
            MidiMsg = StuffInt32(Msg, &H7B, 0, 0)
            midiOutShortMsg(hMidiOUT, MidiMsg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Play a note by number (0-127), specifying a velocity value (0-127)
    Public Sub PlayNote(ByVal Note As Byte, ByVal Velocity As Byte)
        Dim Msg As Byte
        Dim MidiMsg As Int32
        If _Engaged = False Then Exit Sub
        If PatchNumber = 128 Then 'Drums
            SendMsg(&H99, Note, Velocity) 'Adds Drums to the PlayNote Sub
            Exit Sub
        End If
        Msg = StuffByte(GetByte(MIDIStatusMessages.NoteOn), _OutputChannel)
        MidiMsg = StuffInt32(Msg, GetByte(Note + _Transpose), Velocity, 0)
        Try
            midiOutShortMsg(hMidiOUT, MidiMsg)
            '_NoteDuration = 1 This works, but why is _NoteDuration not keeping the value???
            If _NoteDuration > 0 Then
                Dim no As NotesOff
                no.Note = GetByte(Note + _Transpose)
                Dim j As DateTime = Now
                no.ShutoffTime = j.AddMilliseconds(_NoteDuration)  'DateAdd(DateInterval.Second, _NoteDuration, Now)
                SyncLock notesToTurnOff
                    notesToTurnOff.Add(no)
                End SyncLock
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub StopNote(ByVal Note As Byte, Optional ByVal Velocity As Byte = 64)
        Dim Msg As Byte
        Dim MidiMsg As Int32
        If _Engaged = False Then Exit Sub
        Msg = StuffByte(GetByte(MIDIStatusMessages.NoteOff), _OutputChannel)
        MidiMsg = StuffInt32(Msg, GetByte(Note + _Transpose), Velocity, 0)
        Try
            midiOutShortMsg(hMidiOUT, MidiMsg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'This is for DRUMS or PatchNumber 128
    Public Sub SendMsg(ByVal Status As Byte, ByVal Note As Byte, ByVal Velocity As Byte)
        Dim msg As Integer = Velocity * 65536 + Note * 256 + Status
        midiOutShortMsg(hMidiOUT, msg)
    End Sub
#End Region

#Region " Property Handlers "
    Private _sendPatchChangeOnOpen As Boolean = True
    Public Property SendPatchChangeOnOpen() As Boolean
        Get
            Return _sendPatchChangeOnOpen
        End Get
        Set(ByVal Value As Boolean)
            _sendPatchChangeOnOpen = Value
        End Set
    End Property
    Private _LocalControl As Boolean = True
    Public Property LocalControl() As Boolean
        Get
            Return _LocalControl
        End Get
        Set(ByVal Value As Boolean)
            If _Engaged = True Then
                Dim Msg As Byte
                Dim MidiMsg As Int32
                Try
                    Msg = StuffByte(GetByte(MIDIStatusMessages.ChannelModeMessage), _OutputChannel)
                    If Value = True Then
                        MidiMsg = StuffInt32(Msg, &H7A, &H7F, 0)
                    Else
                        MidiMsg = StuffInt32(Msg, &H7A, 0, 0)
                    End If
                    midiOutShortMsg(hMidiOUT, MidiMsg)
                Catch ex As Exception
                    Throw New Exception("Error setting Local Control: " & ex.Message, ex)
                End Try
            End If
            _LocalControl = Value
        End Set
    End Property
    Private _Transpose As Int32 = 0
    Public Property Transpose() As Int32
        Get
            Return _Transpose
        End Get
        Set(ByVal Value As Int32)
            _Transpose = Value
        End Set
    End Property
    Private _FilterAfterTouch As Boolean = True
    Public Property FilterAfterTouch() As Boolean
        Get
            Return _FilterAfterTouch
        End Get
        Set(ByVal Value As Boolean)
            _FilterAfterTouch = Value
        End Set
    End Property
    Private _NoteDuration As Int32 = 0
    Public Property NoteDuration() As Int32
        Get
            Return _NoteDuration
        End Get
        Set(ByVal Value As Int32)
            If Value > 0 Then
                Dim T As New Threading.Thread(AddressOf ShutoffNoteCallback)
                T.Start()
            End If
            _NoteDuration = Value
        End Set
    End Property
    Private ev As New Threading.AutoResetEvent(False)
    Public ReadOnly Property Engaged() As Boolean
        Get
            Engaged = _Engaged
        End Get
    End Property
    Private _OutputDeviceName As String = ""
    Public Property OutputDeviceName() As String
        Get
            Return _OutputDeviceName
        End Get
        Set(ByVal Value As String)
            If Value Is Nothing Then Exit Property
            Dim i As Int32
            _OutputDeviceID = -1
            Dim devices() As String = Instrument.OutDeviceNames
            If Not devices Is Nothing Then
                For i = 0 To devices.Length - 1
                    If Not devices(i) Is Nothing Then
                        If devices(i).ToLower = Value.ToLower Then
                            _OutputDeviceName = Value
                            _OutputDeviceID = i
                            Exit For
                        End If
                    End If
                Next
            End If
        End Set
    End Property
    Private _InputDeviceName As String = ""
    Public Property InputDeviceName() As String
        Get
            InputDeviceName = _InputDeviceName
        End Get
        Set(ByVal Value As String)
            If Value Is Nothing Then Exit Property
            Dim i As Int32
            _InputDeviceID = -1
            Dim devices() As String = Instrument.InDeviceNames
            If Not devices Is Nothing Then
                For i = 0 To devices.Length - 1
                    If Not devices(i) Is Nothing Then
                        If devices(i).ToLower = Value.ToLower Then
                            _InputDeviceName = Value
                            _InputDeviceID = i
                            Exit For
                        End If
                    End If
                Next
            End If
        End Set
    End Property
    Private _OutputChannel As Byte = 0
    Public Property OutputChannel() As Byte
        Get
            OutputChannel = _OutputChannel
        End Get
        Set(ByVal Value As Byte)
            _OutputChannel = Value
        End Set
    End Property
    Private _InputChannel As Byte = 0
    Public Property InputChannel() As Byte
        Get
            InputChannel = _InputChannel
        End Get
        Set(ByVal Value As Byte)
            _InputChannel = Value
        End Set
    End Property
    Private _Volume As Byte = 127 '(0 - 127)
    Public Property Volume() As Byte
        Get
            Return _Volume
        End Get
        Set(ByVal Value As Byte)
            _Volume = Value
            If _Engaged = True Then
                Try
                    Dim Msg As Byte = StuffByte(GetByte(MIDIStatusMessages.ControllerChange), _OutputChannel)
                    Dim MidiMsg As Int32 = StuffInt32(Msg, 7, Value, 0)
                    midiOutShortMsg(hMidiOUT, MidiMsg)
                Catch ex As Exception
                    Throw New Exception("Error setting Volume: " & ex.Message, ex)
                End Try
            End If
        End Set
    End Property
    Private _PatchNumber As Byte = 0
    Public Property PatchNumber() As Byte
        Get
            Return _PatchNumber
        End Get
        Set(ByVal Value As Byte)
            _PatchNumber = Value
            If _Engaged = True Then
                Try
                    Dim Msg As Byte = StuffByte(GetByte(MIDIStatusMessages.ProgramChange), _OutputChannel)
                    Dim MidiMsg As Int32 = StuffInt32(Msg, Value, 0, 0)
                    midiOutShortMsg(hMidiOUT, MidiMsg)
                Catch ex As Exception
                    Throw ex
                End Try
            End If
        End Set
    End Property
#End Region

#Region " Shared Arrays "
    'General MIDI Instrument Names
    Public Shared GMInstrumentNames() As String = _
    {"AcousticGrandPiano", "BrightAcousticPiano", "ElectricGrandPiano", "HonkyTonkPiano", _
    "ElectricPiano1", "ElectricPiano2", "Harpsichord", "Clavi", "Celesta", _
    "Glockenspiel", "MusicBox", "Vibraphone", "Marimba", "Xylophone", "TubularBells", _
    "Dulcimer", "DrawbarOrgan", "PercussiveOrgan", "RockOrgan", "ChurchOrgan", _
    "ReedOrgan", "Accordion", "Harmonica", "TangoAccordion", "AcousticGuitarNylon", _
    "AcousticGuitarSteel", "ElectricGuitarJazz", "ElectricGuitarClean", "ElectricGuitarMuted", _
    "OverdrivenGuitar", "DistortionGuitar", "GuitarHarmonics", "AcousticBass", _
    "ElectricBassFinger", "ElectricBassPick", "FretlessBass", "SlapBass1", "SlapBass2", _
    "SynthBass1", "SynthBass2", "Violin", "Viola", "Cello", "Contrabass", _
    "TremoloStrings", "PizzicatoStrings", "OrchestralHarp", "Timpani", "StringEnsemble1", _
    "StringEnsemble2", "SynthStrings1", "SynthStrings2", "ChoirAahs", "VoiceOohs", _
    "SynthVoice", "OrchestraHit", "Trumpet", "Trombone", "Tuba", "MutedTrumpet", "FrenchHorn", _
    "BrassSection", "SynthBrass1", "SynthBrass2", "SopranoSax", "AltoSax", "TenorSax", _
    "BaritoneSax", "Oboe", "EnglishHorn", "Bassoon", "Clarinet", "Piccolo", "Flute", _
    "Recorder", "PanFlute", "BlownBottle", "Shakuhachi", "Whistle", "Ocarina", _
    "Lead1Square", "Lead2Sawtooth", "Lead3Calliope", "Lead4Chiff", "Lead5Charang", _
    "Lead6Voice", "Lead7Fifths", "Lead8BassPluslead", "Pad1NewAge", "Pad2Warm", _
    "Pad3Polysynth", "Pad4Choir", "Pad5Bowed", "Pad6Metallic", "Pad7Halo", "Pad8Sweep", _
    "FX1Rain", "FX2Soundtrack", "FX3Crystal", "FX4Atmosphere", "FX5Brightness", _
    "FX6Goblins", "FX7Echoes", "FX8SciFi", "Sitar", "Banjo", "Shamisen", "Koto", _
    "Kalimba", "Bagpipe", "Fiddle", "Shanai", "TinkleBell", "Agogo", "SteelDrums", _
    "Woodblock", "TaikoDrum", "MelodicTom", "SynthDrum", "ReverseCymbal", "GuitarFretNoise", _
    "BreathNoise", "Seashore", "BirdTweet", "TelephoneRing", "Helicopter", "Applause", _
    "Gunshot", "Drums"}
#End Region
End Class

#Region " Enums "
Public Enum MIDIStatusMessages
    NoteOff = CByte(&H8)
    NoteOn = CByte(&H9)
    PolyphonicKeyPressure = CByte(&HA)
    ControllerChange = CByte(&HB)
    ProgramChange = CByte(&HC)
    ChannelPressure = CByte(&HD)
    PitchBend = CByte(&HE)
    ChannelModeMessage = CByte(&HB)
End Enum
Public Enum MIDIControllers
    ModWheel = CByte(1)
    BreathController = CByte(2)
    FootController = CByte(4)
    PortamentoTime = CByte(5)
    MainVolume = CByte(7)
    Balance = CByte(8)
    Pan = CByte(10)
    ExpressionController = CByte(11)
    DamperPedal = CByte(64)
    Portamento = CByte(65)
    Sostenuto = CByte(66)
    SoftPedal = CByte(67)
    Hold2 = CByte(69)
    ExternalEffectsDepth = CByte(91)
    TremeloDepth = CByte(92)
    ChorusDepth = CByte(93)
    DetuneDepth = CByte(94)
    PhaserDepth = CByte(95)
    DataIncrement = CByte(96)
    DataDecrement = CByte(97)
    AllNotesOff = CByte(123)
End Enum
Public Enum GMInstruments
    AcousticGrandPiano = 0
    BrightAcousticPiano = 1
    ElectricGrandPiano = 2
    HonkyTonkPiano = 3
    ElectricPiano1 = 4
    ElectricPiano2 = 5
    Harpsichord = 6
    Clavi = 7
    Celesta = 8
    Glockenspiel = 9
    MusicBox = 10
    Vibraphone = 11
    Marimba = 12
    Xylophone = 13
    TubularBells = 14
    Dulcimer = 15
    DrawbarOrgan = 16
    PercussiveOrgan = 17
    RockOrgan = 18
    ChurchOrgan = 19
    ReedOrgan = 20
    Accordion = 21
    Harmonica = 22
    TangoAccordion = 23
    AcousticGuitarNylon = 24
    AcousticGuitarSteel = 25
    ElectricGuitarJazz = 26
    ElectricGuitarClean = 27
    ElectricGuitarMuted = 28
    OverdrivenGuitar = 29
    DistortionGuitar = 30
    GuitarHarmonics = 31
    AcousticBass = 32
    ElectricBassFinger = 33
    ElectricBassPick = 34
    FretlessBass = 35
    SlapBass1 = 36
    SlapBass2 = 37
    SynthBass1 = 38
    SynthBass2 = 39
    Violin = 40
    Viola = 41
    Cello = 42
    Contrabass = 43
    TremoloStrings = 44
    PizzicatoStrings = 45
    OrchestralHarp = 46
    Timpani = 47
    StringEnsemble1 = 48
    StringEnsemble2 = 49
    SynthStrings1 = 50
    SynthStrings2 = 51
    ChoirAahs = 52
    VoiceOohs = 53
    SynthVoice = 54
    OrchestraHit = 55
    Trumpet = 56
    Trombone = 57
    Tuba = 58
    MutedTrumpet = 59
    FrenchHorn = 60
    BrassSection = 61
    SynthBrass1 = 62
    SynthBrass2 = 63
    SopranoSax = 64
    AltoSax = 65
    TenorSax = 66
    BaritoneSax = 67
    Oboe = 68
    EnglishHorn = 69
    Bassoon = 70
    Clarinet = 71
    Piccolo = 72
    Flute = 73
    Recorder = 74
    PanFlute = 75
    BlownBottle = 76
    Shakuhachi = 77
    Whistle = 78
    Ocarina = 79
    Lead1Square = 80
    Lead2Sawtooth = 81
    Lead3Calliope = 82
    Lead4Chiff = 83
    Lead5Charang = 84
    Lead6Voice = 85
    Lead7Fifths = 86
    Lead8BassPluslead = 87
    Pad1NewAge = 88
    Pad2Warm = 89
    Pad3Polysynth = 90
    Pad4Choir = 91
    Pad5Bowed = 92
    Pad6Metallic = 93
    Pad7Halo = 94
    Pad8Sweep = 95
    FX1Rain = 96
    FX2Soundtrack = 97
    FX3Crystal = 98
    FX4Atmosphere = 99
    FX5Brightness = 100
    FX6Goblins = 101
    FX7Echoes = 102
    FX8SciFi = 103
    Sitar = 104
    Banjo = 105
    Shamisen = 106
    Koto = 107
    Kalimba = 108
    Bagpipe = 109
    Fiddle = 110
    Shanai = 111
    TinkleBell = 112
    Agogo = 113
    SteelDrums = 114
    Woodblock = 115
    TaikoDrum = 116
    MelodicTom = 117
    SynthDrum = 118
    ReverseCymbal = 119
    GuitarFretNoise = 120
    BreathNoise = 121
    Seashore = 122
    BirdTweet = 123
    TelephoneRing = 124
    Helicopter = 125
    Applause = 126
    Gunshot = 127
    Drums = 128
End Enum
#End Region

'-----InstrumentData Class------
<Serializable()> Public Class InstrumentData
    Public Name As String
    Public InputDeviceName As String
    Public OutputDeviceName As String
    Public InputChannel As Byte
    Public OutputChannel As Byte
    Public NoteDuration As Int32
    Public SendPatchChangeOnOpen As Boolean
    Public LocalControl As Boolean
    Public FilterAftertouch As Boolean = True
    Public Transpose As Int32
    Public PatchNumber As Byte
    Public Volume As Byte = 127
End Class

'-----midi Module-----
Module midi_play
    ' this module containes all midi API functions
    Public Function GetByte(ByVal obj As Object) As Byte
        Dim b As Byte
        If IsNumeric(obj) = False Then
            b = 0
        Else
            Select Case CInt(obj)
                Case Is < 0 : b = 0
                Case Is > 255 : b = 255
                Case Else : b = CByte(obj)
            End Select
        End If
        Return b
    End Function
    Public Const MAXPNAMELEN As Short = 32 'max product name length (including NULL)
    Structure MIDIEVENT
        Dim dwDeltaTime As Integer 'Ticks since last event
        Dim dwStreamID As Integer 'Reserved; must be zero
        Dim dwEvent As Integer 'Event type and parameters
        <VBFixedArray(1)> Dim dwParms() As Integer 'Parameters if this is a long event
        Public Sub Initialize()
            ReDim dwParms(1)
        End Sub
    End Structure
    Structure MIDIHDR
        Dim lpData As String
        Dim dwBufferLength As Integer
        Dim dwBytesRecorded As Integer
        Dim dwUser As Integer
        Dim dwFlags As Integer
        Dim lpNext As Integer
        Dim Reserved As Integer
        Dim dwOffset As Integer
        <VBFixedArray(4)> Dim dwReserved() As Integer
        Public Sub Initialize()
            ReDim dwReserved(4)
        End Sub
    End Structure
    Structure MIDIINCAPS
        Dim wMid As Short
        Dim wPid As Short
        Dim vDriverVersion As Integer
        <VBFixedString(MAXPNAMELEN), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=MAXPNAMELEN)> Public szPname As String
    End Structure
    Structure MIDIOUTCAPS
        Dim wMid As Short
        Dim wPid As Short
        Dim vDriverVersion As Integer
        <VBFixedString(MAXPNAMELEN), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=MAXPNAMELEN)> Public szPname As String
        Dim wTechnology As Short
        Dim wVoices As Short
        Dim wNotes As Short
        Dim wChannelMask As Short
        Dim dwSupport As Integer
    End Structure
    Structure MIDIPROPTEMPO
        Dim cbStruct As Integer
        Dim dwTempo As Integer
    End Structure
    Structure MIDIPROPTIMEDIV
        Dim cbStruct As Integer
        Dim dwTimeDiv As Integer
    End Structure
    Structure MIDISTRMBUFFVER
        Dim dwVersion As Integer '  Stream buffer format version
        Dim dwMid As Integer '  Manufacturer ID as defined in MMREG.H
        Dim dwOEMVersion As Integer '  Manufacturer version for custom ext
    End Structure
    ' MIDI API Functions for Windows 95
    Declare Function midiConnect Lib "winmm.dll" (ByVal hmi As Integer, ByVal hmo As Integer, ByRef pReserved As Int32) As Integer
    Declare Function midiDisconnect Lib "winmm.dll" (ByVal hmi As Integer, ByVal hmo As Integer, ByRef pReserved As Int32) As Integer
    Declare Function midiInAddBuffer Lib "winmm.dll" (ByVal hMidiIN As Integer, ByRef lpMidiInHdr As MIDIHDR, ByVal uSize As Integer) As Integer
    Declare Function midiInClose Lib "winmm.dll" (ByVal hMidiIN As Integer) As Integer
    Declare Function midiInGetDevCaps Lib "winmm.dll" Alias "midiInGetDevCapsA" (ByVal uDeviceID As Integer, ByRef lpCaps As MIDIINCAPS, ByVal uSize As Integer) As Integer
    Declare Function midiInGetErrorText Lib "winmm.dll" Alias "midiInGetErrorTextA" (ByVal err_Renamed As Integer, ByVal lpText As String, ByVal uSize As Integer) As Integer
    Declare Function midiInGetID Lib "winmm.dll" (ByVal hMidiIN As Integer, ByRef DeviceName As String) As Integer
    Declare Function midiInGetNumDevs Lib "winmm.dll" () As Integer
    Declare Function midiInMessage Lib "winmm.dll" (ByVal hMidiIN As Integer, ByVal Msg As Integer, ByVal dw1 As Integer, ByVal dw2 As Integer) As Integer
    'Declare Function midiInOpen Lib "winmm.dll" (ByRef lphMidiIn As Integer, ByVal uDeviceID As Integer, ByVal dwCallback As Int32, ByVal dwInstance As Integer, ByVal dwFlags As Integer) As Integer
    Public Delegate Sub MidiDelegate(ByVal MidiInHandle As Int32, ByVal wMsg As Int32, ByVal Instance As Int32, ByVal wParam As Int32, ByVal lParam As Int32)
    Declare Function midiInOpen Lib "winmm.dll" (ByRef lphMidiIn As Integer, _
        ByVal uDeviceID As Integer, <MarshalAs(UnmanagedType.FunctionPtr)> ByVal dwCallback As MidiDelegate, _
        ByVal dwInstance As Integer, ByVal dwFlags As Integer) As Integer

    Declare Function midiInPrepareHeader Lib "winmm.dll" (ByVal hMidiIN As Integer, ByRef lpMidiInHdr As MIDIHDR, ByVal uSize As Integer) As Integer
    Declare Function midiInReset Lib "winmm.dll" (ByVal hMidiIN As Integer) As Integer
    Declare Function midiInStart Lib "winmm.dll" (ByVal hMidiIN As Integer) As Integer
    Declare Function midiInStop Lib "winmm.dll" (ByVal hMidiIN As Integer) As Integer
    Declare Function midiInUnprepareHeader Lib "winmm.dll" (ByVal hMidiIN As Integer, ByRef lpMidiInHdr As MIDIHDR, ByVal uSize As Integer) As Integer
    Declare Function midiOutCacheDrumPatches Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByVal uPatch As Integer, ByRef lpKeyArray As Integer, ByVal uFlags As Integer) As Integer
    Declare Function midiOutCachePatches Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByVal uBank As Integer, ByRef lpPatchArray As Integer, ByVal uFlags As Integer) As Integer
    Declare Function midiOutClose Lib "winmm.dll" (ByVal hMidiOUT As Integer) As Integer
    Declare Function midiOutGetDevCaps Lib "winmm.dll" Alias "midiOutGetDevCapsA" (ByVal uDeviceID As Integer, ByRef lpCaps As MIDIOUTCAPS, ByVal uSize As Integer) As Integer
    Declare Function midiOutGetErrorText Lib "winmm.dll" Alias "midiOutGetErrorTextA" (ByVal err_Renamed As Integer, ByVal lpText As String, ByVal uSize As Integer) As Integer
    Declare Function midiOutGetID Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByRef DeviceName As String) As Integer
    Declare Function midiOutGetNumDevs Lib "winmm" () As Short
    Declare Function midiOutGetVolume Lib "winmm.dll" (ByVal uDeviceID As Integer, ByRef lpdwVolume As Integer) As Integer
    Declare Function midiOutLongMsg Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByRef lpMidiOutHdr As MIDIHDR, ByVal uSize As Integer) As Integer
    Declare Function midiOutMessage Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByVal Msg As Integer, ByVal dw1 As Integer, ByVal dw2 As Integer) As Integer
    Declare Function midiOutOpen Lib "winmm.dll" (ByRef lphMidiOut As Integer, ByVal uDeviceID As Integer, ByVal dwCallback As Integer, ByVal dwInstance As Integer, ByVal dwFlags As Integer) As Integer
    Declare Function midiOutPrepareHeader Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByRef lpMidiOutHdr As MIDIHDR, ByVal uSize As Integer) As Integer
    Declare Function midiOutReset Lib "winmm.dll" (ByVal hMidiOUT As Integer) As Integer
    Declare Function midiOutSetVolume Lib "winmm.dll" (ByVal uDeviceID As Integer, ByVal dwVolume As Integer) As Integer
    Declare Function midiOutShortMsg Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByVal dwMsg As Integer) As Integer
    Declare Function midiOutUnprepareHeader Lib "winmm.dll" (ByVal hMidiOUT As Integer, ByRef lpMidiOutHdr As MIDIHDR, ByVal uSize As Integer) As Integer
    Declare Function midiStreamClose Lib "winmm.dll" (ByVal hms As Integer) As Integer
    Declare Function midiStreamOpen Lib "winmm.dll" (ByRef phms As Integer, ByRef puDeviceID As Integer, ByVal cMidi As Integer, ByVal dwCallback As Integer, ByVal dwInstance As Integer, ByVal fdwOpen As Integer) As Integer
    Declare Function midiStreamOut Lib "winmm.dll" (ByVal hms As Integer, ByRef pmh As MIDIHDR, ByVal cbmh As Integer) As Integer
    Declare Function midiStreamPause Lib "winmm.dll" (ByVal hms As Integer) As Integer
    'Declare Function midiStreamPosition Lib "winmm.dll" (ByVal hms As Integer, ByRef lpmmt As MMakePiano, ByVal cbmmt As Integer) As Integer
    Declare Function midiStreamProperty Lib "winmm.dll" (ByVal hms As Integer, ByRef lppropdata As Byte, ByVal dwProperty As Integer) As Integer
    Declare Function midiStreamRestart Lib "winmm.dll" (ByVal hms As Integer) As Integer
    Declare Function midiStreamStop Lib "winmm.dll" (ByVal hms As Integer) As Integer
    'General error return values
    Public Const MMSYSERR_BASE As Short = 0
    Public Const MMSYSERR_NOERROR As Short = 0 '  no error
    Public Const MMSYSERR_ERROR As Integer = (MMSYSERR_BASE + 1) '  unspecified error
    Public Const MMSYSERR_BADDEVICEID As Integer = (MMSYSERR_BASE + 2) '  device ID out of range
    Public Const MMSYSERR_NOTENABLED As Integer = (MMSYSERR_BASE + 3) '  driver failed enable
    Public Const MMSYSERR_ALLOCATED As Integer = (MMSYSERR_BASE + 4) '  device already allocated
    Public Const MMSYSERR_INVALHANDLE As Integer = (MMSYSERR_BASE + 5) '  device handle is invalid
    Public Const MMSYSERR_NODRIVER As Integer = (MMSYSERR_BASE + 6) '  no device driver present
    Public Const MMSYSERR_NOMEM As Integer = (MMSYSERR_BASE + 7) '  memory allocation error
    Public Const MMSYSERR_NOTSUPPORTED As Integer = (MMSYSERR_BASE + 8) '  function isn't supported
    Public Const MMSYSERR_BADERRNUM As Integer = (MMSYSERR_BASE + 9) '  error value out of range
    Public Const MMSYSERR_INVALFLAG As Integer = (MMSYSERR_BASE + 10) '  invalid flag passed
    Public Const MMSYSERR_INVALPARAM As Integer = (MMSYSERR_BASE + 11) '  invalid parameter passed
    Public Const MMSYSERR_HANDLEBUSY As Integer = (MMSYSERR_BASE + 12) '  handle being used
    'simultaneously on another
    'thread (eg callback)
    Public Const MMSYSERR_INVALIDALIAS As Integer = (MMSYSERR_BASE + 13) '  "Specified alias not found in WIN.INI
    Public Const MMSYSERR_LASTERROR As Integer = (MMSYSERR_BASE + 13) '  last error in range
    'flags for dwFlags field of MIDIHDR structure
    Public Const MHDR_DONE As Short = &H1S '  done bit
    Public Const MHDR_PREPARED As Short = &H2S '  set if header prepared
    Public Const MHDR_INQUEUE As Short = &H4S '  reserved for driver
    Public Const MHDR_VALID As Short = &H7S '  valid flags / ;Internal /
    'flags used with waveOutOpen(), waveInOpen(), midiInOpen(), and
    'midiOutOpen() to specify the type of the dwCallback parameter.
    Public Const CALLBACK_TYPEMASK As Integer = &H70000 '  callback type mask
    Public Const CALLBACK_NULL As Short = &H0S '  no callback
    Public Const CALLBACK_WINDOW As Integer = &H10000 '  dwCallback is a HWND
    Public Const CALLBACK_TASK As Integer = &H20000 '  dwCallback is a HTASK
    Public Const CALLBACK_FUNCTION As Integer = &H30000 '  dwCallback is a FARPROC
    'manufacturer IDs
    Public Const MM_MICROSOFT As Short = 1 '  Microsoft Corp.
    'product IDs
    Public Const MM_MIDI_MAPPER As Short = 1 '  MIDI Mapper
    Public Const MM_WAVE_MAPPER As Short = 2 '  Wave Mapper

    Public Const MM_SNDBLST_MIDIOUT As Short = 3 '  Sound Blaster MIDI output port
    Public Const MM_SNDBLST_MIDIIN As Short = 4 '  Sound Blaster MIDI input port
    Public Const MM_SNDBLST_SYNTH As Short = 5 '  Sound Blaster internal synthesizer
    Public Const MM_SNDBLST_WAVEOUT As Short = 6 '  Sound Blaster waveform output
    Public Const MM_SNDBLST_WAVEIN As Short = 7 '  Sound Blaster waveform input

    Public Const MM_ADLIB As Short = 9 '  Ad Lib-compatible synthesizer

    Public Const MM_MPU401_MIDIOUT As Short = 10 '  MPU401-compatible MIDI output port
    Public Const MM_MPU401_MIDIIN As Short = 11 '  MPU401-compatible MIDI input port

    Public Const MM_PC_JOYSTICK As Short = 12 '  Joystick adapter

    Public Const MIDI_IO_STATUS As Short = &H20
    Public Const MM_MIM_OPEN As Short = &H3C1S '  MIDI input
    Public Const MM_MIM_CLOSE As Short = &H3C2S
    Public Const MM_MIM_DATA As Short = &H3C3S
    Public Const MM_MIM_LONGDATA As Short = &H3C4S
    Public Const MM_MIM_ERROR As Short = &H3C5S
    Public Const MM_MIM_LONGERROR As Short = &H3C6S
    Public Const MM_MIM_MOREDATA As Short = &H3CC

    Public Const MM_MOM_OPEN As Short = &H3C7S '  MIDI output
    Public Const MM_MOM_CLOSE As Short = &H3C8S
    Public Const MM_MOM_DONE As Short = &H3C9S
    '----------------------------------------------------------------
    'MIDI Mapper
    Public Const MIDI_MAPPER As Short = -1
    'flags for wTechnology field of MIDIOUTCAPS structure
    Public Const MOD_MIDIPORT As Byte = 1 '  output port
    Public Const MOD_SYNTH As Byte = 2 '  generic internal synth
    Public Const MOD_SQSYNTH As Byte = 3 '  square wave internal synth
    Public Const MOD_FMSYNTH As Byte = 4 '  FM internal synth
    Public Const MOD_MAPPER As Byte = 5 '  MIDI mapper
    'flags for dwSupport field of MIDIOUTCAPS
    Public Const MIDICAPS_VOLUME As Byte = &H1 '  supports volume control
    Public Const MIDICAPS_LRVOLUME As Byte = &H2 '  separate left-right volume control
    Public Const MIDICAPS_CACHE As Byte = &H4
    'MIDI Controller Numbers Constants
    Public Const MOD_WHEEL As Byte = 1
    Public Const BREATH_CONTROLLER As Byte = 2
    Public Const FOOT_CONTROLLER As Byte = 4
    Public Const PORTAMENTO_TIME As Byte = 5
    Public Const MAIN_VOLUME As Byte = 7
    Public Const BALANCE As Byte = 8
    Public Const PAN As Byte = 10
    Public Const EXPRESS_CONTROLLER As Byte = 11
    Public Const DAMPER_PEDAL As Byte = 64
    Public Const PORTAMENTO As Byte = 65
    Public Const SOSTENUTO As Byte = 66
    Public Const SOFT_PEDAL As Byte = 67
    Public Const HOLD_2 As Byte = 69
    Public Const EXTERNAL_FX_DEPTH As Byte = 91
    Public Const TREMELO_DEPTH As Byte = 92
    Public Const CHORUS_DEPTH As Byte = 93
    Public Const DETUNE_DEPTH As Byte = 94
    Public Const PHASER_DEPTH As Byte = 95
    Public Const DATA_INCREMENT As Byte = 96
    Public Const DATA_DECREMENT As Byte = 97
    'MIDI status messages
    Public Const NOTE_OFF As Byte = &H80
    Public Const NOTE_ON As Byte = &H90
    Public Const POLY_KEY_PRESS As Byte = &HA0
    Public Const CONTROLLER_CHANGE As Byte = &HB0
    Public Const PROGRAM_CHANGE As Byte = &HC0
    Public Const CHANNEL_PRESSURE As Byte = &HD0
    Public Const PITCH_BEND As Byte = &HE0
End Module
