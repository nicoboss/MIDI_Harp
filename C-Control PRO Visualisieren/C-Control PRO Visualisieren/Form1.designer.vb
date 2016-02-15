<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Comport = New System.Windows.Forms.ComboBox()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MIDI_Pause_Button = New System.Windows.Forms.Button()
        Me.Tackt_Ausgabefenster = New System.Windows.Forms.Label()
        Me.MIDI_Start_Button = New System.Windows.Forms.Button()
        Me.MIDI_Save_Button = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.C2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.D2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.E2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.F2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.G2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.A2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.H2_Grenzwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.C3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.D3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.E3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.F3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.G3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.A3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.H3_Grenzwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.C4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.D4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.E4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.F4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.G4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.A4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.H4_Grenzwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.C5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.D5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.E5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.F5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.G5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.A5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.H5_Grenzwert = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.C6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.D6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.E6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.F6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.G6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.A6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.H6_Grenzwert = New System.Windows.Forms.TextBox()
        Me.SaveMIDIDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Einstellungen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AnzMessungen = New System.Windows.Forms.TextBox()
        Me.AnzMessfehler = New System.Windows.Forms.TextBox()
        Me.Messintervall_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Messintervall_TextBox = New System.Windows.Forms.TextBox()
        Me.MessungenProS_TexBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.MIDI_SpecialMode = New System.Windows.Forms.RadioButton()
        Me.MIDI_NormalMode = New System.Windows.Forms.RadioButton()
        Me.cboInstruments = New System.Windows.Forms.ComboBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Metronom_OFF = New System.Windows.Forms.RadioButton()
        Me.Metronom_ON = New System.Windows.Forms.RadioButton()
        Me.Metronom_Betont = New System.Windows.Forms.RadioButton()
        Me.Tempo_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Tackt_Naenner_Input = New System.Windows.Forms.NumericUpDown()
        Me.Tackt_Zaehler_Input = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BPM_Label = New System.Windows.Forms.Label()
        Me.BPM = New System.Windows.Forms.NumericUpDown()
        Me.Transpose_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Halbtonverschiebung = New System.Windows.Forms.NumericUpDown()
        Me.Oktavenverschiebung = New System.Windows.Forms.ComboBox()
        Me.Tackt = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H6_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H5_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H4_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H3_Verschiebung = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.C2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.D2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.E2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.F2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.G2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.A2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.H2_Verschiebung = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.META_Copyright_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.ToolTip_OFF = New System.Windows.Forms.RadioButton()
        Me.ToolTip_ON = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.META_Autor_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.META_Spurnamen_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.META_Bemerkung_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.META_Dateinamen_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Com_Search_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.hsbVolume = New System.Windows.Forms.HScrollBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.hsbPan = New System.Windows.Forms.HScrollBar()
        Me.hsbModWheel = New System.Windows.Forms.HScrollBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DirectPlay_OFF = New System.Windows.Forms.RadioButton()
        Me.DirectPlay_ON = New System.Windows.Forms.RadioButton()
        Me.C_Klappe = New System.Windows.Forms.TrackBar()
        Me.Serial_BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Mesgeschwindigkeitsberechnung_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Save_Tastenkombination = New System.Windows.Forms.Button()
        Me.Pause_Tastenkombination = New System.Windows.Forms.Button()
        Me.Start_Tastenkombination = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Save_Label = New System.Windows.Forms.Label()
        Me.Pause_Label = New System.Windows.Forms.Label()
        Me.Start_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.C2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H2_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H3_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H4_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H5_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.C6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.D6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.E6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.F6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.G6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.A6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.H6_VerticalProgessBar = New MIDI_Harfe.MTech010VerticalProgessBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.Einstellungen_GroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Messintervall_GroupBox.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Tempo_GroupBox.SuspendLayout()
        CType(Me.Tackt_Naenner_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tackt_Zaehler_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Transpose_GroupBox.SuspendLayout()
        CType(Me.Halbtonverschiebung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        CType(Me.C1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.H1_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.C_Klappe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Comport)
        Me.GroupBox1.Controls.Add(Me.Button_Disconnect)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comport - Einstellungen"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'ComboBox_Comport
        '
        Me.ComboBox_Comport.FormattingEnabled = True
        Me.ComboBox_Comport.Location = New System.Drawing.Point(210, 21)
        Me.ComboBox_Comport.Name = "ComboBox_Comport"
        Me.ComboBox_Comport.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_Comport.Sorted = True
        Me.ComboBox_Comport.TabIndex = 6
        '
        'Button_Disconnect
        '
        Me.Button_Disconnect.Location = New System.Drawing.Point(87, 19)
        Me.Button_Disconnect.Name = "Button_Disconnect"
        Me.Button_Disconnect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Disconnect.TabIndex = 5
        Me.Button_Disconnect.Text = "Trennen"
        Me.Button_Disconnect.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(6, 19)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connect.TabIndex = 4
        Me.Button_Connect.Text = "Verbinden"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 230400
        Me.SerialPort1.DtrEnable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MIDI_Pause_Button)
        Me.GroupBox2.Controls.Add(Me.Tackt_Ausgabefenster)
        Me.GroupBox2.Controls.Add(Me.MIDI_Start_Button)
        Me.GroupBox2.Controls.Add(Me.MIDI_Save_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 391)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausgabe"
        '
        'MIDI_Pause_Button
        '
        Me.MIDI_Pause_Button.Enabled = False
        Me.MIDI_Pause_Button.Location = New System.Drawing.Point(6, 213)
        Me.MIDI_Pause_Button.Name = "MIDI_Pause_Button"
        Me.MIDI_Pause_Button.Size = New System.Drawing.Size(288, 58)
        Me.MIDI_Pause_Button.TabIndex = 23
        Me.MIDI_Pause_Button.Text = "Aufnahme pausieren"
        Me.MIDI_Pause_Button.UseVisualStyleBackColor = True
        '
        'Tackt_Ausgabefenster
        '
        Me.Tackt_Ausgabefenster.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Tackt_Ausgabefenster.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tackt_Ausgabefenster.ForeColor = System.Drawing.Color.Black
        Me.Tackt_Ausgabefenster.Location = New System.Drawing.Point(6, 25)
        Me.Tackt_Ausgabefenster.Name = "Tackt_Ausgabefenster"
        Me.Tackt_Ausgabefenster.Padding = New System.Windows.Forms.Padding(25, 5, 20, 10)
        Me.Tackt_Ausgabefenster.Size = New System.Drawing.Size(288, 98)
        Me.Tackt_Ausgabefenster.TabIndex = 1
        Me.Tackt_Ausgabefenster.Text = "1  1"
        Me.Tackt_Ausgabefenster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MIDI_Start_Button
        '
        Me.MIDI_Start_Button.Location = New System.Drawing.Point(6, 141)
        Me.MIDI_Start_Button.Name = "MIDI_Start_Button"
        Me.MIDI_Start_Button.Size = New System.Drawing.Size(288, 60)
        Me.MIDI_Start_Button.TabIndex = 22
        Me.MIDI_Start_Button.Text = "Aufnahme starten"
        Me.MIDI_Start_Button.UseVisualStyleBackColor = True
        '
        'MIDI_Save_Button
        '
        Me.MIDI_Save_Button.Enabled = False
        Me.MIDI_Save_Button.Location = New System.Drawing.Point(6, 284)
        Me.MIDI_Save_Button.Name = "MIDI_Save_Button"
        Me.MIDI_Save_Button.Size = New System.Drawing.Size(288, 58)
        Me.MIDI_Save_Button.TabIndex = 11
        Me.MIDI_Save_Button.Text = "Aufnahme speichern"
        Me.MIDI_Save_Button.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.Controls.Add(Me.C2_Grenzwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.D2_Grenzwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.E2_Grenzwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.F2_Grenzwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.G2_Grenzwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.A2_Grenzwert)
        Me.FlowLayoutPanel1.Controls.Add(Me.H2_Grenzwert)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(228, 191)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'C2_Button
        '
        Me.C2_Button.Location = New System.Drawing.Point(3, 106)
        Me.C2_Button.Name = "C2_Button"
        Me.C2_Button.Size = New System.Drawing.Size(26, 23)
        Me.C2_Button.TabIndex = 172
        Me.C2_Button.Text = "C"
        Me.C2_Button.UseVisualStyleBackColor = True
        '
        'D2_Button
        '
        Me.D2_Button.Location = New System.Drawing.Point(35, 106)
        Me.D2_Button.Name = "D2_Button"
        Me.D2_Button.Size = New System.Drawing.Size(26, 23)
        Me.D2_Button.TabIndex = 173
        Me.D2_Button.Text = "D"
        Me.D2_Button.UseVisualStyleBackColor = True
        '
        'E2_Button
        '
        Me.E2_Button.Location = New System.Drawing.Point(67, 106)
        Me.E2_Button.Name = "E2_Button"
        Me.E2_Button.Size = New System.Drawing.Size(26, 23)
        Me.E2_Button.TabIndex = 174
        Me.E2_Button.Text = "E"
        Me.E2_Button.UseVisualStyleBackColor = True
        '
        'F2_Button
        '
        Me.F2_Button.Location = New System.Drawing.Point(99, 106)
        Me.F2_Button.Name = "F2_Button"
        Me.F2_Button.Size = New System.Drawing.Size(26, 23)
        Me.F2_Button.TabIndex = 175
        Me.F2_Button.Text = "F"
        Me.F2_Button.UseVisualStyleBackColor = True
        '
        'G2_Button
        '
        Me.G2_Button.Location = New System.Drawing.Point(131, 106)
        Me.G2_Button.Name = "G2_Button"
        Me.G2_Button.Size = New System.Drawing.Size(26, 23)
        Me.G2_Button.TabIndex = 176
        Me.G2_Button.Text = "G"
        Me.G2_Button.UseVisualStyleBackColor = True
        '
        'A2_Button
        '
        Me.A2_Button.Location = New System.Drawing.Point(163, 106)
        Me.A2_Button.Name = "A2_Button"
        Me.A2_Button.Size = New System.Drawing.Size(26, 23)
        Me.A2_Button.TabIndex = 177
        Me.A2_Button.Text = "A"
        Me.A2_Button.UseVisualStyleBackColor = True
        '
        'H2_Button
        '
        Me.H2_Button.Location = New System.Drawing.Point(195, 106)
        Me.H2_Button.Name = "H2_Button"
        Me.H2_Button.Size = New System.Drawing.Size(26, 23)
        Me.H2_Button.TabIndex = 178
        Me.H2_Button.Text = "H"
        Me.H2_Button.UseVisualStyleBackColor = True
        '
        'C2_Wert
        '
        Me.C2_Wert.Location = New System.Drawing.Point(3, 135)
        Me.C2_Wert.Name = "C2_Wert"
        Me.C2_Wert.ReadOnly = True
        Me.C2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.C2_Wert.TabIndex = 11
        Me.C2_Wert.Text = "0"
        Me.C2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Wert
        '
        Me.D2_Wert.Location = New System.Drawing.Point(35, 135)
        Me.D2_Wert.Name = "D2_Wert"
        Me.D2_Wert.ReadOnly = True
        Me.D2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.D2_Wert.TabIndex = 12
        Me.D2_Wert.Text = "0"
        Me.D2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Wert
        '
        Me.E2_Wert.Location = New System.Drawing.Point(67, 135)
        Me.E2_Wert.Name = "E2_Wert"
        Me.E2_Wert.ReadOnly = True
        Me.E2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.E2_Wert.TabIndex = 13
        Me.E2_Wert.Text = "0"
        Me.E2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Wert
        '
        Me.F2_Wert.Location = New System.Drawing.Point(99, 135)
        Me.F2_Wert.Name = "F2_Wert"
        Me.F2_Wert.ReadOnly = True
        Me.F2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.F2_Wert.TabIndex = 14
        Me.F2_Wert.Text = "0"
        Me.F2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Wert
        '
        Me.G2_Wert.Location = New System.Drawing.Point(131, 135)
        Me.G2_Wert.Name = "G2_Wert"
        Me.G2_Wert.ReadOnly = True
        Me.G2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.G2_Wert.TabIndex = 15
        Me.G2_Wert.Text = "0"
        Me.G2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Wert
        '
        Me.A2_Wert.Location = New System.Drawing.Point(163, 135)
        Me.A2_Wert.Name = "A2_Wert"
        Me.A2_Wert.ReadOnly = True
        Me.A2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.A2_Wert.TabIndex = 16
        Me.A2_Wert.Text = "0"
        Me.A2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Wert
        '
        Me.H2_Wert.Location = New System.Drawing.Point(195, 135)
        Me.H2_Wert.Name = "H2_Wert"
        Me.H2_Wert.ReadOnly = True
        Me.H2_Wert.Size = New System.Drawing.Size(26, 20)
        Me.H2_Wert.TabIndex = 17
        Me.H2_Wert.Text = "0"
        Me.H2_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C2_Grenzwert
        '
        Me.C2_Grenzwert.Location = New System.Drawing.Point(3, 161)
        Me.C2_Grenzwert.MaxLength = 3
        Me.C2_Grenzwert.Name = "C2_Grenzwert"
        Me.C2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.C2_Grenzwert.TabIndex = 18
        Me.C2_Grenzwert.Text = "200"
        Me.C2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Grenzwert
        '
        Me.D2_Grenzwert.Location = New System.Drawing.Point(35, 161)
        Me.D2_Grenzwert.MaxLength = 3
        Me.D2_Grenzwert.Name = "D2_Grenzwert"
        Me.D2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D2_Grenzwert.TabIndex = 19
        Me.D2_Grenzwert.Text = "200"
        Me.D2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Grenzwert
        '
        Me.E2_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E2_Grenzwert.MaxLength = 3
        Me.E2_Grenzwert.Name = "E2_Grenzwert"
        Me.E2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E2_Grenzwert.TabIndex = 20
        Me.E2_Grenzwert.Text = "200"
        Me.E2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Grenzwert
        '
        Me.F2_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F2_Grenzwert.MaxLength = 3
        Me.F2_Grenzwert.Name = "F2_Grenzwert"
        Me.F2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F2_Grenzwert.TabIndex = 21
        Me.F2_Grenzwert.Text = "200"
        Me.F2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Grenzwert
        '
        Me.G2_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G2_Grenzwert.MaxLength = 3
        Me.G2_Grenzwert.Name = "G2_Grenzwert"
        Me.G2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G2_Grenzwert.TabIndex = 22
        Me.G2_Grenzwert.Text = "200"
        Me.G2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Grenzwert
        '
        Me.A2_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A2_Grenzwert.MaxLength = 3
        Me.A2_Grenzwert.Name = "A2_Grenzwert"
        Me.A2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A2_Grenzwert.TabIndex = 23
        Me.A2_Grenzwert.Text = "200"
        Me.A2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Grenzwert
        '
        Me.H2_Grenzwert.Location = New System.Drawing.Point(195, 161)
        Me.H2_Grenzwert.MaxLength = 3
        Me.H2_Grenzwert.Name = "H2_Grenzwert"
        Me.H2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.H2_Grenzwert.TabIndex = 24
        Me.H2_Grenzwert.Text = "200"
        Me.H2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel2.Controls.Add(Me.C3_Grenzwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.D3_Grenzwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.E3_Grenzwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.F3_Grenzwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.G3_Grenzwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.A3_Grenzwert)
        Me.FlowLayoutPanel2.Controls.Add(Me.H3_Grenzwert)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(249, 24)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(230, 191)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'C3_Button
        '
        Me.C3_Button.Location = New System.Drawing.Point(3, 106)
        Me.C3_Button.Name = "C3_Button"
        Me.C3_Button.Size = New System.Drawing.Size(26, 23)
        Me.C3_Button.TabIndex = 179
        Me.C3_Button.Text = "c"
        Me.C3_Button.UseVisualStyleBackColor = True
        '
        'D3_Button
        '
        Me.D3_Button.Location = New System.Drawing.Point(35, 106)
        Me.D3_Button.Name = "D3_Button"
        Me.D3_Button.Size = New System.Drawing.Size(26, 23)
        Me.D3_Button.TabIndex = 180
        Me.D3_Button.Text = "d"
        Me.D3_Button.UseVisualStyleBackColor = True
        '
        'E3_Button
        '
        Me.E3_Button.Location = New System.Drawing.Point(67, 106)
        Me.E3_Button.Name = "E3_Button"
        Me.E3_Button.Size = New System.Drawing.Size(26, 23)
        Me.E3_Button.TabIndex = 181
        Me.E3_Button.Text = "e"
        Me.E3_Button.UseVisualStyleBackColor = True
        '
        'F3_Button
        '
        Me.F3_Button.Location = New System.Drawing.Point(99, 106)
        Me.F3_Button.Name = "F3_Button"
        Me.F3_Button.Size = New System.Drawing.Size(26, 23)
        Me.F3_Button.TabIndex = 182
        Me.F3_Button.Text = "f"
        Me.F3_Button.UseVisualStyleBackColor = True
        '
        'G3_Button
        '
        Me.G3_Button.Location = New System.Drawing.Point(131, 106)
        Me.G3_Button.Name = "G3_Button"
        Me.G3_Button.Size = New System.Drawing.Size(26, 23)
        Me.G3_Button.TabIndex = 183
        Me.G3_Button.Text = "g"
        Me.G3_Button.UseVisualStyleBackColor = True
        '
        'A3_Button
        '
        Me.A3_Button.Location = New System.Drawing.Point(163, 106)
        Me.A3_Button.Name = "A3_Button"
        Me.A3_Button.Size = New System.Drawing.Size(26, 23)
        Me.A3_Button.TabIndex = 184
        Me.A3_Button.Text = "a"
        Me.A3_Button.UseVisualStyleBackColor = True
        '
        'H3_Button
        '
        Me.H3_Button.Location = New System.Drawing.Point(195, 106)
        Me.H3_Button.Name = "H3_Button"
        Me.H3_Button.Size = New System.Drawing.Size(26, 23)
        Me.H3_Button.TabIndex = 185
        Me.H3_Button.Text = "h"
        Me.H3_Button.UseVisualStyleBackColor = True
        '
        'C3_Wert
        '
        Me.C3_Wert.Location = New System.Drawing.Point(3, 135)
        Me.C3_Wert.Name = "C3_Wert"
        Me.C3_Wert.ReadOnly = True
        Me.C3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.C3_Wert.TabIndex = 12
        Me.C3_Wert.Text = "0"
        Me.C3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Wert
        '
        Me.D3_Wert.Location = New System.Drawing.Point(35, 135)
        Me.D3_Wert.Name = "D3_Wert"
        Me.D3_Wert.ReadOnly = True
        Me.D3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.D3_Wert.TabIndex = 13
        Me.D3_Wert.Text = "0"
        Me.D3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Wert
        '
        Me.E3_Wert.Location = New System.Drawing.Point(67, 135)
        Me.E3_Wert.Name = "E3_Wert"
        Me.E3_Wert.ReadOnly = True
        Me.E3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.E3_Wert.TabIndex = 14
        Me.E3_Wert.Text = "0"
        Me.E3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Wert
        '
        Me.F3_Wert.Location = New System.Drawing.Point(99, 135)
        Me.F3_Wert.Name = "F3_Wert"
        Me.F3_Wert.ReadOnly = True
        Me.F3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.F3_Wert.TabIndex = 15
        Me.F3_Wert.Text = "0"
        Me.F3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Wert
        '
        Me.G3_Wert.Location = New System.Drawing.Point(131, 135)
        Me.G3_Wert.Name = "G3_Wert"
        Me.G3_Wert.ReadOnly = True
        Me.G3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.G3_Wert.TabIndex = 16
        Me.G3_Wert.Text = "0"
        Me.G3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Wert
        '
        Me.A3_Wert.Location = New System.Drawing.Point(163, 135)
        Me.A3_Wert.Name = "A3_Wert"
        Me.A3_Wert.ReadOnly = True
        Me.A3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.A3_Wert.TabIndex = 17
        Me.A3_Wert.Text = "0"
        Me.A3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Wert
        '
        Me.H3_Wert.Location = New System.Drawing.Point(195, 135)
        Me.H3_Wert.Name = "H3_Wert"
        Me.H3_Wert.ReadOnly = True
        Me.H3_Wert.Size = New System.Drawing.Size(26, 20)
        Me.H3_Wert.TabIndex = 18
        Me.H3_Wert.Text = "0"
        Me.H3_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C3_Grenzwert
        '
        Me.C3_Grenzwert.Location = New System.Drawing.Point(3, 161)
        Me.C3_Grenzwert.MaxLength = 3
        Me.C3_Grenzwert.Name = "C3_Grenzwert"
        Me.C3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.C3_Grenzwert.TabIndex = 25
        Me.C3_Grenzwert.Text = "150"
        Me.C3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Grenzwert
        '
        Me.D3_Grenzwert.Location = New System.Drawing.Point(35, 161)
        Me.D3_Grenzwert.MaxLength = 3
        Me.D3_Grenzwert.Name = "D3_Grenzwert"
        Me.D3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D3_Grenzwert.TabIndex = 26
        Me.D3_Grenzwert.Text = "150"
        Me.D3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Grenzwert
        '
        Me.E3_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E3_Grenzwert.MaxLength = 3
        Me.E3_Grenzwert.Name = "E3_Grenzwert"
        Me.E3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E3_Grenzwert.TabIndex = 27
        Me.E3_Grenzwert.Text = "150"
        Me.E3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Grenzwert
        '
        Me.F3_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F3_Grenzwert.MaxLength = 3
        Me.F3_Grenzwert.Name = "F3_Grenzwert"
        Me.F3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F3_Grenzwert.TabIndex = 28
        Me.F3_Grenzwert.Text = "150"
        Me.F3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Grenzwert
        '
        Me.G3_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G3_Grenzwert.MaxLength = 3
        Me.G3_Grenzwert.Name = "G3_Grenzwert"
        Me.G3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G3_Grenzwert.TabIndex = 29
        Me.G3_Grenzwert.Text = "150"
        Me.G3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Grenzwert
        '
        Me.A3_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A3_Grenzwert.MaxLength = 3
        Me.A3_Grenzwert.Name = "A3_Grenzwert"
        Me.A3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A3_Grenzwert.TabIndex = 30
        Me.A3_Grenzwert.Text = "150"
        Me.A3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Grenzwert
        '
        Me.H3_Grenzwert.Location = New System.Drawing.Point(195, 161)
        Me.H3_Grenzwert.MaxLength = 3
        Me.H3_Grenzwert.Name = "H3_Grenzwert"
        Me.H3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.H3_Grenzwert.TabIndex = 31
        Me.H3_Grenzwert.Text = "150"
        Me.H3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel3.Controls.Add(Me.C4_Grenzwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.D4_Grenzwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.E4_Grenzwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.F4_Grenzwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.G4_Grenzwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.A4_Grenzwert)
        Me.FlowLayoutPanel3.Controls.Add(Me.H4_Grenzwert)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(496, 24)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(232, 191)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'C4_Button
        '
        Me.C4_Button.Location = New System.Drawing.Point(3, 106)
        Me.C4_Button.Name = "C4_Button"
        Me.C4_Button.Size = New System.Drawing.Size(26, 23)
        Me.C4_Button.TabIndex = 179
        Me.C4_Button.Text = "c'"
        Me.C4_Button.UseVisualStyleBackColor = True
        '
        'D4_Button
        '
        Me.D4_Button.Location = New System.Drawing.Point(35, 106)
        Me.D4_Button.Name = "D4_Button"
        Me.D4_Button.Size = New System.Drawing.Size(26, 23)
        Me.D4_Button.TabIndex = 180
        Me.D4_Button.Text = "d'"
        Me.D4_Button.UseVisualStyleBackColor = True
        '
        'E4_Button
        '
        Me.E4_Button.Location = New System.Drawing.Point(67, 106)
        Me.E4_Button.Name = "E4_Button"
        Me.E4_Button.Size = New System.Drawing.Size(26, 23)
        Me.E4_Button.TabIndex = 181
        Me.E4_Button.Text = "e'"
        Me.E4_Button.UseVisualStyleBackColor = True
        '
        'F4_Button
        '
        Me.F4_Button.Location = New System.Drawing.Point(99, 106)
        Me.F4_Button.Name = "F4_Button"
        Me.F4_Button.Size = New System.Drawing.Size(26, 23)
        Me.F4_Button.TabIndex = 182
        Me.F4_Button.Text = "f'"
        Me.F4_Button.UseVisualStyleBackColor = True
        '
        'G4_Button
        '
        Me.G4_Button.Location = New System.Drawing.Point(131, 106)
        Me.G4_Button.Name = "G4_Button"
        Me.G4_Button.Size = New System.Drawing.Size(26, 23)
        Me.G4_Button.TabIndex = 183
        Me.G4_Button.Text = "g'"
        Me.G4_Button.UseVisualStyleBackColor = True
        '
        'A4_Button
        '
        Me.A4_Button.Location = New System.Drawing.Point(163, 106)
        Me.A4_Button.Name = "A4_Button"
        Me.A4_Button.Size = New System.Drawing.Size(26, 23)
        Me.A4_Button.TabIndex = 184
        Me.A4_Button.Text = "a'"
        Me.A4_Button.UseVisualStyleBackColor = True
        '
        'H4_Button
        '
        Me.H4_Button.Location = New System.Drawing.Point(195, 106)
        Me.H4_Button.Name = "H4_Button"
        Me.H4_Button.Size = New System.Drawing.Size(26, 23)
        Me.H4_Button.TabIndex = 185
        Me.H4_Button.Text = "h'"
        Me.H4_Button.UseVisualStyleBackColor = True
        '
        'C4_Wert
        '
        Me.C4_Wert.Location = New System.Drawing.Point(3, 135)
        Me.C4_Wert.Name = "C4_Wert"
        Me.C4_Wert.ReadOnly = True
        Me.C4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.C4_Wert.TabIndex = 12
        Me.C4_Wert.Text = "0"
        Me.C4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Wert
        '
        Me.D4_Wert.Location = New System.Drawing.Point(35, 135)
        Me.D4_Wert.Name = "D4_Wert"
        Me.D4_Wert.ReadOnly = True
        Me.D4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.D4_Wert.TabIndex = 13
        Me.D4_Wert.Text = "0"
        Me.D4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Wert
        '
        Me.E4_Wert.Location = New System.Drawing.Point(67, 135)
        Me.E4_Wert.Name = "E4_Wert"
        Me.E4_Wert.ReadOnly = True
        Me.E4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.E4_Wert.TabIndex = 14
        Me.E4_Wert.Text = "0"
        Me.E4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Wert
        '
        Me.F4_Wert.Location = New System.Drawing.Point(99, 135)
        Me.F4_Wert.Name = "F4_Wert"
        Me.F4_Wert.ReadOnly = True
        Me.F4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.F4_Wert.TabIndex = 15
        Me.F4_Wert.Text = "0"
        Me.F4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Wert
        '
        Me.G4_Wert.Location = New System.Drawing.Point(131, 135)
        Me.G4_Wert.Name = "G4_Wert"
        Me.G4_Wert.ReadOnly = True
        Me.G4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.G4_Wert.TabIndex = 16
        Me.G4_Wert.Text = "0"
        Me.G4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Wert
        '
        Me.A4_Wert.Location = New System.Drawing.Point(163, 135)
        Me.A4_Wert.Name = "A4_Wert"
        Me.A4_Wert.ReadOnly = True
        Me.A4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.A4_Wert.TabIndex = 17
        Me.A4_Wert.Text = "0"
        Me.A4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Wert
        '
        Me.H4_Wert.Location = New System.Drawing.Point(195, 135)
        Me.H4_Wert.Name = "H4_Wert"
        Me.H4_Wert.ReadOnly = True
        Me.H4_Wert.Size = New System.Drawing.Size(26, 20)
        Me.H4_Wert.TabIndex = 18
        Me.H4_Wert.Text = "0"
        Me.H4_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C4_Grenzwert
        '
        Me.C4_Grenzwert.Location = New System.Drawing.Point(3, 161)
        Me.C4_Grenzwert.MaxLength = 3
        Me.C4_Grenzwert.Name = "C4_Grenzwert"
        Me.C4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.C4_Grenzwert.TabIndex = 25
        Me.C4_Grenzwert.Text = "100"
        Me.C4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Grenzwert
        '
        Me.D4_Grenzwert.Location = New System.Drawing.Point(35, 161)
        Me.D4_Grenzwert.MaxLength = 3
        Me.D4_Grenzwert.Name = "D4_Grenzwert"
        Me.D4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D4_Grenzwert.TabIndex = 26
        Me.D4_Grenzwert.Text = "100"
        Me.D4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Grenzwert
        '
        Me.E4_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E4_Grenzwert.MaxLength = 3
        Me.E4_Grenzwert.Name = "E4_Grenzwert"
        Me.E4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E4_Grenzwert.TabIndex = 27
        Me.E4_Grenzwert.Text = "100"
        Me.E4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Grenzwert
        '
        Me.F4_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F4_Grenzwert.MaxLength = 3
        Me.F4_Grenzwert.Name = "F4_Grenzwert"
        Me.F4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F4_Grenzwert.TabIndex = 28
        Me.F4_Grenzwert.Text = "100"
        Me.F4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Grenzwert
        '
        Me.G4_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G4_Grenzwert.MaxLength = 3
        Me.G4_Grenzwert.Name = "G4_Grenzwert"
        Me.G4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G4_Grenzwert.TabIndex = 29
        Me.G4_Grenzwert.Text = "100"
        Me.G4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Grenzwert
        '
        Me.A4_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A4_Grenzwert.MaxLength = 3
        Me.A4_Grenzwert.Name = "A4_Grenzwert"
        Me.A4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A4_Grenzwert.TabIndex = 30
        Me.A4_Grenzwert.Text = "100"
        Me.A4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Grenzwert
        '
        Me.H4_Grenzwert.Location = New System.Drawing.Point(195, 161)
        Me.H4_Grenzwert.MaxLength = 3
        Me.H4_Grenzwert.Name = "H4_Grenzwert"
        Me.H4_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.H4_Grenzwert.TabIndex = 31
        Me.H4_Grenzwert.Text = "100"
        Me.H4_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel4.Controls.Add(Me.C5_Grenzwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.D5_Grenzwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.E5_Grenzwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.F5_Grenzwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.G5_Grenzwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.A5_Grenzwert)
        Me.FlowLayoutPanel4.Controls.Add(Me.H5_Grenzwert)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(734, 24)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(231, 191)
        Me.FlowLayoutPanel4.TabIndex = 9
        '
        'C5_Button
        '
        Me.C5_Button.Location = New System.Drawing.Point(3, 106)
        Me.C5_Button.Name = "C5_Button"
        Me.C5_Button.Size = New System.Drawing.Size(26, 23)
        Me.C5_Button.TabIndex = 179
        Me.C5_Button.Text = "c''"
        Me.C5_Button.UseVisualStyleBackColor = True
        '
        'D5_Button
        '
        Me.D5_Button.Location = New System.Drawing.Point(35, 106)
        Me.D5_Button.Name = "D5_Button"
        Me.D5_Button.Size = New System.Drawing.Size(26, 23)
        Me.D5_Button.TabIndex = 180
        Me.D5_Button.Text = "d''"
        Me.D5_Button.UseVisualStyleBackColor = True
        '
        'E5_Button
        '
        Me.E5_Button.Location = New System.Drawing.Point(67, 106)
        Me.E5_Button.Name = "E5_Button"
        Me.E5_Button.Size = New System.Drawing.Size(26, 23)
        Me.E5_Button.TabIndex = 181
        Me.E5_Button.Text = "e''"
        Me.E5_Button.UseVisualStyleBackColor = True
        '
        'F5_Button
        '
        Me.F5_Button.Location = New System.Drawing.Point(99, 106)
        Me.F5_Button.Name = "F5_Button"
        Me.F5_Button.Size = New System.Drawing.Size(26, 23)
        Me.F5_Button.TabIndex = 182
        Me.F5_Button.Text = "f''"
        Me.F5_Button.UseVisualStyleBackColor = True
        '
        'G5_Button
        '
        Me.G5_Button.Location = New System.Drawing.Point(131, 106)
        Me.G5_Button.Name = "G5_Button"
        Me.G5_Button.Size = New System.Drawing.Size(26, 23)
        Me.G5_Button.TabIndex = 183
        Me.G5_Button.Text = "g''"
        Me.G5_Button.UseVisualStyleBackColor = True
        '
        'A5_Button
        '
        Me.A5_Button.Location = New System.Drawing.Point(163, 106)
        Me.A5_Button.Name = "A5_Button"
        Me.A5_Button.Size = New System.Drawing.Size(26, 23)
        Me.A5_Button.TabIndex = 184
        Me.A5_Button.Text = "a''"
        Me.A5_Button.UseVisualStyleBackColor = True
        '
        'H5_Button
        '
        Me.H5_Button.Location = New System.Drawing.Point(195, 106)
        Me.H5_Button.Name = "H5_Button"
        Me.H5_Button.Size = New System.Drawing.Size(26, 23)
        Me.H5_Button.TabIndex = 185
        Me.H5_Button.Text = "h''"
        Me.H5_Button.UseVisualStyleBackColor = True
        '
        'C5_Wert
        '
        Me.C5_Wert.Location = New System.Drawing.Point(3, 135)
        Me.C5_Wert.Name = "C5_Wert"
        Me.C5_Wert.ReadOnly = True
        Me.C5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.C5_Wert.TabIndex = 12
        Me.C5_Wert.Text = "0"
        Me.C5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Wert
        '
        Me.D5_Wert.Location = New System.Drawing.Point(35, 135)
        Me.D5_Wert.Name = "D5_Wert"
        Me.D5_Wert.ReadOnly = True
        Me.D5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.D5_Wert.TabIndex = 13
        Me.D5_Wert.Text = "0"
        Me.D5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Wert
        '
        Me.E5_Wert.Location = New System.Drawing.Point(67, 135)
        Me.E5_Wert.Name = "E5_Wert"
        Me.E5_Wert.ReadOnly = True
        Me.E5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.E5_Wert.TabIndex = 14
        Me.E5_Wert.Text = "0"
        Me.E5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Wert
        '
        Me.F5_Wert.Location = New System.Drawing.Point(99, 135)
        Me.F5_Wert.Name = "F5_Wert"
        Me.F5_Wert.ReadOnly = True
        Me.F5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.F5_Wert.TabIndex = 15
        Me.F5_Wert.Text = "0"
        Me.F5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Wert
        '
        Me.G5_Wert.Location = New System.Drawing.Point(131, 135)
        Me.G5_Wert.Name = "G5_Wert"
        Me.G5_Wert.ReadOnly = True
        Me.G5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.G5_Wert.TabIndex = 16
        Me.G5_Wert.Text = "0"
        Me.G5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Wert
        '
        Me.A5_Wert.Location = New System.Drawing.Point(163, 135)
        Me.A5_Wert.Name = "A5_Wert"
        Me.A5_Wert.ReadOnly = True
        Me.A5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.A5_Wert.TabIndex = 17
        Me.A5_Wert.Text = "0"
        Me.A5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Wert
        '
        Me.H5_Wert.Location = New System.Drawing.Point(195, 135)
        Me.H5_Wert.Name = "H5_Wert"
        Me.H5_Wert.ReadOnly = True
        Me.H5_Wert.Size = New System.Drawing.Size(26, 20)
        Me.H5_Wert.TabIndex = 18
        Me.H5_Wert.Text = "0"
        Me.H5_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C5_Grenzwert
        '
        Me.C5_Grenzwert.Location = New System.Drawing.Point(3, 161)
        Me.C5_Grenzwert.MaxLength = 3
        Me.C5_Grenzwert.Name = "C5_Grenzwert"
        Me.C5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.C5_Grenzwert.TabIndex = 25
        Me.C5_Grenzwert.Text = "75"
        Me.C5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Grenzwert
        '
        Me.D5_Grenzwert.Location = New System.Drawing.Point(35, 161)
        Me.D5_Grenzwert.MaxLength = 3
        Me.D5_Grenzwert.Name = "D5_Grenzwert"
        Me.D5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D5_Grenzwert.TabIndex = 26
        Me.D5_Grenzwert.Text = "75"
        Me.D5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Grenzwert
        '
        Me.E5_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E5_Grenzwert.MaxLength = 3
        Me.E5_Grenzwert.Name = "E5_Grenzwert"
        Me.E5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E5_Grenzwert.TabIndex = 27
        Me.E5_Grenzwert.Text = "75"
        Me.E5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Grenzwert
        '
        Me.F5_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F5_Grenzwert.MaxLength = 3
        Me.F5_Grenzwert.Name = "F5_Grenzwert"
        Me.F5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F5_Grenzwert.TabIndex = 28
        Me.F5_Grenzwert.Text = "75"
        Me.F5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Grenzwert
        '
        Me.G5_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G5_Grenzwert.MaxLength = 3
        Me.G5_Grenzwert.Name = "G5_Grenzwert"
        Me.G5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G5_Grenzwert.TabIndex = 29
        Me.G5_Grenzwert.Text = "75"
        Me.G5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Grenzwert
        '
        Me.A5_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A5_Grenzwert.MaxLength = 3
        Me.A5_Grenzwert.Name = "A5_Grenzwert"
        Me.A5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A5_Grenzwert.TabIndex = 30
        Me.A5_Grenzwert.Text = "75"
        Me.A5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Grenzwert
        '
        Me.H5_Grenzwert.Location = New System.Drawing.Point(195, 161)
        Me.H5_Grenzwert.MaxLength = 3
        Me.H5_Grenzwert.Name = "H5_Grenzwert"
        Me.H5_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.H5_Grenzwert.TabIndex = 31
        Me.H5_Grenzwert.Text = "75"
        Me.H5_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel5.Controls.Add(Me.C6_Grenzwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.D6_Grenzwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.E6_Grenzwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.F6_Grenzwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.G6_Grenzwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.A6_Grenzwert)
        Me.FlowLayoutPanel5.Controls.Add(Me.H6_Grenzwert)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(982, 24)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(237, 191)
        Me.FlowLayoutPanel5.TabIndex = 10
        '
        'C6_Button
        '
        Me.C6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C6_Button.Location = New System.Drawing.Point(3, 106)
        Me.C6_Button.Name = "C6_Button"
        Me.C6_Button.Size = New System.Drawing.Size(26, 23)
        Me.C6_Button.TabIndex = 179
        Me.C6_Button.Text = "c'''"
        Me.C6_Button.UseVisualStyleBackColor = True
        '
        'D6_Button
        '
        Me.D6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6_Button.Location = New System.Drawing.Point(35, 106)
        Me.D6_Button.Name = "D6_Button"
        Me.D6_Button.Size = New System.Drawing.Size(26, 23)
        Me.D6_Button.TabIndex = 180
        Me.D6_Button.Text = "d'''"
        Me.D6_Button.UseVisualStyleBackColor = True
        '
        'E6_Button
        '
        Me.E6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E6_Button.Location = New System.Drawing.Point(67, 106)
        Me.E6_Button.Name = "E6_Button"
        Me.E6_Button.Size = New System.Drawing.Size(26, 23)
        Me.E6_Button.TabIndex = 181
        Me.E6_Button.Text = "e'''"
        Me.E6_Button.UseVisualStyleBackColor = True
        '
        'F6_Button
        '
        Me.F6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F6_Button.Location = New System.Drawing.Point(99, 106)
        Me.F6_Button.Name = "F6_Button"
        Me.F6_Button.Size = New System.Drawing.Size(26, 23)
        Me.F6_Button.TabIndex = 182
        Me.F6_Button.Text = "f'''"
        Me.F6_Button.UseVisualStyleBackColor = True
        '
        'G6_Button
        '
        Me.G6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G6_Button.Location = New System.Drawing.Point(131, 106)
        Me.G6_Button.Name = "G6_Button"
        Me.G6_Button.Size = New System.Drawing.Size(26, 23)
        Me.G6_Button.TabIndex = 183
        Me.G6_Button.Text = "g'''"
        Me.G6_Button.UseVisualStyleBackColor = True
        '
        'A6_Button
        '
        Me.A6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A6_Button.Location = New System.Drawing.Point(163, 106)
        Me.A6_Button.Name = "A6_Button"
        Me.A6_Button.Size = New System.Drawing.Size(26, 23)
        Me.A6_Button.TabIndex = 184
        Me.A6_Button.Text = "a'''"
        Me.A6_Button.UseVisualStyleBackColor = True
        '
        'H6_Button
        '
        Me.H6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H6_Button.Location = New System.Drawing.Point(195, 106)
        Me.H6_Button.Name = "H6_Button"
        Me.H6_Button.Size = New System.Drawing.Size(26, 23)
        Me.H6_Button.TabIndex = 185
        Me.H6_Button.Text = "h'''"
        Me.H6_Button.UseVisualStyleBackColor = True
        '
        'C6_Wert
        '
        Me.C6_Wert.Location = New System.Drawing.Point(3, 135)
        Me.C6_Wert.Name = "C6_Wert"
        Me.C6_Wert.ReadOnly = True
        Me.C6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.C6_Wert.TabIndex = 12
        Me.C6_Wert.Text = "0"
        Me.C6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Wert
        '
        Me.D6_Wert.Location = New System.Drawing.Point(35, 135)
        Me.D6_Wert.Name = "D6_Wert"
        Me.D6_Wert.ReadOnly = True
        Me.D6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.D6_Wert.TabIndex = 13
        Me.D6_Wert.Text = "0"
        Me.D6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Wert
        '
        Me.E6_Wert.Location = New System.Drawing.Point(67, 135)
        Me.E6_Wert.Name = "E6_Wert"
        Me.E6_Wert.ReadOnly = True
        Me.E6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.E6_Wert.TabIndex = 14
        Me.E6_Wert.Text = "0"
        Me.E6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Wert
        '
        Me.F6_Wert.Location = New System.Drawing.Point(99, 135)
        Me.F6_Wert.Name = "F6_Wert"
        Me.F6_Wert.ReadOnly = True
        Me.F6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.F6_Wert.TabIndex = 15
        Me.F6_Wert.Text = "0"
        Me.F6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Wert
        '
        Me.G6_Wert.Location = New System.Drawing.Point(131, 135)
        Me.G6_Wert.Name = "G6_Wert"
        Me.G6_Wert.ReadOnly = True
        Me.G6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.G6_Wert.TabIndex = 16
        Me.G6_Wert.Text = "0"
        Me.G6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Wert
        '
        Me.A6_Wert.Location = New System.Drawing.Point(163, 135)
        Me.A6_Wert.Name = "A6_Wert"
        Me.A6_Wert.ReadOnly = True
        Me.A6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.A6_Wert.TabIndex = 17
        Me.A6_Wert.Text = "0"
        Me.A6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Wert
        '
        Me.H6_Wert.Location = New System.Drawing.Point(195, 135)
        Me.H6_Wert.Name = "H6_Wert"
        Me.H6_Wert.ReadOnly = True
        Me.H6_Wert.Size = New System.Drawing.Size(26, 20)
        Me.H6_Wert.TabIndex = 18
        Me.H6_Wert.Text = "0"
        Me.H6_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C6_Grenzwert
        '
        Me.C6_Grenzwert.Location = New System.Drawing.Point(3, 161)
        Me.C6_Grenzwert.MaxLength = 3
        Me.C6_Grenzwert.Name = "C6_Grenzwert"
        Me.C6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.C6_Grenzwert.TabIndex = 25
        Me.C6_Grenzwert.Text = "50"
        Me.C6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Grenzwert
        '
        Me.D6_Grenzwert.Location = New System.Drawing.Point(35, 161)
        Me.D6_Grenzwert.MaxLength = 3
        Me.D6_Grenzwert.Name = "D6_Grenzwert"
        Me.D6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D6_Grenzwert.TabIndex = 26
        Me.D6_Grenzwert.Text = "50"
        Me.D6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Grenzwert
        '
        Me.E6_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E6_Grenzwert.MaxLength = 3
        Me.E6_Grenzwert.Name = "E6_Grenzwert"
        Me.E6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E6_Grenzwert.TabIndex = 27
        Me.E6_Grenzwert.Text = "50"
        Me.E6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Grenzwert
        '
        Me.F6_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F6_Grenzwert.MaxLength = 3
        Me.F6_Grenzwert.Name = "F6_Grenzwert"
        Me.F6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F6_Grenzwert.TabIndex = 28
        Me.F6_Grenzwert.Text = "50"
        Me.F6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Grenzwert
        '
        Me.G6_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G6_Grenzwert.MaxLength = 3
        Me.G6_Grenzwert.Name = "G6_Grenzwert"
        Me.G6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G6_Grenzwert.TabIndex = 29
        Me.G6_Grenzwert.Text = "50"
        Me.G6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Grenzwert
        '
        Me.A6_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A6_Grenzwert.MaxLength = 3
        Me.A6_Grenzwert.Name = "A6_Grenzwert"
        Me.A6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A6_Grenzwert.TabIndex = 30
        Me.A6_Grenzwert.Text = "50"
        Me.A6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Grenzwert
        '
        Me.H6_Grenzwert.Location = New System.Drawing.Point(195, 161)
        Me.H6_Grenzwert.MaxLength = 3
        Me.H6_Grenzwert.Name = "H6_Grenzwert"
        Me.H6_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.H6_Grenzwert.TabIndex = 31
        Me.H6_Grenzwert.Text = "50"
        Me.H6_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Einstellungen_GroupBox
        '
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox3)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Messintervall_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox19)
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox13)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Tempo_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Transpose_GroupBox)
        Me.Einstellungen_GroupBox.Location = New System.Drawing.Point(326, 13)
        Me.Einstellungen_GroupBox.Name = "Einstellungen_GroupBox"
        Me.Einstellungen_GroupBox.Size = New System.Drawing.Size(217, 454)
        Me.Einstellungen_GroupBox.TabIndex = 20
        Me.Einstellungen_GroupBox.TabStop = False
        Me.Einstellungen_GroupBox.Text = "Einstellungen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AnzMessungen)
        Me.GroupBox3.Controls.Add(Me.AnzMessfehler)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 399)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(199, 49)
        Me.GroupBox3.TabIndex = 182
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Anzahl Messungen und Messfehler"
        '
        'AnzMessungen
        '
        Me.AnzMessungen.Enabled = False
        Me.AnzMessungen.Location = New System.Drawing.Point(12, 23)
        Me.AnzMessungen.Name = "AnzMessungen"
        Me.AnzMessungen.ReadOnly = True
        Me.AnzMessungen.Size = New System.Drawing.Size(79, 20)
        Me.AnzMessungen.TabIndex = 0
        Me.AnzMessungen.Text = "0"
        Me.AnzMessungen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AnzMessfehler
        '
        Me.AnzMessfehler.Enabled = False
        Me.AnzMessfehler.Location = New System.Drawing.Point(103, 23)
        Me.AnzMessfehler.Name = "AnzMessfehler"
        Me.AnzMessfehler.ReadOnly = True
        Me.AnzMessfehler.Size = New System.Drawing.Size(79, 20)
        Me.AnzMessfehler.TabIndex = 187
        Me.AnzMessfehler.Text = "0"
        Me.AnzMessfehler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Messintervall_GroupBox
        '
        Me.Messintervall_GroupBox.Controls.Add(Me.Messintervall_TextBox)
        Me.Messintervall_GroupBox.Controls.Add(Me.MessungenProS_TexBox)
        Me.Messintervall_GroupBox.Controls.Add(Me.Label5)
        Me.Messintervall_GroupBox.Location = New System.Drawing.Point(9, 344)
        Me.Messintervall_GroupBox.Name = "Messintervall_GroupBox"
        Me.Messintervall_GroupBox.Size = New System.Drawing.Size(199, 48)
        Me.Messintervall_GroupBox.TabIndex = 174
        Me.Messintervall_GroupBox.TabStop = False
        Me.Messintervall_GroupBox.Text = "Messintervall vom Mikrokontroller"
        '
        'Messintervall_TextBox
        '
        Me.Messintervall_TextBox.Enabled = False
        Me.Messintervall_TextBox.Location = New System.Drawing.Point(124, 18)
        Me.Messintervall_TextBox.Name = "Messintervall_TextBox"
        Me.Messintervall_TextBox.ReadOnly = True
        Me.Messintervall_TextBox.Size = New System.Drawing.Size(58, 20)
        Me.Messintervall_TextBox.TabIndex = 181
        Me.Messintervall_TextBox.Text = "0 ms"
        '
        'MessungenProS_TexBox
        '
        Me.MessungenProS_TexBox.Enabled = False
        Me.MessungenProS_TexBox.Location = New System.Drawing.Point(58, 18)
        Me.MessungenProS_TexBox.Name = "MessungenProS_TexBox"
        Me.MessungenProS_TexBox.ReadOnly = True
        Me.MessungenProS_TexBox.Size = New System.Drawing.Size(58, 20)
        Me.MessungenProS_TexBox.TabIndex = 180
        Me.MessungenProS_TexBox.Text = "0 M/s"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "Mes/S:"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.MIDI_SpecialMode)
        Me.GroupBox19.Controls.Add(Me.MIDI_NormalMode)
        Me.GroupBox19.Controls.Add(Me.cboInstruments)
        Me.GroupBox19.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(199, 89)
        Me.GroupBox19.TabIndex = 173
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "MIDI Aufnahmemodus"
        '
        'MIDI_SpecialMode
        '
        Me.MIDI_SpecialMode.AutoSize = True
        Me.MIDI_SpecialMode.Checked = True
        Me.MIDI_SpecialMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MIDI_SpecialMode.Location = New System.Drawing.Point(116, 23)
        Me.MIDI_SpecialMode.Name = "MIDI_SpecialMode"
        Me.MIDI_SpecialMode.Size = New System.Drawing.Size(74, 17)
        Me.MIDI_SpecialMode.TabIndex = 4
        Me.MIDI_SpecialMode.TabStop = True
        Me.MIDI_SpecialMode.Text = "nur Töhne"
        Me.ToolTip1.SetToolTip(Me.MIDI_SpecialMode, resources.GetString("MIDI_SpecialMode.ToolTip"))
        Me.MIDI_SpecialMode.UseVisualStyleBackColor = True
        '
        'MIDI_NormalMode
        '
        Me.MIDI_NormalMode.AutoSize = True
        Me.MIDI_NormalMode.Location = New System.Drawing.Point(13, 22)
        Me.MIDI_NormalMode.Name = "MIDI_NormalMode"
        Me.MIDI_NormalMode.Size = New System.Drawing.Size(97, 17)
        Me.MIDI_NormalMode.TabIndex = 3
        Me.MIDI_NormalMode.Text = "Standardt MIDI"
        Me.ToolTip1.SetToolTip(Me.MIDI_NormalMode, resources.GetString("MIDI_NormalMode.ToolTip"))
        Me.MIDI_NormalMode.UseVisualStyleBackColor = True
        '
        'cboInstruments
        '
        Me.cboInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstruments.Location = New System.Drawing.Point(12, 46)
        Me.cboInstruments.Name = "cboInstruments"
        Me.cboInstruments.Size = New System.Drawing.Size(175, 21)
        Me.cboInstruments.TabIndex = 2
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Metronom_OFF)
        Me.GroupBox13.Controls.Add(Me.Metronom_ON)
        Me.GroupBox13.Controls.Add(Me.Metronom_Betont)
        Me.GroupBox13.Location = New System.Drawing.Point(9, 289)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(199, 45)
        Me.GroupBox13.TabIndex = 168
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Metronom"
        Me.ToolTip1.SetToolTip(Me.GroupBox13, "Das Metronom dient zur Hilfe")
        '
        'Metronom_OFF
        '
        Me.Metronom_OFF.AutoSize = True
        Me.Metronom_OFF.Checked = True
        Me.Metronom_OFF.Location = New System.Drawing.Point(141, 19)
        Me.Metronom_OFF.Name = "Metronom_OFF"
        Me.Metronom_OFF.Size = New System.Drawing.Size(43, 17)
        Me.Metronom_OFF.TabIndex = 1
        Me.Metronom_OFF.TabStop = True
        Me.Metronom_OFF.Text = "Aus"
        Me.Metronom_OFF.UseVisualStyleBackColor = True
        '
        'Metronom_ON
        '
        Me.Metronom_ON.AutoSize = True
        Me.Metronom_ON.Location = New System.Drawing.Point(87, 19)
        Me.Metronom_ON.Name = "Metronom_ON"
        Me.Metronom_ON.Size = New System.Drawing.Size(40, 17)
        Me.Metronom_ON.TabIndex = 0
        Me.Metronom_ON.Text = "Ein"
        Me.Metronom_ON.UseVisualStyleBackColor = True
        '
        'Metronom_Betont
        '
        Me.Metronom_Betont.AutoSize = True
        Me.Metronom_Betont.Location = New System.Drawing.Point(16, 19)
        Me.Metronom_Betont.Name = "Metronom_Betont"
        Me.Metronom_Betont.Size = New System.Drawing.Size(56, 17)
        Me.Metronom_Betont.TabIndex = 0
        Me.Metronom_Betont.Text = "Betont"
        Me.Metronom_Betont.UseVisualStyleBackColor = True
        '
        'Tempo_GroupBox
        '
        Me.Tempo_GroupBox.Controls.Add(Me.Label18)
        Me.Tempo_GroupBox.Controls.Add(Me.Tackt_Naenner_Input)
        Me.Tempo_GroupBox.Controls.Add(Me.Tackt_Zaehler_Input)
        Me.Tempo_GroupBox.Controls.Add(Me.Label17)
        Me.Tempo_GroupBox.Controls.Add(Me.BPM_Label)
        Me.Tempo_GroupBox.Controls.Add(Me.BPM)
        Me.Tempo_GroupBox.Location = New System.Drawing.Point(9, 114)
        Me.Tempo_GroupBox.Name = "Tempo_GroupBox"
        Me.Tempo_GroupBox.Size = New System.Drawing.Size(199, 63)
        Me.Tempo_GroupBox.TabIndex = 172
        Me.Tempo_GroupBox.TabStop = False
        Me.Tempo_GroupBox.Text = "Tempo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(122, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 13)
        Me.Label18.TabIndex = 172
        Me.Label18.Text = "/"
        '
        'Tackt_Naenner_Input
        '
        Me.Tackt_Naenner_Input.Location = New System.Drawing.Point(137, 12)
        Me.Tackt_Naenner_Input.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.Tackt_Naenner_Input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tackt_Naenner_Input.Name = "Tackt_Naenner_Input"
        Me.Tackt_Naenner_Input.Size = New System.Drawing.Size(48, 20)
        Me.Tackt_Naenner_Input.TabIndex = 174
        Me.Tackt_Naenner_Input.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Tackt_Zaehler_Input
        '
        Me.Tackt_Zaehler_Input.Location = New System.Drawing.Point(61, 12)
        Me.Tackt_Zaehler_Input.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.Tackt_Zaehler_Input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tackt_Zaehler_Input.Name = "Tackt_Zaehler_Input"
        Me.Tackt_Zaehler_Input.Size = New System.Drawing.Size(55, 20)
        Me.Tackt_Zaehler_Input.TabIndex = 172
        Me.Tackt_Zaehler_Input.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 173
        Me.Label17.Text = "Tackt:"
        '
        'BPM_Label
        '
        Me.BPM_Label.AutoSize = True
        Me.BPM_Label.Location = New System.Drawing.Point(12, 42)
        Me.BPM_Label.Name = "BPM_Label"
        Me.BPM_Label.Size = New System.Drawing.Size(84, 13)
        Me.BPM_Label.TabIndex = 172
        Me.BPM_Label.Text = "Aufnahme BPM:"
        '
        'BPM
        '
        Me.BPM.Location = New System.Drawing.Point(137, 37)
        Me.BPM.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.BPM.Name = "BPM"
        Me.BPM.Size = New System.Drawing.Size(48, 20)
        Me.BPM.TabIndex = 168
        Me.BPM.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Transpose_GroupBox
        '
        Me.Transpose_GroupBox.Controls.Add(Me.Label2)
        Me.Transpose_GroupBox.Controls.Add(Me.Label1)
        Me.Transpose_GroupBox.Controls.Add(Me.Halbtonverschiebung)
        Me.Transpose_GroupBox.Controls.Add(Me.Oktavenverschiebung)
        Me.Transpose_GroupBox.Location = New System.Drawing.Point(9, 194)
        Me.Transpose_GroupBox.Name = "Transpose_GroupBox"
        Me.Transpose_GroupBox.Size = New System.Drawing.Size(199, 83)
        Me.Transpose_GroupBox.TabIndex = 166
        Me.Transpose_GroupBox.TabStop = False
        Me.Transpose_GroupBox.Text = "Tonhöhenveschiebung (Transpose)"
        Me.ToolTip1.SetToolTip(Me.Transpose_GroupBox, "Konvertierungsfehler zu MIDI File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Wird demnächst behoben)")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Notenverschiebung:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Oktavenver.:"
        '
        'Halbtonverschiebung
        '
        Me.Halbtonverschiebung.Location = New System.Drawing.Point(127, 55)
        Me.Halbtonverschiebung.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.Halbtonverschiebung.Minimum = New Decimal(New Integer() {36, 0, 0, -2147483648})
        Me.Halbtonverschiebung.Name = "Halbtonverschiebung"
        Me.Halbtonverschiebung.Size = New System.Drawing.Size(55, 20)
        Me.Halbtonverschiebung.TabIndex = 165
        '
        'Oktavenverschiebung
        '
        Me.Oktavenverschiebung.Items.AddRange(New Object() {"+ 2 Oktaven", "+ 3 Oktaven", "+ 1 Oktave", "Normahl", "- 1 Oktave", "- 2 Oktaven", "- 3 Oktaven"})
        Me.Oktavenverschiebung.Location = New System.Drawing.Point(90, 25)
        Me.Oktavenverschiebung.Name = "Oktavenverschiebung"
        Me.Oktavenverschiebung.Size = New System.Drawing.Size(92, 21)
        Me.Oktavenverschiebung.TabIndex = 165
        Me.Oktavenverschiebung.Text = "Normahl"
        '
        'Tackt
        '
        Me.Tackt.Interval = 125
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel11)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel10)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel9)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel8)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel7)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel4)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel5)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox4.Location = New System.Drawing.Point(13, 483)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1229, 260)
        Me.GroupBox4.TabIndex = 167
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MIDI Visualisierung"
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
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(982, 217)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(236, 27)
        Me.FlowLayoutPanel11.TabIndex = 173
        '
        'C6_Verschiebung
        '
        Me.C6_Verschiebung.Location = New System.Drawing.Point(3, 3)
        Me.C6_Verschiebung.Name = "C6_Verschiebung"
        Me.C6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.C6_Verschiebung.TabIndex = 19
        Me.C6_Verschiebung.Text = "0"
        Me.C6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6_Verschiebung
        '
        Me.D6_Verschiebung.Location = New System.Drawing.Point(35, 3)
        Me.D6_Verschiebung.Name = "D6_Verschiebung"
        Me.D6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.D6_Verschiebung.TabIndex = 20
        Me.D6_Verschiebung.Text = "0"
        Me.D6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E6_Verschiebung
        '
        Me.E6_Verschiebung.Location = New System.Drawing.Point(67, 3)
        Me.E6_Verschiebung.Name = "E6_Verschiebung"
        Me.E6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.E6_Verschiebung.TabIndex = 21
        Me.E6_Verschiebung.Text = "0"
        Me.E6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F6_Verschiebung
        '
        Me.F6_Verschiebung.Location = New System.Drawing.Point(99, 3)
        Me.F6_Verschiebung.Name = "F6_Verschiebung"
        Me.F6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.F6_Verschiebung.TabIndex = 22
        Me.F6_Verschiebung.Text = "0"
        Me.F6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G6_Verschiebung
        '
        Me.G6_Verschiebung.Location = New System.Drawing.Point(131, 3)
        Me.G6_Verschiebung.Name = "G6_Verschiebung"
        Me.G6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.G6_Verschiebung.TabIndex = 23
        Me.G6_Verschiebung.Text = "0"
        Me.G6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A6_Verschiebung
        '
        Me.A6_Verschiebung.Location = New System.Drawing.Point(163, 3)
        Me.A6_Verschiebung.Name = "A6_Verschiebung"
        Me.A6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.A6_Verschiebung.TabIndex = 24
        Me.A6_Verschiebung.Text = "0"
        Me.A6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H6_Verschiebung
        '
        Me.H6_Verschiebung.Location = New System.Drawing.Point(195, 3)
        Me.H6_Verschiebung.Name = "H6_Verschiebung"
        Me.H6_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.H6_Verschiebung.TabIndex = 25
        Me.H6_Verschiebung.Text = "0"
        Me.H6_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(737, 217)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(228, 27)
        Me.FlowLayoutPanel10.TabIndex = 172
        '
        'C5_Verschiebung
        '
        Me.C5_Verschiebung.Location = New System.Drawing.Point(3, 3)
        Me.C5_Verschiebung.Name = "C5_Verschiebung"
        Me.C5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.C5_Verschiebung.TabIndex = 19
        Me.C5_Verschiebung.Text = "0"
        Me.C5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5_Verschiebung
        '
        Me.D5_Verschiebung.Location = New System.Drawing.Point(35, 3)
        Me.D5_Verschiebung.Name = "D5_Verschiebung"
        Me.D5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.D5_Verschiebung.TabIndex = 20
        Me.D5_Verschiebung.Text = "0"
        Me.D5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E5_Verschiebung
        '
        Me.E5_Verschiebung.Location = New System.Drawing.Point(67, 3)
        Me.E5_Verschiebung.Name = "E5_Verschiebung"
        Me.E5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.E5_Verschiebung.TabIndex = 21
        Me.E5_Verschiebung.Text = "0"
        Me.E5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F5_Verschiebung
        '
        Me.F5_Verschiebung.Location = New System.Drawing.Point(99, 3)
        Me.F5_Verschiebung.Name = "F5_Verschiebung"
        Me.F5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.F5_Verschiebung.TabIndex = 22
        Me.F5_Verschiebung.Text = "0"
        Me.F5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G5_Verschiebung
        '
        Me.G5_Verschiebung.Location = New System.Drawing.Point(131, 3)
        Me.G5_Verschiebung.Name = "G5_Verschiebung"
        Me.G5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.G5_Verschiebung.TabIndex = 23
        Me.G5_Verschiebung.Text = "0"
        Me.G5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A5_Verschiebung
        '
        Me.A5_Verschiebung.Location = New System.Drawing.Point(163, 3)
        Me.A5_Verschiebung.Name = "A5_Verschiebung"
        Me.A5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.A5_Verschiebung.TabIndex = 24
        Me.A5_Verschiebung.Text = "0"
        Me.A5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H5_Verschiebung
        '
        Me.H5_Verschiebung.Location = New System.Drawing.Point(195, 3)
        Me.H5_Verschiebung.Name = "H5_Verschiebung"
        Me.H5_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.H5_Verschiebung.TabIndex = 25
        Me.H5_Verschiebung.Text = "0"
        Me.H5_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(496, 217)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(232, 27)
        Me.FlowLayoutPanel9.TabIndex = 171
        '
        'C4_Verschiebung
        '
        Me.C4_Verschiebung.Location = New System.Drawing.Point(3, 3)
        Me.C4_Verschiebung.Name = "C4_Verschiebung"
        Me.C4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.C4_Verschiebung.TabIndex = 19
        Me.C4_Verschiebung.Text = "0"
        Me.C4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4_Verschiebung
        '
        Me.D4_Verschiebung.Location = New System.Drawing.Point(35, 3)
        Me.D4_Verschiebung.Name = "D4_Verschiebung"
        Me.D4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.D4_Verschiebung.TabIndex = 20
        Me.D4_Verschiebung.Text = "0"
        Me.D4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E4_Verschiebung
        '
        Me.E4_Verschiebung.Location = New System.Drawing.Point(67, 3)
        Me.E4_Verschiebung.Name = "E4_Verschiebung"
        Me.E4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.E4_Verschiebung.TabIndex = 21
        Me.E4_Verschiebung.Text = "0"
        Me.E4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Verschiebung
        '
        Me.F4_Verschiebung.Location = New System.Drawing.Point(99, 3)
        Me.F4_Verschiebung.Name = "F4_Verschiebung"
        Me.F4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.F4_Verschiebung.TabIndex = 22
        Me.F4_Verschiebung.Text = "0"
        Me.F4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G4_Verschiebung
        '
        Me.G4_Verschiebung.Location = New System.Drawing.Point(131, 3)
        Me.G4_Verschiebung.Name = "G4_Verschiebung"
        Me.G4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.G4_Verschiebung.TabIndex = 23
        Me.G4_Verschiebung.Text = "0"
        Me.G4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A4_Verschiebung
        '
        Me.A4_Verschiebung.Location = New System.Drawing.Point(163, 3)
        Me.A4_Verschiebung.Name = "A4_Verschiebung"
        Me.A4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.A4_Verschiebung.TabIndex = 24
        Me.A4_Verschiebung.Text = "0"
        Me.A4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4_Verschiebung
        '
        Me.H4_Verschiebung.Location = New System.Drawing.Point(195, 3)
        Me.H4_Verschiebung.Name = "H4_Verschiebung"
        Me.H4_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.H4_Verschiebung.TabIndex = 25
        Me.H4_Verschiebung.Text = "0"
        Me.H4_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(249, 217)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(230, 27)
        Me.FlowLayoutPanel8.TabIndex = 170
        '
        'C3_Verschiebung
        '
        Me.C3_Verschiebung.Location = New System.Drawing.Point(3, 3)
        Me.C3_Verschiebung.Name = "C3_Verschiebung"
        Me.C3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.C3_Verschiebung.TabIndex = 19
        Me.C3_Verschiebung.Text = "0"
        Me.C3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Verschiebung
        '
        Me.D3_Verschiebung.Location = New System.Drawing.Point(35, 3)
        Me.D3_Verschiebung.Name = "D3_Verschiebung"
        Me.D3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.D3_Verschiebung.TabIndex = 20
        Me.D3_Verschiebung.Text = "0"
        Me.D3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Verschiebung
        '
        Me.E3_Verschiebung.Location = New System.Drawing.Point(67, 3)
        Me.E3_Verschiebung.Name = "E3_Verschiebung"
        Me.E3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.E3_Verschiebung.TabIndex = 21
        Me.E3_Verschiebung.Text = "0"
        Me.E3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Verschiebung
        '
        Me.F3_Verschiebung.Location = New System.Drawing.Point(99, 3)
        Me.F3_Verschiebung.Name = "F3_Verschiebung"
        Me.F3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.F3_Verschiebung.TabIndex = 22
        Me.F3_Verschiebung.Text = "0"
        Me.F3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Verschiebung
        '
        Me.G3_Verschiebung.Location = New System.Drawing.Point(131, 3)
        Me.G3_Verschiebung.Name = "G3_Verschiebung"
        Me.G3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.G3_Verschiebung.TabIndex = 23
        Me.G3_Verschiebung.Text = "0"
        Me.G3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Verschiebung
        '
        Me.A3_Verschiebung.Location = New System.Drawing.Point(163, 3)
        Me.A3_Verschiebung.Name = "A3_Verschiebung"
        Me.A3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.A3_Verschiebung.TabIndex = 24
        Me.A3_Verschiebung.Text = "0"
        Me.A3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Verschiebung
        '
        Me.H3_Verschiebung.Location = New System.Drawing.Point(195, 3)
        Me.H3_Verschiebung.Name = "H3_Verschiebung"
        Me.H3_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.H3_Verschiebung.TabIndex = 25
        Me.H3_Verschiebung.Text = "0"
        Me.H3_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(6, 217)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(228, 27)
        Me.FlowLayoutPanel7.TabIndex = 169
        '
        'C2_Verschiebung
        '
        Me.C2_Verschiebung.Location = New System.Drawing.Point(3, 3)
        Me.C2_Verschiebung.Name = "C2_Verschiebung"
        Me.C2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.C2_Verschiebung.TabIndex = 19
        Me.C2_Verschiebung.Text = "0"
        Me.C2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2_Verschiebung
        '
        Me.D2_Verschiebung.Location = New System.Drawing.Point(35, 3)
        Me.D2_Verschiebung.Name = "D2_Verschiebung"
        Me.D2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.D2_Verschiebung.TabIndex = 20
        Me.D2_Verschiebung.Text = "0"
        Me.D2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Verschiebung
        '
        Me.E2_Verschiebung.Location = New System.Drawing.Point(67, 3)
        Me.E2_Verschiebung.Name = "E2_Verschiebung"
        Me.E2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.E2_Verschiebung.TabIndex = 21
        Me.E2_Verschiebung.Text = "0"
        Me.E2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Verschiebung
        '
        Me.F2_Verschiebung.Location = New System.Drawing.Point(99, 3)
        Me.F2_Verschiebung.Name = "F2_Verschiebung"
        Me.F2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.F2_Verschiebung.TabIndex = 22
        Me.F2_Verschiebung.Text = "0"
        Me.F2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Verschiebung
        '
        Me.G2_Verschiebung.Location = New System.Drawing.Point(131, 3)
        Me.G2_Verschiebung.Name = "G2_Verschiebung"
        Me.G2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.G2_Verschiebung.TabIndex = 23
        Me.G2_Verschiebung.Text = "0"
        Me.G2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Verschiebung
        '
        Me.A2_Verschiebung.Location = New System.Drawing.Point(163, 3)
        Me.A2_Verschiebung.Name = "A2_Verschiebung"
        Me.A2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.A2_Verschiebung.TabIndex = 24
        Me.A2_Verschiebung.Text = "0"
        Me.A2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Verschiebung
        '
        Me.H2_Verschiebung.Location = New System.Drawing.Point(195, 3)
        Me.H2_Verschiebung.Name = "H2_Verschiebung"
        Me.H2_Verschiebung.Size = New System.Drawing.Size(26, 20)
        Me.H2_Verschiebung.TabIndex = 25
        Me.H2_Verschiebung.Text = "0"
        Me.H2_Verschiebung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 800
        Me.ToolTip1.AutoPopDelay = 30000
        Me.ToolTip1.InitialDelay = 800
        Me.ToolTip1.ReshowDelay = 160
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.META_Copyright_Input)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 194)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(166, 114)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Copyright Eintrag"
        Me.ToolTip1.SetToolTip(Me.GroupBox8, "Copyright Eintrag in den META Tag des MIDI Files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Der Eintrag darf die Länge von " & _
                "255 Zeichen nicht überschreiten!")
        '
        'META_Copyright_Input
        '
        Me.META_Copyright_Input.Location = New System.Drawing.Point(9, 19)
        Me.META_Copyright_Input.MaxLength = 127
        Me.META_Copyright_Input.Multiline = True
        Me.META_Copyright_Input.Name = "META_Copyright_Input"
        Me.META_Copyright_Input.Size = New System.Drawing.Size(142, 83)
        Me.META_Copyright_Input.TabIndex = 2
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.ToolTip_OFF)
        Me.GroupBox17.Controls.Add(Me.ToolTip_ON)
        Me.GroupBox17.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(175, 54)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "ToolTip Hilfe Anzeigen?"
        Me.ToolTip1.SetToolTip(Me.GroupBox17, resources.GetString("GroupBox17.ToolTip"))
        '
        'ToolTip_OFF
        '
        Me.ToolTip_OFF.AutoSize = True
        Me.ToolTip_OFF.Checked = True
        Me.ToolTip_OFF.Location = New System.Drawing.Point(98, 22)
        Me.ToolTip_OFF.Name = "ToolTip_OFF"
        Me.ToolTip_OFF.Size = New System.Drawing.Size(47, 17)
        Me.ToolTip_OFF.TabIndex = 3
        Me.ToolTip_OFF.TabStop = True
        Me.ToolTip_OFF.Text = "Nein"
        Me.ToolTip_OFF.UseVisualStyleBackColor = True
        '
        'ToolTip_ON
        '
        Me.ToolTip_ON.AutoSize = True
        Me.ToolTip_ON.Location = New System.Drawing.Point(23, 22)
        Me.ToolTip_ON.Name = "ToolTip_ON"
        Me.ToolTip_ON.Size = New System.Drawing.Size(36, 17)
        Me.ToolTip_ON.TabIndex = 2
        Me.ToolTip_ON.Text = "Ja"
        Me.ToolTip_ON.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox16)
        Me.GroupBox7.Controls.Add(Me.GroupBox11)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(559, 13)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(195, 454)
        Me.GroupBox7.TabIndex = 172
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Zusatzinformationen (Optional)"
        Me.ToolTip1.SetToolTip(Me.GroupBox7, resources.GetString("GroupBox7.ToolTip"))
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.META_Autor_Input)
        Me.GroupBox16.Location = New System.Drawing.Point(15, 73)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(164, 46)
        Me.GroupBox16.TabIndex = 5
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Autor"
        '
        'META_Autor_Input
        '
        Me.META_Autor_Input.Location = New System.Drawing.Point(12, 17)
        Me.META_Autor_Input.MaxLength = 127
        Me.META_Autor_Input.Name = "META_Autor_Input"
        Me.META_Autor_Input.Size = New System.Drawing.Size(142, 20)
        Me.META_Autor_Input.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.META_Spurnamen_Input)
        Me.GroupBox11.Location = New System.Drawing.Point(14, 129)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(165, 53)
        Me.GroupBox11.TabIndex = 4
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = " Spurnamen"
        '
        'META_Spurnamen_Input
        '
        Me.META_Spurnamen_Input.Location = New System.Drawing.Point(12, 24)
        Me.META_Spurnamen_Input.MaxLength = 127
        Me.META_Spurnamen_Input.Name = "META_Spurnamen_Input"
        Me.META_Spurnamen_Input.Size = New System.Drawing.Size(142, 20)
        Me.META_Spurnamen_Input.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.META_Bemerkung_Input)
        Me.GroupBox9.Location = New System.Drawing.Point(13, 314)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(165, 128)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Bemerkung"
        '
        'META_Bemerkung_Input
        '
        Me.META_Bemerkung_Input.Location = New System.Drawing.Point(10, 26)
        Me.META_Bemerkung_Input.MaxLength = 127
        Me.META_Bemerkung_Input.Multiline = True
        Me.META_Bemerkung_Input.Name = "META_Bemerkung_Input"
        Me.META_Bemerkung_Input.Size = New System.Drawing.Size(142, 88)
        Me.META_Bemerkung_Input.TabIndex = 1
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.META_Dateinamen_Input)
        Me.GroupBox10.Location = New System.Drawing.Point(14, 21)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(165, 46)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Dateinamen (im META)"
        '
        'META_Dateinamen_Input
        '
        Me.META_Dateinamen_Input.Location = New System.Drawing.Point(12, 17)
        Me.META_Dateinamen_Input.MaxLength = 127
        Me.META_Dateinamen_Input.Name = "META_Dateinamen_Input"
        Me.META_Dateinamen_Input.Size = New System.Drawing.Size(142, 20)
        Me.META_Dateinamen_Input.TabIndex = 0
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.FlowLayoutPanel6)
        Me.GroupBox18.Location = New System.Drawing.Point(774, 346)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(457, 120)
        Me.GroupBox18.TabIndex = 184
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Tonart (Klappen)"
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
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(21, 19)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(417, 101)
        Me.FlowLayoutPanel6.TabIndex = 0
        '
        'C1_Klappe
        '
        Me.C1_Klappe.Location = New System.Drawing.Point(3, 3)
        Me.C1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.C1_Klappe.Maximum = 1
        Me.C1_Klappe.Minimum = -1
        Me.C1_Klappe.Name = "C1_Klappe"
        Me.C1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.C1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.C1_Klappe.TabIndex = 183
        Me.C1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'D1_Klappe
        '
        Me.D1_Klappe.Location = New System.Drawing.Point(54, 3)
        Me.D1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.D1_Klappe.Maximum = 1
        Me.D1_Klappe.Minimum = -1
        Me.D1_Klappe.Name = "D1_Klappe"
        Me.D1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.D1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.D1_Klappe.TabIndex = 184
        Me.D1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'E1_Klappe
        '
        Me.E1_Klappe.Location = New System.Drawing.Point(105, 3)
        Me.E1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.E1_Klappe.Maximum = 1
        Me.E1_Klappe.Minimum = -1
        Me.E1_Klappe.Name = "E1_Klappe"
        Me.E1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.E1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.E1_Klappe.TabIndex = 185
        Me.E1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.E1_Klappe.Value = 1
        '
        'F1_Klappe
        '
        Me.F1_Klappe.Location = New System.Drawing.Point(156, 3)
        Me.F1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.F1_Klappe.Maximum = 1
        Me.F1_Klappe.Minimum = -1
        Me.F1_Klappe.Name = "F1_Klappe"
        Me.F1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.F1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.F1_Klappe.TabIndex = 186
        Me.F1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'G1_Klappe
        '
        Me.G1_Klappe.Location = New System.Drawing.Point(207, 3)
        Me.G1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.G1_Klappe.Maximum = 1
        Me.G1_Klappe.Minimum = -1
        Me.G1_Klappe.Name = "G1_Klappe"
        Me.G1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.G1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.G1_Klappe.TabIndex = 187
        Me.G1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'A1_Klappe
        '
        Me.A1_Klappe.Location = New System.Drawing.Point(258, 3)
        Me.A1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.A1_Klappe.Maximum = 1
        Me.A1_Klappe.Minimum = -1
        Me.A1_Klappe.Name = "A1_Klappe"
        Me.A1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.A1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.A1_Klappe.TabIndex = 188
        Me.A1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.A1_Klappe.Value = 1
        '
        'H1_Klappe
        '
        Me.H1_Klappe.Location = New System.Drawing.Point(309, 3)
        Me.H1_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.H1_Klappe.Maximum = 1
        Me.H1_Klappe.Minimum = -1
        Me.H1_Klappe.Name = "H1_Klappe"
        Me.H1_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.H1_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.H1_Klappe.TabIndex = 189
        Me.H1_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.H1_Klappe.Value = 1
        '
        'C2_Klappe
        '
        Me.C2_Klappe.Location = New System.Drawing.Point(360, 3)
        Me.C2_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.C2_Klappe.Maximum = 1
        Me.C2_Klappe.Minimum = -1
        Me.C2_Klappe.Name = "C2_Klappe"
        Me.C2_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.C2_Klappe.Size = New System.Drawing.Size(45, 73)
        Me.C2_Klappe.TabIndex = 197
        Me.C2_Klappe.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'C1_Klappe_Text
        '
        Me.C1_Klappe_Text.Location = New System.Drawing.Point(3, 77)
        Me.C1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.C1_Klappe_Text.Name = "C1_Klappe_Text"
        Me.C1_Klappe_Text.ReadOnly = True
        Me.C1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.C1_Klappe_Text.TabIndex = 190
        Me.C1_Klappe_Text.Text = "c"
        Me.C1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D1_Klappe_Text
        '
        Me.D1_Klappe_Text.Location = New System.Drawing.Point(54, 77)
        Me.D1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.D1_Klappe_Text.Name = "D1_Klappe_Text"
        Me.D1_Klappe_Text.ReadOnly = True
        Me.D1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.D1_Klappe_Text.TabIndex = 198
        Me.D1_Klappe_Text.Text = "d"
        Me.D1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E1_Klappe_Text
        '
        Me.E1_Klappe_Text.Location = New System.Drawing.Point(105, 77)
        Me.E1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.E1_Klappe_Text.Name = "E1_Klappe_Text"
        Me.E1_Klappe_Text.ReadOnly = True
        Me.E1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.E1_Klappe_Text.TabIndex = 199
        Me.E1_Klappe_Text.Text = "e"
        Me.E1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F1_Klappe_Text
        '
        Me.F1_Klappe_Text.Location = New System.Drawing.Point(156, 77)
        Me.F1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.F1_Klappe_Text.Name = "F1_Klappe_Text"
        Me.F1_Klappe_Text.ReadOnly = True
        Me.F1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.F1_Klappe_Text.TabIndex = 200
        Me.F1_Klappe_Text.Text = "f"
        Me.F1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G1_Klappe_Text
        '
        Me.G1_Klappe_Text.Location = New System.Drawing.Point(207, 77)
        Me.G1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.G1_Klappe_Text.Name = "G1_Klappe_Text"
        Me.G1_Klappe_Text.ReadOnly = True
        Me.G1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.G1_Klappe_Text.TabIndex = 201
        Me.G1_Klappe_Text.Text = "g"
        Me.G1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A1_Klappe_Text
        '
        Me.A1_Klappe_Text.Location = New System.Drawing.Point(258, 77)
        Me.A1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.A1_Klappe_Text.Name = "A1_Klappe_Text"
        Me.A1_Klappe_Text.ReadOnly = True
        Me.A1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.A1_Klappe_Text.TabIndex = 202
        Me.A1_Klappe_Text.Text = "a"
        Me.A1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H1_Klappe_Text
        '
        Me.H1_Klappe_Text.Location = New System.Drawing.Point(309, 77)
        Me.H1_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.H1_Klappe_Text.Name = "H1_Klappe_Text"
        Me.H1_Klappe_Text.ReadOnly = True
        Me.H1_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.H1_Klappe_Text.TabIndex = 203
        Me.H1_Klappe_Text.Text = "h"
        Me.H1_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C2_Klappe_Text
        '
        Me.C2_Klappe_Text.Location = New System.Drawing.Point(360, 77)
        Me.C2_Klappe_Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.C2_Klappe_Text.Name = "C2_Klappe_Text"
        Me.C2_Klappe_Text.ReadOnly = True
        Me.C2_Klappe_Text.Size = New System.Drawing.Size(45, 20)
        Me.C2_Klappe_Text.TabIndex = 204
        Me.C2_Klappe_Text.Text = "c"
        Me.C2_Klappe_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Button37)
        Me.GroupBox14.Controls.Add(Me.Button36)
        Me.GroupBox14.Controls.Add(Me.GroupBox17)
        Me.GroupBox14.Location = New System.Drawing.Point(1016, 18)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(215, 202)
        Me.GroupBox14.TabIndex = 185
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Programmeinstellungen"
        '
        'Button37
        '
        Me.Button37.Location = New System.Drawing.Point(22, 149)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(175, 43)
        Me.Button37.TabIndex = 2
        Me.Button37.Text = "Über"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button36
        '
        Me.Button36.Location = New System.Drawing.Point(22, 91)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(175, 43)
        Me.Button36.TabIndex = 1
        Me.Button36.Text = "Hilfe"
        Me.Button36.UseVisualStyleBackColor = True
        '
        'Com_Search_Timer
        '
        Me.Com_Search_Timer.Enabled = True
        Me.Com_Search_Timer.Interval = 2000
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1237, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.GroupBox12)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Location = New System.Drawing.Point(776, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(221, 202)
        Me.GroupBox6.TabIndex = 167
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Direct Play"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox12.Controls.Add(Me.Label11)
        Me.GroupBox12.Controls.Add(Me.Label15)
        Me.GroupBox12.Controls.Add(Me.hsbVolume)
        Me.GroupBox12.Controls.Add(Me.Label14)
        Me.GroupBox12.Controls.Add(Me.hsbPan)
        Me.GroupBox12.Controls.Add(Me.hsbModWheel)
        Me.GroupBox12.Location = New System.Drawing.Point(10, 83)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(200, 109)
        Me.GroupBox12.TabIndex = 174
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Einstellungen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Volume:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Efeckt:"
        '
        'hsbVolume
        '
        Me.hsbVolume.Location = New System.Drawing.Point(72, 22)
        Me.hsbVolume.Maximum = 127
        Me.hsbVolume.Name = "hsbVolume"
        Me.hsbVolume.Size = New System.Drawing.Size(115, 17)
        Me.hsbVolume.TabIndex = 6
        Me.hsbVolume.Value = 127
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Balance:"
        '
        'hsbPan
        '
        Me.hsbPan.Location = New System.Drawing.Point(72, 51)
        Me.hsbPan.Name = "hsbPan"
        Me.hsbPan.Size = New System.Drawing.Size(115, 17)
        Me.hsbPan.TabIndex = 172
        Me.hsbPan.Value = 50
        '
        'hsbModWheel
        '
        Me.hsbModWheel.Location = New System.Drawing.Point(74, 80)
        Me.hsbModWheel.Maximum = 255
        Me.hsbModWheel.Name = "hsbModWheel"
        Me.hsbModWheel.Size = New System.Drawing.Size(115, 17)
        Me.hsbModWheel.TabIndex = 172
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DirectPlay_OFF)
        Me.GroupBox5.Controls.Add(Me.DirectPlay_ON)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(199, 56)
        Me.GroupBox5.TabIndex = 163
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Empfangende Noten abspielen"
        '
        'DirectPlay_OFF
        '
        Me.DirectPlay_OFF.AutoSize = True
        Me.DirectPlay_OFF.Checked = True
        Me.DirectPlay_OFF.Location = New System.Drawing.Point(115, 26)
        Me.DirectPlay_OFF.Name = "DirectPlay_OFF"
        Me.DirectPlay_OFF.Size = New System.Drawing.Size(47, 17)
        Me.DirectPlay_OFF.TabIndex = 1
        Me.DirectPlay_OFF.TabStop = True
        Me.DirectPlay_OFF.Text = "Nein"
        Me.DirectPlay_OFF.UseVisualStyleBackColor = True
        '
        'DirectPlay_ON
        '
        Me.DirectPlay_ON.AutoSize = True
        Me.DirectPlay_ON.Location = New System.Drawing.Point(31, 26)
        Me.DirectPlay_ON.Name = "DirectPlay_ON"
        Me.DirectPlay_ON.Size = New System.Drawing.Size(36, 17)
        Me.DirectPlay_ON.TabIndex = 0
        Me.DirectPlay_ON.Text = "Ja"
        Me.DirectPlay_ON.UseVisualStyleBackColor = True
        '
        'C_Klappe
        '
        Me.C_Klappe.Location = New System.Drawing.Point(3, 3)
        Me.C_Klappe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.C_Klappe.Maximum = 1
        Me.C_Klappe.Minimum = -1
        Me.C_Klappe.Name = "C_Klappe"
        Me.C_Klappe.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.C_Klappe.Size = New System.Drawing.Size(45, 73)
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
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.TextBox2)
        Me.GroupBox15.Controls.Add(Me.TextBox1)
        Me.GroupBox15.Controls.Add(Me.Save_Tastenkombination)
        Me.GroupBox15.Controls.Add(Me.Pause_Tastenkombination)
        Me.GroupBox15.Controls.Add(Me.Start_Tastenkombination)
        Me.GroupBox15.Controls.Add(Me.GroupBox20)
        Me.GroupBox15.Controls.Add(Me.TextBox4)
        Me.GroupBox15.Controls.Add(Me.TextBox5)
        Me.GroupBox15.Controls.Add(Me.TextBox6)
        Me.GroupBox15.Controls.Add(Me.Label7)
        Me.GroupBox15.Controls.Add(Me.Label8)
        Me.GroupBox15.Controls.Add(Me.Label9)
        Me.GroupBox15.Controls.Add(Me.Save_Label)
        Me.GroupBox15.Controls.Add(Me.Pause_Label)
        Me.GroupBox15.Controls.Add(Me.Start_Label)
        Me.GroupBox15.Location = New System.Drawing.Point(776, 232)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(456, 106)
        Me.GroupBox15.TabIndex = 187
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Tastenkonbinationen (Hintergrundssteuerung)"
        Me.ToolTip1.SetToolTip(Me.GroupBox15, resources.GetString("GroupBox15.ToolTip"))
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(254, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(58, 20)
        Me.TextBox2.TabIndex = 192
        Me.TextBox2.Text = "Alt + F4"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(281, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(31, 20)
        Me.TextBox1.TabIndex = 191
        Me.TextBox1.Text = "+"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save_Tastenkombination
        '
        Me.Save_Tastenkombination.Location = New System.Drawing.Point(52, 72)
        Me.Save_Tastenkombination.Name = "Save_Tastenkombination"
        Me.Save_Tastenkombination.Size = New System.Drawing.Size(117, 21)
        Me.Save_Tastenkombination.TabIndex = 190
        Me.Save_Tastenkombination.Text = "F9"
        Me.Save_Tastenkombination.UseVisualStyleBackColor = True
        '
        'Pause_Tastenkombination
        '
        Me.Pause_Tastenkombination.Location = New System.Drawing.Point(52, 45)
        Me.Pause_Tastenkombination.Name = "Pause_Tastenkombination"
        Me.Pause_Tastenkombination.Size = New System.Drawing.Size(117, 21)
        Me.Pause_Tastenkombination.TabIndex = 189
        Me.Pause_Tastenkombination.Text = "Leert."
        Me.Pause_Tastenkombination.UseVisualStyleBackColor = True
        '
        'Start_Tastenkombination
        '
        Me.Start_Tastenkombination.Location = New System.Drawing.Point(52, 19)
        Me.Start_Tastenkombination.Name = "Start_Tastenkombination"
        Me.Start_Tastenkombination.Size = New System.Drawing.Size(117, 21)
        Me.Start_Tastenkombination.TabIndex = 188
        Me.Start_Tastenkombination.Text = "F9"
        Me.Start_Tastenkombination.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.TextBox9)
        Me.GroupBox20.Controls.Add(Me.TextBox8)
        Me.GroupBox20.Location = New System.Drawing.Point(326, 17)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(124, 76)
        Me.GroupBox20.TabIndex = 12
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Klappen"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(6, 45)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(108, 20)
        Me.TextBox9.TabIndex = 1
        Me.TextBox9.Text = "●   a-h + up / down"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(6, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(108, 20)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.Text = "●   1-8 + up / down"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(212, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(36, 20)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.Text = "Esc"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(240, 46)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "Ctrl + M"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(240, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(31, 20)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Text = "-"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Exit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Metronom:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(179, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Volume:"
        '
        'Save_Label
        '
        Me.Save_Label.AutoSize = True
        Me.Save_Label.Location = New System.Drawing.Point(6, 76)
        Me.Save_Label.Name = "Save_Label"
        Me.Save_Label.Size = New System.Drawing.Size(35, 13)
        Me.Save_Label.TabIndex = 2
        Me.Save_Label.Text = "Save:"
        '
        'Pause_Label
        '
        Me.Pause_Label.AutoSize = True
        Me.Pause_Label.Location = New System.Drawing.Point(6, 49)
        Me.Pause_Label.Name = "Pause_Label"
        Me.Pause_Label.Size = New System.Drawing.Size(40, 13)
        Me.Pause_Label.TabIndex = 1
        Me.Pause_Label.Text = "Pause:"
        '
        'Start_Label
        '
        Me.Start_Label.AutoSize = True
        Me.Start_Label.Location = New System.Drawing.Point(6, 23)
        Me.Start_Label.Name = "Start_Label"
        Me.Start_Label.Size = New System.Drawing.Size(32, 13)
        Me.Start_Label.TabIndex = 0
        Me.Start_Label.Text = "Start:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'C2_VerticalProgessBar
        '
        Me.C2_VerticalProgessBar.AccessibleName = ""
        Me.C2_VerticalProgessBar.Location = New System.Drawing.Point(3, 3)
        Me.C2_VerticalProgessBar.Maximum = 255
        Me.C2_VerticalProgessBar.Name = "C2_VerticalProgessBar"
        Me.C2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.C2_VerticalProgessBar.TabIndex = 3
        '
        'D2_VerticalProgessBar
        '
        Me.D2_VerticalProgessBar.Location = New System.Drawing.Point(35, 3)
        Me.D2_VerticalProgessBar.Maximum = 255
        Me.D2_VerticalProgessBar.Name = "D2_VerticalProgessBar"
        Me.D2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.D2_VerticalProgessBar.TabIndex = 4
        '
        'E2_VerticalProgessBar
        '
        Me.E2_VerticalProgessBar.Location = New System.Drawing.Point(67, 3)
        Me.E2_VerticalProgessBar.Maximum = 255
        Me.E2_VerticalProgessBar.Name = "E2_VerticalProgessBar"
        Me.E2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.E2_VerticalProgessBar.TabIndex = 5
        '
        'F2_VerticalProgessBar
        '
        Me.F2_VerticalProgessBar.Location = New System.Drawing.Point(99, 3)
        Me.F2_VerticalProgessBar.Maximum = 255
        Me.F2_VerticalProgessBar.Name = "F2_VerticalProgessBar"
        Me.F2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.F2_VerticalProgessBar.TabIndex = 6
        '
        'G2_VerticalProgessBar
        '
        Me.G2_VerticalProgessBar.Location = New System.Drawing.Point(131, 3)
        Me.G2_VerticalProgessBar.Maximum = 255
        Me.G2_VerticalProgessBar.Name = "G2_VerticalProgessBar"
        Me.G2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.G2_VerticalProgessBar.TabIndex = 7
        '
        'A2_VerticalProgessBar
        '
        Me.A2_VerticalProgessBar.Location = New System.Drawing.Point(163, 3)
        Me.A2_VerticalProgessBar.Maximum = 255
        Me.A2_VerticalProgessBar.Name = "A2_VerticalProgessBar"
        Me.A2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.A2_VerticalProgessBar.TabIndex = 8
        '
        'H2_VerticalProgessBar
        '
        Me.H2_VerticalProgessBar.Location = New System.Drawing.Point(195, 3)
        Me.H2_VerticalProgessBar.Maximum = 255
        Me.H2_VerticalProgessBar.Name = "H2_VerticalProgessBar"
        Me.H2_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.H2_VerticalProgessBar.TabIndex = 9
        '
        'C3_VerticalProgessBar
        '
        Me.C3_VerticalProgessBar.AccessibleName = ""
        Me.C3_VerticalProgessBar.Location = New System.Drawing.Point(3, 3)
        Me.C3_VerticalProgessBar.Maximum = 255
        Me.C3_VerticalProgessBar.Name = "C3_VerticalProgessBar"
        Me.C3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.C3_VerticalProgessBar.TabIndex = 186
        '
        'D3_VerticalProgessBar
        '
        Me.D3_VerticalProgessBar.Location = New System.Drawing.Point(35, 3)
        Me.D3_VerticalProgessBar.Maximum = 255
        Me.D3_VerticalProgessBar.Name = "D3_VerticalProgessBar"
        Me.D3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.D3_VerticalProgessBar.TabIndex = 187
        '
        'E3_VerticalProgessBar
        '
        Me.E3_VerticalProgessBar.Location = New System.Drawing.Point(67, 3)
        Me.E3_VerticalProgessBar.Maximum = 255
        Me.E3_VerticalProgessBar.Name = "E3_VerticalProgessBar"
        Me.E3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.E3_VerticalProgessBar.TabIndex = 188
        '
        'F3_VerticalProgessBar
        '
        Me.F3_VerticalProgessBar.Location = New System.Drawing.Point(99, 3)
        Me.F3_VerticalProgessBar.Maximum = 255
        Me.F3_VerticalProgessBar.Name = "F3_VerticalProgessBar"
        Me.F3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.F3_VerticalProgessBar.TabIndex = 189
        '
        'G3_VerticalProgessBar
        '
        Me.G3_VerticalProgessBar.Location = New System.Drawing.Point(131, 3)
        Me.G3_VerticalProgessBar.Maximum = 255
        Me.G3_VerticalProgessBar.Name = "G3_VerticalProgessBar"
        Me.G3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.G3_VerticalProgessBar.TabIndex = 190
        '
        'A3_VerticalProgessBar
        '
        Me.A3_VerticalProgessBar.Location = New System.Drawing.Point(163, 3)
        Me.A3_VerticalProgessBar.Maximum = 255
        Me.A3_VerticalProgessBar.Name = "A3_VerticalProgessBar"
        Me.A3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.A3_VerticalProgessBar.TabIndex = 191
        '
        'H3_VerticalProgessBar
        '
        Me.H3_VerticalProgessBar.Location = New System.Drawing.Point(195, 3)
        Me.H3_VerticalProgessBar.Maximum = 255
        Me.H3_VerticalProgessBar.Name = "H3_VerticalProgessBar"
        Me.H3_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.H3_VerticalProgessBar.TabIndex = 192
        '
        'C4_VerticalProgessBar
        '
        Me.C4_VerticalProgessBar.Location = New System.Drawing.Point(3, 3)
        Me.C4_VerticalProgessBar.Maximum = 255
        Me.C4_VerticalProgessBar.Name = "C4_VerticalProgessBar"
        Me.C4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.C4_VerticalProgessBar.TabIndex = 3
        '
        'D4_VerticalProgessBar
        '
        Me.D4_VerticalProgessBar.Location = New System.Drawing.Point(35, 3)
        Me.D4_VerticalProgessBar.Maximum = 255
        Me.D4_VerticalProgessBar.Name = "D4_VerticalProgessBar"
        Me.D4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.D4_VerticalProgessBar.TabIndex = 4
        '
        'E4_VerticalProgessBar
        '
        Me.E4_VerticalProgessBar.Location = New System.Drawing.Point(67, 3)
        Me.E4_VerticalProgessBar.Maximum = 255
        Me.E4_VerticalProgessBar.Name = "E4_VerticalProgessBar"
        Me.E4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.E4_VerticalProgessBar.TabIndex = 5
        '
        'F4_VerticalProgessBar
        '
        Me.F4_VerticalProgessBar.Location = New System.Drawing.Point(99, 3)
        Me.F4_VerticalProgessBar.Maximum = 255
        Me.F4_VerticalProgessBar.Name = "F4_VerticalProgessBar"
        Me.F4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.F4_VerticalProgessBar.TabIndex = 6
        '
        'G4_VerticalProgessBar
        '
        Me.G4_VerticalProgessBar.Location = New System.Drawing.Point(131, 3)
        Me.G4_VerticalProgessBar.Maximum = 255
        Me.G4_VerticalProgessBar.Name = "G4_VerticalProgessBar"
        Me.G4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.G4_VerticalProgessBar.TabIndex = 7
        '
        'A4_VerticalProgessBar
        '
        Me.A4_VerticalProgessBar.Location = New System.Drawing.Point(163, 3)
        Me.A4_VerticalProgessBar.Maximum = 255
        Me.A4_VerticalProgessBar.Name = "A4_VerticalProgessBar"
        Me.A4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.A4_VerticalProgessBar.TabIndex = 8
        '
        'H4_VerticalProgessBar
        '
        Me.H4_VerticalProgessBar.Location = New System.Drawing.Point(195, 3)
        Me.H4_VerticalProgessBar.Maximum = 255
        Me.H4_VerticalProgessBar.Name = "H4_VerticalProgessBar"
        Me.H4_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.H4_VerticalProgessBar.TabIndex = 9
        '
        'C5_VerticalProgessBar
        '
        Me.C5_VerticalProgessBar.Location = New System.Drawing.Point(3, 3)
        Me.C5_VerticalProgessBar.Maximum = 255
        Me.C5_VerticalProgessBar.Name = "C5_VerticalProgessBar"
        Me.C5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.C5_VerticalProgessBar.TabIndex = 3
        '
        'D5_VerticalProgessBar
        '
        Me.D5_VerticalProgessBar.Location = New System.Drawing.Point(35, 3)
        Me.D5_VerticalProgessBar.Maximum = 255
        Me.D5_VerticalProgessBar.Name = "D5_VerticalProgessBar"
        Me.D5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.D5_VerticalProgessBar.TabIndex = 4
        '
        'E5_VerticalProgessBar
        '
        Me.E5_VerticalProgessBar.Location = New System.Drawing.Point(67, 3)
        Me.E5_VerticalProgessBar.Maximum = 255
        Me.E5_VerticalProgessBar.Name = "E5_VerticalProgessBar"
        Me.E5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.E5_VerticalProgessBar.TabIndex = 5
        '
        'F5_VerticalProgessBar
        '
        Me.F5_VerticalProgessBar.Location = New System.Drawing.Point(99, 3)
        Me.F5_VerticalProgessBar.Maximum = 255
        Me.F5_VerticalProgessBar.Name = "F5_VerticalProgessBar"
        Me.F5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.F5_VerticalProgessBar.TabIndex = 6
        '
        'G5_VerticalProgessBar
        '
        Me.G5_VerticalProgessBar.Location = New System.Drawing.Point(131, 3)
        Me.G5_VerticalProgessBar.Maximum = 255
        Me.G5_VerticalProgessBar.Name = "G5_VerticalProgessBar"
        Me.G5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.G5_VerticalProgessBar.TabIndex = 7
        '
        'A5_VerticalProgessBar
        '
        Me.A5_VerticalProgessBar.Location = New System.Drawing.Point(163, 3)
        Me.A5_VerticalProgessBar.Maximum = 255
        Me.A5_VerticalProgessBar.Name = "A5_VerticalProgessBar"
        Me.A5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.A5_VerticalProgessBar.TabIndex = 8
        '
        'H5_VerticalProgessBar
        '
        Me.H5_VerticalProgessBar.Location = New System.Drawing.Point(195, 3)
        Me.H5_VerticalProgessBar.Maximum = 255
        Me.H5_VerticalProgessBar.Name = "H5_VerticalProgessBar"
        Me.H5_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.H5_VerticalProgessBar.TabIndex = 9
        '
        'C6_VerticalProgessBar
        '
        Me.C6_VerticalProgessBar.Location = New System.Drawing.Point(3, 3)
        Me.C6_VerticalProgessBar.Maximum = 255
        Me.C6_VerticalProgessBar.Name = "C6_VerticalProgessBar"
        Me.C6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.C6_VerticalProgessBar.TabIndex = 3
        '
        'D6_VerticalProgessBar
        '
        Me.D6_VerticalProgessBar.Location = New System.Drawing.Point(35, 3)
        Me.D6_VerticalProgessBar.Maximum = 255
        Me.D6_VerticalProgessBar.Name = "D6_VerticalProgessBar"
        Me.D6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.D6_VerticalProgessBar.TabIndex = 4
        '
        'E6_VerticalProgessBar
        '
        Me.E6_VerticalProgessBar.Location = New System.Drawing.Point(67, 3)
        Me.E6_VerticalProgessBar.Maximum = 255
        Me.E6_VerticalProgessBar.Name = "E6_VerticalProgessBar"
        Me.E6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.E6_VerticalProgessBar.TabIndex = 5
        '
        'F6_VerticalProgessBar
        '
        Me.F6_VerticalProgessBar.Location = New System.Drawing.Point(99, 3)
        Me.F6_VerticalProgessBar.Maximum = 255
        Me.F6_VerticalProgessBar.Name = "F6_VerticalProgessBar"
        Me.F6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.F6_VerticalProgessBar.TabIndex = 6
        '
        'G6_VerticalProgessBar
        '
        Me.G6_VerticalProgessBar.Location = New System.Drawing.Point(131, 3)
        Me.G6_VerticalProgessBar.Maximum = 255
        Me.G6_VerticalProgessBar.Name = "G6_VerticalProgessBar"
        Me.G6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.G6_VerticalProgessBar.TabIndex = 7
        '
        'A6_VerticalProgessBar
        '
        Me.A6_VerticalProgessBar.Location = New System.Drawing.Point(163, 3)
        Me.A6_VerticalProgessBar.Maximum = 255
        Me.A6_VerticalProgessBar.Name = "A6_VerticalProgessBar"
        Me.A6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.A6_VerticalProgessBar.TabIndex = 8
        '
        'H6_VerticalProgessBar
        '
        Me.H6_VerticalProgessBar.Location = New System.Drawing.Point(195, 3)
        Me.H6_VerticalProgessBar.Maximum = 255
        Me.H6_VerticalProgessBar.Name = "H6_VerticalProgessBar"
        Me.H6_VerticalProgessBar.Size = New System.Drawing.Size(26, 97)
        Me.H6_VerticalProgessBar.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 771)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox18)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Einstellungen_GroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIDI Harfe V0.1 alpha Build 60"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.Einstellungen_GroupBox.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Messintervall_GroupBox.ResumeLayout(False)
        Me.Messintervall_GroupBox.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Tempo_GroupBox.ResumeLayout(False)
        Me.Tempo_GroupBox.PerformLayout()
        CType(Me.Tackt_Naenner_Input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tackt_Zaehler_Input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Transpose_GroupBox.ResumeLayout(False)
        Me.Transpose_GroupBox.PerformLayout()
        CType(Me.Halbtonverschiebung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.FlowLayoutPanel11.ResumeLayout(False)
        Me.FlowLayoutPanel11.PerformLayout()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel10.PerformLayout()
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.FlowLayoutPanel9.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
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
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.C_Klappe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_Comport As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Disconnect As System.Windows.Forms.Button
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents D2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H4_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H5_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H6_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents C2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H2_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H3_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H4_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H5_Wert As System.Windows.Forms.TextBox
    Friend WithEvents C6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents D6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents E6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents F6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents G6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents A6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents H6_Wert As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents C2_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents MIDI_Save_Button As System.Windows.Forms.Button
    Public WithEvents SaveMIDIDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Einstellungen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MIDI_Start_Button As System.Windows.Forms.Button
    Friend WithEvents Tackt As System.Windows.Forms.Timer
    Friend WithEvents Tackt_Ausgabefenster As System.Windows.Forms.Label
    Friend WithEvents D2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents E2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents F2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents G2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents A2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents H2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents C3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents D3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents E3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents F3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents G3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents A3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents H3_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents C4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents D4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents E4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents F4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents G4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents A4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents H4_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents C5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents D5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents E5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents F5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents G5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents A5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents H5_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents C6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents D6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents E6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents F6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents G6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents A6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents H6_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Halbtonverschiebung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Oktavenverschiebung As System.Windows.Forms.ComboBox
    Friend WithEvents Transpose_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MIDI_Pause_Button As System.Windows.Forms.Button
    Friend WithEvents cboInstruments As System.Windows.Forms.ComboBox
    Friend WithEvents Tempo_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Tackt_Naenner_Input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Tackt_Zaehler_Input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BPM_Label As System.Windows.Forms.Label
    Friend WithEvents BPM As System.Windows.Forms.NumericUpDown
    Friend WithEvents C2_Button As System.Windows.Forms.Button
    Friend WithEvents D2_Button As System.Windows.Forms.Button
    Friend WithEvents E2_Button As System.Windows.Forms.Button
    Friend WithEvents F2_Button As System.Windows.Forms.Button
    Friend WithEvents G2_Button As System.Windows.Forms.Button
    Friend WithEvents A2_Button As System.Windows.Forms.Button
    Friend WithEvents H2_Button As System.Windows.Forms.Button
    Friend WithEvents C3_Button As System.Windows.Forms.Button
    Friend WithEvents D3_Button As System.Windows.Forms.Button
    Friend WithEvents E3_Button As System.Windows.Forms.Button
    Friend WithEvents F3_Button As System.Windows.Forms.Button
    Friend WithEvents G3_Button As System.Windows.Forms.Button
    Friend WithEvents A3_Button As System.Windows.Forms.Button
    Friend WithEvents H3_Button As System.Windows.Forms.Button
    Friend WithEvents C4_Button As System.Windows.Forms.Button
    Friend WithEvents D4_Button As System.Windows.Forms.Button
    Friend WithEvents E4_Button As System.Windows.Forms.Button
    Friend WithEvents F4_Button As System.Windows.Forms.Button
    Friend WithEvents G4_Button As System.Windows.Forms.Button
    Friend WithEvents A4_Button As System.Windows.Forms.Button
    Friend WithEvents H4_Button As System.Windows.Forms.Button
    Friend WithEvents C5_Button As System.Windows.Forms.Button
    Friend WithEvents D5_Button As System.Windows.Forms.Button
    Friend WithEvents E5_Button As System.Windows.Forms.Button
    Friend WithEvents F5_Button As System.Windows.Forms.Button
    Friend WithEvents G5_Button As System.Windows.Forms.Button
    Friend WithEvents A5_Button As System.Windows.Forms.Button
    Friend WithEvents H5_Button As System.Windows.Forms.Button
    Friend WithEvents C6_Button As System.Windows.Forms.Button
    Friend WithEvents D6_Button As System.Windows.Forms.Button
    Friend WithEvents E6_Button As System.Windows.Forms.Button
    Friend WithEvents F6_Button As System.Windows.Forms.Button
    Friend WithEvents G6_Button As System.Windows.Forms.Button
    Friend WithEvents A6_Button As System.Windows.Forms.Button
    Friend WithEvents H6_Button As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Spurnamen_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Bemerkung_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Dateinamen_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Copyright_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents E1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents F1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents G1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents A1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents H1_Klappe As System.Windows.Forms.TrackBar
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
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Metronom_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents Metronom_ON As System.Windows.Forms.RadioButton
    Friend WithEvents Metronom_Betont As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip_ON As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Autor_Input As System.Windows.Forms.TextBox
    Private WithEvents C3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents D3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents E3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents F3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents G3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents A3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents H3_VerticalProgessBar As MIDI_Harfe.MTech010VerticalProgessBar
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents MIDI_SpecialMode As System.Windows.Forms.RadioButton
    Friend WithEvents MIDI_NormalMode As System.Windows.Forms.RadioButton
    Friend WithEvents Com_Search_Timer As System.Windows.Forms.Timer
    Friend WithEvents Messintervall_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents hsbModWheel As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbPan As System.Windows.Forms.HScrollBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DirectPlay_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents DirectPlay_ON As System.Windows.Forms.RadioButton
    Friend WithEvents hsbVolume As System.Windows.Forms.HScrollBar
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents D1_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents C2_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents C1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents D1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents E1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents F1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents G1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents A1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents H1_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents C2_Klappe_Text As System.Windows.Forms.TextBox
    Friend WithEvents C_Klappe As System.Windows.Forms.TrackBar
    Friend WithEvents C2_Grenzwert As System.Windows.Forms.TextBox
    Friend WithEvents Serial_BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents AnzMessungen As System.Windows.Forms.TextBox
    Friend WithEvents AnzMessfehler As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Mesgeschwindigkeitsberechnung_Timer As System.Windows.Forms.Timer
    Friend WithEvents MessungenProS_TexBox As System.Windows.Forms.TextBox
    Friend WithEvents Messintervall_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Save_Label As System.Windows.Forms.Label
    Friend WithEvents Pause_Label As System.Windows.Forms.Label
    Friend WithEvents Start_Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Save_Tastenkombination As System.Windows.Forms.Button
    Friend WithEvents Pause_Tastenkombination As System.Windows.Forms.Button
    Friend WithEvents Start_Tastenkombination As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
