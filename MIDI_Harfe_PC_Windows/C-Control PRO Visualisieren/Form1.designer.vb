<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SaveMIDIDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Tackt = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tastenkonbinationen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Tastenkonbinationen_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Aktion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Konbination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Save_Tastenkombination = New System.Windows.Forms.Button()
        Me.Pause_Tastenkombination = New System.Windows.Forms.Button()
        Me.Start_Tastenkombination = New System.Windows.Forms.Button()
        Me.Save_Label = New System.Windows.Forms.Label()
        Me.Pause_Label = New System.Windows.Forms.Label()
        Me.Start_Label = New System.Windows.Forms.Label()
        Me.ToolTip_YesNo_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip_OFF = New System.Windows.Forms.RadioButton()
        Me.ToolTip_ON = New System.Windows.Forms.RadioButton()
        Me.META_Tags_GroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.META_Autor_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.META_Spurnamen_Input = New System.Windows.Forms.TextBox()
        Me.Bemerkung_GroupBox = New System.Windows.Forms.GroupBox()
        Me.META_Bemerkung_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.META_Dateinamen_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.META_Copyright_Input = New System.Windows.Forms.TextBox()
        Me.MIDI_SpecialMode = New System.Windows.Forms.RadioButton()
        Me.MIDI_NormalMode = New System.Windows.Forms.RadioButton()
        Me.Metronom_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Metronom_OFF = New System.Windows.Forms.RadioButton()
        Me.Metronom_ON = New System.Windows.Forms.RadioButton()
        Me.Metronom_Betont = New System.Windows.Forms.RadioButton()
        Me.Transpose_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Halbtonverschiebung = New System.Windows.Forms.NumericUpDown()
        Me.Oktavenverschiebung = New System.Windows.Forms.ComboBox()
        Me.Connect_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Comport = New System.Windows.Forms.ComboBox()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.cboInstruments = New System.Windows.Forms.ComboBox()
        Me.DirectPlay_OFF = New System.Windows.Forms.RadioButton()
        Me.Messintervall_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Messintervall_TextBox = New System.Windows.Forms.TextBox()
        Me.MessungenProS_TexBox = New System.Windows.Forms.TextBox()
        Me.Messintervall_Label = New System.Windows.Forms.Label()
        Me.Tempo_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Tackt_Naenner_Input = New System.Windows.Forms.NumericUpDown()
        Me.Tackt_Zaehler_Input = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BPM_Label = New System.Windows.Forms.Label()
        Me.BPM = New System.Windows.Forms.NumericUpDown()
        Me.DirectPlay_ON = New System.Windows.Forms.RadioButton()
        Me.SendKeys_OFF = New System.Windows.Forms.RadioButton()
        Me.SendKeys_ON = New System.Windows.Forms.RadioButton()
        Me.SendKey_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SendKey_gis = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SendKey_ais = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SendKey_fis = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SendKey_cis = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SendKey_dis = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SendKey_OM = New System.Windows.Forms.Button()
        Me.SendKey_g = New System.Windows.Forms.Button()
        Me.SendKey_d = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SendKey_OP = New System.Windows.Forms.Button()
        Me.SendKey_a = New System.Windows.Forms.Button()
        Me.SendKey_e = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SendKey_h = New System.Windows.Forms.Button()
        Me.SendKey_f = New System.Windows.Forms.Button()
        Me.SendKey_c = New System.Windows.Forms.Button()
        Me.SendKeys_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Instrumentenauswahl_GroupBox = New System.Windows.Forms.GroupBox()
        Me.MIDI_Aufnahmemodus_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Volume_max_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Volume_min_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Volume_Steps_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MIDI_Pause_Button = New System.Windows.Forms.Button()
        Me.MIDI_Start_Button = New System.Windows.Forms.Button()
        Me.MIDI_Save_Button = New System.Windows.Forms.Button()
        Me.MIDI_Visualisierung_GroupBox = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C6_Button = New System.Windows.Forms.Button()
        Me.D6_Button = New System.Windows.Forms.Button()
        Me.E6_Button = New System.Windows.Forms.Button()
        Me.F6_Button = New System.Windows.Forms.Button()
        Me.G6_Button = New System.Windows.Forms.Button()
        Me.A6_Button = New System.Windows.Forms.Button()
        Me.H6_Button = New System.Windows.Forms.Button()
        Me.C6_Wert = New System.Windows.Forms.TextBox()
        Me.D6_Wert = New System.Windows.Forms.TextBox()
        Me.E6_Wert = New System.Windows.Forms.TextBox()
        Me.F6_Wert = New System.Windows.Forms.TextBox()
        Me.G6_Wert = New System.Windows.Forms.TextBox()
        Me.A6_Wert = New System.Windows.Forms.TextBox()
        Me.H6_Wert = New System.Windows.Forms.TextBox()
        Me.C6_Startwert = New System.Windows.Forms.TextBox()
        Me.D6_Startwert = New System.Windows.Forms.TextBox()
        Me.E6_Startwert = New System.Windows.Forms.TextBox()
        Me.F6_Startwert = New System.Windows.Forms.TextBox()
        Me.G6_Startwert = New System.Windows.Forms.TextBox()
        Me.A6_Startwert = New System.Windows.Forms.TextBox()
        Me.H6_Startwert = New System.Windows.Forms.TextBox()
        Me.C6_Stopwert = New System.Windows.Forms.TextBox()
        Me.D6_Stopwert = New System.Windows.Forms.TextBox()
        Me.E6_Stopwert = New System.Windows.Forms.TextBox()
        Me.F6_Stopwert = New System.Windows.Forms.TextBox()
        Me.G6_Stopwert = New System.Windows.Forms.TextBox()
        Me.A6_Stopwert = New System.Windows.Forms.TextBox()
        Me.H6_Stopwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C2_Button = New System.Windows.Forms.Button()
        Me.D2_Button = New System.Windows.Forms.Button()
        Me.E2_Button = New System.Windows.Forms.Button()
        Me.F2_Button = New System.Windows.Forms.Button()
        Me.G2_Button = New System.Windows.Forms.Button()
        Me.A2_Button = New System.Windows.Forms.Button()
        Me.H2_Button = New System.Windows.Forms.Button()
        Me.C2_Wert = New System.Windows.Forms.TextBox()
        Me.D2_Wert = New System.Windows.Forms.TextBox()
        Me.E2_Wert = New System.Windows.Forms.TextBox()
        Me.F2_Wert = New System.Windows.Forms.TextBox()
        Me.G2_Wert = New System.Windows.Forms.TextBox()
        Me.A2_Wert = New System.Windows.Forms.TextBox()
        Me.H2_Wert = New System.Windows.Forms.TextBox()
        Me.C2_Startwert = New System.Windows.Forms.TextBox()
        Me.D2_Startwert = New System.Windows.Forms.TextBox()
        Me.E2_Startwert = New System.Windows.Forms.TextBox()
        Me.F2_Startwert = New System.Windows.Forms.TextBox()
        Me.G2_Startwert = New System.Windows.Forms.TextBox()
        Me.A2_Startwert = New System.Windows.Forms.TextBox()
        Me.H2_Startwert = New System.Windows.Forms.TextBox()
        Me.C2_Stopwert = New System.Windows.Forms.TextBox()
        Me.D2_Stopwert = New System.Windows.Forms.TextBox()
        Me.E2_Stopwert = New System.Windows.Forms.TextBox()
        Me.F2_Stopwert = New System.Windows.Forms.TextBox()
        Me.G2_Stopwert = New System.Windows.Forms.TextBox()
        Me.A2_Stopwert = New System.Windows.Forms.TextBox()
        Me.H2_Stopwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C3_Button = New System.Windows.Forms.Button()
        Me.D3_Button = New System.Windows.Forms.Button()
        Me.E3_Button = New System.Windows.Forms.Button()
        Me.F3_Button = New System.Windows.Forms.Button()
        Me.G3_Button = New System.Windows.Forms.Button()
        Me.A3_Button = New System.Windows.Forms.Button()
        Me.H3_Button = New System.Windows.Forms.Button()
        Me.C3_Wert = New System.Windows.Forms.TextBox()
        Me.D3_Wert = New System.Windows.Forms.TextBox()
        Me.E3_Wert = New System.Windows.Forms.TextBox()
        Me.F3_Wert = New System.Windows.Forms.TextBox()
        Me.G3_Wert = New System.Windows.Forms.TextBox()
        Me.A3_Wert = New System.Windows.Forms.TextBox()
        Me.H3_Wert = New System.Windows.Forms.TextBox()
        Me.C3_Startwert = New System.Windows.Forms.TextBox()
        Me.D3_Startwert = New System.Windows.Forms.TextBox()
        Me.E3_Startwert = New System.Windows.Forms.TextBox()
        Me.F3_Startwert = New System.Windows.Forms.TextBox()
        Me.G3_Startwert = New System.Windows.Forms.TextBox()
        Me.A3_Startwert = New System.Windows.Forms.TextBox()
        Me.H3_Startwert = New System.Windows.Forms.TextBox()
        Me.C3_Stopwert = New System.Windows.Forms.TextBox()
        Me.D3_Stopwert = New System.Windows.Forms.TextBox()
        Me.E3_Stopwert = New System.Windows.Forms.TextBox()
        Me.F3_Stopwert = New System.Windows.Forms.TextBox()
        Me.G3_Stopwert = New System.Windows.Forms.TextBox()
        Me.A3_Stopwert = New System.Windows.Forms.TextBox()
        Me.H3_Stopwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C5_Button = New System.Windows.Forms.Button()
        Me.D5_Button = New System.Windows.Forms.Button()
        Me.E5_Button = New System.Windows.Forms.Button()
        Me.F5_Button = New System.Windows.Forms.Button()
        Me.G5_Button = New System.Windows.Forms.Button()
        Me.A5_Button = New System.Windows.Forms.Button()
        Me.H5_Button = New System.Windows.Forms.Button()
        Me.C5_Wert = New System.Windows.Forms.TextBox()
        Me.D5_Wert = New System.Windows.Forms.TextBox()
        Me.E5_Wert = New System.Windows.Forms.TextBox()
        Me.F5_Wert = New System.Windows.Forms.TextBox()
        Me.G5_Wert = New System.Windows.Forms.TextBox()
        Me.A5_Wert = New System.Windows.Forms.TextBox()
        Me.H5_Wert = New System.Windows.Forms.TextBox()
        Me.C5_Startwert = New System.Windows.Forms.TextBox()
        Me.D5_Startwert = New System.Windows.Forms.TextBox()
        Me.E5_Startwert = New System.Windows.Forms.TextBox()
        Me.F5_Startwert = New System.Windows.Forms.TextBox()
        Me.G5_Startwert = New System.Windows.Forms.TextBox()
        Me.A5_Startwert = New System.Windows.Forms.TextBox()
        Me.H5_Startwert = New System.Windows.Forms.TextBox()
        Me.C5_Stopwert = New System.Windows.Forms.TextBox()
        Me.D5_Stopwert = New System.Windows.Forms.TextBox()
        Me.E5_Stopwert = New System.Windows.Forms.TextBox()
        Me.F5_Stopwert = New System.Windows.Forms.TextBox()
        Me.G5_Stopwert = New System.Windows.Forms.TextBox()
        Me.A5_Stopwert = New System.Windows.Forms.TextBox()
        Me.H5_Stopwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C4_Button = New System.Windows.Forms.Button()
        Me.D4_Button = New System.Windows.Forms.Button()
        Me.E4_Button = New System.Windows.Forms.Button()
        Me.F4_Button = New System.Windows.Forms.Button()
        Me.G4_Button = New System.Windows.Forms.Button()
        Me.A4_Button = New System.Windows.Forms.Button()
        Me.H4_Button = New System.Windows.Forms.Button()
        Me.C4_Wert = New System.Windows.Forms.TextBox()
        Me.D4_Wert = New System.Windows.Forms.TextBox()
        Me.E4_Wert = New System.Windows.Forms.TextBox()
        Me.F4_Wert = New System.Windows.Forms.TextBox()
        Me.G4_Wert = New System.Windows.Forms.TextBox()
        Me.A4_Wert = New System.Windows.Forms.TextBox()
        Me.H4_Wert = New System.Windows.Forms.TextBox()
        Me.C4_Startwert = New System.Windows.Forms.TextBox()
        Me.D4_Startwert = New System.Windows.Forms.TextBox()
        Me.E4_Startwert = New System.Windows.Forms.TextBox()
        Me.F4_Startwert = New System.Windows.Forms.TextBox()
        Me.G4_Startwert = New System.Windows.Forms.TextBox()
        Me.A4_Startwert = New System.Windows.Forms.TextBox()
        Me.H4_Startwert = New System.Windows.Forms.TextBox()
        Me.C4_Stopwert = New System.Windows.Forms.TextBox()
        Me.D4_Stopwert = New System.Windows.Forms.TextBox()
        Me.E4_Stopwert = New System.Windows.Forms.TextBox()
        Me.F4_Stopwert = New System.Windows.Forms.TextBox()
        Me.G4_Stopwert = New System.Windows.Forms.TextBox()
        Me.A4_Stopwert = New System.Windows.Forms.TextBox()
        Me.H4_Stopwert = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.DirectPlay_YesNo_GroupBox = New System.Windows.Forms.GroupBox()
        Me.About_Button = New System.Windows.Forms.Button()
        Me.Help_Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Anz_Messungen_TextBox = New System.Windows.Forms.TextBox()
        Me.Anz_Verbindungsfehler_TextBox = New System.Windows.Forms.TextBox()
        Me.Tackt_Ausgabefenster = New System.Windows.Forms.Label()
        Me.Com_Search_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.C_Klappe = New System.Windows.Forms.TrackBar()
        Me.Serial_BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Mesgeschwindigkeitsberechnung_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GetAsyncKeyState_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DirectPlay_GroupBox = New System.Windows.Forms.GroupBox()
        Me.DirectPlay_Einstellungen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.hsbVolume = New System.Windows.Forms.HScrollBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.hsbPan = New System.Windows.Forms.HScrollBar()
        Me.hsbModWheel = New System.Windows.Forms.HScrollBar()
        Me.Programmeinstellungen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Klappen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C1_Klappe = New System.Windows.Forms.TrackBar()
        Me.D1_Klappe = New System.Windows.Forms.TrackBar()
        Me.E1_Klappe = New System.Windows.Forms.TrackBar()
        Me.F1_Klappe = New System.Windows.Forms.TrackBar()
        Me.G1_Klappe = New System.Windows.Forms.TrackBar()
        Me.A1_Klappe = New System.Windows.Forms.TrackBar()
        Me.H1_Klappe = New System.Windows.Forms.TrackBar()
        Me.C2_Klappe = New System.Windows.Forms.TrackBar()
        Me.C1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.D1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.E1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.F1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.G1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.A1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.H1_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.C2_Klappe_Text = New System.Windows.Forms.TextBox()
        Me.Einstellungen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Display_Refresh_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Tastenkonbinationen_GroupBox.SuspendLayout()
        CType(Me.Tastenkonbinationen_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTip_YesNo_GroupBox.SuspendLayout()
        Me.META_Tags_GroupBox.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Bemerkung_GroupBox.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Metronom_GroupBox.SuspendLayout()
        Me.Transpose_GroupBox.SuspendLayout()
        CType(Me.Halbtonverschiebung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Connect_GroupBox.SuspendLayout()
        Me.Messintervall_GroupBox.SuspendLayout()
        Me.Tempo_GroupBox.SuspendLayout()
        CType(Me.Tackt_Naenner_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tackt_Zaehler_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SendKey_GroupBox.SuspendLayout()
        Me.SendKeys_GroupBox.SuspendLayout()
        Me.Instrumentenauswahl_GroupBox.SuspendLayout()
        Me.MIDI_Aufnahmemodus_GroupBox.SuspendLayout()
        CType(Me.Volume_max_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Volume_min_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Volume_Steps_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MIDI_Visualisierung_GroupBox.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.DirectPlay_YesNo_GroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.DirectPlay_GroupBox.SuspendLayout()
        Me.DirectPlay_Einstellungen_GroupBox.SuspendLayout()
        Me.Programmeinstellungen_GroupBox.SuspendLayout()
        Me.Klappen_GroupBox.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        CType(Me.C1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.H1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Einstellungen_GroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 230400
        Me.SerialPort1.DtrEnable = True
        '
        'Tackt
        '
        Me.Tackt.Interval = 125
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 30000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        '
        'Tastenkonbinationen_GroupBox
        '
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Tastenkonbinationen_DataGridView)
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Save_Tastenkombination)
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Pause_Tastenkombination)
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Start_Tastenkombination)
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Save_Label)
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Pause_Label)
        Me.Tastenkonbinationen_GroupBox.Controls.Add(Me.Start_Label)
        Me.Tastenkonbinationen_GroupBox.Location = New System.Drawing.Point(1149, 345)
        Me.Tastenkonbinationen_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tastenkonbinationen_GroupBox.Name = "Tastenkonbinationen_GroupBox"
        Me.Tastenkonbinationen_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tastenkonbinationen_GroupBox.Size = New System.Drawing.Size(742, 175)
        Me.Tastenkonbinationen_GroupBox.TabIndex = 197
        Me.Tastenkonbinationen_GroupBox.TabStop = False
        Me.Tastenkonbinationen_GroupBox.Text = "Tastenkonbinationen (Hintergrundssteuerung)"
        Me.ToolTip1.SetToolTip(Me.Tastenkonbinationen_GroupBox, "/")
        '
        'Tastenkonbinationen_DataGridView
        '
        Me.Tastenkonbinationen_DataGridView.AllowUserToAddRows = False
        Me.Tastenkonbinationen_DataGridView.AllowUserToDeleteRows = False
        Me.Tastenkonbinationen_DataGridView.AllowUserToResizeColumns = False
        Me.Tastenkonbinationen_DataGridView.AllowUserToResizeRows = False
        Me.Tastenkonbinationen_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Tastenkonbinationen_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tastenkonbinationen_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Tastenkonbinationen_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tastenkonbinationen_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Aktion, Me.Konbination})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tastenkonbinationen_DataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tastenkonbinationen_DataGridView.EnableHeadersVisualStyles = False
        Me.Tastenkonbinationen_DataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.Tastenkonbinationen_DataGridView.Location = New System.Drawing.Point(360, 31)
        Me.Tastenkonbinationen_DataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tastenkonbinationen_DataGridView.MultiSelect = False
        Me.Tastenkonbinationen_DataGridView.Name = "Tastenkonbinationen_DataGridView"
        Me.Tastenkonbinationen_DataGridView.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tastenkonbinationen_DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Tastenkonbinationen_DataGridView.RowHeadersVisible = False
        Me.Tastenkonbinationen_DataGridView.Size = New System.Drawing.Size(360, 128)
        Me.Tastenkonbinationen_DataGridView.TabIndex = 191
        '
        'Aktion
        '
        Me.Aktion.FillWeight = 110.0!
        Me.Aktion.HeaderText = "Aktion"
        Me.Aktion.Name = "Aktion"
        Me.Aktion.ReadOnly = True
        Me.Aktion.Width = 110
        '
        'Konbination
        '
        Me.Konbination.FillWeight = 110.0!
        Me.Konbination.HeaderText = "Konbination"
        Me.Konbination.Name = "Konbination"
        Me.Konbination.ReadOnly = True
        Me.Konbination.Width = 110
        '
        'Save_Tastenkombination
        '
        Me.Save_Tastenkombination.Location = New System.Drawing.Point(78, 126)
        Me.Save_Tastenkombination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Save_Tastenkombination.Name = "Save_Tastenkombination"
        Me.Save_Tastenkombination.Size = New System.Drawing.Size(252, 32)
        Me.Save_Tastenkombination.TabIndex = 190
        Me.Save_Tastenkombination.Text = "F9"
        Me.Save_Tastenkombination.UseVisualStyleBackColor = True
        '
        'Pause_Tastenkombination
        '
        Me.Pause_Tastenkombination.Location = New System.Drawing.Point(78, 75)
        Me.Pause_Tastenkombination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pause_Tastenkombination.Name = "Pause_Tastenkombination"
        Me.Pause_Tastenkombination.Size = New System.Drawing.Size(252, 32)
        Me.Pause_Tastenkombination.TabIndex = 189
        Me.Pause_Tastenkombination.Text = "Leert."
        Me.Pause_Tastenkombination.UseVisualStyleBackColor = True
        '
        'Start_Tastenkombination
        '
        Me.Start_Tastenkombination.Location = New System.Drawing.Point(78, 29)
        Me.Start_Tastenkombination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Start_Tastenkombination.Name = "Start_Tastenkombination"
        Me.Start_Tastenkombination.Size = New System.Drawing.Size(252, 32)
        Me.Start_Tastenkombination.TabIndex = 188
        Me.Start_Tastenkombination.Text = "F9"
        Me.Start_Tastenkombination.UseVisualStyleBackColor = True
        '
        'Save_Label
        '
        Me.Save_Label.AutoSize = True
        Me.Save_Label.Location = New System.Drawing.Point(10, 132)
        Me.Save_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Save_Label.Name = "Save_Label"
        Me.Save_Label.Size = New System.Drawing.Size(49, 20)
        Me.Save_Label.TabIndex = 2
        Me.Save_Label.Text = "Save:"
        '
        'Pause_Label
        '
        Me.Pause_Label.AutoSize = True
        Me.Pause_Label.Location = New System.Drawing.Point(10, 82)
        Me.Pause_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Pause_Label.Name = "Pause_Label"
        Me.Pause_Label.Size = New System.Drawing.Size(58, 20)
        Me.Pause_Label.TabIndex = 1
        Me.Pause_Label.Text = "Pause:"
        '
        'Start_Label
        '
        Me.Start_Label.AutoSize = True
        Me.Start_Label.Location = New System.Drawing.Point(9, 35)
        Me.Start_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Start_Label.Name = "Start_Label"
        Me.Start_Label.Size = New System.Drawing.Size(48, 20)
        Me.Start_Label.TabIndex = 0
        Me.Start_Label.Text = "Start:"
        '
        'ToolTip_YesNo_GroupBox
        '
        Me.ToolTip_YesNo_GroupBox.Controls.Add(Me.ToolTip_OFF)
        Me.ToolTip_YesNo_GroupBox.Controls.Add(Me.ToolTip_ON)
        Me.ToolTip_YesNo_GroupBox.Location = New System.Drawing.Point(38, 34)
        Me.ToolTip_YesNo_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolTip_YesNo_GroupBox.Name = "ToolTip_YesNo_GroupBox"
        Me.ToolTip_YesNo_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolTip_YesNo_GroupBox.Size = New System.Drawing.Size(302, 83)
        Me.ToolTip_YesNo_GroupBox.TabIndex = 0
        Me.ToolTip_YesNo_GroupBox.TabStop = False
        Me.ToolTip_YesNo_GroupBox.Text = "ToolTip Hilfe Anzeigen?"
        Me.ToolTip1.SetToolTip(Me.ToolTip_YesNo_GroupBox, resources.GetString("ToolTip_YesNo_GroupBox.ToolTip"))
        '
        'ToolTip_OFF
        '
        Me.ToolTip_OFF.AutoSize = True
        Me.ToolTip_OFF.Checked = True
        Me.ToolTip_OFF.Location = New System.Drawing.Point(186, 34)
        Me.ToolTip_OFF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolTip_OFF.Name = "ToolTip_OFF"
        Me.ToolTip_OFF.Size = New System.Drawing.Size(66, 24)
        Me.ToolTip_OFF.TabIndex = 3
        Me.ToolTip_OFF.TabStop = True
        Me.ToolTip_OFF.Text = "Nein"
        Me.ToolTip1.SetToolTip(Me.ToolTip_OFF, "Deaktiviert diese TolTip Hilfe")
        Me.ToolTip_OFF.UseVisualStyleBackColor = True
        '
        'ToolTip_ON
        '
        Me.ToolTip_ON.AutoSize = True
        Me.ToolTip_ON.Location = New System.Drawing.Point(50, 34)
        Me.ToolTip_ON.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolTip_ON.Name = "ToolTip_ON"
        Me.ToolTip_ON.Size = New System.Drawing.Size(51, 24)
        Me.ToolTip_ON.TabIndex = 2
        Me.ToolTip_ON.Text = "Ja"
        Me.ToolTip1.SetToolTip(Me.ToolTip_ON, "Aktiviert diese TolTip Hilfe")
        Me.ToolTip_ON.UseVisualStyleBackColor = True
        '
        'META_Tags_GroupBox
        '
        Me.META_Tags_GroupBox.Controls.Add(Me.GroupBox16)
        Me.META_Tags_GroupBox.Controls.Add(Me.GroupBox11)
        Me.META_Tags_GroupBox.Controls.Add(Me.Bemerkung_GroupBox)
        Me.META_Tags_GroupBox.Controls.Add(Me.GroupBox10)
        Me.META_Tags_GroupBox.Controls.Add(Me.GroupBox8)
        Me.META_Tags_GroupBox.Location = New System.Drawing.Point(824, 17)
        Me.META_Tags_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Tags_GroupBox.Name = "META_Tags_GroupBox"
        Me.META_Tags_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Tags_GroupBox.Size = New System.Drawing.Size(292, 472)
        Me.META_Tags_GroupBox.TabIndex = 194
        Me.META_Tags_GroupBox.TabStop = False
        Me.META_Tags_GroupBox.Text = "Zusatzinformationen (Optional)"
        Me.ToolTip1.SetToolTip(Me.META_Tags_GroupBox, resources.GetString("META_Tags_GroupBox.ToolTip"))
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.META_Autor_Input)
        Me.GroupBox16.Location = New System.Drawing.Point(22, 112)
        Me.GroupBox16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox16.Size = New System.Drawing.Size(246, 71)
        Me.GroupBox16.TabIndex = 5
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Autor"
        '
        'META_Autor_Input
        '
        Me.META_Autor_Input.Location = New System.Drawing.Point(18, 26)
        Me.META_Autor_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Autor_Input.MaxLength = 127
        Me.META_Autor_Input.Name = "META_Autor_Input"
        Me.META_Autor_Input.Size = New System.Drawing.Size(211, 26)
        Me.META_Autor_Input.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.META_Spurnamen_Input)
        Me.GroupBox11.Location = New System.Drawing.Point(21, 192)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox11.Size = New System.Drawing.Size(248, 71)
        Me.GroupBox11.TabIndex = 4
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = " Spurnamen"
        '
        'META_Spurnamen_Input
        '
        Me.META_Spurnamen_Input.Location = New System.Drawing.Point(21, 29)
        Me.META_Spurnamen_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Spurnamen_Input.MaxLength = 127
        Me.META_Spurnamen_Input.Name = "META_Spurnamen_Input"
        Me.META_Spurnamen_Input.Size = New System.Drawing.Size(211, 26)
        Me.META_Spurnamen_Input.TabIndex = 0
        '
        'Bemerkung_GroupBox
        '
        Me.Bemerkung_GroupBox.Controls.Add(Me.META_Bemerkung_Input)
        Me.Bemerkung_GroupBox.Location = New System.Drawing.Point(24, 372)
        Me.Bemerkung_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bemerkung_GroupBox.Name = "Bemerkung_GroupBox"
        Me.Bemerkung_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bemerkung_GroupBox.Size = New System.Drawing.Size(248, 88)
        Me.Bemerkung_GroupBox.TabIndex = 3
        Me.Bemerkung_GroupBox.TabStop = False
        Me.Bemerkung_GroupBox.Text = "Bemerkung"
        '
        'META_Bemerkung_Input
        '
        Me.META_Bemerkung_Input.Location = New System.Drawing.Point(18, 29)
        Me.META_Bemerkung_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Bemerkung_Input.MaxLength = 127
        Me.META_Bemerkung_Input.Multiline = True
        Me.META_Bemerkung_Input.Name = "META_Bemerkung_Input"
        Me.META_Bemerkung_Input.Size = New System.Drawing.Size(211, 47)
        Me.META_Bemerkung_Input.TabIndex = 1
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.META_Dateinamen_Input)
        Me.GroupBox10.Location = New System.Drawing.Point(21, 32)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox10.Size = New System.Drawing.Size(248, 71)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Dateinamen (im META)"
        '
        'META_Dateinamen_Input
        '
        Me.META_Dateinamen_Input.Location = New System.Drawing.Point(18, 26)
        Me.META_Dateinamen_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Dateinamen_Input.MaxLength = 127
        Me.META_Dateinamen_Input.Name = "META_Dateinamen_Input"
        Me.META_Dateinamen_Input.Size = New System.Drawing.Size(211, 26)
        Me.META_Dateinamen_Input.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.META_Copyright_Input)
        Me.GroupBox8.Location = New System.Drawing.Point(22, 271)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(249, 92)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Copyright Eintrag"
        Me.ToolTip1.SetToolTip(Me.GroupBox8, "Copyright Eintrag in den META Tag des MIDI Files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Der Eintrag darf die Länge von " &
        "255 Zeichen nicht überschreiten!")
        '
        'META_Copyright_Input
        '
        Me.META_Copyright_Input.Location = New System.Drawing.Point(18, 29)
        Me.META_Copyright_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.META_Copyright_Input.MaxLength = 127
        Me.META_Copyright_Input.Multiline = True
        Me.META_Copyright_Input.Name = "META_Copyright_Input"
        Me.META_Copyright_Input.Size = New System.Drawing.Size(211, 47)
        Me.META_Copyright_Input.TabIndex = 2
        '
        'MIDI_SpecialMode
        '
        Me.MIDI_SpecialMode.AutoSize = True
        Me.MIDI_SpecialMode.Checked = True
        Me.MIDI_SpecialMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MIDI_SpecialMode.Location = New System.Drawing.Point(174, 29)
        Me.MIDI_SpecialMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_SpecialMode.Name = "MIDI_SpecialMode"
        Me.MIDI_SpecialMode.Size = New System.Drawing.Size(105, 24)
        Me.MIDI_SpecialMode.TabIndex = 4
        Me.MIDI_SpecialMode.TabStop = True
        Me.MIDI_SpecialMode.Text = "Rohdaten"
        Me.ToolTip1.SetToolTip(Me.MIDI_SpecialMode, resources.GetString("MIDI_SpecialMode.ToolTip"))
        Me.MIDI_SpecialMode.UseVisualStyleBackColor = True
        '
        'MIDI_NormalMode
        '
        Me.MIDI_NormalMode.AutoSize = True
        Me.MIDI_NormalMode.Location = New System.Drawing.Point(20, 29)
        Me.MIDI_NormalMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_NormalMode.Name = "MIDI_NormalMode"
        Me.MIDI_NormalMode.Size = New System.Drawing.Size(144, 24)
        Me.MIDI_NormalMode.TabIndex = 3
        Me.MIDI_NormalMode.Text = "Standardt MIDI"
        Me.ToolTip1.SetToolTip(Me.MIDI_NormalMode, resources.GetString("MIDI_NormalMode.ToolTip"))
        Me.MIDI_NormalMode.UseVisualStyleBackColor = True
        '
        'Metronom_GroupBox
        '
        Me.Metronom_GroupBox.Controls.Add(Me.Metronom_OFF)
        Me.Metronom_GroupBox.Controls.Add(Me.Metronom_ON)
        Me.Metronom_GroupBox.Controls.Add(Me.Metronom_Betont)
        Me.Metronom_GroupBox.Location = New System.Drawing.Point(14, 468)
        Me.Metronom_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Metronom_GroupBox.Name = "Metronom_GroupBox"
        Me.Metronom_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Metronom_GroupBox.Size = New System.Drawing.Size(298, 69)
        Me.Metronom_GroupBox.TabIndex = 168
        Me.Metronom_GroupBox.TabStop = False
        Me.Metronom_GroupBox.Text = "Metronom"
        Me.ToolTip1.SetToolTip(Me.Metronom_GroupBox, resources.GetString("Metronom_GroupBox.ToolTip"))
        '
        'Metronom_OFF
        '
        Me.Metronom_OFF.AutoSize = True
        Me.Metronom_OFF.Checked = True
        Me.Metronom_OFF.Location = New System.Drawing.Point(20, 29)
        Me.Metronom_OFF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Metronom_OFF.Name = "Metronom_OFF"
        Me.Metronom_OFF.Size = New System.Drawing.Size(62, 24)
        Me.Metronom_OFF.TabIndex = 1
        Me.Metronom_OFF.TabStop = True
        Me.Metronom_OFF.Text = "Aus"
        Me.Metronom_OFF.UseVisualStyleBackColor = True
        '
        'Metronom_ON
        '
        Me.Metronom_ON.AutoSize = True
        Me.Metronom_ON.Location = New System.Drawing.Point(104, 31)
        Me.Metronom_ON.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Metronom_ON.Name = "Metronom_ON"
        Me.Metronom_ON.Size = New System.Drawing.Size(57, 24)
        Me.Metronom_ON.TabIndex = 0
        Me.Metronom_ON.Text = "Ein"
        Me.Metronom_ON.UseVisualStyleBackColor = True
        '
        'Metronom_Betont
        '
        Me.Metronom_Betont.AutoSize = True
        Me.Metronom_Betont.Location = New System.Drawing.Point(186, 31)
        Me.Metronom_Betont.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Metronom_Betont.Name = "Metronom_Betont"
        Me.Metronom_Betont.Size = New System.Drawing.Size(82, 24)
        Me.Metronom_Betont.TabIndex = 0
        Me.Metronom_Betont.Text = "Betont"
        Me.Metronom_Betont.UseVisualStyleBackColor = True
        '
        'Transpose_GroupBox
        '
        Me.Transpose_GroupBox.Controls.Add(Me.Label2)
        Me.Transpose_GroupBox.Controls.Add(Me.Label1)
        Me.Transpose_GroupBox.Controls.Add(Me.Halbtonverschiebung)
        Me.Transpose_GroupBox.Controls.Add(Me.Oktavenverschiebung)
        Me.Transpose_GroupBox.Location = New System.Drawing.Point(14, 331)
        Me.Transpose_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Transpose_GroupBox.Name = "Transpose_GroupBox"
        Me.Transpose_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Transpose_GroupBox.Size = New System.Drawing.Size(298, 128)
        Me.Transpose_GroupBox.TabIndex = 166
        Me.Transpose_GroupBox.TabStop = False
        Me.Transpose_GroupBox.Text = "Tonhöhenveschiebung (Transpose)"
        Me.ToolTip1.SetToolTip(Me.Transpose_GroupBox, "Einstallung der Tonhöhe des zu Aufnehmenden MIDI Files.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Halbtonverschiebung:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Oktavenver.:"
        '
        'Halbtonverschiebung
        '
        Me.Halbtonverschiebung.Location = New System.Drawing.Point(190, 85)
        Me.Halbtonverschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Halbtonverschiebung.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.Halbtonverschiebung.Minimum = New Decimal(New Integer() {36, 0, 0, -2147483648})
        Me.Halbtonverschiebung.Name = "Halbtonverschiebung"
        Me.Halbtonverschiebung.Size = New System.Drawing.Size(82, 26)
        Me.Halbtonverschiebung.TabIndex = 165
        '
        'Oktavenverschiebung
        '
        Me.Oktavenverschiebung.Items.AddRange(New Object() {"+ 3 Oktaven", "+ 2 Oktaven", "+ 1 Oktave", "Normahl", "- 1 Oktave", "- 2 Oktaven", "- 3 Oktaven"})
        Me.Oktavenverschiebung.Location = New System.Drawing.Point(135, 38)
        Me.Oktavenverschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Oktavenverschiebung.Name = "Oktavenverschiebung"
        Me.Oktavenverschiebung.Size = New System.Drawing.Size(136, 28)
        Me.Oktavenverschiebung.TabIndex = 165
        Me.Oktavenverschiebung.Text = "Normahl"
        '
        'Connect_GroupBox
        '
        Me.Connect_GroupBox.Controls.Add(Me.ComboBox_Comport)
        Me.Connect_GroupBox.Controls.Add(Me.Button_Disconnect)
        Me.Connect_GroupBox.Controls.Add(Me.Button_Connect)
        Me.Connect_GroupBox.Location = New System.Drawing.Point(14, 17)
        Me.Connect_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Connect_GroupBox.Name = "Connect_GroupBox"
        Me.Connect_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Connect_GroupBox.Size = New System.Drawing.Size(441, 88)
        Me.Connect_GroupBox.TabIndex = 188
        Me.Connect_GroupBox.TabStop = False
        Me.Connect_GroupBox.Text = "Comport - Verbindungseinstellungen für Mikrokontroller"
        Me.ToolTip1.SetToolTip(Me.Connect_GroupBox, resources.GetString("Connect_GroupBox.ToolTip"))
        '
        'ComboBox_Comport
        '
        Me.ComboBox_Comport.FormattingEnabled = True
        Me.ComboBox_Comport.Location = New System.Drawing.Point(315, 32)
        Me.ComboBox_Comport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox_Comport.Name = "ComboBox_Comport"
        Me.ComboBox_Comport.Size = New System.Drawing.Size(109, 28)
        Me.ComboBox_Comport.Sorted = True
        Me.ComboBox_Comport.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ComboBox_Comport, resources.GetString("ComboBox_Comport.ToolTip"))
        '
        'Button_Disconnect
        '
        Me.Button_Disconnect.Location = New System.Drawing.Point(130, 29)
        Me.Button_Disconnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Disconnect.Name = "Button_Disconnect"
        Me.Button_Disconnect.Size = New System.Drawing.Size(112, 35)
        Me.Button_Disconnect.TabIndex = 5
        Me.Button_Disconnect.Text = "Trennen"
        Me.ToolTip1.SetToolTip(Me.Button_Disconnect, "Trennt die Verbindung zum Mikrokontroller." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Einfach ausstecken oder Programm schl" &
        "iessen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "macht übrigens dem Mikrokontroller nichts. :D")
        Me.Button_Disconnect.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(9, 29)
        Me.Button_Connect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(112, 35)
        Me.Button_Connect.TabIndex = 4
        Me.Button_Connect.Text = "Verbinden"
        Me.ToolTip1.SetToolTip(Me.Button_Connect, "Stellt eine Verbindung mit dem Mikrokontroller her.")
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'cboInstruments
        '
        Me.cboInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstruments.Location = New System.Drawing.Point(14, 29)
        Me.cboInstruments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboInstruments.Name = "cboInstruments"
        Me.cboInstruments.Size = New System.Drawing.Size(262, 28)
        Me.cboInstruments.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cboInstruments, "Wähle ein beliebiges MIDI Instrument aus.")
        '
        'DirectPlay_OFF
        '
        Me.DirectPlay_OFF.AutoSize = True
        Me.DirectPlay_OFF.Checked = True
        Me.DirectPlay_OFF.Location = New System.Drawing.Point(172, 40)
        Me.DirectPlay_OFF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_OFF.Name = "DirectPlay_OFF"
        Me.DirectPlay_OFF.Size = New System.Drawing.Size(66, 24)
        Me.DirectPlay_OFF.TabIndex = 1
        Me.DirectPlay_OFF.TabStop = True
        Me.DirectPlay_OFF.Text = "Nein"
        Me.ToolTip1.SetToolTip(Me.DirectPlay_OFF, "Diese Option deaktiviert das Senden der empfangenen MIDI Noten per winm,m.dll api" &
        ".")
        Me.DirectPlay_OFF.UseVisualStyleBackColor = True
        '
        'Messintervall_GroupBox
        '
        Me.Messintervall_GroupBox.Controls.Add(Me.Messintervall_TextBox)
        Me.Messintervall_GroupBox.Controls.Add(Me.MessungenProS_TexBox)
        Me.Messintervall_GroupBox.Controls.Add(Me.Messintervall_Label)
        Me.Messintervall_GroupBox.Location = New System.Drawing.Point(14, 546)
        Me.Messintervall_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Messintervall_GroupBox.Name = "Messintervall_GroupBox"
        Me.Messintervall_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Messintervall_GroupBox.Size = New System.Drawing.Size(298, 78)
        Me.Messintervall_GroupBox.TabIndex = 174
        Me.Messintervall_GroupBox.TabStop = False
        Me.Messintervall_GroupBox.Text = "Messintervall vom Mikrokontroller"
        Me.ToolTip1.SetToolTip(Me.Messintervall_GroupBox, "Anzeige der empfangenen Messungen pro Sekunde," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sowie des Messintervalls in Milli" &
        "sekunden (1/1000 S)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Der Messintervall entspricht übrigens genau der" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Latenzz" &
        "eit der DirectPlay Funktion!")
        '
        'Messintervall_TextBox
        '
        Me.Messintervall_TextBox.Enabled = False
        Me.Messintervall_TextBox.Location = New System.Drawing.Point(183, 34)
        Me.Messintervall_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Messintervall_TextBox.Name = "Messintervall_TextBox"
        Me.Messintervall_TextBox.ReadOnly = True
        Me.Messintervall_TextBox.Size = New System.Drawing.Size(85, 26)
        Me.Messintervall_TextBox.TabIndex = 181
        Me.Messintervall_TextBox.Text = "0 ms"
        '
        'MessungenProS_TexBox
        '
        Me.MessungenProS_TexBox.Enabled = False
        Me.MessungenProS_TexBox.Location = New System.Drawing.Point(86, 34)
        Me.MessungenProS_TexBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MessungenProS_TexBox.Name = "MessungenProS_TexBox"
        Me.MessungenProS_TexBox.ReadOnly = True
        Me.MessungenProS_TexBox.Size = New System.Drawing.Size(85, 26)
        Me.MessungenProS_TexBox.TabIndex = 180
        Me.MessungenProS_TexBox.Text = "0 M/s"
        '
        'Messintervall_Label
        '
        Me.Messintervall_Label.AutoSize = True
        Me.Messintervall_Label.Location = New System.Drawing.Point(14, 38)
        Me.Messintervall_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Messintervall_Label.Name = "Messintervall_Label"
        Me.Messintervall_Label.Size = New System.Drawing.Size(58, 20)
        Me.Messintervall_Label.TabIndex = 179
        Me.Messintervall_Label.Text = "Mes/S:"
        '
        'Tempo_GroupBox
        '
        Me.Tempo_GroupBox.Controls.Add(Me.Label18)
        Me.Tempo_GroupBox.Controls.Add(Me.Tackt_Naenner_Input)
        Me.Tempo_GroupBox.Controls.Add(Me.Tackt_Zaehler_Input)
        Me.Tempo_GroupBox.Controls.Add(Me.Label17)
        Me.Tempo_GroupBox.Controls.Add(Me.BPM_Label)
        Me.Tempo_GroupBox.Controls.Add(Me.BPM)
        Me.Tempo_GroupBox.Location = New System.Drawing.Point(14, 228)
        Me.Tempo_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tempo_GroupBox.Name = "Tempo_GroupBox"
        Me.Tempo_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tempo_GroupBox.Size = New System.Drawing.Size(298, 97)
        Me.Tempo_GroupBox.TabIndex = 172
        Me.Tempo_GroupBox.TabStop = False
        Me.Tempo_GroupBox.Text = "Tempo"
        Me.ToolTip1.SetToolTip(Me.Tempo_GroupBox, "Einstellung des Tacktes und der Geschwindigkeit des zu Aufnehmenden MIDI FIles")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(183, 25)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 20)
        Me.Label18.TabIndex = 172
        Me.Label18.Text = "/"
        '
        'Tackt_Naenner_Input
        '
        Me.Tackt_Naenner_Input.Location = New System.Drawing.Point(206, 18)
        Me.Tackt_Naenner_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tackt_Naenner_Input.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.Tackt_Naenner_Input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tackt_Naenner_Input.Name = "Tackt_Naenner_Input"
        Me.Tackt_Naenner_Input.Size = New System.Drawing.Size(72, 26)
        Me.Tackt_Naenner_Input.TabIndex = 174
        Me.Tackt_Naenner_Input.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Tackt_Zaehler_Input
        '
        Me.Tackt_Zaehler_Input.Location = New System.Drawing.Point(92, 18)
        Me.Tackt_Zaehler_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tackt_Zaehler_Input.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.Tackt_Zaehler_Input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tackt_Zaehler_Input.Name = "Tackt_Zaehler_Input"
        Me.Tackt_Zaehler_Input.Size = New System.Drawing.Size(82, 26)
        Me.Tackt_Zaehler_Input.TabIndex = 172
        Me.Tackt_Zaehler_Input.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 29)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 20)
        Me.Label17.TabIndex = 173
        Me.Label17.Text = "Tackt:"
        '
        'BPM_Label
        '
        Me.BPM_Label.AutoSize = True
        Me.BPM_Label.Location = New System.Drawing.Point(18, 65)
        Me.BPM_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BPM_Label.Name = "BPM_Label"
        Me.BPM_Label.Size = New System.Drawing.Size(125, 20)
        Me.BPM_Label.TabIndex = 172
        Me.BPM_Label.Text = "Aufnahme BPM:"
        '
        'BPM
        '
        Me.BPM.Location = New System.Drawing.Point(206, 57)
        Me.BPM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BPM.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.BPM.Name = "BPM"
        Me.BPM.Size = New System.Drawing.Size(72, 26)
        Me.BPM.TabIndex = 168
        Me.BPM.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'DirectPlay_ON
        '
        Me.DirectPlay_ON.AutoSize = True
        Me.DirectPlay_ON.Location = New System.Drawing.Point(46, 40)
        Me.DirectPlay_ON.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_ON.Name = "DirectPlay_ON"
        Me.DirectPlay_ON.Size = New System.Drawing.Size(51, 24)
        Me.DirectPlay_ON.TabIndex = 0
        Me.DirectPlay_ON.Text = "Ja"
        Me.ToolTip1.SetToolTip(Me.DirectPlay_ON, resources.GetString("DirectPlay_ON.ToolTip"))
        Me.DirectPlay_ON.UseVisualStyleBackColor = True
        '
        'SendKeys_OFF
        '
        Me.SendKeys_OFF.AutoSize = True
        Me.SendKeys_OFF.Checked = True
        Me.SendKeys_OFF.Location = New System.Drawing.Point(250, 37)
        Me.SendKeys_OFF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKeys_OFF.Name = "SendKeys_OFF"
        Me.SendKeys_OFF.Size = New System.Drawing.Size(66, 24)
        Me.SendKeys_OFF.TabIndex = 3
        Me.SendKeys_OFF.TabStop = True
        Me.SendKeys_OFF.Text = "Nein"
        Me.ToolTip1.SetToolTip(Me.SendKeys_OFF, "Deaktivieren der Funktion SendKey to Virtual MIDI Piano")
        Me.SendKeys_OFF.UseVisualStyleBackColor = True
        '
        'SendKeys_ON
        '
        Me.SendKeys_ON.AutoSize = True
        Me.SendKeys_ON.Location = New System.Drawing.Point(75, 37)
        Me.SendKeys_ON.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKeys_ON.Name = "SendKeys_ON"
        Me.SendKeys_ON.Size = New System.Drawing.Size(51, 24)
        Me.SendKeys_ON.TabIndex = 2
        Me.SendKeys_ON.Text = "Ja"
        Me.ToolTip1.SetToolTip(Me.SendKeys_ON, "Aktivieren der Funktion SendKey to Virtual MIDI Piano")
        Me.SendKeys_ON.UseVisualStyleBackColor = True
        '
        'SendKey_GroupBox
        '
        Me.SendKey_GroupBox.Controls.Add(Me.Label20)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_gis)
        Me.SendKey_GroupBox.Controls.Add(Me.Label21)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_ais)
        Me.SendKey_GroupBox.Controls.Add(Me.Label22)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_fis)
        Me.SendKey_GroupBox.Controls.Add(Me.Label13)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_cis)
        Me.SendKey_GroupBox.Controls.Add(Me.Label16)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_dis)
        Me.SendKey_GroupBox.Controls.Add(Me.Label6)
        Me.SendKey_GroupBox.Controls.Add(Me.Label7)
        Me.SendKey_GroupBox.Controls.Add(Me.Label8)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_OM)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_g)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_d)
        Me.SendKey_GroupBox.Controls.Add(Me.Label10)
        Me.SendKey_GroupBox.Controls.Add(Me.Label12)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_OP)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_a)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_e)
        Me.SendKey_GroupBox.Controls.Add(Me.Label5)
        Me.SendKey_GroupBox.Controls.Add(Me.Label4)
        Me.SendKey_GroupBox.Controls.Add(Me.Label3)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_h)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_f)
        Me.SendKey_GroupBox.Controls.Add(Me.SendKey_c)
        Me.SendKey_GroupBox.Location = New System.Drawing.Point(824, 498)
        Me.SendKey_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_GroupBox.Name = "SendKey_GroupBox"
        Me.SendKey_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_GroupBox.Size = New System.Drawing.Size(294, 232)
        Me.SendKey_GroupBox.TabIndex = 12
        Me.SendKey_GroupBox.TabStop = False
        Me.SendKey_GroupBox.Text = "SendKey to Virtual MIDI Piano Okt 2"
        Me.ToolTip1.SetToolTip(Me.SendKey_GroupBox, resources.GetString("SendKey_GroupBox.ToolTip"))
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(104, 157)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 20)
        Me.Label20.TabIndex = 232
        Me.Label20.Text = "gis:"
        '
        'SendKey_gis
        '
        Me.SendKey_gis.Location = New System.Drawing.Point(140, 151)
        Me.SendKey_gis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_gis.Name = "SendKey_gis"
        Me.SendKey_gis.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_gis.TabIndex = 231
        Me.SendKey_gis.Text = "6"
        Me.SendKey_gis.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(198, 157)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 20)
        Me.Label21.TabIndex = 230
        Me.Label21.Text = "ais:"
        '
        'SendKey_ais
        '
        Me.SendKey_ais.Location = New System.Drawing.Point(236, 151)
        Me.SendKey_ais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_ais.Name = "SendKey_ais"
        Me.SendKey_ais.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_ais.TabIndex = 229
        Me.SendKey_ais.Text = "7"
        Me.SendKey_ais.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 157)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 20)
        Me.Label22.TabIndex = 228
        Me.Label22.Text = "fis:"
        '
        'SendKey_fis
        '
        Me.SendKey_fis.Location = New System.Drawing.Point(39, 151)
        Me.SendKey_fis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_fis.Name = "SendKey_fis"
        Me.SendKey_fis.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_fis.TabIndex = 227
        Me.SendKey_fis.Text = "5"
        Me.SendKey_fis.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(104, 115)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 20)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "cis:"
        '
        'SendKey_cis
        '
        Me.SendKey_cis.Location = New System.Drawing.Point(140, 109)
        Me.SendKey_cis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_cis.Name = "SendKey_cis"
        Me.SendKey_cis.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_cis.TabIndex = 225
        Me.SendKey_cis.Text = "2"
        Me.SendKey_cis.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(198, 115)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 20)
        Me.Label16.TabIndex = 224
        Me.Label16.Text = "dis:"
        '
        'SendKey_dis
        '
        Me.SendKey_dis.Location = New System.Drawing.Point(236, 109)
        Me.SendKey_dis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_dis.Name = "SendKey_dis"
        Me.SendKey_dis.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_dis.TabIndex = 223
        Me.SendKey_dis.Text = "3"
        Me.SendKey_dis.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 200)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "Config. Seite:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 20)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "g:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 20)
        Me.Label8.TabIndex = 218
        Me.Label8.Text = "d:"
        '
        'SendKey_OM
        '
        Me.SendKey_OM.Location = New System.Drawing.Point(120, 194)
        Me.SendKey_OM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_OM.Name = "SendKey_OM"
        Me.SendKey_OM.Size = New System.Drawing.Size(69, 32)
        Me.SendKey_OM.TabIndex = 217
        Me.SendKey_OM.Text = "Okt. -"
        Me.SendKey_OM.UseVisualStyleBackColor = True
        '
        'SendKey_g
        '
        Me.SendKey_g.Location = New System.Drawing.Point(140, 69)
        Me.SendKey_g.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_g.Name = "SendKey_g"
        Me.SendKey_g.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_g.TabIndex = 216
        Me.SendKey_g.Text = "T"
        Me.SendKey_g.UseVisualStyleBackColor = True
        '
        'SendKey_d
        '
        Me.SendKey_d.Location = New System.Drawing.Point(140, 29)
        Me.SendKey_d.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_d.Name = "SendKey_d"
        Me.SendKey_d.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_d.TabIndex = 215
        Me.SendKey_d.Text = "W"
        Me.SendKey_d.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 20)
        Me.Label10.TabIndex = 213
        Me.Label10.Text = "a:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 35)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 20)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "e:"
        '
        'SendKey_OP
        '
        Me.SendKey_OP.Location = New System.Drawing.Point(219, 194)
        Me.SendKey_OP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_OP.Name = "SendKey_OP"
        Me.SendKey_OP.Size = New System.Drawing.Size(66, 32)
        Me.SendKey_OP.TabIndex = 211
        Me.SendKey_OP.Text = "Okt. +"
        Me.SendKey_OP.UseVisualStyleBackColor = True
        '
        'SendKey_a
        '
        Me.SendKey_a.Location = New System.Drawing.Point(236, 69)
        Me.SendKey_a.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_a.Name = "SendKey_a"
        Me.SendKey_a.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_a.TabIndex = 210
        Me.SendKey_a.Text = "Z"
        Me.SendKey_a.UseVisualStyleBackColor = True
        '
        'SendKey_e
        '
        Me.SendKey_e.Location = New System.Drawing.Point(236, 29)
        Me.SendKey_e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_e.Name = "SendKey_e"
        Me.SendKey_e.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_e.TabIndex = 209
        Me.SendKey_e.Text = "E"
        Me.SendKey_e.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 20)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "h:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "f:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 20)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "c:"
        '
        'SendKey_h
        '
        Me.SendKey_h.Location = New System.Drawing.Point(39, 109)
        Me.SendKey_h.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_h.Name = "SendKey_h"
        Me.SendKey_h.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_h.TabIndex = 193
        Me.SendKey_h.Text = "U"
        Me.SendKey_h.UseVisualStyleBackColor = True
        '
        'SendKey_f
        '
        Me.SendKey_f.Location = New System.Drawing.Point(39, 69)
        Me.SendKey_f.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_f.Name = "SendKey_f"
        Me.SendKey_f.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_f.TabIndex = 192
        Me.SendKey_f.Text = "R"
        Me.SendKey_f.UseVisualStyleBackColor = True
        '
        'SendKey_c
        '
        Me.SendKey_c.Location = New System.Drawing.Point(39, 29)
        Me.SendKey_c.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKey_c.Name = "SendKey_c"
        Me.SendKey_c.Size = New System.Drawing.Size(50, 32)
        Me.SendKey_c.TabIndex = 191
        Me.SendKey_c.Text = "Q"
        Me.SendKey_c.UseVisualStyleBackColor = True
        '
        'SendKeys_GroupBox
        '
        Me.SendKeys_GroupBox.Controls.Add(Me.SendKeys_OFF)
        Me.SendKeys_GroupBox.Controls.Add(Me.SendKeys_ON)
        Me.SendKeys_GroupBox.Location = New System.Drawing.Point(14, 655)
        Me.SendKeys_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKeys_GroupBox.Name = "SendKeys_GroupBox"
        Me.SendKeys_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendKeys_GroupBox.Size = New System.Drawing.Size(441, 75)
        Me.SendKeys_GroupBox.TabIndex = 198
        Me.SendKeys_GroupBox.TabStop = False
        Me.SendKeys_GroupBox.Text = "SendKeys to Virtual MIDI Piano aktivieren?"
        Me.ToolTip1.SetToolTip(Me.SendKeys_GroupBox, resources.GetString("SendKeys_GroupBox.ToolTip"))
        '
        'Instrumentenauswahl_GroupBox
        '
        Me.Instrumentenauswahl_GroupBox.Controls.Add(Me.cboInstruments)
        Me.Instrumentenauswahl_GroupBox.Location = New System.Drawing.Point(14, 149)
        Me.Instrumentenauswahl_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Instrumentenauswahl_GroupBox.Name = "Instrumentenauswahl_GroupBox"
        Me.Instrumentenauswahl_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Instrumentenauswahl_GroupBox.Size = New System.Drawing.Size(298, 69)
        Me.Instrumentenauswahl_GroupBox.TabIndex = 183
        Me.Instrumentenauswahl_GroupBox.TabStop = False
        Me.Instrumentenauswahl_GroupBox.Text = "Instrument"
        Me.ToolTip1.SetToolTip(Me.Instrumentenauswahl_GroupBox, "Wähle ein beliebiges MIDI Instrument aus.")
        '
        'MIDI_Aufnahmemodus_GroupBox
        '
        Me.MIDI_Aufnahmemodus_GroupBox.Controls.Add(Me.Volume_max_NumericUpDown)
        Me.MIDI_Aufnahmemodus_GroupBox.Controls.Add(Me.Volume_min_NumericUpDown)
        Me.MIDI_Aufnahmemodus_GroupBox.Controls.Add(Me.Volume_Steps_NumericUpDown)
        Me.MIDI_Aufnahmemodus_GroupBox.Controls.Add(Me.MIDI_SpecialMode)
        Me.MIDI_Aufnahmemodus_GroupBox.Controls.Add(Me.MIDI_NormalMode)
        Me.MIDI_Aufnahmemodus_GroupBox.Location = New System.Drawing.Point(14, 25)
        Me.MIDI_Aufnahmemodus_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Aufnahmemodus_GroupBox.Name = "MIDI_Aufnahmemodus_GroupBox"
        Me.MIDI_Aufnahmemodus_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Aufnahmemodus_GroupBox.Size = New System.Drawing.Size(298, 115)
        Me.MIDI_Aufnahmemodus_GroupBox.TabIndex = 173
        Me.MIDI_Aufnahmemodus_GroupBox.TabStop = False
        Me.MIDI_Aufnahmemodus_GroupBox.Text = "MIDI Aufnahmemodus"
        Me.ToolTip1.SetToolTip(Me.MIDI_Aufnahmemodus_GroupBox, """Schönes"" MIDI File oder RawData für weiterverarbeitung?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Genauere Informationen " &
        "stehen auf den einzelnen Punkten.")
        '
        'Volume_max_NumericUpDown
        '
        Me.Volume_max_NumericUpDown.Location = New System.Drawing.Point(206, 72)
        Me.Volume_max_NumericUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Volume_max_NumericUpDown.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.Volume_max_NumericUpDown.Name = "Volume_max_NumericUpDown"
        Me.Volume_max_NumericUpDown.Size = New System.Drawing.Size(80, 26)
        Me.Volume_max_NumericUpDown.TabIndex = 171
        Me.ToolTip1.SetToolTip(Me.Volume_max_NumericUpDown, resources.GetString("Volume_max_NumericUpDown.ToolTip"))
        Me.Volume_max_NumericUpDown.Value = New Decimal(New Integer() {127, 0, 0, 0})
        '
        'Volume_min_NumericUpDown
        '
        Me.Volume_min_NumericUpDown.Location = New System.Drawing.Point(117, 72)
        Me.Volume_min_NumericUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Volume_min_NumericUpDown.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.Volume_min_NumericUpDown.Name = "Volume_min_NumericUpDown"
        Me.Volume_min_NumericUpDown.Size = New System.Drawing.Size(80, 26)
        Me.Volume_min_NumericUpDown.TabIndex = 170
        Me.ToolTip1.SetToolTip(Me.Volume_min_NumericUpDown, resources.GetString("Volume_min_NumericUpDown.ToolTip"))
        '
        'Volume_Steps_NumericUpDown
        '
        Me.Volume_Steps_NumericUpDown.Location = New System.Drawing.Point(18, 72)
        Me.Volume_Steps_NumericUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Volume_Steps_NumericUpDown.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.Volume_Steps_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Volume_Steps_NumericUpDown.Name = "Volume_Steps_NumericUpDown"
        Me.Volume_Steps_NumericUpDown.Size = New System.Drawing.Size(80, 26)
        Me.Volume_Steps_NumericUpDown.TabIndex = 169
        Me.ToolTip1.SetToolTip(Me.Volume_Steps_NumericUpDown, resources.GetString("Volume_Steps_NumericUpDown.ToolTip"))
        Me.Volume_Steps_NumericUpDown.Value = New Decimal(New Integer() {127, 0, 0, 0})
        '
        'MIDI_Pause_Button
        '
        Me.MIDI_Pause_Button.Enabled = False
        Me.MIDI_Pause_Button.Location = New System.Drawing.Point(9, 323)
        Me.MIDI_Pause_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Pause_Button.Name = "MIDI_Pause_Button"
        Me.MIDI_Pause_Button.Size = New System.Drawing.Size(423, 89)
        Me.MIDI_Pause_Button.TabIndex = 23
        Me.MIDI_Pause_Button.Text = "Aufnahme pausieren"
        Me.ToolTip1.SetToolTip(Me.MIDI_Pause_Button, "Pausiert oder setzt eine Aufnahme sauber fort." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Diese Funktion kann auch über die" &
        " Hintergrundssteueruing von einem andern Programm aus ausgeführt werden." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.MIDI_Pause_Button.UseVisualStyleBackColor = True
        '
        'MIDI_Start_Button
        '
        Me.MIDI_Start_Button.Location = New System.Drawing.Point(9, 217)
        Me.MIDI_Start_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Start_Button.Name = "MIDI_Start_Button"
        Me.MIDI_Start_Button.Size = New System.Drawing.Size(423, 92)
        Me.MIDI_Start_Button.TabIndex = 22
        Me.MIDI_Start_Button.Text = "Aufnahme starten"
        Me.ToolTip1.SetToolTip(Me.MIDI_Start_Button, "Startet eine neue MIDI Aufnahme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Diese Funktion kann auch über die Hintergrundsst" &
        "eueruing von einem andern Programm aus ausgeführt werden.")
        Me.MIDI_Start_Button.UseVisualStyleBackColor = True
        '
        'MIDI_Save_Button
        '
        Me.MIDI_Save_Button.Enabled = False
        Me.MIDI_Save_Button.Location = New System.Drawing.Point(9, 425)
        Me.MIDI_Save_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Save_Button.Name = "MIDI_Save_Button"
        Me.MIDI_Save_Button.Size = New System.Drawing.Size(423, 89)
        Me.MIDI_Save_Button.TabIndex = 11
        Me.MIDI_Save_Button.Text = "Aufnahme speichern"
        Me.ToolTip1.SetToolTip(Me.MIDI_Save_Button, resources.GetString("MIDI_Save_Button.ToolTip"))
        Me.MIDI_Save_Button.UseVisualStyleBackColor = True
        '
        'MIDI_Visualisierung_GroupBox
        '
        Me.MIDI_Visualisierung_GroupBox.Controls.Add(Me.FlowLayoutPanel5)
        Me.MIDI_Visualisierung_GroupBox.Controls.Add(Me.FlowLayoutPanel1)
        Me.MIDI_Visualisierung_GroupBox.Controls.Add(Me.FlowLayoutPanel2)
        Me.MIDI_Visualisierung_GroupBox.Controls.Add(Me.FlowLayoutPanel4)
        Me.MIDI_Visualisierung_GroupBox.Controls.Add(Me.FlowLayoutPanel3)
        Me.MIDI_Visualisierung_GroupBox.Controls.Add(Me.GroupBox5)
        Me.MIDI_Visualisierung_GroupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MIDI_Visualisierung_GroupBox.Location = New System.Drawing.Point(14, 740)
        Me.MIDI_Visualisierung_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Visualisierung_GroupBox.Name = "MIDI_Visualisierung_GroupBox"
        Me.MIDI_Visualisierung_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MIDI_Visualisierung_GroupBox.Size = New System.Drawing.Size(1878, 438)
        Me.MIDI_Visualisierung_GroupBox.TabIndex = 192
        Me.MIDI_Visualisierung_GroupBox.TabStop = False
        Me.MIDI_Visualisierung_GroupBox.Text = "MIDI Visualisierung und Tonbasierende Induvidualeinstellungen"
        Me.ToolTip1.SetToolTip(Me.MIDI_Visualisierung_GroupBox, resources.GetString("MIDI_Visualisierung_GroupBox.ToolTip"))
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.C6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.D6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.E6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.F6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.G6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.A6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.H6_VerticalProgessBar)
        Me.FlowLayoutPanel5.Controls.Add(Me.C6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.D6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.E6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.F6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.G6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.A6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.H6_Button)
        Me.FlowLayoutPanel5.Controls.Add(Me.C6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.D6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.E6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.F6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.G6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.A6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.H6_Wert)
        Me.FlowLayoutPanel5.Controls.Add(Me.C6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.D6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.E6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.F6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.G6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.A6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.H6_Startwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.C6_Stopwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.D6_Stopwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.E6_Stopwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.F6_Stopwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.G6_Stopwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.A6_Stopwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.H6_Stopwert)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(1488, 29)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(356, 323)
        Me.FlowLayoutPanel5.TabIndex = 10
        '
        'C6_VerticalProgessBar
        '
        Me.C6_VerticalProgessBar.Location = New System.Drawing.Point(4, 5)
        Me.C6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C6_VerticalProgessBar.Maximum = 255
        Me.C6_VerticalProgessBar.Name = "C6_VerticalProgessBar"
        Me.C6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.C6_VerticalProgessBar.TabIndex = 3
        '
        'D6_VerticalProgessBar
        '
        Me.D6_VerticalProgessBar.Location = New System.Drawing.Point(51, 5)
        Me.D6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D6_VerticalProgessBar.Maximum = 255
        Me.D6_VerticalProgessBar.Name = "D6_VerticalProgessBar"
        Me.D6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.D6_VerticalProgessBar.TabIndex = 4
        '
        'E6_VerticalProgessBar
        '
        Me.E6_VerticalProgessBar.Location = New System.Drawing.Point(98, 5)
        Me.E6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E6_VerticalProgessBar.Maximum = 255
        Me.E6_VerticalProgessBar.Name = "E6_VerticalProgessBar"
        Me.E6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.E6_VerticalProgessBar.TabIndex = 5
        '
        'F6_VerticalProgessBar
        '
        Me.F6_VerticalProgessBar.Location = New System.Drawing.Point(145, 5)
        Me.F6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F6_VerticalProgessBar.Maximum = 255
        Me.F6_VerticalProgessBar.Name = "F6_VerticalProgessBar"
        Me.F6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.F6_VerticalProgessBar.TabIndex = 6
        '
        'G6_VerticalProgessBar
        '
        Me.G6_VerticalProgessBar.Location = New System.Drawing.Point(192, 5)
        Me.G6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G6_VerticalProgessBar.Maximum = 255
        Me.G6_VerticalProgessBar.Name = "G6_VerticalProgessBar"
        Me.G6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.G6_VerticalProgessBar.TabIndex = 7
        '
        'A6_VerticalProgessBar
        '
        Me.A6_VerticalProgessBar.Location = New System.Drawing.Point(239, 5)
        Me.A6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A6_VerticalProgessBar.Maximum = 255
        Me.A6_VerticalProgessBar.Name = "A6_VerticalProgessBar"
        Me.A6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.A6_VerticalProgessBar.TabIndex = 8
        '
        'H6_VerticalProgessBar
        '
        Me.H6_VerticalProgessBar.Location = New System.Drawing.Point(286, 5)
        Me.H6_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H6_VerticalProgessBar.Maximum = 255
        Me.H6_VerticalProgessBar.Name = "H6_VerticalProgessBar"
        Me.H6_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.H6_VerticalProgessBar.TabIndex = 9
        '
        'C6_Button
        '
        Me.C6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C6_Button.Location = New System.Drawing.Point(4, 164)
        Me.C6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C6_Button.Name = "C6_Button"
        Me.C6_Button.Size = New System.Drawing.Size(39, 35)
        Me.C6_Button.TabIndex = 179
        Me.C6_Button.Text = "c'''"
        Me.C6_Button.UseVisualStyleBackColor = True
        '
        'D6_Button
        '
        Me.D6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6_Button.Location = New System.Drawing.Point(51, 164)
        Me.D6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D6_Button.Name = "D6_Button"
        Me.D6_Button.Size = New System.Drawing.Size(39, 35)
        Me.D6_Button.TabIndex = 180
        Me.D6_Button.Text = "d'''"
        Me.D6_Button.UseVisualStyleBackColor = True
        '
        'E6_Button
        '
        Me.E6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E6_Button.Location = New System.Drawing.Point(98, 164)
        Me.E6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E6_Button.Name = "E6_Button"
        Me.E6_Button.Size = New System.Drawing.Size(39, 35)
        Me.E6_Button.TabIndex = 181
        Me.E6_Button.Text = "e'''"
        Me.E6_Button.UseVisualStyleBackColor = True
        '
        'F6_Button
        '
        Me.F6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F6_Button.Location = New System.Drawing.Point(145, 164)
        Me.F6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F6_Button.Name = "F6_Button"
        Me.F6_Button.Size = New System.Drawing.Size(39, 35)
        Me.F6_Button.TabIndex = 182
        Me.F6_Button.Text = "f'''"
        Me.F6_Button.UseVisualStyleBackColor = True
        '
        'G6_Button
        '
        Me.G6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G6_Button.Location = New System.Drawing.Point(192, 164)
        Me.G6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G6_Button.Name = "G6_Button"
        Me.G6_Button.Size = New System.Drawing.Size(39, 35)
        Me.G6_Button.TabIndex = 183
        Me.G6_Button.Text = "g'''"
        Me.G6_Button.UseVisualStyleBackColor = True
        '
        'A6_Button
        '
        Me.A6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A6_Button.Location = New System.Drawing.Point(239, 164)
        Me.A6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A6_Button.Name = "A6_Button"
        Me.A6_Button.Size = New System.Drawing.Size(39, 35)
        Me.A6_Button.TabIndex = 184
        Me.A6_Button.Text = "a'''"
        Me.A6_Button.UseVisualStyleBackColor = True
        '
        'H6_Button
        '
        Me.H6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H6_Button.Location = New System.Drawing.Point(286, 164)
        Me.H6_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H6_Button.Name = "H6_Button"
        Me.H6_Button.Size = New System.Drawing.Size(39, 35)
        Me.H6_Button.TabIndex = 185
        Me.H6_Button.Text = "h'''"
        Me.H6_Button.UseVisualStyleBackColor = True
        '
        'C6_Wert
        '
        Me.C6_Wert.Location = New System.Drawing.Point(4, 209)
        Me.C6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C6_Wert.Name = "C6_Wert"
        Me.C6_Wert.ReadOnly = True
        Me.C6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.C6_Wert.TabIndex = 12
        Me.C6_Wert.Text = "0"
        Me.C6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Wert
        '
        Me.D6_Wert.Location = New System.Drawing.Point(49, 209)
        Me.D6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D6_Wert.Name = "D6_Wert"
        Me.D6_Wert.ReadOnly = True
        Me.D6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.D6_Wert.TabIndex = 13
        Me.D6_Wert.Text = "0"
        Me.D6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Wert
        '
        Me.E6_Wert.Location = New System.Drawing.Point(94, 209)
        Me.E6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E6_Wert.Name = "E6_Wert"
        Me.E6_Wert.ReadOnly = True
        Me.E6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.E6_Wert.TabIndex = 14
        Me.E6_Wert.Text = "0"
        Me.E6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Wert
        '
        Me.F6_Wert.Location = New System.Drawing.Point(139, 209)
        Me.F6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F6_Wert.Name = "F6_Wert"
        Me.F6_Wert.ReadOnly = True
        Me.F6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.F6_Wert.TabIndex = 15
        Me.F6_Wert.Text = "0"
        Me.F6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Wert
        '
        Me.G6_Wert.Location = New System.Drawing.Point(184, 209)
        Me.G6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G6_Wert.Name = "G6_Wert"
        Me.G6_Wert.ReadOnly = True
        Me.G6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.G6_Wert.TabIndex = 16
        Me.G6_Wert.Text = "0"
        Me.G6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Wert
        '
        Me.A6_Wert.Location = New System.Drawing.Point(229, 209)
        Me.A6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A6_Wert.Name = "A6_Wert"
        Me.A6_Wert.ReadOnly = True
        Me.A6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.A6_Wert.TabIndex = 17
        Me.A6_Wert.Text = "0"
        Me.A6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Wert
        '
        Me.H6_Wert.Location = New System.Drawing.Point(274, 209)
        Me.H6_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H6_Wert.Name = "H6_Wert"
        Me.H6_Wert.ReadOnly = True
        Me.H6_Wert.Size = New System.Drawing.Size(37, 26)
        Me.H6_Wert.TabIndex = 18
        Me.H6_Wert.Text = "0"
        Me.H6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C6_Startwert
        '
        Me.C6_Startwert.Location = New System.Drawing.Point(4, 245)
        Me.C6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C6_Startwert.MaxLength = 3
        Me.C6_Startwert.Name = "C6_Startwert"
        Me.C6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.C6_Startwert.TabIndex = 25
        Me.C6_Startwert.Text = "50"
        Me.C6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Startwert
        '
        Me.D6_Startwert.Location = New System.Drawing.Point(49, 245)
        Me.D6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D6_Startwert.MaxLength = 3
        Me.D6_Startwert.Name = "D6_Startwert"
        Me.D6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.D6_Startwert.TabIndex = 26
        Me.D6_Startwert.Text = "50"
        Me.D6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Startwert
        '
        Me.E6_Startwert.Location = New System.Drawing.Point(94, 245)
        Me.E6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E6_Startwert.MaxLength = 3
        Me.E6_Startwert.Name = "E6_Startwert"
        Me.E6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.E6_Startwert.TabIndex = 27
        Me.E6_Startwert.Text = "50"
        Me.E6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Startwert
        '
        Me.F6_Startwert.Location = New System.Drawing.Point(139, 245)
        Me.F6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F6_Startwert.MaxLength = 3
        Me.F6_Startwert.Name = "F6_Startwert"
        Me.F6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.F6_Startwert.TabIndex = 28
        Me.F6_Startwert.Text = "50"
        Me.F6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Startwert
        '
        Me.G6_Startwert.Location = New System.Drawing.Point(184, 245)
        Me.G6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G6_Startwert.MaxLength = 3
        Me.G6_Startwert.Name = "G6_Startwert"
        Me.G6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.G6_Startwert.TabIndex = 29
        Me.G6_Startwert.Text = "50"
        Me.G6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Startwert
        '
        Me.A6_Startwert.Location = New System.Drawing.Point(229, 245)
        Me.A6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A6_Startwert.MaxLength = 3
        Me.A6_Startwert.Name = "A6_Startwert"
        Me.A6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.A6_Startwert.TabIndex = 30
        Me.A6_Startwert.Text = "50"
        Me.A6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Startwert
        '
        Me.H6_Startwert.Location = New System.Drawing.Point(274, 245)
        Me.H6_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H6_Startwert.MaxLength = 3
        Me.H6_Startwert.Name = "H6_Startwert"
        Me.H6_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.H6_Startwert.TabIndex = 31
        Me.H6_Startwert.Text = "50"
        Me.H6_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C6_Stopwert
        '
        Me.C6_Stopwert.Location = New System.Drawing.Point(4, 281)
        Me.C6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C6_Stopwert.MaxLength = 3
        Me.C6_Stopwert.Name = "C6_Stopwert"
        Me.C6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.C6_Stopwert.TabIndex = 186
        Me.C6_Stopwert.Text = "200"
        Me.C6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Stopwert
        '
        Me.D6_Stopwert.Location = New System.Drawing.Point(49, 281)
        Me.D6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D6_Stopwert.MaxLength = 3
        Me.D6_Stopwert.Name = "D6_Stopwert"
        Me.D6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.D6_Stopwert.TabIndex = 187
        Me.D6_Stopwert.Text = "200"
        Me.D6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Stopwert
        '
        Me.E6_Stopwert.Location = New System.Drawing.Point(94, 281)
        Me.E6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E6_Stopwert.MaxLength = 3
        Me.E6_Stopwert.Name = "E6_Stopwert"
        Me.E6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.E6_Stopwert.TabIndex = 188
        Me.E6_Stopwert.Text = "200"
        Me.E6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Stopwert
        '
        Me.F6_Stopwert.Location = New System.Drawing.Point(139, 281)
        Me.F6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F6_Stopwert.MaxLength = 3
        Me.F6_Stopwert.Name = "F6_Stopwert"
        Me.F6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.F6_Stopwert.TabIndex = 189
        Me.F6_Stopwert.Text = "200"
        Me.F6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Stopwert
        '
        Me.G6_Stopwert.Location = New System.Drawing.Point(184, 281)
        Me.G6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G6_Stopwert.MaxLength = 3
        Me.G6_Stopwert.Name = "G6_Stopwert"
        Me.G6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.G6_Stopwert.TabIndex = 190
        Me.G6_Stopwert.Text = "200"
        Me.G6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Stopwert
        '
        Me.A6_Stopwert.Location = New System.Drawing.Point(229, 281)
        Me.A6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A6_Stopwert.MaxLength = 3
        Me.A6_Stopwert.Name = "A6_Stopwert"
        Me.A6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.A6_Stopwert.TabIndex = 191
        Me.A6_Stopwert.Text = "200"
        Me.A6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Stopwert
        '
        Me.H6_Stopwert.Location = New System.Drawing.Point(274, 281)
        Me.H6_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H6_Stopwert.MaxLength = 3
        Me.H6_Stopwert.Name = "H6_Stopwert"
        Me.H6_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.H6_Stopwert.TabIndex = 192
        Me.H6_Stopwert.Text = "200"
        Me.H6_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.C2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.D2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.E2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.F2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.G2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.A2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.H2_VerticalProgessBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.C2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.D2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.E2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.F2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.G2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.A2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.H2_Button)
        Me.FlowLayoutPanel1.Controls.Add(Me.C2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.D2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.E2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.F2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.G2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.A2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.H2_Wert)
        Me.FlowLayoutPanel1.Controls.Add(Me.C2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.D2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.E2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.F2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.G2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.A2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.H2_Startwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.C2_Stopwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.D2_Stopwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.E2_Stopwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.F2_Stopwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.G2_Stopwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.A2_Stopwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.H2_Stopwert)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(33, 29)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(342, 323)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'C2_VerticalProgessBar
        '
        Me.C2_VerticalProgessBar.AccessibleName = ""
        Me.C2_VerticalProgessBar.Location = New System.Drawing.Point(4, 5)
        Me.C2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C2_VerticalProgessBar.Maximum = 255
        Me.C2_VerticalProgessBar.Name = "C2_VerticalProgessBar"
        Me.C2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.C2_VerticalProgessBar.TabIndex = 3
        '
        'D2_VerticalProgessBar
        '
        Me.D2_VerticalProgessBar.Location = New System.Drawing.Point(51, 5)
        Me.D2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D2_VerticalProgessBar.Maximum = 255
        Me.D2_VerticalProgessBar.Name = "D2_VerticalProgessBar"
        Me.D2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.D2_VerticalProgessBar.TabIndex = 4
        '
        'E2_VerticalProgessBar
        '
        Me.E2_VerticalProgessBar.Location = New System.Drawing.Point(98, 5)
        Me.E2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E2_VerticalProgessBar.Maximum = 255
        Me.E2_VerticalProgessBar.Name = "E2_VerticalProgessBar"
        Me.E2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.E2_VerticalProgessBar.TabIndex = 5
        '
        'F2_VerticalProgessBar
        '
        Me.F2_VerticalProgessBar.Location = New System.Drawing.Point(145, 5)
        Me.F2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F2_VerticalProgessBar.Maximum = 255
        Me.F2_VerticalProgessBar.Name = "F2_VerticalProgessBar"
        Me.F2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.F2_VerticalProgessBar.TabIndex = 6
        '
        'G2_VerticalProgessBar
        '
        Me.G2_VerticalProgessBar.Location = New System.Drawing.Point(192, 5)
        Me.G2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G2_VerticalProgessBar.Maximum = 255
        Me.G2_VerticalProgessBar.Name = "G2_VerticalProgessBar"
        Me.G2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.G2_VerticalProgessBar.TabIndex = 7
        '
        'A2_VerticalProgessBar
        '
        Me.A2_VerticalProgessBar.Location = New System.Drawing.Point(239, 5)
        Me.A2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2_VerticalProgessBar.Maximum = 255
        Me.A2_VerticalProgessBar.Name = "A2_VerticalProgessBar"
        Me.A2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.A2_VerticalProgessBar.TabIndex = 8
        '
        'H2_VerticalProgessBar
        '
        Me.H2_VerticalProgessBar.Location = New System.Drawing.Point(286, 5)
        Me.H2_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H2_VerticalProgessBar.Maximum = 255
        Me.H2_VerticalProgessBar.Name = "H2_VerticalProgessBar"
        Me.H2_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.H2_VerticalProgessBar.TabIndex = 9
        '
        'C2_Button
        '
        Me.C2_Button.Location = New System.Drawing.Point(4, 164)
        Me.C2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C2_Button.Name = "C2_Button"
        Me.C2_Button.Size = New System.Drawing.Size(39, 35)
        Me.C2_Button.TabIndex = 172
        Me.C2_Button.Text = "C"
        Me.C2_Button.UseVisualStyleBackColor = True
        '
        'D2_Button
        '
        Me.D2_Button.Location = New System.Drawing.Point(51, 164)
        Me.D2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D2_Button.Name = "D2_Button"
        Me.D2_Button.Size = New System.Drawing.Size(39, 35)
        Me.D2_Button.TabIndex = 173
        Me.D2_Button.Text = "D"
        Me.D2_Button.UseVisualStyleBackColor = True
        '
        'E2_Button
        '
        Me.E2_Button.Location = New System.Drawing.Point(98, 164)
        Me.E2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E2_Button.Name = "E2_Button"
        Me.E2_Button.Size = New System.Drawing.Size(39, 35)
        Me.E2_Button.TabIndex = 174
        Me.E2_Button.Text = "E"
        Me.E2_Button.UseVisualStyleBackColor = True
        '
        'F2_Button
        '
        Me.F2_Button.Location = New System.Drawing.Point(145, 164)
        Me.F2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F2_Button.Name = "F2_Button"
        Me.F2_Button.Size = New System.Drawing.Size(39, 35)
        Me.F2_Button.TabIndex = 175
        Me.F2_Button.Text = "F"
        Me.F2_Button.UseVisualStyleBackColor = True
        '
        'G2_Button
        '
        Me.G2_Button.Location = New System.Drawing.Point(192, 164)
        Me.G2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G2_Button.Name = "G2_Button"
        Me.G2_Button.Size = New System.Drawing.Size(39, 35)
        Me.G2_Button.TabIndex = 176
        Me.G2_Button.Text = "G"
        Me.G2_Button.UseVisualStyleBackColor = True
        '
        'A2_Button
        '
        Me.A2_Button.Location = New System.Drawing.Point(239, 164)
        Me.A2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2_Button.Name = "A2_Button"
        Me.A2_Button.Size = New System.Drawing.Size(39, 35)
        Me.A2_Button.TabIndex = 177
        Me.A2_Button.Text = "A"
        Me.A2_Button.UseVisualStyleBackColor = True
        '
        'H2_Button
        '
        Me.H2_Button.Location = New System.Drawing.Point(286, 164)
        Me.H2_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H2_Button.Name = "H2_Button"
        Me.H2_Button.Size = New System.Drawing.Size(39, 35)
        Me.H2_Button.TabIndex = 178
        Me.H2_Button.Text = "H"
        Me.H2_Button.UseVisualStyleBackColor = True
        '
        'C2_Wert
        '
        Me.C2_Wert.Location = New System.Drawing.Point(4, 209)
        Me.C2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C2_Wert.Name = "C2_Wert"
        Me.C2_Wert.ReadOnly = True
        Me.C2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.C2_Wert.TabIndex = 11
        Me.C2_Wert.Text = "0"
        Me.C2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Wert
        '
        Me.D2_Wert.Location = New System.Drawing.Point(49, 209)
        Me.D2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D2_Wert.Name = "D2_Wert"
        Me.D2_Wert.ReadOnly = True
        Me.D2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.D2_Wert.TabIndex = 12
        Me.D2_Wert.Text = "0"
        Me.D2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Wert
        '
        Me.E2_Wert.Location = New System.Drawing.Point(94, 209)
        Me.E2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E2_Wert.Name = "E2_Wert"
        Me.E2_Wert.ReadOnly = True
        Me.E2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.E2_Wert.TabIndex = 13
        Me.E2_Wert.Text = "0"
        Me.E2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Wert
        '
        Me.F2_Wert.Location = New System.Drawing.Point(139, 209)
        Me.F2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F2_Wert.Name = "F2_Wert"
        Me.F2_Wert.ReadOnly = True
        Me.F2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.F2_Wert.TabIndex = 14
        Me.F2_Wert.Text = "0"
        Me.F2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Wert
        '
        Me.G2_Wert.Location = New System.Drawing.Point(184, 209)
        Me.G2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G2_Wert.Name = "G2_Wert"
        Me.G2_Wert.ReadOnly = True
        Me.G2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.G2_Wert.TabIndex = 15
        Me.G2_Wert.Text = "0"
        Me.G2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Wert
        '
        Me.A2_Wert.Location = New System.Drawing.Point(229, 209)
        Me.A2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2_Wert.Name = "A2_Wert"
        Me.A2_Wert.ReadOnly = True
        Me.A2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.A2_Wert.TabIndex = 16
        Me.A2_Wert.Text = "0"
        Me.A2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Wert
        '
        Me.H2_Wert.Location = New System.Drawing.Point(274, 209)
        Me.H2_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H2_Wert.Name = "H2_Wert"
        Me.H2_Wert.ReadOnly = True
        Me.H2_Wert.Size = New System.Drawing.Size(37, 26)
        Me.H2_Wert.TabIndex = 17
        Me.H2_Wert.Text = "0"
        Me.H2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C2_Startwert
        '
        Me.C2_Startwert.Location = New System.Drawing.Point(4, 245)
        Me.C2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C2_Startwert.MaxLength = 3
        Me.C2_Startwert.Name = "C2_Startwert"
        Me.C2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.C2_Startwert.TabIndex = 18
        Me.C2_Startwert.Text = "200"
        Me.C2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Startwert
        '
        Me.D2_Startwert.Location = New System.Drawing.Point(49, 245)
        Me.D2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D2_Startwert.MaxLength = 3
        Me.D2_Startwert.Name = "D2_Startwert"
        Me.D2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.D2_Startwert.TabIndex = 19
        Me.D2_Startwert.Text = "200"
        Me.D2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Startwert
        '
        Me.E2_Startwert.Location = New System.Drawing.Point(94, 245)
        Me.E2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E2_Startwert.MaxLength = 3
        Me.E2_Startwert.Name = "E2_Startwert"
        Me.E2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.E2_Startwert.TabIndex = 20
        Me.E2_Startwert.Text = "200"
        Me.E2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Startwert
        '
        Me.F2_Startwert.Location = New System.Drawing.Point(139, 245)
        Me.F2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F2_Startwert.MaxLength = 3
        Me.F2_Startwert.Name = "F2_Startwert"
        Me.F2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.F2_Startwert.TabIndex = 21
        Me.F2_Startwert.Text = "200"
        Me.F2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Startwert
        '
        Me.G2_Startwert.Location = New System.Drawing.Point(184, 245)
        Me.G2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G2_Startwert.MaxLength = 3
        Me.G2_Startwert.Name = "G2_Startwert"
        Me.G2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.G2_Startwert.TabIndex = 22
        Me.G2_Startwert.Text = "200"
        Me.G2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Startwert
        '
        Me.A2_Startwert.Location = New System.Drawing.Point(229, 245)
        Me.A2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2_Startwert.MaxLength = 3
        Me.A2_Startwert.Name = "A2_Startwert"
        Me.A2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.A2_Startwert.TabIndex = 23
        Me.A2_Startwert.Text = "200"
        Me.A2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Startwert
        '
        Me.H2_Startwert.Location = New System.Drawing.Point(274, 245)
        Me.H2_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H2_Startwert.MaxLength = 3
        Me.H2_Startwert.Name = "H2_Startwert"
        Me.H2_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.H2_Startwert.TabIndex = 24
        Me.H2_Startwert.Text = "200"
        Me.H2_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C2_Stopwert
        '
        Me.C2_Stopwert.Location = New System.Drawing.Point(4, 281)
        Me.C2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C2_Stopwert.MaxLength = 3
        Me.C2_Stopwert.Name = "C2_Stopwert"
        Me.C2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.C2_Stopwert.TabIndex = 179
        Me.C2_Stopwert.Text = "200"
        Me.C2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Stopwert
        '
        Me.D2_Stopwert.Location = New System.Drawing.Point(49, 281)
        Me.D2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D2_Stopwert.MaxLength = 3
        Me.D2_Stopwert.Name = "D2_Stopwert"
        Me.D2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.D2_Stopwert.TabIndex = 180
        Me.D2_Stopwert.Text = "200"
        Me.D2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Stopwert
        '
        Me.E2_Stopwert.Location = New System.Drawing.Point(94, 281)
        Me.E2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E2_Stopwert.MaxLength = 3
        Me.E2_Stopwert.Name = "E2_Stopwert"
        Me.E2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.E2_Stopwert.TabIndex = 181
        Me.E2_Stopwert.Text = "200"
        Me.E2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Stopwert
        '
        Me.F2_Stopwert.Location = New System.Drawing.Point(139, 281)
        Me.F2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F2_Stopwert.MaxLength = 3
        Me.F2_Stopwert.Name = "F2_Stopwert"
        Me.F2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.F2_Stopwert.TabIndex = 182
        Me.F2_Stopwert.Text = "200"
        Me.F2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Stopwert
        '
        Me.G2_Stopwert.Location = New System.Drawing.Point(184, 281)
        Me.G2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G2_Stopwert.MaxLength = 3
        Me.G2_Stopwert.Name = "G2_Stopwert"
        Me.G2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.G2_Stopwert.TabIndex = 183
        Me.G2_Stopwert.Text = "200"
        Me.G2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Stopwert
        '
        Me.A2_Stopwert.Location = New System.Drawing.Point(229, 281)
        Me.A2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2_Stopwert.MaxLength = 3
        Me.A2_Stopwert.Name = "A2_Stopwert"
        Me.A2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.A2_Stopwert.TabIndex = 184
        Me.A2_Stopwert.Text = "200"
        Me.A2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Stopwert
        '
        Me.H2_Stopwert.Location = New System.Drawing.Point(274, 281)
        Me.H2_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H2_Stopwert.MaxLength = 3
        Me.H2_Stopwert.Name = "H2_Stopwert"
        Me.H2_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.H2_Stopwert.TabIndex = 185
        Me.H2_Stopwert.Text = "200"
        Me.H2_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.C3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.D3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.E3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.F3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.G3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.A3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.H3_VerticalProgessBar)
        Me.FlowLayoutPanel2.Controls.Add(Me.C3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.D3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.E3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.F3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.G3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.A3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.H3_Button)
        Me.FlowLayoutPanel2.Controls.Add(Me.C3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.D3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.E3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.F3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.G3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.A3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.H3_Wert)
        Me.FlowLayoutPanel2.Controls.Add(Me.C3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.D3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.E3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.F3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.G3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.A3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.H3_Startwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.C3_Stopwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.D3_Stopwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.E3_Stopwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.F3_Stopwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.G3_Stopwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.A3_Stopwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.H3_Stopwert)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(394, 29)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(345, 323)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'C3_VerticalProgessBar
        '
        Me.C3_VerticalProgessBar.AccessibleName = ""
        Me.C3_VerticalProgessBar.Location = New System.Drawing.Point(4, 5)
        Me.C3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C3_VerticalProgessBar.Maximum = 255
        Me.C3_VerticalProgessBar.Name = "C3_VerticalProgessBar"
        Me.C3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.C3_VerticalProgessBar.TabIndex = 186
        '
        'D3_VerticalProgessBar
        '
        Me.D3_VerticalProgessBar.Location = New System.Drawing.Point(51, 5)
        Me.D3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D3_VerticalProgessBar.Maximum = 255
        Me.D3_VerticalProgessBar.Name = "D3_VerticalProgessBar"
        Me.D3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.D3_VerticalProgessBar.TabIndex = 187
        '
        'E3_VerticalProgessBar
        '
        Me.E3_VerticalProgessBar.Location = New System.Drawing.Point(98, 5)
        Me.E3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E3_VerticalProgessBar.Maximum = 255
        Me.E3_VerticalProgessBar.Name = "E3_VerticalProgessBar"
        Me.E3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.E3_VerticalProgessBar.TabIndex = 188
        '
        'F3_VerticalProgessBar
        '
        Me.F3_VerticalProgessBar.Location = New System.Drawing.Point(145, 5)
        Me.F3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F3_VerticalProgessBar.Maximum = 255
        Me.F3_VerticalProgessBar.Name = "F3_VerticalProgessBar"
        Me.F3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.F3_VerticalProgessBar.TabIndex = 189
        '
        'G3_VerticalProgessBar
        '
        Me.G3_VerticalProgessBar.Location = New System.Drawing.Point(192, 5)
        Me.G3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G3_VerticalProgessBar.Maximum = 255
        Me.G3_VerticalProgessBar.Name = "G3_VerticalProgessBar"
        Me.G3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.G3_VerticalProgessBar.TabIndex = 190
        '
        'A3_VerticalProgessBar
        '
        Me.A3_VerticalProgessBar.Location = New System.Drawing.Point(239, 5)
        Me.A3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A3_VerticalProgessBar.Maximum = 255
        Me.A3_VerticalProgessBar.Name = "A3_VerticalProgessBar"
        Me.A3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.A3_VerticalProgessBar.TabIndex = 191
        '
        'H3_VerticalProgessBar
        '
        Me.H3_VerticalProgessBar.Location = New System.Drawing.Point(286, 5)
        Me.H3_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H3_VerticalProgessBar.Maximum = 255
        Me.H3_VerticalProgessBar.Name = "H3_VerticalProgessBar"
        Me.H3_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.H3_VerticalProgessBar.TabIndex = 192
        '
        'C3_Button
        '
        Me.C3_Button.Location = New System.Drawing.Point(4, 164)
        Me.C3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C3_Button.Name = "C3_Button"
        Me.C3_Button.Size = New System.Drawing.Size(39, 35)
        Me.C3_Button.TabIndex = 179
        Me.C3_Button.Text = "c"
        Me.C3_Button.UseVisualStyleBackColor = True
        '
        'D3_Button
        '
        Me.D3_Button.Location = New System.Drawing.Point(51, 164)
        Me.D3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D3_Button.Name = "D3_Button"
        Me.D3_Button.Size = New System.Drawing.Size(39, 35)
        Me.D3_Button.TabIndex = 180
        Me.D3_Button.Text = "d"
        Me.D3_Button.UseVisualStyleBackColor = True
        '
        'E3_Button
        '
        Me.E3_Button.Location = New System.Drawing.Point(98, 164)
        Me.E3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E3_Button.Name = "E3_Button"
        Me.E3_Button.Size = New System.Drawing.Size(39, 35)
        Me.E3_Button.TabIndex = 181
        Me.E3_Button.Text = "e"
        Me.E3_Button.UseVisualStyleBackColor = True
        '
        'F3_Button
        '
        Me.F3_Button.Location = New System.Drawing.Point(145, 164)
        Me.F3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F3_Button.Name = "F3_Button"
        Me.F3_Button.Size = New System.Drawing.Size(39, 35)
        Me.F3_Button.TabIndex = 182
        Me.F3_Button.Text = "f"
        Me.F3_Button.UseVisualStyleBackColor = True
        '
        'G3_Button
        '
        Me.G3_Button.Location = New System.Drawing.Point(192, 164)
        Me.G3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G3_Button.Name = "G3_Button"
        Me.G3_Button.Size = New System.Drawing.Size(39, 35)
        Me.G3_Button.TabIndex = 183
        Me.G3_Button.Text = "g"
        Me.G3_Button.UseVisualStyleBackColor = True
        '
        'A3_Button
        '
        Me.A3_Button.Location = New System.Drawing.Point(239, 164)
        Me.A3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A3_Button.Name = "A3_Button"
        Me.A3_Button.Size = New System.Drawing.Size(39, 35)
        Me.A3_Button.TabIndex = 184
        Me.A3_Button.Text = "a"
        Me.A3_Button.UseVisualStyleBackColor = True
        '
        'H3_Button
        '
        Me.H3_Button.Location = New System.Drawing.Point(286, 164)
        Me.H3_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H3_Button.Name = "H3_Button"
        Me.H3_Button.Size = New System.Drawing.Size(39, 35)
        Me.H3_Button.TabIndex = 185
        Me.H3_Button.Text = "h"
        Me.H3_Button.UseVisualStyleBackColor = True
        '
        'C3_Wert
        '
        Me.C3_Wert.Location = New System.Drawing.Point(4, 209)
        Me.C3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C3_Wert.Name = "C3_Wert"
        Me.C3_Wert.ReadOnly = True
        Me.C3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.C3_Wert.TabIndex = 12
        Me.C3_Wert.Text = "0"
        Me.C3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Wert
        '
        Me.D3_Wert.Location = New System.Drawing.Point(49, 209)
        Me.D3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D3_Wert.Name = "D3_Wert"
        Me.D3_Wert.ReadOnly = True
        Me.D3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.D3_Wert.TabIndex = 13
        Me.D3_Wert.Text = "0"
        Me.D3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Wert
        '
        Me.E3_Wert.Location = New System.Drawing.Point(94, 209)
        Me.E3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E3_Wert.Name = "E3_Wert"
        Me.E3_Wert.ReadOnly = True
        Me.E3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.E3_Wert.TabIndex = 14
        Me.E3_Wert.Text = "0"
        Me.E3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Wert
        '
        Me.F3_Wert.Location = New System.Drawing.Point(139, 209)
        Me.F3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F3_Wert.Name = "F3_Wert"
        Me.F3_Wert.ReadOnly = True
        Me.F3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.F3_Wert.TabIndex = 15
        Me.F3_Wert.Text = "0"
        Me.F3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Wert
        '
        Me.G3_Wert.Location = New System.Drawing.Point(184, 209)
        Me.G3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G3_Wert.Name = "G3_Wert"
        Me.G3_Wert.ReadOnly = True
        Me.G3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.G3_Wert.TabIndex = 16
        Me.G3_Wert.Text = "0"
        Me.G3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Wert
        '
        Me.A3_Wert.Location = New System.Drawing.Point(229, 209)
        Me.A3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A3_Wert.Name = "A3_Wert"
        Me.A3_Wert.ReadOnly = True
        Me.A3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.A3_Wert.TabIndex = 17
        Me.A3_Wert.Text = "0"
        Me.A3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Wert
        '
        Me.H3_Wert.Location = New System.Drawing.Point(274, 209)
        Me.H3_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H3_Wert.Name = "H3_Wert"
        Me.H3_Wert.ReadOnly = True
        Me.H3_Wert.Size = New System.Drawing.Size(37, 26)
        Me.H3_Wert.TabIndex = 18
        Me.H3_Wert.Text = "0"
        Me.H3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C3_Startwert
        '
        Me.C3_Startwert.Location = New System.Drawing.Point(4, 245)
        Me.C3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C3_Startwert.MaxLength = 3
        Me.C3_Startwert.Name = "C3_Startwert"
        Me.C3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.C3_Startwert.TabIndex = 25
        Me.C3_Startwert.Text = "150"
        Me.C3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Startwert
        '
        Me.D3_Startwert.Location = New System.Drawing.Point(49, 245)
        Me.D3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D3_Startwert.MaxLength = 3
        Me.D3_Startwert.Name = "D3_Startwert"
        Me.D3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.D3_Startwert.TabIndex = 26
        Me.D3_Startwert.Text = "150"
        Me.D3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Startwert
        '
        Me.E3_Startwert.Location = New System.Drawing.Point(94, 245)
        Me.E3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E3_Startwert.MaxLength = 3
        Me.E3_Startwert.Name = "E3_Startwert"
        Me.E3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.E3_Startwert.TabIndex = 27
        Me.E3_Startwert.Text = "150"
        Me.E3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Startwert
        '
        Me.F3_Startwert.Location = New System.Drawing.Point(139, 245)
        Me.F3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F3_Startwert.MaxLength = 3
        Me.F3_Startwert.Name = "F3_Startwert"
        Me.F3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.F3_Startwert.TabIndex = 28
        Me.F3_Startwert.Text = "150"
        Me.F3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Startwert
        '
        Me.G3_Startwert.Location = New System.Drawing.Point(184, 245)
        Me.G3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G3_Startwert.MaxLength = 3
        Me.G3_Startwert.Name = "G3_Startwert"
        Me.G3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.G3_Startwert.TabIndex = 29
        Me.G3_Startwert.Text = "150"
        Me.G3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Startwert
        '
        Me.A3_Startwert.Location = New System.Drawing.Point(229, 245)
        Me.A3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A3_Startwert.MaxLength = 3
        Me.A3_Startwert.Name = "A3_Startwert"
        Me.A3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.A3_Startwert.TabIndex = 30
        Me.A3_Startwert.Text = "150"
        Me.A3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Startwert
        '
        Me.H3_Startwert.Location = New System.Drawing.Point(274, 245)
        Me.H3_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H3_Startwert.MaxLength = 3
        Me.H3_Startwert.Name = "H3_Startwert"
        Me.H3_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.H3_Startwert.TabIndex = 31
        Me.H3_Startwert.Text = "150"
        Me.H3_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C3_Stopwert
        '
        Me.C3_Stopwert.Location = New System.Drawing.Point(4, 281)
        Me.C3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C3_Stopwert.MaxLength = 3
        Me.C3_Stopwert.Name = "C3_Stopwert"
        Me.C3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.C3_Stopwert.TabIndex = 193
        Me.C3_Stopwert.Text = "200"
        Me.C3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Stopwert
        '
        Me.D3_Stopwert.Location = New System.Drawing.Point(49, 281)
        Me.D3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D3_Stopwert.MaxLength = 3
        Me.D3_Stopwert.Name = "D3_Stopwert"
        Me.D3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.D3_Stopwert.TabIndex = 194
        Me.D3_Stopwert.Text = "200"
        Me.D3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Stopwert
        '
        Me.E3_Stopwert.Location = New System.Drawing.Point(94, 281)
        Me.E3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E3_Stopwert.MaxLength = 3
        Me.E3_Stopwert.Name = "E3_Stopwert"
        Me.E3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.E3_Stopwert.TabIndex = 195
        Me.E3_Stopwert.Text = "200"
        Me.E3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Stopwert
        '
        Me.F3_Stopwert.Location = New System.Drawing.Point(139, 281)
        Me.F3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F3_Stopwert.MaxLength = 3
        Me.F3_Stopwert.Name = "F3_Stopwert"
        Me.F3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.F3_Stopwert.TabIndex = 196
        Me.F3_Stopwert.Text = "200"
        Me.F3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Stopwert
        '
        Me.G3_Stopwert.Location = New System.Drawing.Point(184, 281)
        Me.G3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G3_Stopwert.MaxLength = 3
        Me.G3_Stopwert.Name = "G3_Stopwert"
        Me.G3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.G3_Stopwert.TabIndex = 197
        Me.G3_Stopwert.Text = "200"
        Me.G3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Stopwert
        '
        Me.A3_Stopwert.Location = New System.Drawing.Point(229, 281)
        Me.A3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A3_Stopwert.MaxLength = 3
        Me.A3_Stopwert.Name = "A3_Stopwert"
        Me.A3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.A3_Stopwert.TabIndex = 198
        Me.A3_Stopwert.Text = "200"
        Me.A3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Stopwert
        '
        Me.H3_Stopwert.Location = New System.Drawing.Point(274, 281)
        Me.H3_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H3_Stopwert.MaxLength = 3
        Me.H3_Stopwert.Name = "H3_Stopwert"
        Me.H3_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.H3_Stopwert.TabIndex = 199
        Me.H3_Stopwert.Text = "200"
        Me.H3_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.C5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.D5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.E5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.F5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.G5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.A5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.H5_VerticalProgessBar)
        Me.FlowLayoutPanel4.Controls.Add(Me.C5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.D5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.E5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.F5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.G5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.A5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.H5_Button)
        Me.FlowLayoutPanel4.Controls.Add(Me.C5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.D5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.E5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.F5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.G5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.A5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.H5_Wert)
        Me.FlowLayoutPanel4.Controls.Add(Me.C5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.D5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.E5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.F5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.G5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.A5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.H5_Startwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.C5_Stopwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.D5_Stopwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.E5_Stopwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.F5_Stopwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.G5_Stopwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.A5_Stopwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.H5_Stopwert)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(1125, 29)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(346, 323)
        Me.FlowLayoutPanel4.TabIndex = 9
        '
        'C5_VerticalProgessBar
        '
        Me.C5_VerticalProgessBar.Location = New System.Drawing.Point(4, 5)
        Me.C5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C5_VerticalProgessBar.Maximum = 255
        Me.C5_VerticalProgessBar.Name = "C5_VerticalProgessBar"
        Me.C5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.C5_VerticalProgessBar.TabIndex = 3
        '
        'D5_VerticalProgessBar
        '
        Me.D5_VerticalProgessBar.Location = New System.Drawing.Point(51, 5)
        Me.D5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D5_VerticalProgessBar.Maximum = 255
        Me.D5_VerticalProgessBar.Name = "D5_VerticalProgessBar"
        Me.D5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.D5_VerticalProgessBar.TabIndex = 4
        '
        'E5_VerticalProgessBar
        '
        Me.E5_VerticalProgessBar.Location = New System.Drawing.Point(98, 5)
        Me.E5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E5_VerticalProgessBar.Maximum = 255
        Me.E5_VerticalProgessBar.Name = "E5_VerticalProgessBar"
        Me.E5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.E5_VerticalProgessBar.TabIndex = 5
        '
        'F5_VerticalProgessBar
        '
        Me.F5_VerticalProgessBar.Location = New System.Drawing.Point(145, 5)
        Me.F5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F5_VerticalProgessBar.Maximum = 255
        Me.F5_VerticalProgessBar.Name = "F5_VerticalProgessBar"
        Me.F5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.F5_VerticalProgessBar.TabIndex = 6
        '
        'G5_VerticalProgessBar
        '
        Me.G5_VerticalProgessBar.Location = New System.Drawing.Point(192, 5)
        Me.G5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G5_VerticalProgessBar.Maximum = 255
        Me.G5_VerticalProgessBar.Name = "G5_VerticalProgessBar"
        Me.G5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.G5_VerticalProgessBar.TabIndex = 7
        '
        'A5_VerticalProgessBar
        '
        Me.A5_VerticalProgessBar.Location = New System.Drawing.Point(239, 5)
        Me.A5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A5_VerticalProgessBar.Maximum = 255
        Me.A5_VerticalProgessBar.Name = "A5_VerticalProgessBar"
        Me.A5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.A5_VerticalProgessBar.TabIndex = 8
        '
        'H5_VerticalProgessBar
        '
        Me.H5_VerticalProgessBar.Location = New System.Drawing.Point(286, 5)
        Me.H5_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H5_VerticalProgessBar.Maximum = 255
        Me.H5_VerticalProgessBar.Name = "H5_VerticalProgessBar"
        Me.H5_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.H5_VerticalProgessBar.TabIndex = 9
        '
        'C5_Button
        '
        Me.C5_Button.Location = New System.Drawing.Point(4, 164)
        Me.C5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C5_Button.Name = "C5_Button"
        Me.C5_Button.Size = New System.Drawing.Size(39, 35)
        Me.C5_Button.TabIndex = 179
        Me.C5_Button.Text = "c''"
        Me.C5_Button.UseVisualStyleBackColor = True
        '
        'D5_Button
        '
        Me.D5_Button.Location = New System.Drawing.Point(51, 164)
        Me.D5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D5_Button.Name = "D5_Button"
        Me.D5_Button.Size = New System.Drawing.Size(39, 35)
        Me.D5_Button.TabIndex = 180
        Me.D5_Button.Text = "d''"
        Me.D5_Button.UseVisualStyleBackColor = True
        '
        'E5_Button
        '
        Me.E5_Button.Location = New System.Drawing.Point(98, 164)
        Me.E5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E5_Button.Name = "E5_Button"
        Me.E5_Button.Size = New System.Drawing.Size(39, 35)
        Me.E5_Button.TabIndex = 181
        Me.E5_Button.Text = "e''"
        Me.E5_Button.UseVisualStyleBackColor = True
        '
        'F5_Button
        '
        Me.F5_Button.Location = New System.Drawing.Point(145, 164)
        Me.F5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F5_Button.Name = "F5_Button"
        Me.F5_Button.Size = New System.Drawing.Size(39, 35)
        Me.F5_Button.TabIndex = 182
        Me.F5_Button.Text = "f''"
        Me.F5_Button.UseVisualStyleBackColor = True
        '
        'G5_Button
        '
        Me.G5_Button.Location = New System.Drawing.Point(192, 164)
        Me.G5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G5_Button.Name = "G5_Button"
        Me.G5_Button.Size = New System.Drawing.Size(39, 35)
        Me.G5_Button.TabIndex = 183
        Me.G5_Button.Text = "g''"
        Me.G5_Button.UseVisualStyleBackColor = True
        '
        'A5_Button
        '
        Me.A5_Button.Location = New System.Drawing.Point(239, 164)
        Me.A5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A5_Button.Name = "A5_Button"
        Me.A5_Button.Size = New System.Drawing.Size(39, 35)
        Me.A5_Button.TabIndex = 184
        Me.A5_Button.Text = "a''"
        Me.A5_Button.UseVisualStyleBackColor = True
        '
        'H5_Button
        '
        Me.H5_Button.Location = New System.Drawing.Point(286, 164)
        Me.H5_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H5_Button.Name = "H5_Button"
        Me.H5_Button.Size = New System.Drawing.Size(39, 35)
        Me.H5_Button.TabIndex = 185
        Me.H5_Button.Text = "h''"
        Me.H5_Button.UseVisualStyleBackColor = True
        '
        'C5_Wert
        '
        Me.C5_Wert.Location = New System.Drawing.Point(4, 209)
        Me.C5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C5_Wert.Name = "C5_Wert"
        Me.C5_Wert.ReadOnly = True
        Me.C5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.C5_Wert.TabIndex = 12
        Me.C5_Wert.Text = "0"
        Me.C5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Wert
        '
        Me.D5_Wert.Location = New System.Drawing.Point(49, 209)
        Me.D5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D5_Wert.Name = "D5_Wert"
        Me.D5_Wert.ReadOnly = True
        Me.D5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.D5_Wert.TabIndex = 13
        Me.D5_Wert.Text = "0"
        Me.D5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Wert
        '
        Me.E5_Wert.Location = New System.Drawing.Point(94, 209)
        Me.E5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E5_Wert.Name = "E5_Wert"
        Me.E5_Wert.ReadOnly = True
        Me.E5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.E5_Wert.TabIndex = 14
        Me.E5_Wert.Text = "0"
        Me.E5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Wert
        '
        Me.F5_Wert.Location = New System.Drawing.Point(139, 209)
        Me.F5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F5_Wert.Name = "F5_Wert"
        Me.F5_Wert.ReadOnly = True
        Me.F5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.F5_Wert.TabIndex = 15
        Me.F5_Wert.Text = "0"
        Me.F5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Wert
        '
        Me.G5_Wert.Location = New System.Drawing.Point(184, 209)
        Me.G5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G5_Wert.Name = "G5_Wert"
        Me.G5_Wert.ReadOnly = True
        Me.G5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.G5_Wert.TabIndex = 16
        Me.G5_Wert.Text = "0"
        Me.G5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Wert
        '
        Me.A5_Wert.Location = New System.Drawing.Point(229, 209)
        Me.A5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A5_Wert.Name = "A5_Wert"
        Me.A5_Wert.ReadOnly = True
        Me.A5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.A5_Wert.TabIndex = 17
        Me.A5_Wert.Text = "0"
        Me.A5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Wert
        '
        Me.H5_Wert.Location = New System.Drawing.Point(274, 209)
        Me.H5_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H5_Wert.Name = "H5_Wert"
        Me.H5_Wert.ReadOnly = True
        Me.H5_Wert.Size = New System.Drawing.Size(37, 26)
        Me.H5_Wert.TabIndex = 18
        Me.H5_Wert.Text = "0"
        Me.H5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C5_Startwert
        '
        Me.C5_Startwert.Location = New System.Drawing.Point(4, 245)
        Me.C5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C5_Startwert.MaxLength = 3
        Me.C5_Startwert.Name = "C5_Startwert"
        Me.C5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.C5_Startwert.TabIndex = 25
        Me.C5_Startwert.Text = "75"
        Me.C5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Startwert
        '
        Me.D5_Startwert.Location = New System.Drawing.Point(49, 245)
        Me.D5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D5_Startwert.MaxLength = 3
        Me.D5_Startwert.Name = "D5_Startwert"
        Me.D5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.D5_Startwert.TabIndex = 26
        Me.D5_Startwert.Text = "75"
        Me.D5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Startwert
        '
        Me.E5_Startwert.Location = New System.Drawing.Point(94, 245)
        Me.E5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E5_Startwert.MaxLength = 3
        Me.E5_Startwert.Name = "E5_Startwert"
        Me.E5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.E5_Startwert.TabIndex = 27
        Me.E5_Startwert.Text = "75"
        Me.E5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Startwert
        '
        Me.F5_Startwert.Location = New System.Drawing.Point(139, 245)
        Me.F5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F5_Startwert.MaxLength = 3
        Me.F5_Startwert.Name = "F5_Startwert"
        Me.F5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.F5_Startwert.TabIndex = 28
        Me.F5_Startwert.Text = "75"
        Me.F5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Startwert
        '
        Me.G5_Startwert.Location = New System.Drawing.Point(184, 245)
        Me.G5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G5_Startwert.MaxLength = 3
        Me.G5_Startwert.Name = "G5_Startwert"
        Me.G5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.G5_Startwert.TabIndex = 29
        Me.G5_Startwert.Text = "75"
        Me.G5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Startwert
        '
        Me.A5_Startwert.Location = New System.Drawing.Point(229, 245)
        Me.A5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A5_Startwert.MaxLength = 3
        Me.A5_Startwert.Name = "A5_Startwert"
        Me.A5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.A5_Startwert.TabIndex = 30
        Me.A5_Startwert.Text = "75"
        Me.A5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Startwert
        '
        Me.H5_Startwert.Location = New System.Drawing.Point(274, 245)
        Me.H5_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H5_Startwert.MaxLength = 3
        Me.H5_Startwert.Name = "H5_Startwert"
        Me.H5_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.H5_Startwert.TabIndex = 31
        Me.H5_Startwert.Text = "75"
        Me.H5_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C5_Stopwert
        '
        Me.C5_Stopwert.Location = New System.Drawing.Point(4, 281)
        Me.C5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C5_Stopwert.MaxLength = 3
        Me.C5_Stopwert.Name = "C5_Stopwert"
        Me.C5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.C5_Stopwert.TabIndex = 186
        Me.C5_Stopwert.Text = "200"
        Me.C5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Stopwert
        '
        Me.D5_Stopwert.Location = New System.Drawing.Point(49, 281)
        Me.D5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D5_Stopwert.MaxLength = 3
        Me.D5_Stopwert.Name = "D5_Stopwert"
        Me.D5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.D5_Stopwert.TabIndex = 187
        Me.D5_Stopwert.Text = "200"
        Me.D5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Stopwert
        '
        Me.E5_Stopwert.Location = New System.Drawing.Point(94, 281)
        Me.E5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E5_Stopwert.MaxLength = 3
        Me.E5_Stopwert.Name = "E5_Stopwert"
        Me.E5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.E5_Stopwert.TabIndex = 188
        Me.E5_Stopwert.Text = "200"
        Me.E5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Stopwert
        '
        Me.F5_Stopwert.Location = New System.Drawing.Point(139, 281)
        Me.F5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F5_Stopwert.MaxLength = 3
        Me.F5_Stopwert.Name = "F5_Stopwert"
        Me.F5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.F5_Stopwert.TabIndex = 189
        Me.F5_Stopwert.Text = "200"
        Me.F5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Stopwert
        '
        Me.G5_Stopwert.Location = New System.Drawing.Point(184, 281)
        Me.G5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G5_Stopwert.MaxLength = 3
        Me.G5_Stopwert.Name = "G5_Stopwert"
        Me.G5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.G5_Stopwert.TabIndex = 190
        Me.G5_Stopwert.Text = "200"
        Me.G5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Stopwert
        '
        Me.A5_Stopwert.Location = New System.Drawing.Point(229, 281)
        Me.A5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A5_Stopwert.MaxLength = 3
        Me.A5_Stopwert.Name = "A5_Stopwert"
        Me.A5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.A5_Stopwert.TabIndex = 191
        Me.A5_Stopwert.Text = "200"
        Me.A5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Stopwert
        '
        Me.H5_Stopwert.Location = New System.Drawing.Point(274, 281)
        Me.H5_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H5_Stopwert.MaxLength = 3
        Me.H5_Stopwert.Name = "H5_Stopwert"
        Me.H5_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.H5_Stopwert.TabIndex = 192
        Me.H5_Stopwert.Text = "200"
        Me.H5_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.C4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.D4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.E4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.F4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.G4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.A4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.H4_VerticalProgessBar)
        Me.FlowLayoutPanel3.Controls.Add(Me.C4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.D4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.E4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.F4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.G4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.A4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.H4_Button)
        Me.FlowLayoutPanel3.Controls.Add(Me.C4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.D4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.E4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.F4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.G4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.A4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.H4_Wert)
        Me.FlowLayoutPanel3.Controls.Add(Me.C4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.D4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.E4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.F4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.G4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.A4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.H4_Startwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.C4_Stopwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.D4_Stopwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.E4_Stopwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.F4_Stopwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.G4_Stopwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.A4_Stopwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.H4_Stopwert)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(756, 29)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(348, 323)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'C4_VerticalProgessBar
        '
        Me.C4_VerticalProgessBar.Location = New System.Drawing.Point(4, 5)
        Me.C4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C4_VerticalProgessBar.Maximum = 255
        Me.C4_VerticalProgessBar.Name = "C4_VerticalProgessBar"
        Me.C4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.C4_VerticalProgessBar.TabIndex = 3
        '
        'D4_VerticalProgessBar
        '
        Me.D4_VerticalProgessBar.Location = New System.Drawing.Point(51, 5)
        Me.D4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D4_VerticalProgessBar.Maximum = 255
        Me.D4_VerticalProgessBar.Name = "D4_VerticalProgessBar"
        Me.D4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.D4_VerticalProgessBar.TabIndex = 4
        '
        'E4_VerticalProgessBar
        '
        Me.E4_VerticalProgessBar.Location = New System.Drawing.Point(98, 5)
        Me.E4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E4_VerticalProgessBar.Maximum = 255
        Me.E4_VerticalProgessBar.Name = "E4_VerticalProgessBar"
        Me.E4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.E4_VerticalProgessBar.TabIndex = 5
        '
        'F4_VerticalProgessBar
        '
        Me.F4_VerticalProgessBar.Location = New System.Drawing.Point(145, 5)
        Me.F4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F4_VerticalProgessBar.Maximum = 255
        Me.F4_VerticalProgessBar.Name = "F4_VerticalProgessBar"
        Me.F4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.F4_VerticalProgessBar.TabIndex = 6
        '
        'G4_VerticalProgessBar
        '
        Me.G4_VerticalProgessBar.Location = New System.Drawing.Point(192, 5)
        Me.G4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G4_VerticalProgessBar.Maximum = 255
        Me.G4_VerticalProgessBar.Name = "G4_VerticalProgessBar"
        Me.G4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.G4_VerticalProgessBar.TabIndex = 7
        '
        'A4_VerticalProgessBar
        '
        Me.A4_VerticalProgessBar.Location = New System.Drawing.Point(239, 5)
        Me.A4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A4_VerticalProgessBar.Maximum = 255
        Me.A4_VerticalProgessBar.Name = "A4_VerticalProgessBar"
        Me.A4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.A4_VerticalProgessBar.TabIndex = 8
        '
        'H4_VerticalProgessBar
        '
        Me.H4_VerticalProgessBar.Location = New System.Drawing.Point(286, 5)
        Me.H4_VerticalProgessBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H4_VerticalProgessBar.Maximum = 255
        Me.H4_VerticalProgessBar.Name = "H4_VerticalProgessBar"
        Me.H4_VerticalProgessBar.Size = New System.Drawing.Size(39, 149)
        Me.H4_VerticalProgessBar.TabIndex = 9
        '
        'C4_Button
        '
        Me.C4_Button.Location = New System.Drawing.Point(4, 164)
        Me.C4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C4_Button.Name = "C4_Button"
        Me.C4_Button.Size = New System.Drawing.Size(39, 35)
        Me.C4_Button.TabIndex = 179
        Me.C4_Button.Text = "c'"
        Me.C4_Button.UseVisualStyleBackColor = True
        '
        'D4_Button
        '
        Me.D4_Button.Location = New System.Drawing.Point(51, 164)
        Me.D4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D4_Button.Name = "D4_Button"
        Me.D4_Button.Size = New System.Drawing.Size(39, 35)
        Me.D4_Button.TabIndex = 180
        Me.D4_Button.Text = "d'"
        Me.D4_Button.UseVisualStyleBackColor = True
        '
        'E4_Button
        '
        Me.E4_Button.Location = New System.Drawing.Point(98, 164)
        Me.E4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E4_Button.Name = "E4_Button"
        Me.E4_Button.Size = New System.Drawing.Size(39, 35)
        Me.E4_Button.TabIndex = 181
        Me.E4_Button.Text = "e'"
        Me.E4_Button.UseVisualStyleBackColor = True
        '
        'F4_Button
        '
        Me.F4_Button.Location = New System.Drawing.Point(145, 164)
        Me.F4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F4_Button.Name = "F4_Button"
        Me.F4_Button.Size = New System.Drawing.Size(39, 35)
        Me.F4_Button.TabIndex = 182
        Me.F4_Button.Text = "f'"
        Me.F4_Button.UseVisualStyleBackColor = True
        '
        'G4_Button
        '
        Me.G4_Button.Location = New System.Drawing.Point(192, 164)
        Me.G4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G4_Button.Name = "G4_Button"
        Me.G4_Button.Size = New System.Drawing.Size(39, 35)
        Me.G4_Button.TabIndex = 183
        Me.G4_Button.Text = "g'"
        Me.G4_Button.UseVisualStyleBackColor = True
        '
        'A4_Button
        '
        Me.A4_Button.Location = New System.Drawing.Point(239, 164)
        Me.A4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A4_Button.Name = "A4_Button"
        Me.A4_Button.Size = New System.Drawing.Size(39, 35)
        Me.A4_Button.TabIndex = 184
        Me.A4_Button.Text = "a'"
        Me.A4_Button.UseVisualStyleBackColor = True
        '
        'H4_Button
        '
        Me.H4_Button.Location = New System.Drawing.Point(286, 164)
        Me.H4_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H4_Button.Name = "H4_Button"
        Me.H4_Button.Size = New System.Drawing.Size(39, 35)
        Me.H4_Button.TabIndex = 185
        Me.H4_Button.Text = "h'"
        Me.H4_Button.UseVisualStyleBackColor = True
        '
        'C4_Wert
        '
        Me.C4_Wert.Location = New System.Drawing.Point(4, 209)
        Me.C4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C4_Wert.Name = "C4_Wert"
        Me.C4_Wert.ReadOnly = True
        Me.C4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.C4_Wert.TabIndex = 12
        Me.C4_Wert.Text = "0"
        Me.C4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Wert
        '
        Me.D4_Wert.Location = New System.Drawing.Point(49, 209)
        Me.D4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D4_Wert.Name = "D4_Wert"
        Me.D4_Wert.ReadOnly = True
        Me.D4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.D4_Wert.TabIndex = 13
        Me.D4_Wert.Text = "0"
        Me.D4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Wert
        '
        Me.E4_Wert.Location = New System.Drawing.Point(94, 209)
        Me.E4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E4_Wert.Name = "E4_Wert"
        Me.E4_Wert.ReadOnly = True
        Me.E4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.E4_Wert.TabIndex = 14
        Me.E4_Wert.Text = "0"
        Me.E4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Wert
        '
        Me.F4_Wert.Location = New System.Drawing.Point(139, 209)
        Me.F4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F4_Wert.Name = "F4_Wert"
        Me.F4_Wert.ReadOnly = True
        Me.F4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.F4_Wert.TabIndex = 15
        Me.F4_Wert.Text = "0"
        Me.F4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Wert
        '
        Me.G4_Wert.Location = New System.Drawing.Point(184, 209)
        Me.G4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G4_Wert.Name = "G4_Wert"
        Me.G4_Wert.ReadOnly = True
        Me.G4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.G4_Wert.TabIndex = 16
        Me.G4_Wert.Text = "0"
        Me.G4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Wert
        '
        Me.A4_Wert.Location = New System.Drawing.Point(229, 209)
        Me.A4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A4_Wert.Name = "A4_Wert"
        Me.A4_Wert.ReadOnly = True
        Me.A4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.A4_Wert.TabIndex = 17
        Me.A4_Wert.Text = "0"
        Me.A4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Wert
        '
        Me.H4_Wert.Location = New System.Drawing.Point(274, 209)
        Me.H4_Wert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H4_Wert.Name = "H4_Wert"
        Me.H4_Wert.ReadOnly = True
        Me.H4_Wert.Size = New System.Drawing.Size(37, 26)
        Me.H4_Wert.TabIndex = 18
        Me.H4_Wert.Text = "0"
        Me.H4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C4_Startwert
        '
        Me.C4_Startwert.Location = New System.Drawing.Point(4, 245)
        Me.C4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C4_Startwert.MaxLength = 3
        Me.C4_Startwert.Name = "C4_Startwert"
        Me.C4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.C4_Startwert.TabIndex = 25
        Me.C4_Startwert.Text = "100"
        Me.C4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Startwert
        '
        Me.D4_Startwert.Location = New System.Drawing.Point(49, 245)
        Me.D4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D4_Startwert.MaxLength = 3
        Me.D4_Startwert.Name = "D4_Startwert"
        Me.D4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.D4_Startwert.TabIndex = 26
        Me.D4_Startwert.Text = "100"
        Me.D4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Startwert
        '
        Me.E4_Startwert.Location = New System.Drawing.Point(94, 245)
        Me.E4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E4_Startwert.MaxLength = 3
        Me.E4_Startwert.Name = "E4_Startwert"
        Me.E4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.E4_Startwert.TabIndex = 27
        Me.E4_Startwert.Text = "100"
        Me.E4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Startwert
        '
        Me.F4_Startwert.Location = New System.Drawing.Point(139, 245)
        Me.F4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F4_Startwert.MaxLength = 3
        Me.F4_Startwert.Name = "F4_Startwert"
        Me.F4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.F4_Startwert.TabIndex = 28
        Me.F4_Startwert.Text = "100"
        Me.F4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Startwert
        '
        Me.G4_Startwert.Location = New System.Drawing.Point(184, 245)
        Me.G4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G4_Startwert.MaxLength = 3
        Me.G4_Startwert.Name = "G4_Startwert"
        Me.G4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.G4_Startwert.TabIndex = 29
        Me.G4_Startwert.Text = "100"
        Me.G4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Startwert
        '
        Me.A4_Startwert.Location = New System.Drawing.Point(229, 245)
        Me.A4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A4_Startwert.MaxLength = 3
        Me.A4_Startwert.Name = "A4_Startwert"
        Me.A4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.A4_Startwert.TabIndex = 30
        Me.A4_Startwert.Text = "100"
        Me.A4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Startwert
        '
        Me.H4_Startwert.Location = New System.Drawing.Point(274, 245)
        Me.H4_Startwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H4_Startwert.MaxLength = 3
        Me.H4_Startwert.Name = "H4_Startwert"
        Me.H4_Startwert.Size = New System.Drawing.Size(37, 26)
        Me.H4_Startwert.TabIndex = 31
        Me.H4_Startwert.Text = "100"
        Me.H4_Startwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C4_Stopwert
        '
        Me.C4_Stopwert.Location = New System.Drawing.Point(4, 281)
        Me.C4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C4_Stopwert.MaxLength = 3
        Me.C4_Stopwert.Name = "C4_Stopwert"
        Me.C4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.C4_Stopwert.TabIndex = 186
        Me.C4_Stopwert.Text = "200"
        Me.C4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Stopwert
        '
        Me.D4_Stopwert.Location = New System.Drawing.Point(49, 281)
        Me.D4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D4_Stopwert.MaxLength = 3
        Me.D4_Stopwert.Name = "D4_Stopwert"
        Me.D4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.D4_Stopwert.TabIndex = 187
        Me.D4_Stopwert.Text = "200"
        Me.D4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Stopwert
        '
        Me.E4_Stopwert.Location = New System.Drawing.Point(94, 281)
        Me.E4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E4_Stopwert.MaxLength = 3
        Me.E4_Stopwert.Name = "E4_Stopwert"
        Me.E4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.E4_Stopwert.TabIndex = 188
        Me.E4_Stopwert.Text = "200"
        Me.E4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Stopwert
        '
        Me.F4_Stopwert.Location = New System.Drawing.Point(139, 281)
        Me.F4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F4_Stopwert.MaxLength = 3
        Me.F4_Stopwert.Name = "F4_Stopwert"
        Me.F4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.F4_Stopwert.TabIndex = 189
        Me.F4_Stopwert.Text = "200"
        Me.F4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Stopwert
        '
        Me.G4_Stopwert.Location = New System.Drawing.Point(184, 281)
        Me.G4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G4_Stopwert.MaxLength = 3
        Me.G4_Stopwert.Name = "G4_Stopwert"
        Me.G4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.G4_Stopwert.TabIndex = 190
        Me.G4_Stopwert.Text = "200"
        Me.G4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Stopwert
        '
        Me.A4_Stopwert.Location = New System.Drawing.Point(229, 281)
        Me.A4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A4_Stopwert.MaxLength = 3
        Me.A4_Stopwert.Name = "A4_Stopwert"
        Me.A4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.A4_Stopwert.TabIndex = 191
        Me.A4_Stopwert.Text = "200"
        Me.A4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Stopwert
        '
        Me.H4_Stopwert.Location = New System.Drawing.Point(274, 281)
        Me.H4_Stopwert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H4_Stopwert.MaxLength = 3
        Me.H4_Stopwert.Name = "H4_Stopwert"
        Me.H4_Stopwert.Size = New System.Drawing.Size(37, 26)
        Me.H4_Stopwert.TabIndex = 192
        Me.H4_Stopwert.Text = "200"
        Me.H4_Stopwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel11)
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel7)
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel10)
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel8)
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel9)
        Me.GroupBox5.Location = New System.Drawing.Point(33, 357)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Size = New System.Drawing.Size(1815, 78)
        Me.GroupBox5.TabIndex = 174
        Me.GroupBox5.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(718, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(336, 20)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "Induviduelle Halbtonverschiebung (Transpose)"
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.C6_Verschiebung)
        Me.FlowLayoutPanel11.Controls.Add(Me.D6_Verschiebung)
        Me.FlowLayoutPanel11.Controls.Add(Me.E6_Verschiebung)
        Me.FlowLayoutPanel11.Controls.Add(Me.F6_Verschiebung)
        Me.FlowLayoutPanel11.Controls.Add(Me.G6_Verschiebung)
        Me.FlowLayoutPanel11.Controls.Add(Me.A6_Verschiebung)
        Me.FlowLayoutPanel11.Controls.Add(Me.H6_Verschiebung)
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(1455, 26)
        Me.FlowLayoutPanel11.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(356, 42)
        Me.FlowLayoutPanel11.TabIndex = 173
        '
        'C6_Verschiebung
        '
        Me.C6_Verschiebung.Location = New System.Drawing.Point(4, 5)
        Me.C6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C6_Verschiebung.Name = "C6_Verschiebung"
        Me.C6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.C6_Verschiebung.TabIndex = 19
        Me.C6_Verschiebung.Text = "0"
        Me.C6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Verschiebung
        '
        Me.D6_Verschiebung.Location = New System.Drawing.Point(49, 5)
        Me.D6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D6_Verschiebung.Name = "D6_Verschiebung"
        Me.D6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.D6_Verschiebung.TabIndex = 20
        Me.D6_Verschiebung.Text = "0"
        Me.D6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Verschiebung
        '
        Me.E6_Verschiebung.Location = New System.Drawing.Point(94, 5)
        Me.E6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E6_Verschiebung.Name = "E6_Verschiebung"
        Me.E6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.E6_Verschiebung.TabIndex = 21
        Me.E6_Verschiebung.Text = "0"
        Me.E6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Verschiebung
        '
        Me.F6_Verschiebung.Location = New System.Drawing.Point(139, 5)
        Me.F6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F6_Verschiebung.Name = "F6_Verschiebung"
        Me.F6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.F6_Verschiebung.TabIndex = 22
        Me.F6_Verschiebung.Text = "0"
        Me.F6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Verschiebung
        '
        Me.G6_Verschiebung.Location = New System.Drawing.Point(184, 5)
        Me.G6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G6_Verschiebung.Name = "G6_Verschiebung"
        Me.G6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.G6_Verschiebung.TabIndex = 23
        Me.G6_Verschiebung.Text = "0"
        Me.G6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Verschiebung
        '
        Me.A6_Verschiebung.Location = New System.Drawing.Point(229, 5)
        Me.A6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A6_Verschiebung.Name = "A6_Verschiebung"
        Me.A6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.A6_Verschiebung.TabIndex = 24
        Me.A6_Verschiebung.Text = "0"
        Me.A6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Verschiebung
        '
        Me.H6_Verschiebung.Location = New System.Drawing.Point(274, 5)
        Me.H6_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H6_Verschiebung.Name = "H6_Verschiebung"
        Me.H6_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.H6_Verschiebung.TabIndex = 25
        Me.H6_Verschiebung.Text = "0"
        Me.H6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.C2_Verschiebung)
        Me.FlowLayoutPanel7.Controls.Add(Me.D2_Verschiebung)
        Me.FlowLayoutPanel7.Controls.Add(Me.E2_Verschiebung)
        Me.FlowLayoutPanel7.Controls.Add(Me.F2_Verschiebung)
        Me.FlowLayoutPanel7.Controls.Add(Me.G2_Verschiebung)
        Me.FlowLayoutPanel7.Controls.Add(Me.A2_Verschiebung)
        Me.FlowLayoutPanel7.Controls.Add(Me.H2_Verschiebung)
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(0, 26)
        Me.FlowLayoutPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(342, 42)
        Me.FlowLayoutPanel7.TabIndex = 169
        '
        'C2_Verschiebung
        '
        Me.C2_Verschiebung.Location = New System.Drawing.Point(4, 5)
        Me.C2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C2_Verschiebung.Name = "C2_Verschiebung"
        Me.C2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.C2_Verschiebung.TabIndex = 19
        Me.C2_Verschiebung.Text = "0"
        Me.C2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Verschiebung
        '
        Me.D2_Verschiebung.Location = New System.Drawing.Point(49, 5)
        Me.D2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D2_Verschiebung.Name = "D2_Verschiebung"
        Me.D2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.D2_Verschiebung.TabIndex = 20
        Me.D2_Verschiebung.Text = "0"
        Me.D2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Verschiebung
        '
        Me.E2_Verschiebung.Location = New System.Drawing.Point(94, 5)
        Me.E2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E2_Verschiebung.Name = "E2_Verschiebung"
        Me.E2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.E2_Verschiebung.TabIndex = 21
        Me.E2_Verschiebung.Text = "0"
        Me.E2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Verschiebung
        '
        Me.F2_Verschiebung.Location = New System.Drawing.Point(139, 5)
        Me.F2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F2_Verschiebung.Name = "F2_Verschiebung"
        Me.F2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.F2_Verschiebung.TabIndex = 22
        Me.F2_Verschiebung.Text = "0"
        Me.F2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Verschiebung
        '
        Me.G2_Verschiebung.Location = New System.Drawing.Point(184, 5)
        Me.G2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G2_Verschiebung.Name = "G2_Verschiebung"
        Me.G2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.G2_Verschiebung.TabIndex = 23
        Me.G2_Verschiebung.Text = "0"
        Me.G2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Verschiebung
        '
        Me.A2_Verschiebung.Location = New System.Drawing.Point(229, 5)
        Me.A2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2_Verschiebung.Name = "A2_Verschiebung"
        Me.A2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.A2_Verschiebung.TabIndex = 24
        Me.A2_Verschiebung.Text = "0"
        Me.A2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Verschiebung
        '
        Me.H2_Verschiebung.Location = New System.Drawing.Point(274, 5)
        Me.H2_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H2_Verschiebung.Name = "H2_Verschiebung"
        Me.H2_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.H2_Verschiebung.TabIndex = 25
        Me.H2_Verschiebung.Text = "0"
        Me.H2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.C5_Verschiebung)
        Me.FlowLayoutPanel10.Controls.Add(Me.D5_Verschiebung)
        Me.FlowLayoutPanel10.Controls.Add(Me.E5_Verschiebung)
        Me.FlowLayoutPanel10.Controls.Add(Me.F5_Verschiebung)
        Me.FlowLayoutPanel10.Controls.Add(Me.G5_Verschiebung)
        Me.FlowLayoutPanel10.Controls.Add(Me.A5_Verschiebung)
        Me.FlowLayoutPanel10.Controls.Add(Me.H5_Verschiebung)
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(1088, 26)
        Me.FlowLayoutPanel10.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(346, 42)
        Me.FlowLayoutPanel10.TabIndex = 172
        '
        'C5_Verschiebung
        '
        Me.C5_Verschiebung.Location = New System.Drawing.Point(4, 5)
        Me.C5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C5_Verschiebung.Name = "C5_Verschiebung"
        Me.C5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.C5_Verschiebung.TabIndex = 19
        Me.C5_Verschiebung.Text = "0"
        Me.C5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Verschiebung
        '
        Me.D5_Verschiebung.Location = New System.Drawing.Point(49, 5)
        Me.D5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D5_Verschiebung.Name = "D5_Verschiebung"
        Me.D5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.D5_Verschiebung.TabIndex = 20
        Me.D5_Verschiebung.Text = "0"
        Me.D5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Verschiebung
        '
        Me.E5_Verschiebung.Location = New System.Drawing.Point(94, 5)
        Me.E5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E5_Verschiebung.Name = "E5_Verschiebung"
        Me.E5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.E5_Verschiebung.TabIndex = 21
        Me.E5_Verschiebung.Text = "0"
        Me.E5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Verschiebung
        '
        Me.F5_Verschiebung.Location = New System.Drawing.Point(139, 5)
        Me.F5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F5_Verschiebung.Name = "F5_Verschiebung"
        Me.F5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.F5_Verschiebung.TabIndex = 22
        Me.F5_Verschiebung.Text = "0"
        Me.F5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Verschiebung
        '
        Me.G5_Verschiebung.Location = New System.Drawing.Point(184, 5)
        Me.G5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G5_Verschiebung.Name = "G5_Verschiebung"
        Me.G5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.G5_Verschiebung.TabIndex = 23
        Me.G5_Verschiebung.Text = "0"
        Me.G5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Verschiebung
        '
        Me.A5_Verschiebung.Location = New System.Drawing.Point(229, 5)
        Me.A5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A5_Verschiebung.Name = "A5_Verschiebung"
        Me.A5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.A5_Verschiebung.TabIndex = 24
        Me.A5_Verschiebung.Text = "0"
        Me.A5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Verschiebung
        '
        Me.H5_Verschiebung.Location = New System.Drawing.Point(274, 5)
        Me.H5_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H5_Verschiebung.Name = "H5_Verschiebung"
        Me.H5_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.H5_Verschiebung.TabIndex = 25
        Me.H5_Verschiebung.Text = "0"
        Me.H5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.C3_Verschiebung)
        Me.FlowLayoutPanel8.Controls.Add(Me.D3_Verschiebung)
        Me.FlowLayoutPanel8.Controls.Add(Me.E3_Verschiebung)
        Me.FlowLayoutPanel8.Controls.Add(Me.F3_Verschiebung)
        Me.FlowLayoutPanel8.Controls.Add(Me.G3_Verschiebung)
        Me.FlowLayoutPanel8.Controls.Add(Me.A3_Verschiebung)
        Me.FlowLayoutPanel8.Controls.Add(Me.H3_Verschiebung)
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(362, 26)
        Me.FlowLayoutPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(345, 42)
        Me.FlowLayoutPanel8.TabIndex = 170
        '
        'C3_Verschiebung
        '
        Me.C3_Verschiebung.Location = New System.Drawing.Point(4, 5)
        Me.C3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C3_Verschiebung.Name = "C3_Verschiebung"
        Me.C3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.C3_Verschiebung.TabIndex = 19
        Me.C3_Verschiebung.Text = "0"
        Me.C3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Verschiebung
        '
        Me.D3_Verschiebung.Location = New System.Drawing.Point(49, 5)
        Me.D3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D3_Verschiebung.Name = "D3_Verschiebung"
        Me.D3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.D3_Verschiebung.TabIndex = 20
        Me.D3_Verschiebung.Text = "0"
        Me.D3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Verschiebung
        '
        Me.E3_Verschiebung.Location = New System.Drawing.Point(94, 5)
        Me.E3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E3_Verschiebung.Name = "E3_Verschiebung"
        Me.E3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.E3_Verschiebung.TabIndex = 21
        Me.E3_Verschiebung.Text = "0"
        Me.E3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Verschiebung
        '
        Me.F3_Verschiebung.Location = New System.Drawing.Point(139, 5)
        Me.F3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F3_Verschiebung.Name = "F3_Verschiebung"
        Me.F3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.F3_Verschiebung.TabIndex = 22
        Me.F3_Verschiebung.Text = "0"
        Me.F3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Verschiebung
        '
        Me.G3_Verschiebung.Location = New System.Drawing.Point(184, 5)
        Me.G3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G3_Verschiebung.Name = "G3_Verschiebung"
        Me.G3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.G3_Verschiebung.TabIndex = 23
        Me.G3_Verschiebung.Text = "0"
        Me.G3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Verschiebung
        '
        Me.A3_Verschiebung.Location = New System.Drawing.Point(229, 5)
        Me.A3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A3_Verschiebung.Name = "A3_Verschiebung"
        Me.A3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.A3_Verschiebung.TabIndex = 24
        Me.A3_Verschiebung.Text = "0"
        Me.A3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Verschiebung
        '
        Me.H3_Verschiebung.Location = New System.Drawing.Point(274, 5)
        Me.H3_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H3_Verschiebung.Name = "H3_Verschiebung"
        Me.H3_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.H3_Verschiebung.TabIndex = 25
        Me.H3_Verschiebung.Text = "0"
        Me.H3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.C4_Verschiebung)
        Me.FlowLayoutPanel9.Controls.Add(Me.D4_Verschiebung)
        Me.FlowLayoutPanel9.Controls.Add(Me.E4_Verschiebung)
        Me.FlowLayoutPanel9.Controls.Add(Me.F4_Verschiebung)
        Me.FlowLayoutPanel9.Controls.Add(Me.G4_Verschiebung)
        Me.FlowLayoutPanel9.Controls.Add(Me.A4_Verschiebung)
        Me.FlowLayoutPanel9.Controls.Add(Me.H4_Verschiebung)
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(718, 26)
        Me.FlowLayoutPanel9.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(346, 42)
        Me.FlowLayoutPanel9.TabIndex = 171
        '
        'C4_Verschiebung
        '
        Me.C4_Verschiebung.Location = New System.Drawing.Point(4, 5)
        Me.C4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C4_Verschiebung.Name = "C4_Verschiebung"
        Me.C4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.C4_Verschiebung.TabIndex = 19
        Me.C4_Verschiebung.Text = "0"
        Me.C4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Verschiebung
        '
        Me.D4_Verschiebung.Location = New System.Drawing.Point(49, 5)
        Me.D4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.D4_Verschiebung.Name = "D4_Verschiebung"
        Me.D4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.D4_Verschiebung.TabIndex = 20
        Me.D4_Verschiebung.Text = "0"
        Me.D4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Verschiebung
        '
        Me.E4_Verschiebung.Location = New System.Drawing.Point(94, 5)
        Me.E4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E4_Verschiebung.Name = "E4_Verschiebung"
        Me.E4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.E4_Verschiebung.TabIndex = 21
        Me.E4_Verschiebung.Text = "0"
        Me.E4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Verschiebung
        '
        Me.F4_Verschiebung.Location = New System.Drawing.Point(139, 5)
        Me.F4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.F4_Verschiebung.Name = "F4_Verschiebung"
        Me.F4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.F4_Verschiebung.TabIndex = 22
        Me.F4_Verschiebung.Text = "0"
        Me.F4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Verschiebung
        '
        Me.G4_Verschiebung.Location = New System.Drawing.Point(184, 5)
        Me.G4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.G4_Verschiebung.Name = "G4_Verschiebung"
        Me.G4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.G4_Verschiebung.TabIndex = 23
        Me.G4_Verschiebung.Text = "0"
        Me.G4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Verschiebung
        '
        Me.A4_Verschiebung.Location = New System.Drawing.Point(229, 5)
        Me.A4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A4_Verschiebung.Name = "A4_Verschiebung"
        Me.A4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.A4_Verschiebung.TabIndex = 24
        Me.A4_Verschiebung.Text = "0"
        Me.A4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Verschiebung
        '
        Me.H4_Verschiebung.Location = New System.Drawing.Point(274, 5)
        Me.H4_Verschiebung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.H4_Verschiebung.Name = "H4_Verschiebung"
        Me.H4_Verschiebung.Size = New System.Drawing.Size(37, 26)
        Me.H4_Verschiebung.TabIndex = 25
        Me.H4_Verschiebung.Text = "0"
        Me.H4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DirectPlay_YesNo_GroupBox
        '
        Me.DirectPlay_YesNo_GroupBox.Controls.Add(Me.DirectPlay_OFF)
        Me.DirectPlay_YesNo_GroupBox.Controls.Add(Me.DirectPlay_ON)
        Me.DirectPlay_YesNo_GroupBox.Location = New System.Drawing.Point(15, 25)
        Me.DirectPlay_YesNo_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_YesNo_GroupBox.Name = "DirectPlay_YesNo_GroupBox"
        Me.DirectPlay_YesNo_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_YesNo_GroupBox.Size = New System.Drawing.Size(298, 86)
        Me.DirectPlay_YesNo_GroupBox.TabIndex = 163
        Me.DirectPlay_YesNo_GroupBox.TabStop = False
        Me.DirectPlay_YesNo_GroupBox.Text = "Empfangende Noten abspielen"
        Me.ToolTip1.SetToolTip(Me.DirectPlay_YesNo_GroupBox, "Sollen empfangene MIDI Sygnale per winmm.dll ins" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Betriebssystem gesendet werden?" &
        " Genauere Infor-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mationen unter den emntsprechenden Punkten.")
        '
        'About_Button
        '
        Me.About_Button.Location = New System.Drawing.Point(38, 228)
        Me.About_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.About_Button.Name = "About_Button"
        Me.About_Button.Size = New System.Drawing.Size(302, 66)
        Me.About_Button.TabIndex = 2
        Me.About_Button.Text = "Über"
        Me.ToolTip1.SetToolTip(Me.About_Button, "Zeigt die wichtigsten Informationen wie Version, Lizenzstatus usw. ")
        Me.About_Button.UseVisualStyleBackColor = True
        '
        'Help_Button
        '
        Me.Help_Button.Location = New System.Drawing.Point(38, 140)
        Me.Help_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(302, 66)
        Me.Help_Button.TabIndex = 1
        Me.Help_Button.Text = "Hilfe"
        Me.ToolTip1.SetToolTip(Me.Help_Button, "Öffnet die Hilfsfunktion.")
        Me.Help_Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Anz_Messungen_TextBox)
        Me.GroupBox3.Controls.Add(Me.Anz_Verbindungsfehler_TextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 632)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(298, 69)
        Me.GroupBox3.TabIndex = 182
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Anz.Messungen + Verbindungsfehler"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, resources.GetString("GroupBox3.ToolTip"))
        '
        'Anz_Messungen_TextBox
        '
        Me.Anz_Messungen_TextBox.Enabled = False
        Me.Anz_Messungen_TextBox.Location = New System.Drawing.Point(18, 31)
        Me.Anz_Messungen_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Anz_Messungen_TextBox.Name = "Anz_Messungen_TextBox"
        Me.Anz_Messungen_TextBox.ReadOnly = True
        Me.Anz_Messungen_TextBox.Size = New System.Drawing.Size(124, 26)
        Me.Anz_Messungen_TextBox.TabIndex = 0
        Me.Anz_Messungen_TextBox.Text = "0"
        Me.Anz_Messungen_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Anz_Verbindungsfehler_TextBox
        '
        Me.Anz_Verbindungsfehler_TextBox.Enabled = False
        Me.Anz_Verbindungsfehler_TextBox.Location = New System.Drawing.Point(153, 31)
        Me.Anz_Verbindungsfehler_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Anz_Verbindungsfehler_TextBox.Name = "Anz_Verbindungsfehler_TextBox"
        Me.Anz_Verbindungsfehler_TextBox.ReadOnly = True
        Me.Anz_Verbindungsfehler_TextBox.Size = New System.Drawing.Size(134, 26)
        Me.Anz_Verbindungsfehler_TextBox.TabIndex = 187
        Me.Anz_Verbindungsfehler_TextBox.Text = "0"
        Me.Anz_Verbindungsfehler_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tackt_Ausgabefenster
        '
        Me.Tackt_Ausgabefenster.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Tackt_Ausgabefenster.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tackt_Ausgabefenster.ForeColor = System.Drawing.Color.Black
        Me.Tackt_Ausgabefenster.Location = New System.Drawing.Point(9, 38)
        Me.Tackt_Ausgabefenster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Tackt_Ausgabefenster.Name = "Tackt_Ausgabefenster"
        Me.Tackt_Ausgabefenster.Padding = New System.Windows.Forms.Padding(38, 8, 30, 15)
        Me.Tackt_Ausgabefenster.Size = New System.Drawing.Size(423, 155)
        Me.Tackt_Ausgabefenster.TabIndex = 1
        Me.Tackt_Ausgabefenster.Text = "1  1"
        Me.Tackt_Ausgabefenster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Tackt_Ausgabefenster, "In diesem bereich wird der Momentane Tackt ausgegeben. Diese angaben machen eigen" &
        "dlich nur bei m Aufnahmemodus ""Standart MIDI"" wirklich einen Sinn.")
        '
        'Com_Search_Timer
        '
        Me.Com_Search_Timer.Enabled = True
        Me.Com_Search_Timer.Interval = 2000
        '
        'C_Klappe
        '
        Me.C_Klappe.Location = New System.Drawing.Point(3, 3)
        Me.C_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.C_Klappe.Maximum = 1
        Me.C_Klappe.Minimum = -1
        Me.C_Klappe.Name = "C_Klappe"
        Me.C_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.C_Klappe.Size = New System.Drawing.Size(69, 73)
        Me.C_Klappe.TabIndex = 183
        Me.C_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Serial_BackgroundWorker
        '
        Me.Serial_BackgroundWorker.WorkerSupportsCancellation = True
        '
        'Mesgeschwindigkeitsberechnung_Timer
        '
        Me.Mesgeschwindigkeitsberechnung_Timer.Interval = 250
        '
        'GetAsyncKeyState_Timer
        '
        Me.GetAsyncKeyState_Timer.Enabled = True
        Me.GetAsyncKeyState_Timer.Interval = 20
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SendKeys_GroupBox)
        Me.Panel1.Controls.Add(Me.Tastenkonbinationen_GroupBox)
        Me.Panel1.Controls.Add(Me.SendKey_GroupBox)
        Me.Panel1.Controls.Add(Me.DirectPlay_GroupBox)
        Me.Panel1.Controls.Add(Me.Programmeinstellungen_GroupBox)
        Me.Panel1.Controls.Add(Me.Klappen_GroupBox)
        Me.Panel1.Controls.Add(Me.META_Tags_GroupBox)
        Me.Panel1.Controls.Add(Me.MIDI_Visualisierung_GroupBox)
        Me.Panel1.Controls.Add(Me.Einstellungen_GroupBox)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Connect_GroupBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1910, 1185)
        Me.Panel1.TabIndex = 0
        '
        'DirectPlay_GroupBox
        '
        Me.DirectPlay_GroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.DirectPlay_GroupBox.Controls.Add(Me.DirectPlay_Einstellungen_GroupBox)
        Me.DirectPlay_GroupBox.Controls.Add(Me.DirectPlay_YesNo_GroupBox)
        Me.DirectPlay_GroupBox.Location = New System.Drawing.Point(1149, 17)
        Me.DirectPlay_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_GroupBox.Name = "DirectPlay_GroupBox"
        Me.DirectPlay_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_GroupBox.Size = New System.Drawing.Size(332, 311)
        Me.DirectPlay_GroupBox.TabIndex = 193
        Me.DirectPlay_GroupBox.TabStop = False
        Me.DirectPlay_GroupBox.Text = "Direct Play"
        '
        'DirectPlay_Einstellungen_GroupBox
        '
        Me.DirectPlay_Einstellungen_GroupBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DirectPlay_Einstellungen_GroupBox.Controls.Add(Me.Label11)
        Me.DirectPlay_Einstellungen_GroupBox.Controls.Add(Me.Label15)
        Me.DirectPlay_Einstellungen_GroupBox.Controls.Add(Me.hsbVolume)
        Me.DirectPlay_Einstellungen_GroupBox.Controls.Add(Me.Label14)
        Me.DirectPlay_Einstellungen_GroupBox.Controls.Add(Me.hsbPan)
        Me.DirectPlay_Einstellungen_GroupBox.Controls.Add(Me.hsbModWheel)
        Me.DirectPlay_Einstellungen_GroupBox.Location = New System.Drawing.Point(15, 128)
        Me.DirectPlay_Einstellungen_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_Einstellungen_GroupBox.Name = "DirectPlay_Einstellungen_GroupBox"
        Me.DirectPlay_Einstellungen_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DirectPlay_Einstellungen_GroupBox.Size = New System.Drawing.Size(300, 168)
        Me.DirectPlay_Einstellungen_GroupBox.TabIndex = 174
        Me.DirectPlay_Einstellungen_GroupBox.TabStop = False
        Me.DirectPlay_Einstellungen_GroupBox.Text = "Einstellungen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 40)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Volume:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 125)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Efeckt:"
        '
        'hsbVolume
        '
        Me.hsbVolume.Location = New System.Drawing.Point(108, 34)
        Me.hsbVolume.Maximum = 127
        Me.hsbVolume.Name = "hsbVolume"
        Me.hsbVolume.Size = New System.Drawing.Size(172, 17)
        Me.hsbVolume.TabIndex = 6
        Me.hsbVolume.Value = 127
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 85)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 20)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Balance:"
        '
        'hsbPan
        '
        Me.hsbPan.Location = New System.Drawing.Point(108, 78)
        Me.hsbPan.Name = "hsbPan"
        Me.hsbPan.Size = New System.Drawing.Size(172, 17)
        Me.hsbPan.TabIndex = 172
        Me.hsbPan.Value = 50
        '
        'hsbModWheel
        '
        Me.hsbModWheel.Location = New System.Drawing.Point(111, 123)
        Me.hsbModWheel.Maximum = 255
        Me.hsbModWheel.Name = "hsbModWheel"
        Me.hsbModWheel.Size = New System.Drawing.Size(172, 17)
        Me.hsbModWheel.TabIndex = 172
        '
        'Programmeinstellungen_GroupBox
        '
        Me.Programmeinstellungen_GroupBox.Controls.Add(Me.About_Button)
        Me.Programmeinstellungen_GroupBox.Controls.Add(Me.Help_Button)
        Me.Programmeinstellungen_GroupBox.Controls.Add(Me.ToolTip_YesNo_GroupBox)
        Me.Programmeinstellungen_GroupBox.Location = New System.Drawing.Point(1509, 17)
        Me.Programmeinstellungen_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Programmeinstellungen_GroupBox.Name = "Programmeinstellungen_GroupBox"
        Me.Programmeinstellungen_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Programmeinstellungen_GroupBox.Size = New System.Drawing.Size(382, 311)
        Me.Programmeinstellungen_GroupBox.TabIndex = 196
        Me.Programmeinstellungen_GroupBox.TabStop = False
        Me.Programmeinstellungen_GroupBox.Text = "Programmeinstellungen"
        '
        'Klappen_GroupBox
        '
        Me.Klappen_GroupBox.Controls.Add(Me.FlowLayoutPanel6)
        Me.Klappen_GroupBox.Location = New System.Drawing.Point(1146, 529)
        Me.Klappen_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Klappen_GroupBox.Name = "Klappen_GroupBox"
        Me.Klappen_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Klappen_GroupBox.Size = New System.Drawing.Size(746, 202)
        Me.Klappen_GroupBox.TabIndex = 195
        Me.Klappen_GroupBox.TabStop = False
        Me.Klappen_GroupBox.Text = "Tonart (Klappen)"
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.C1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.D1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.E1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.F1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.G1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.A1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.H1_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.C2_Klappe)
        Me.FlowLayoutPanel6.Controls.Add(Me.C1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.D1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.E1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.F1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.G1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.A1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.H1_Klappe_Text)
        Me.FlowLayoutPanel6.Controls.Add(Me.C2_Klappe_Text)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(18, 34)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(718, 155)
        Me.FlowLayoutPanel6.TabIndex = 0
        '
        'C1_Klappe
        '
        Me.C1_Klappe.Location = New System.Drawing.Point(10, 2)
        Me.C1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.C1_Klappe.Maximum = 1
        Me.C1_Klappe.Minimum = -1
        Me.C1_Klappe.Name = "C1_Klappe"
        Me.C1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.C1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.C1_Klappe.TabIndex = 183
        Me.C1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'D1_Klappe
        '
        Me.D1_Klappe.Location = New System.Drawing.Point(99, 2)
        Me.D1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.D1_Klappe.Maximum = 1
        Me.D1_Klappe.Minimum = -1
        Me.D1_Klappe.Name = "D1_Klappe"
        Me.D1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.D1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.D1_Klappe.TabIndex = 184
        Me.D1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'E1_Klappe
        '
        Me.E1_Klappe.Location = New System.Drawing.Point(188, 2)
        Me.E1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.E1_Klappe.Maximum = 1
        Me.E1_Klappe.Minimum = -1
        Me.E1_Klappe.Name = "E1_Klappe"
        Me.E1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.E1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.E1_Klappe.TabIndex = 185
        Me.E1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'F1_Klappe
        '
        Me.F1_Klappe.Location = New System.Drawing.Point(277, 2)
        Me.F1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.F1_Klappe.Maximum = 1
        Me.F1_Klappe.Minimum = -1
        Me.F1_Klappe.Name = "F1_Klappe"
        Me.F1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.F1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.F1_Klappe.TabIndex = 186
        Me.F1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'G1_Klappe
        '
        Me.G1_Klappe.Location = New System.Drawing.Point(366, 2)
        Me.G1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.G1_Klappe.Maximum = 1
        Me.G1_Klappe.Minimum = -1
        Me.G1_Klappe.Name = "G1_Klappe"
        Me.G1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.G1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.G1_Klappe.TabIndex = 187
        Me.G1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'A1_Klappe
        '
        Me.A1_Klappe.Location = New System.Drawing.Point(455, 2)
        Me.A1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.A1_Klappe.Maximum = 1
        Me.A1_Klappe.Minimum = -1
        Me.A1_Klappe.Name = "A1_Klappe"
        Me.A1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.A1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.A1_Klappe.TabIndex = 188
        Me.A1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'H1_Klappe
        '
        Me.H1_Klappe.Location = New System.Drawing.Point(544, 2)
        Me.H1_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.H1_Klappe.Maximum = 1
        Me.H1_Klappe.Minimum = -1
        Me.H1_Klappe.Name = "H1_Klappe"
        Me.H1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.H1_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.H1_Klappe.TabIndex = 189
        Me.H1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'C2_Klappe
        '
        Me.C2_Klappe.Location = New System.Drawing.Point(633, 2)
        Me.C2_Klappe.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.C2_Klappe.Maximum = 1
        Me.C2_Klappe.Minimum = -1
        Me.C2_Klappe.Name = "C2_Klappe"
        Me.C2_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.C2_Klappe.Size = New System.Drawing.Size(69, 112)
        Me.C2_Klappe.TabIndex = 197
        Me.C2_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'C1_Klappe_Text
        '
        Me.C1_Klappe_Text.Location = New System.Drawing.Point(10, 118)
        Me.C1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.C1_Klappe_Text.Name = "C1_Klappe_Text"
        Me.C1_Klappe_Text.ReadOnly = True
        Me.C1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.C1_Klappe_Text.TabIndex = 190
        Me.C1_Klappe_Text.Text = "c"
        Me.C1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D1_Klappe_Text
        '
        Me.D1_Klappe_Text.Location = New System.Drawing.Point(96, 118)
        Me.D1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.D1_Klappe_Text.Name = "D1_Klappe_Text"
        Me.D1_Klappe_Text.ReadOnly = True
        Me.D1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.D1_Klappe_Text.TabIndex = 198
        Me.D1_Klappe_Text.Text = "d"
        Me.D1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E1_Klappe_Text
        '
        Me.E1_Klappe_Text.Location = New System.Drawing.Point(182, 118)
        Me.E1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.E1_Klappe_Text.Name = "E1_Klappe_Text"
        Me.E1_Klappe_Text.ReadOnly = True
        Me.E1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.E1_Klappe_Text.TabIndex = 199
        Me.E1_Klappe_Text.Text = "e"
        Me.E1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F1_Klappe_Text
        '
        Me.F1_Klappe_Text.Location = New System.Drawing.Point(268, 118)
        Me.F1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.F1_Klappe_Text.Name = "F1_Klappe_Text"
        Me.F1_Klappe_Text.ReadOnly = True
        Me.F1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.F1_Klappe_Text.TabIndex = 200
        Me.F1_Klappe_Text.Text = "f"
        Me.F1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G1_Klappe_Text
        '
        Me.G1_Klappe_Text.Location = New System.Drawing.Point(354, 118)
        Me.G1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.G1_Klappe_Text.Name = "G1_Klappe_Text"
        Me.G1_Klappe_Text.ReadOnly = True
        Me.G1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.G1_Klappe_Text.TabIndex = 201
        Me.G1_Klappe_Text.Text = "g"
        Me.G1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A1_Klappe_Text
        '
        Me.A1_Klappe_Text.Location = New System.Drawing.Point(440, 118)
        Me.A1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.A1_Klappe_Text.Name = "A1_Klappe_Text"
        Me.A1_Klappe_Text.ReadOnly = True
        Me.A1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.A1_Klappe_Text.TabIndex = 202
        Me.A1_Klappe_Text.Text = "a"
        Me.A1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H1_Klappe_Text
        '
        Me.H1_Klappe_Text.Location = New System.Drawing.Point(526, 118)
        Me.H1_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.H1_Klappe_Text.Name = "H1_Klappe_Text"
        Me.H1_Klappe_Text.ReadOnly = True
        Me.H1_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.H1_Klappe_Text.TabIndex = 203
        Me.H1_Klappe_Text.Text = "h"
        Me.H1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C2_Klappe_Text
        '
        Me.C2_Klappe_Text.Location = New System.Drawing.Point(612, 118)
        Me.C2_Klappe_Text.Margin = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.C2_Klappe_Text.Name = "C2_Klappe_Text"
        Me.C2_Klappe_Text.ReadOnly = True
        Me.C2_Klappe_Text.Size = New System.Drawing.Size(66, 26)
        Me.C2_Klappe_Text.TabIndex = 204
        Me.C2_Klappe_Text.Text = "c"
        Me.C2_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Einstellungen_GroupBox
        '
        Me.Einstellungen_GroupBox.Controls.Add(Me.Instrumentenauswahl_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox3)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Messintervall_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.MIDI_Aufnahmemodus_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Metronom_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Tempo_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Transpose_GroupBox)
        Me.Einstellungen_GroupBox.Location = New System.Drawing.Point(474, 17)
        Me.Einstellungen_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Einstellungen_GroupBox.Name = "Einstellungen_GroupBox"
        Me.Einstellungen_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Einstellungen_GroupBox.Size = New System.Drawing.Size(326, 714)
        Me.Einstellungen_GroupBox.TabIndex = 191
        Me.Einstellungen_GroupBox.TabStop = False
        Me.Einstellungen_GroupBox.Text = "Einstellungen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MIDI_Pause_Button)
        Me.GroupBox2.Controls.Add(Me.Tackt_Ausgabefenster)
        Me.GroupBox2.Controls.Add(Me.MIDI_Start_Button)
        Me.GroupBox2.Controls.Add(Me.MIDI_Save_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 114)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(441, 526)
        Me.GroupBox2.TabIndex = 189
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausgabe"
        '
        'Display_Refresh_Timer
        '
        Me.Display_Refresh_Timer.Interval = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1911, 1038)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIDI Harfe V1.2.7 Beta - Nico Bosshard"
        Me.Tastenkonbinationen_GroupBox.ResumeLayout(False)
        Me.Tastenkonbinationen_GroupBox.PerformLayout()
        CType(Me.Tastenkonbinationen_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTip_YesNo_GroupBox.ResumeLayout(False)
        Me.ToolTip_YesNo_GroupBox.PerformLayout()
        Me.META_Tags_GroupBox.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.Bemerkung_GroupBox.ResumeLayout(False)
        Me.Bemerkung_GroupBox.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Metronom_GroupBox.ResumeLayout(False)
        Me.Metronom_GroupBox.PerformLayout()
        Me.Transpose_GroupBox.ResumeLayout(False)
        Me.Transpose_GroupBox.PerformLayout()
        CType(Me.Halbtonverschiebung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Connect_GroupBox.ResumeLayout(False)
        Me.Messintervall_GroupBox.ResumeLayout(False)
        Me.Messintervall_GroupBox.PerformLayout()
        Me.Tempo_GroupBox.ResumeLayout(False)
        Me.Tempo_GroupBox.PerformLayout()
        CType(Me.Tackt_Naenner_Input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tackt_Zaehler_Input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SendKey_GroupBox.ResumeLayout(False)
        Me.SendKey_GroupBox.PerformLayout()
        Me.SendKeys_GroupBox.ResumeLayout(False)
        Me.SendKeys_GroupBox.PerformLayout()
        Me.Instrumentenauswahl_GroupBox.ResumeLayout(False)
        Me.MIDI_Aufnahmemodus_GroupBox.ResumeLayout(False)
        Me.MIDI_Aufnahmemodus_GroupBox.PerformLayout()
        CType(Me.Volume_max_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Volume_min_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Volume_Steps_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MIDI_Visualisierung_GroupBox.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.FlowLayoutPanel11.ResumeLayout(False)
        Me.FlowLayoutPanel11.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel10.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.FlowLayoutPanel9.PerformLayout()
        Me.DirectPlay_YesNo_GroupBox.ResumeLayout(False)
        Me.DirectPlay_YesNo_GroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.C_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.DirectPlay_GroupBox.ResumeLayout(False)
        Me.DirectPlay_Einstellungen_GroupBox.ResumeLayout(False)
        Me.DirectPlay_Einstellungen_GroupBox.PerformLayout()
        Me.Programmeinstellungen_GroupBox.ResumeLayout(False)
        Me.Klappen_GroupBox.ResumeLayout(False)
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        CType(Me.C1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.H1_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Einstellungen_GroupBox.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Public WithEvents SaveMIDIDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Tackt As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Com_Search_Timer As System.Windows.Forms.Timer
    Friend WithEvents C_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents Serial_BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Mesgeschwindigkeitsberechnung_Timer As System.Windows.Forms.Timer
    Friend WithEvents GetAsyncKeyState_Timer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tastenkonbinationen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Save_Tastenkombination As System.Windows.Forms.Button
    Friend WithEvents Pause_Tastenkombination As System.Windows.Forms.Button
    Friend WithEvents Start_Tastenkombination As System.Windows.Forms.Button
    Friend WithEvents SendKey_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Save_Label As System.Windows.Forms.Label
    Friend WithEvents Pause_Label As System.Windows.Forms.Label
    Friend WithEvents Start_Label As System.Windows.Forms.Label
    Friend WithEvents DirectPlay_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DirectPlay_Einstellungen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents hsbVolume As System.Windows.Forms.HScrollBar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents hsbPan As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbModWheel As System.Windows.Forms.HScrollBar
    Friend WithEvents Programmeinstellungen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents About_Button As System.Windows.Forms.Button
    Friend WithEvents Help_Button As System.Windows.Forms.Button
    Friend WithEvents ToolTip_YesNo_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip_ON As System.Windows.Forms.RadioButton
    Friend WithEvents Klappen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents D1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents E1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents F1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents G1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents A1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents H1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents C2_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents C1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents D1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents E1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents F1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents G1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents A1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents H1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents C2_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents META_Tags_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Autor_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Spurnamen_Input As System.Windows.Forms.TextBox
    Friend WithEvents Bemerkung_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents META_Bemerkung_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Dateinamen_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Copyright_Input As System.Windows.Forms.TextBox
    Friend WithEvents MIDI_Visualisierung_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel11 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents D6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents E6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents F6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents G6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents A6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents H6_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel10 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents D5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents E5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents F5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents G5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents A5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents H5_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel9 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents D4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents E4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents F4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents G4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents A4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents H4_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel8 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents D3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents E3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents F3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents G3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents A3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents H3_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel7 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents D2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents E2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents F2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents G2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents A2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents H2_Verschiebung As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents C2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents C2_Button As System.Windows.Forms.Button
    Friend WithEvents D2_Button As System.Windows.Forms.Button
    Friend WithEvents E2_Button As System.Windows.Forms.Button
    Friend WithEvents F2_Button As System.Windows.Forms.Button
    Friend WithEvents G2_Button As System.Windows.Forms.Button
    Friend WithEvents A2_Button As System.Windows.Forms.Button
    Friend WithEvents H2_Button As System.Windows.Forms.Button
    Friend WithEvents C2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents D2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents E2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents F2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents G2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents A2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents H2_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents C3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents C3_Button As System.Windows.Forms.Button
    Friend WithEvents D3_Button As System.Windows.Forms.Button
    Friend WithEvents E3_Button As System.Windows.Forms.Button
    Friend WithEvents F3_Button As System.Windows.Forms.Button
    Friend WithEvents G3_Button As System.Windows.Forms.Button
    Friend WithEvents A3_Button As System.Windows.Forms.Button
    Friend WithEvents H3_Button As System.Windows.Forms.Button
    Friend WithEvents C3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents D3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents E3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents F3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents G3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents A3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents H3_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents C4_Button As System.Windows.Forms.Button
    Friend WithEvents D4_Button As System.Windows.Forms.Button
    Friend WithEvents E4_Button As System.Windows.Forms.Button
    Friend WithEvents F4_Button As System.Windows.Forms.Button
    Friend WithEvents G4_Button As System.Windows.Forms.Button
    Friend WithEvents A4_Button As System.Windows.Forms.Button
    Friend WithEvents H4_Button As System.Windows.Forms.Button
    Friend WithEvents C4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents D4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents E4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents F4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents G4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents A4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents H4_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents C5_Button As System.Windows.Forms.Button
    Friend WithEvents D5_Button As System.Windows.Forms.Button
    Friend WithEvents E5_Button As System.Windows.Forms.Button
    Friend WithEvents F5_Button As System.Windows.Forms.Button
    Friend WithEvents G5_Button As System.Windows.Forms.Button
    Friend WithEvents A5_Button As System.Windows.Forms.Button
    Friend WithEvents H5_Button As System.Windows.Forms.Button
    Friend WithEvents C5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents D5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents E5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents F5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents G5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents A5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents H5_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents C6_Button As System.Windows.Forms.Button
    Friend WithEvents D6_Button As System.Windows.Forms.Button
    Friend WithEvents E6_Button As System.Windows.Forms.Button
    Friend WithEvents F6_Button As System.Windows.Forms.Button
    Friend WithEvents G6_Button As System.Windows.Forms.Button
    Friend WithEvents A6_Button As System.Windows.Forms.Button
    Friend WithEvents H6_Button As System.Windows.Forms.Button
    Friend WithEvents C6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents D6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents E6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents F6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents G6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents A6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents H6_Startwert As System.Windows.Forms.TextBox
    Friend WithEvents Einstellungen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Anz_Messungen_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Anz_Verbindungsfehler_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Messintervall_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Messintervall_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MessungenProS_TexBox As System.Windows.Forms.TextBox
    Friend WithEvents Messintervall_Label As System.Windows.Forms.Label
    Friend WithEvents MIDI_Aufnahmemodus_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MIDI_SpecialMode As System.Windows.Forms.RadioButton
    Friend WithEvents MIDI_NormalMode As System.Windows.Forms.RadioButton
    Friend WithEvents cboInstruments As System.Windows.Forms.ComboBox
    Friend WithEvents Metronom_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Metronom_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents Metronom_ON As System.Windows.Forms.RadioButton
    Friend WithEvents Metronom_Betont As System.Windows.Forms.RadioButton
    Friend WithEvents Tempo_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Tackt_Naenner_Input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Tackt_Zaehler_Input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BPM_Label As System.Windows.Forms.Label
    Friend WithEvents BPM As System.Windows.Forms.NumericUpDown
    Friend WithEvents Transpose_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Halbtonverschiebung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Oktavenverschiebung As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MIDI_Pause_Button As System.Windows.Forms.Button
    Friend WithEvents MIDI_Start_Button As System.Windows.Forms.Button
    Friend WithEvents MIDI_Save_Button As System.Windows.Forms.Button
    Friend WithEvents Connect_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_Comport As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Disconnect As System.Windows.Forms.Button
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents DirectPlay_YesNo_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DirectPlay_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents Instrumentenauswahl_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Tastenkonbinationen_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Aktion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Konbination As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectPlay_ON As System.Windows.Forms.RadioButton
    Friend WithEvents Tackt_Ausgabefenster As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SendKey_OP As System.Windows.Forms.Button
    Friend WithEvents SendKey_a As System.Windows.Forms.Button
    Friend WithEvents SendKey_e As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SendKey_h As System.Windows.Forms.Button
    Friend WithEvents SendKey_f As System.Windows.Forms.Button
    Friend WithEvents SendKey_c As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SendKey_OM As System.Windows.Forms.Button
    Friend WithEvents SendKey_g As System.Windows.Forms.Button
    Friend WithEvents SendKey_d As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SendKey_gis As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents SendKey_ais As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SendKey_fis As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SendKey_cis As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SendKey_dis As System.Windows.Forms.Button
    Friend WithEvents SendKeys_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SendKeys_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents SendKeys_ON As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents C6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents D6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents E6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents F6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents G6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents A6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents H6_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents C2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents D2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents E2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents F2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents G2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents A2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents H2_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents C3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents D3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents E3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents F3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents G3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents A3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents H3_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents C5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents D5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents E5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents F5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents G5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents A5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents H5_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents C4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents D4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents E4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents F4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents G4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents A4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents H4_Stopwert As System.Windows.Forms.TextBox
    Friend WithEvents Display_Refresh_Timer As System.Windows.Forms.Timer
    Friend WithEvents Volume_Steps_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Volume_max_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Volume_min_NumericUpDown As System.Windows.Forms.NumericUpDown

End Class
