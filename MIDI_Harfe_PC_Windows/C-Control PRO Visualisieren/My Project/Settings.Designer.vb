﻿' -----------------------------------------------------------------------
' <copyright file="Settings.Designer.vb">
' Nico Bosshard
' </copyright>
' -----------------------------------------------------------------------


Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
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
        Public Property Takt_Zaehler_Input() As Byte
            Get
                Return CType(Me("Takt_Zaehler_Input"),Byte)
            End Get
            Set
                Me("Takt_Zaehler_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property Takt_Naenner_Input() As Byte
            Get
                Return CType(Me("Takt_Naenner_Input"),Byte)
            End Get
            Set
                Me("Takt_Naenner_Input") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("48")>  _
        Public Property Speed() As UShort
            Get
                Return CType(Me("Speed"),UShort)
            End Get
            Set
                Me("Speed") = value
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
        Public Property META_Dateiname_Input() As String
            Get
                Return CType(Me("META_Dateiname_Input"),String)
            End Get
            Set
                Me("META_Dateiname_Input") = value
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
        Public Property META_Spurname_Input() As String
            Get
                Return CType(Me("META_Spurname_Input"),String)
            End Get
            Set
                Me("META_Spurname_Input") = value
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
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Start_Tastenkombination_Save() As String
            Get
                Return CType(Me("Start_Tastenkombination_Save"),String)
            End Get
            Set
                Me("Start_Tastenkombination_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Start_Tastenkombination_Key2_Save() As Byte
            Get
                Return CType(Me("Start_Tastenkombination_Key2_Save"),Byte)
            End Get
            Set
                Me("Start_Tastenkombination_Key2_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Start_Tastenkombination_Key3_Save() As Byte
            Get
                Return CType(Me("Start_Tastenkombination_Key3_Save"),Byte)
            End Get
            Set
                Me("Start_Tastenkombination_Key3_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Pause_Tastenkombination_Save() As String
            Get
                Return CType(Me("Pause_Tastenkombination_Save"),String)
            End Get
            Set
                Me("Pause_Tastenkombination_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Pause_Tastenkombination_Key2_Save() As Byte
            Get
                Return CType(Me("Pause_Tastenkombination_Key2_Save"),Byte)
            End Get
            Set
                Me("Pause_Tastenkombination_Key2_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Pause_Tastenkombination_Key3_Save() As Byte
            Get
                Return CType(Me("Pause_Tastenkombination_Key3_Save"),Byte)
            End Get
            Set
                Me("Pause_Tastenkombination_Key3_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Save_Tastenkombination_Save() As String
            Get
                Return CType(Me("Save_Tastenkombination_Save"),String)
            End Get
            Set
                Me("Save_Tastenkombination_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Save_Tastenkombination_Key2_Save() As Byte
            Get
                Return CType(Me("Save_Tastenkombination_Key2_Save"),Byte)
            End Get
            Set
                Me("Save_Tastenkombination_Key2_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Save_Tastenkombination_Key3_Save() As Byte
            Get
                Return CType(Me("Save_Tastenkombination_Key3_Save"),Byte)
            End Get
            Set
                Me("Save_Tastenkombination_Key3_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Lizenz_Save() As String
            Get
                Return CType(Me("Lizenz_Save"),String)
            End Get
            Set
                Me("Lizenz_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SendKeys_ON_Save() As Byte
            Get
                Return CType(Me("SendKeys_ON_Save"),Byte)
            End Get
            Set
                Me("SendKeys_ON_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("127")>  _
        Public Property Volume_Steps_Save() As Byte
            Get
                Return CType(Me("Volume_Steps_Save"),Byte)
            End Get
            Set
                Me("Volume_Steps_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Volume_min_Save() As Byte
            Get
                Return CType(Me("Volume_min_Save"),Byte)
            End Get
            Set
                Me("Volume_min_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("127")>  _
        Public Property Volume_max_Save() As Byte
            Get
                Return CType(Me("Volume_max_Save"),Byte)
            End Get
            Set
                Me("Volume_max_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>0</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property Start_Tastenkombination_Key_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Start_Tastenkombination_Key_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Start_Tastenkombination_Key_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>0</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property Pause_Tastenkombination_Key_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Pause_Tastenkombination_Key_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Pause_Tastenkombination_Key_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>0</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property Save_Tastenkombination_Key_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Save_Tastenkombination_Key_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Save_Tastenkombination_Key_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>#</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property SendKey_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("SendKey_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("SendKey_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>#</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property Startwert_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Startwert_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Startwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>#</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property Stoppwert_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Stoppwert_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Stoppwert_Save") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>#</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property Verschiebung_Save() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Verschiebung_Save"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Verschiebung_Save") = value
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
