﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.34003
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funktion zum automatischen Speichern von My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property cboInstruments() As Byte
            Get
                Return CType(Me("cboInstruments"),Byte)
            End Get
            Set
                Me("cboInstruments") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property Tackt_Zaehler_Input() As Byte
            Get
                Return CType(Me("Tackt_Zaehler_Input"),Byte)
            End Get
            Set
                Me("Tackt_Zaehler_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property Tackt_Naenner_Input() As Byte
            Get
                Return CType(Me("Tackt_Naenner_Input"),Byte)
            End Get
            Set
                Me("Tackt_Naenner_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property BPM() As UShort
            Get
                Return CType(Me("BPM"),UShort)
            End Get
            Set
                Me("BPM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MIDI_NormalMode() As Boolean
            Get
                Return CType(Me("MIDI_NormalMode"),Boolean)
            End Get
            Set
                Me("MIDI_NormalMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property Messintervall_NumericUpDown() As UShort
            Get
                Return CType(Me("Messintervall_NumericUpDown"),UShort)
            End Get
            Set
                Me("Messintervall_NumericUpDown") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Halbtonverschiebung() As SByte
            Get
                Return CType(Me("Halbtonverschiebung"),SByte)
            End Get
            Set
                Me("Halbtonverschiebung") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property META_Dateinamen_Input() As String
            Get
                Return CType(Me("META_Dateinamen_Input"),String)
            End Get
            Set
                Me("META_Dateinamen_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property META_Autor_Input() As String
            Get
                Return CType(Me("META_Autor_Input"),String)
            End Get
            Set
                Me("META_Autor_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property META_Spurnamen_Input() As String
            Get
                Return CType(Me("META_Spurnamen_Input"),String)
            End Get
            Set
                Me("META_Spurnamen_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property META_Copyright_Input() As String
            Get
                Return CType(Me("META_Copyright_Input"),String)
            End Get
            Set
                Me("META_Copyright_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property META_Bemerkung_Input() As String
            Get
                Return CType(Me("META_Bemerkung_Input"),String)
            End Get
            Set
                Me("META_Bemerkung_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Metronom_Betont() As Boolean
            Get
                Return CType(Me("Metronom_Betont"),Boolean)
            End Get
            Set
                Me("Metronom_Betont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Metronom_ON() As Boolean
            Get
                Return CType(Me("Metronom_ON"),Boolean)
            End Get
            Set
                Me("Metronom_ON") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property DirectPlay_ON() As Boolean
            Get
                Return CType(Me("DirectPlay_ON"),Boolean)
            End Get
            Set
                Me("DirectPlay_ON") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property hsbVolume() As Byte
            Get
                Return CType(Me("hsbVolume"),Byte)
            End Get
            Set
                Me("hsbVolume") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property hsbPan() As Byte
            Get
                Return CType(Me("hsbPan"),Byte)
            End Get
            Set
                Me("hsbPan") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property hsbModWheel() As Byte
            Get
                Return CType(Me("hsbModWheel"),Byte)
            End Get
            Set
                Me("hsbModWheel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ToolTip_ON() As Boolean
            Get
                Return CType(Me("ToolTip_ON"),Boolean)
            End Get
            Set
                Me("ToolTip_ON") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property C_Klappe() As SByte
            Get
                Return CType(Me("C_Klappe"),SByte)
            End Get
            Set
                Me("C_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property D_Klappe() As SByte
            Get
                Return CType(Me("D_Klappe"),SByte)
            End Get
            Set
                Me("D_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property E_Klappe() As SByte
            Get
                Return CType(Me("E_Klappe"),SByte)
            End Get
            Set
                Me("E_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property F_Klappe() As SByte
            Get
                Return CType(Me("F_Klappe"),SByte)
            End Get
            Set
                Me("F_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property G_Klappe() As SByte
            Get
                Return CType(Me("G_Klappe"),SByte)
            End Get
            Set
                Me("G_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property A_Klappe() As SByte
            Get
                Return CType(Me("A_Klappe"),SByte)
            End Get
            Set
                Me("A_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property H_Klappe() As SByte
            Get
                Return CType(Me("H_Klappe"),SByte)
            End Get
            Set
                Me("H_Klappe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property C2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("C2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("C2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property D2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("D2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("D2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property E2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("E2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("E2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property F2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("F2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("F2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property G2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("G2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("G2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property A2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("A2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("A2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property H2_Grenzwert_Save() As Byte
            Get
                Return CType(Me("H2_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("H2_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property C3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("C3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("C3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property D3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("D3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("D3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property E3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("E3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("E3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property F3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("F3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("F3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property G3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("G3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("G3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property A3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("A3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("A3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property H3_Grenzwert_Save() As Byte
            Get
                Return CType(Me("H3_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("H3_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property C4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("C4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("C4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property D4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("D4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("D4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property E4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("E4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("E4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property F4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("F4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("F4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property G4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("G4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("G4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property A4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("A4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("A4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property H4_Grenzwert_Save() As Byte
            Get
                Return CType(Me("H4_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("H4_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property C5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("C5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("C5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property D5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("D5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("D5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property E5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("E5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("E5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property F5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("F5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("F5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property G5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("G5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("G5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property A5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("A5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("A5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property H5_Grenzwert_Save() As Byte
            Get
                Return CType(Me("H5_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("H5_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property C6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("C6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("C6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property D6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("D6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("D6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property E6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("E6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("E6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property F6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("F6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("F6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property G6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("G6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("G6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property A6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("A6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("A6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property H6_Grenzwert_Save() As Byte
            Get
                Return CType(Me("H6_Grenzwert_Save"),Byte)
            End Get
            Set
                Me("H6_Grenzwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting() As String
            Get
                Return CType(Me("Setting"),String)
            End Get
            Set
                Me("Setting") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.MIDI_Harfe.My.MySettings
            Get
                Return Global.MIDI_Harfe.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
