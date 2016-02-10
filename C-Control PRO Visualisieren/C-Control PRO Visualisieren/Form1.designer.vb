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
        Me.MIDI_Pausieren = New System.Windows.Forms.Button()
        Me.Tackt_Ausgabefenster = New System.Windows.Forms.Label()
        Me.MIDI_Start = New System.Windows.Forms.Button()
        Me.MIDI_Save = New System.Windows.Forms.Button()
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
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
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
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
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
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.SaveMIDIDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Einstellungen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Messintervall_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MessungenProS_NumericUpDown = New System.Windows.Forms.NumericUpDown()
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BPM = New System.Windows.Forms.NumericUpDown()
        Me.Transpose_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Notenverschiebung = New System.Windows.Forms.NumericUpDown()
        Me.Oktavenverschiebung = New System.Windows.Forms.ComboBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Tackt = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.NoteC = New System.Windows.Forms.Button()
        Me.Messintervall = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox103 = New System.Windows.Forms.TextBox()
        Me.TextBox104 = New System.Windows.Forms.TextBox()
        Me.TextBox105 = New System.Windows.Forms.TextBox()
        Me.TextBox106 = New System.Windows.Forms.TextBox()
        Me.TextBox107 = New System.Windows.Forms.TextBox()
        Me.TextBox108 = New System.Windows.Forms.TextBox()
        Me.TextBox109 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox96 = New System.Windows.Forms.TextBox()
        Me.TextBox97 = New System.Windows.Forms.TextBox()
        Me.TextBox98 = New System.Windows.Forms.TextBox()
        Me.TextBox99 = New System.Windows.Forms.TextBox()
        Me.TextBox100 = New System.Windows.Forms.TextBox()
        Me.TextBox101 = New System.Windows.Forms.TextBox()
        Me.TextBox102 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox89 = New System.Windows.Forms.TextBox()
        Me.TextBox90 = New System.Windows.Forms.TextBox()
        Me.TextBox91 = New System.Windows.Forms.TextBox()
        Me.TextBox92 = New System.Windows.Forms.TextBox()
        Me.TextBox93 = New System.Windows.Forms.TextBox()
        Me.TextBox94 = New System.Windows.Forms.TextBox()
        Me.TextBox95 = New System.Windows.Forms.TextBox()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnStopNoteAbove = New System.Windows.Forms.Button()
        Me.btnPlay1Note = New System.Windows.Forms.Button()
        Me.lblClickMe = New System.Windows.Forms.Label()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.META_SpurnamenLH_Input = New System.Windows.Forms.TextBox()
        Me.META_SpurnamenRH_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.META_Bemerkung_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.META_Dateiname_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar7 = New System.Windows.Forms.TrackBar()
        Me.TrackBar8 = New System.Windows.Forms.TrackBar()
        Me.TrackBar9 = New System.Windows.Forms.TrackBar()
        Me.TrackBar10 = New System.Windows.Forms.TrackBar()
        Me.TrackBar11 = New System.Windows.Forms.TrackBar()
        Me.TrackBar12 = New System.Windows.Forms.TrackBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.hsbModWheel = New System.Windows.Forms.HScrollBar()
        Me.hsbPan = New System.Windows.Forms.HScrollBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.hsbVolume = New System.Windows.Forms.HScrollBar()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Com_Search_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.C2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.D2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.E2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.F2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.G2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.A2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.H2_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.C3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.D3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.E3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.F3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.G3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.A3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.H3_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.C4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.D4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.E4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.F4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.G4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.A4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.H4_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.C5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.D5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.E5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.F5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.G5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.A5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.H5_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.C6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.D6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.E6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.F6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.G6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.A6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.H6_VerticalProgessBar = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.Einstellungen_GroupBox.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        CType(Me.Messintervall_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessungenProS_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Tempo_GroupBox.SuspendLayout()
        CType(Me.Tackt_Naenner_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tackt_Zaehler_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Transpose_GroupBox.SuspendLayout()
        CType(Me.Notenverschiebung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
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
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.DtrEnable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MIDI_Pausieren)
        Me.GroupBox2.Controls.Add(Me.Tackt_Ausgabefenster)
        Me.GroupBox2.Controls.Add(Me.MIDI_Start)
        Me.GroupBox2.Controls.Add(Me.MIDI_Save)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 359)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausgabe"
        '
        'MIDI_Pausieren
        '
        Me.MIDI_Pausieren.Enabled = False
        Me.MIDI_Pausieren.Location = New System.Drawing.Point(6, 213)
        Me.MIDI_Pausieren.Name = "MIDI_Pausieren"
        Me.MIDI_Pausieren.Size = New System.Drawing.Size(288, 58)
        Me.MIDI_Pausieren.TabIndex = 23
        Me.MIDI_Pausieren.Text = "Aufnahme pausieren"
        Me.MIDI_Pausieren.UseVisualStyleBackColor = True
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
        'MIDI_Start
        '
        Me.MIDI_Start.Location = New System.Drawing.Point(6, 141)
        Me.MIDI_Start.Name = "MIDI_Start"
        Me.MIDI_Start.Size = New System.Drawing.Size(288, 60)
        Me.MIDI_Start.TabIndex = 22
        Me.MIDI_Start.Text = "Aufnahme starten"
        Me.MIDI_Start.UseVisualStyleBackColor = True
        '
        'MIDI_Save
        '
        Me.MIDI_Save.Enabled = False
        Me.MIDI_Save.Location = New System.Drawing.Point(6, 284)
        Me.MIDI_Save.Name = "MIDI_Save"
        Me.MIDI_Save.Size = New System.Drawing.Size(288, 58)
        Me.MIDI_Save.TabIndex = 11
        Me.MIDI_Save.Text = "Aufnahme speichern"
        Me.MIDI_Save.UseVisualStyleBackColor = True
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
        Me.D2_Grenzwert.Name = "D2_Grenzwert"
        Me.D2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D2_Grenzwert.TabIndex = 19
        Me.D2_Grenzwert.Text = "200"
        Me.D2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E2_Grenzwert
        '
        Me.E2_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E2_Grenzwert.Name = "E2_Grenzwert"
        Me.E2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E2_Grenzwert.TabIndex = 20
        Me.E2_Grenzwert.Text = "200"
        Me.E2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F2_Grenzwert
        '
        Me.F2_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F2_Grenzwert.Name = "F2_Grenzwert"
        Me.F2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F2_Grenzwert.TabIndex = 21
        Me.F2_Grenzwert.Text = "200"
        Me.F2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G2_Grenzwert
        '
        Me.G2_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G2_Grenzwert.Name = "G2_Grenzwert"
        Me.G2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G2_Grenzwert.TabIndex = 22
        Me.G2_Grenzwert.Text = "200"
        Me.G2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2_Grenzwert
        '
        Me.A2_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A2_Grenzwert.Name = "A2_Grenzwert"
        Me.A2_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A2_Grenzwert.TabIndex = 23
        Me.A2_Grenzwert.Text = "200"
        Me.A2_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H2_Grenzwert
        '
        Me.H2_Grenzwert.Location = New System.Drawing.Point(195, 161)
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
        Me.C3_Grenzwert.Name = "C3_Grenzwert"
        Me.C3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.C3_Grenzwert.TabIndex = 25
        Me.C3_Grenzwert.Text = "150"
        Me.C3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3_Grenzwert
        '
        Me.D3_Grenzwert.Location = New System.Drawing.Point(35, 161)
        Me.D3_Grenzwert.Name = "D3_Grenzwert"
        Me.D3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.D3_Grenzwert.TabIndex = 26
        Me.D3_Grenzwert.Text = "150"
        Me.D3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E3_Grenzwert
        '
        Me.E3_Grenzwert.Location = New System.Drawing.Point(67, 161)
        Me.E3_Grenzwert.Name = "E3_Grenzwert"
        Me.E3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.E3_Grenzwert.TabIndex = 27
        Me.E3_Grenzwert.Text = "150"
        Me.E3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F3_Grenzwert
        '
        Me.F3_Grenzwert.Location = New System.Drawing.Point(99, 161)
        Me.F3_Grenzwert.Name = "F3_Grenzwert"
        Me.F3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.F3_Grenzwert.TabIndex = 28
        Me.F3_Grenzwert.Text = "150"
        Me.F3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G3_Grenzwert
        '
        Me.G3_Grenzwert.Location = New System.Drawing.Point(131, 161)
        Me.G3_Grenzwert.Name = "G3_Grenzwert"
        Me.G3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.G3_Grenzwert.TabIndex = 29
        Me.G3_Grenzwert.Text = "150"
        Me.G3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A3_Grenzwert
        '
        Me.A3_Grenzwert.Location = New System.Drawing.Point(163, 161)
        Me.A3_Grenzwert.Name = "A3_Grenzwert"
        Me.A3_Grenzwert.Size = New System.Drawing.Size(26, 20)
        Me.A3_Grenzwert.TabIndex = 30
        Me.A3_Grenzwert.Text = "150"
        Me.A3_Grenzwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H3_Grenzwert
        '
        Me.H3_Grenzwert.Location = New System.Drawing.Point(195, 161)
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
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox50)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox51)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox52)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox53)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox54)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox55)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox56)
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
        'TextBox50
        '
        Me.TextBox50.Location = New System.Drawing.Point(3, 161)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(26, 20)
        Me.TextBox50.TabIndex = 25
        Me.TextBox50.Text = "100"
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox51
        '
        Me.TextBox51.Location = New System.Drawing.Point(35, 161)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(26, 20)
        Me.TextBox51.TabIndex = 26
        Me.TextBox51.Text = "100"
        Me.TextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox52
        '
        Me.TextBox52.Location = New System.Drawing.Point(67, 161)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(26, 20)
        Me.TextBox52.TabIndex = 27
        Me.TextBox52.Text = "100"
        Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox53
        '
        Me.TextBox53.Location = New System.Drawing.Point(99, 161)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(26, 20)
        Me.TextBox53.TabIndex = 28
        Me.TextBox53.Text = "100"
        Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox54
        '
        Me.TextBox54.Location = New System.Drawing.Point(131, 161)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(26, 20)
        Me.TextBox54.TabIndex = 29
        Me.TextBox54.Text = "100"
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox55
        '
        Me.TextBox55.Location = New System.Drawing.Point(163, 161)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(26, 20)
        Me.TextBox55.TabIndex = 30
        Me.TextBox55.Text = "100"
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox56
        '
        Me.TextBox56.Location = New System.Drawing.Point(195, 161)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(26, 20)
        Me.TextBox56.TabIndex = 31
        Me.TextBox56.Text = "100"
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox57)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox58)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox59)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox60)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox61)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox62)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox63)
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
        'TextBox57
        '
        Me.TextBox57.Location = New System.Drawing.Point(3, 161)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(26, 20)
        Me.TextBox57.TabIndex = 25
        Me.TextBox57.Text = "75"
        Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(35, 161)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(26, 20)
        Me.TextBox58.TabIndex = 26
        Me.TextBox58.Text = "75"
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox59
        '
        Me.TextBox59.Location = New System.Drawing.Point(67, 161)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(26, 20)
        Me.TextBox59.TabIndex = 27
        Me.TextBox59.Text = "75"
        Me.TextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox60
        '
        Me.TextBox60.Location = New System.Drawing.Point(99, 161)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(26, 20)
        Me.TextBox60.TabIndex = 28
        Me.TextBox60.Text = "75"
        Me.TextBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox61
        '
        Me.TextBox61.Location = New System.Drawing.Point(131, 161)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(26, 20)
        Me.TextBox61.TabIndex = 29
        Me.TextBox61.Text = "75"
        Me.TextBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox62
        '
        Me.TextBox62.Location = New System.Drawing.Point(163, 161)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(26, 20)
        Me.TextBox62.TabIndex = 30
        Me.TextBox62.Text = "75"
        Me.TextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox63
        '
        Me.TextBox63.Location = New System.Drawing.Point(195, 161)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(26, 20)
        Me.TextBox63.TabIndex = 31
        Me.TextBox63.Text = "75"
        Me.TextBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox64)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox65)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox66)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox67)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox68)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox69)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox70)
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
        'TextBox64
        '
        Me.TextBox64.Location = New System.Drawing.Point(3, 161)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(26, 20)
        Me.TextBox64.TabIndex = 25
        Me.TextBox64.Text = "50"
        Me.TextBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox65
        '
        Me.TextBox65.Location = New System.Drawing.Point(35, 161)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(26, 20)
        Me.TextBox65.TabIndex = 26
        Me.TextBox65.Text = "50"
        Me.TextBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox66
        '
        Me.TextBox66.Location = New System.Drawing.Point(67, 161)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(26, 20)
        Me.TextBox66.TabIndex = 27
        Me.TextBox66.Text = "50"
        Me.TextBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox67
        '
        Me.TextBox67.Location = New System.Drawing.Point(99, 161)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(26, 20)
        Me.TextBox67.TabIndex = 28
        Me.TextBox67.Text = "50"
        Me.TextBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox68
        '
        Me.TextBox68.Location = New System.Drawing.Point(131, 161)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(26, 20)
        Me.TextBox68.TabIndex = 29
        Me.TextBox68.Text = "50"
        Me.TextBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox69
        '
        Me.TextBox69.Location = New System.Drawing.Point(163, 161)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(26, 20)
        Me.TextBox69.TabIndex = 30
        Me.TextBox69.Text = "50"
        Me.TextBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox70
        '
        Me.TextBox70.Location = New System.Drawing.Point(195, 161)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(26, 20)
        Me.TextBox70.TabIndex = 31
        Me.TextBox70.Text = "50"
        Me.TextBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Einstellungen_GroupBox
        '
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox20)
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox19)
        Me.Einstellungen_GroupBox.Controls.Add(Me.GroupBox13)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Tempo_GroupBox)
        Me.Einstellungen_GroupBox.Controls.Add(Me.Transpose_GroupBox)
        Me.Einstellungen_GroupBox.Location = New System.Drawing.Point(326, 13)
        Me.Einstellungen_GroupBox.Name = "Einstellungen_GroupBox"
        Me.Einstellungen_GroupBox.Size = New System.Drawing.Size(217, 422)
        Me.Einstellungen_GroupBox.TabIndex = 20
        Me.Einstellungen_GroupBox.TabStop = False
        Me.Einstellungen_GroupBox.Text = "Einstellungen"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.Label6)
        Me.GroupBox20.Controls.Add(Me.Messintervall_NumericUpDown)
        Me.GroupBox20.Controls.Add(Me.MessungenProS_NumericUpDown)
        Me.GroupBox20.Controls.Add(Me.Label5)
        Me.GroupBox20.Location = New System.Drawing.Point(9, 183)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(199, 70)
        Me.GroupBox20.TabIndex = 174
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Messintervall vom Mikrokontroller"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Messintervall in ms:"
        '
        'Messintervall_NumericUpDown
        '
        Me.Messintervall_NumericUpDown.Location = New System.Drawing.Point(138, 44)
        Me.Messintervall_NumericUpDown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Messintervall_NumericUpDown.Name = "Messintervall_NumericUpDown"
        Me.Messintervall_NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Messintervall_NumericUpDown.TabIndex = 181
        Me.Messintervall_NumericUpDown.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'MessungenProS_NumericUpDown
        '
        Me.MessungenProS_NumericUpDown.Location = New System.Drawing.Point(138, 19)
        Me.MessungenProS_NumericUpDown.Name = "MessungenProS_NumericUpDown"
        Me.MessungenProS_NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.MessungenProS_NumericUpDown.TabIndex = 180
        Me.MessungenProS_NumericUpDown.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "Messungen pro Sek.:"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.MIDI_SpecialMode)
        Me.GroupBox19.Controls.Add(Me.MIDI_NormalMode)
        Me.GroupBox19.Controls.Add(Me.cboInstruments)
        Me.GroupBox19.Location = New System.Drawing.Point(9, 21)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(199, 83)
        Me.GroupBox19.TabIndex = 173
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "MIDI Aufnahmemodus"
        '
        'MIDI_SpecialMode
        '
        Me.MIDI_SpecialMode.AutoSize = True
        Me.MIDI_SpecialMode.Location = New System.Drawing.Point(116, 23)
        Me.MIDI_SpecialMode.Name = "MIDI_SpecialMode"
        Me.MIDI_SpecialMode.Size = New System.Drawing.Size(74, 17)
        Me.MIDI_SpecialMode.TabIndex = 4
        Me.MIDI_SpecialMode.Text = "nur Töhne"
        Me.ToolTip1.SetToolTip(Me.MIDI_SpecialMode, resources.GetString("MIDI_SpecialMode.ToolTip"))
        Me.MIDI_SpecialMode.UseVisualStyleBackColor = True
        '
        'MIDI_NormalMode
        '
        Me.MIDI_NormalMode.AutoSize = True
        Me.MIDI_NormalMode.Checked = True
        Me.MIDI_NormalMode.Location = New System.Drawing.Point(13, 22)
        Me.MIDI_NormalMode.Name = "MIDI_NormalMode"
        Me.MIDI_NormalMode.Size = New System.Drawing.Size(97, 17)
        Me.MIDI_NormalMode.TabIndex = 3
        Me.MIDI_NormalMode.TabStop = True
        Me.MIDI_NormalMode.Text = "Standardt MIDI"
        Me.ToolTip1.SetToolTip(Me.MIDI_NormalMode, resources.GetString("MIDI_NormalMode.ToolTip"))
        Me.MIDI_NormalMode.UseVisualStyleBackColor = True
        '
        'cboInstruments
        '
        Me.cboInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstruments.Location = New System.Drawing.Point(15, 51)
        Me.cboInstruments.Name = "cboInstruments"
        Me.cboInstruments.Size = New System.Drawing.Size(175, 21)
        Me.cboInstruments.TabIndex = 2
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Metronom_OFF)
        Me.GroupBox13.Controls.Add(Me.Metronom_ON)
        Me.GroupBox13.Controls.Add(Me.Metronom_Betont)
        Me.GroupBox13.Location = New System.Drawing.Point(6, 347)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(202, 53)
        Me.GroupBox13.TabIndex = 168
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Metronom"
        Me.ToolTip1.SetToolTip(Me.GroupBox13, "Das Metronom dient zur Hilfe")
        '
        'Metronom_OFF
        '
        Me.Metronom_OFF.AutoSize = True
        Me.Metronom_OFF.Checked = True
        Me.Metronom_OFF.Location = New System.Drawing.Point(146, 23)
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
        Me.Metronom_ON.Location = New System.Drawing.Point(90, 23)
        Me.Metronom_ON.Name = "Metronom_ON"
        Me.Metronom_ON.Size = New System.Drawing.Size(40, 17)
        Me.Metronom_ON.TabIndex = 0
        Me.Metronom_ON.Text = "Ein"
        Me.Metronom_ON.UseVisualStyleBackColor = True
        '
        'Metronom_Betont
        '
        Me.Metronom_Betont.AutoSize = True
        Me.Metronom_Betont.Location = New System.Drawing.Point(18, 24)
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
        Me.Tempo_GroupBox.Controls.Add(Me.Label16)
        Me.Tempo_GroupBox.Controls.Add(Me.BPM)
        Me.Tempo_GroupBox.Location = New System.Drawing.Point(9, 109)
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 172
        Me.Label16.Text = "Aufnahme BPM:"
        '
        'BPM
        '
        Me.BPM.Location = New System.Drawing.Point(137, 37)
        Me.BPM.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.BPM.Name = "BPM"
        Me.BPM.Size = New System.Drawing.Size(48, 20)
        Me.BPM.TabIndex = 168
        Me.BPM.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Transpose_GroupBox
        '
        Me.Transpose_GroupBox.Controls.Add(Me.Label2)
        Me.Transpose_GroupBox.Controls.Add(Me.Label1)
        Me.Transpose_GroupBox.Controls.Add(Me.Notenverschiebung)
        Me.Transpose_GroupBox.Controls.Add(Me.Oktavenverschiebung)
        Me.Transpose_GroupBox.Location = New System.Drawing.Point(9, 261)
        Me.Transpose_GroupBox.Name = "Transpose_GroupBox"
        Me.Transpose_GroupBox.Size = New System.Drawing.Size(199, 83)
        Me.Transpose_GroupBox.TabIndex = 166
        Me.Transpose_GroupBox.TabStop = False
        Me.Transpose_GroupBox.Text = "Tonhöhenverenderung (Transpose)"
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
        'Notenverschiebung
        '
        Me.Notenverschiebung.Location = New System.Drawing.Point(127, 55)
        Me.Notenverschiebung.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.Notenverschiebung.Minimum = New Decimal(New Integer() {32, 0, 0, -2147483648})
        Me.Notenverschiebung.Name = "Notenverschiebung"
        Me.Notenverschiebung.Size = New System.Drawing.Size(55, 20)
        Me.Notenverschiebung.TabIndex = 165
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
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox15.Controls.Add(Me.HScrollBar1)
        Me.GroupBox15.Location = New System.Drawing.Point(860, 391)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(196, 55)
        Me.GroupBox15.TabIndex = 169
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "MIDI Lautstärcke"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(9, 26)
        Me.HScrollBar1.Maximum = 127
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(175, 17)
        Me.HScrollBar1.TabIndex = 7
        Me.HScrollBar1.Value = 127
        '
        'Tackt
        '
        Me.Tackt.Interval = 125
        '
        'NoteC
        '
        Me.NoteC.Location = New System.Drawing.Point(1062, 813)
        Me.NoteC.Name = "NoteC"
        Me.NoteC.Size = New System.Drawing.Size(191, 78)
        Me.NoteC.TabIndex = 165
        Me.NoteC.Text = "NoteC"
        Me.NoteC.UseVisualStyleBackColor = True
        '
        'Messintervall
        '
        Me.Messintervall.Interval = 25
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
        Me.GroupBox4.Location = New System.Drawing.Point(13, 452)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1229, 328)
        Me.GroupBox4.TabIndex = 167
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MIDI Visualisierung"
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox103)
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox104)
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox105)
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox106)
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox107)
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox108)
        Me.FlowLayoutPanel11.Controls.Add(Me.TextBox109)
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(982, 231)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(228, 27)
        Me.FlowLayoutPanel11.TabIndex = 173
        '
        'TextBox103
        '
        Me.TextBox103.Location = New System.Drawing.Point(3, 3)
        Me.TextBox103.Name = "TextBox103"
        Me.TextBox103.Size = New System.Drawing.Size(26, 20)
        Me.TextBox103.TabIndex = 19
        Me.TextBox103.Text = "0"
        Me.TextBox103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox104
        '
        Me.TextBox104.Location = New System.Drawing.Point(35, 3)
        Me.TextBox104.Name = "TextBox104"
        Me.TextBox104.Size = New System.Drawing.Size(26, 20)
        Me.TextBox104.TabIndex = 20
        Me.TextBox104.Text = "0"
        Me.TextBox104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox105
        '
        Me.TextBox105.Location = New System.Drawing.Point(67, 3)
        Me.TextBox105.Name = "TextBox105"
        Me.TextBox105.Size = New System.Drawing.Size(26, 20)
        Me.TextBox105.TabIndex = 21
        Me.TextBox105.Text = "0"
        Me.TextBox105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox106
        '
        Me.TextBox106.Location = New System.Drawing.Point(99, 3)
        Me.TextBox106.Name = "TextBox106"
        Me.TextBox106.Size = New System.Drawing.Size(26, 20)
        Me.TextBox106.TabIndex = 22
        Me.TextBox106.Text = "0"
        Me.TextBox106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox107
        '
        Me.TextBox107.Location = New System.Drawing.Point(131, 3)
        Me.TextBox107.Name = "TextBox107"
        Me.TextBox107.Size = New System.Drawing.Size(26, 20)
        Me.TextBox107.TabIndex = 23
        Me.TextBox107.Text = "0"
        Me.TextBox107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox108
        '
        Me.TextBox108.Location = New System.Drawing.Point(163, 3)
        Me.TextBox108.Name = "TextBox108"
        Me.TextBox108.Size = New System.Drawing.Size(26, 20)
        Me.TextBox108.TabIndex = 24
        Me.TextBox108.Text = "0"
        Me.TextBox108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox109
        '
        Me.TextBox109.Location = New System.Drawing.Point(195, 3)
        Me.TextBox109.Name = "TextBox109"
        Me.TextBox109.Size = New System.Drawing.Size(26, 20)
        Me.TextBox109.TabIndex = 25
        Me.TextBox109.Text = "0"
        Me.TextBox109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox96)
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox97)
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox98)
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox99)
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox100)
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox101)
        Me.FlowLayoutPanel10.Controls.Add(Me.TextBox102)
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(737, 231)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(228, 27)
        Me.FlowLayoutPanel10.TabIndex = 172
        '
        'TextBox96
        '
        Me.TextBox96.Location = New System.Drawing.Point(3, 3)
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.Size = New System.Drawing.Size(26, 20)
        Me.TextBox96.TabIndex = 19
        Me.TextBox96.Text = "0"
        Me.TextBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox97
        '
        Me.TextBox97.Location = New System.Drawing.Point(35, 3)
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.Size = New System.Drawing.Size(26, 20)
        Me.TextBox97.TabIndex = 20
        Me.TextBox97.Text = "0"
        Me.TextBox97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox98
        '
        Me.TextBox98.Location = New System.Drawing.Point(67, 3)
        Me.TextBox98.Name = "TextBox98"
        Me.TextBox98.Size = New System.Drawing.Size(26, 20)
        Me.TextBox98.TabIndex = 21
        Me.TextBox98.Text = "0"
        Me.TextBox98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox99
        '
        Me.TextBox99.Location = New System.Drawing.Point(99, 3)
        Me.TextBox99.Name = "TextBox99"
        Me.TextBox99.Size = New System.Drawing.Size(26, 20)
        Me.TextBox99.TabIndex = 22
        Me.TextBox99.Text = "0"
        Me.TextBox99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox100
        '
        Me.TextBox100.Location = New System.Drawing.Point(131, 3)
        Me.TextBox100.Name = "TextBox100"
        Me.TextBox100.Size = New System.Drawing.Size(26, 20)
        Me.TextBox100.TabIndex = 23
        Me.TextBox100.Text = "0"
        Me.TextBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox101
        '
        Me.TextBox101.Location = New System.Drawing.Point(163, 3)
        Me.TextBox101.Name = "TextBox101"
        Me.TextBox101.Size = New System.Drawing.Size(26, 20)
        Me.TextBox101.TabIndex = 24
        Me.TextBox101.Text = "0"
        Me.TextBox101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox102
        '
        Me.TextBox102.Location = New System.Drawing.Point(195, 3)
        Me.TextBox102.Name = "TextBox102"
        Me.TextBox102.Size = New System.Drawing.Size(26, 20)
        Me.TextBox102.TabIndex = 25
        Me.TextBox102.Text = "0"
        Me.TextBox102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox89)
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox90)
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox91)
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox92)
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox93)
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox94)
        Me.FlowLayoutPanel9.Controls.Add(Me.TextBox95)
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(497, 231)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(228, 27)
        Me.FlowLayoutPanel9.TabIndex = 171
        '
        'TextBox89
        '
        Me.TextBox89.Location = New System.Drawing.Point(3, 3)
        Me.TextBox89.Name = "TextBox89"
        Me.TextBox89.Size = New System.Drawing.Size(26, 20)
        Me.TextBox89.TabIndex = 19
        Me.TextBox89.Text = "0"
        Me.TextBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox90
        '
        Me.TextBox90.Location = New System.Drawing.Point(35, 3)
        Me.TextBox90.Name = "TextBox90"
        Me.TextBox90.Size = New System.Drawing.Size(26, 20)
        Me.TextBox90.TabIndex = 20
        Me.TextBox90.Text = "0"
        Me.TextBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox91
        '
        Me.TextBox91.Location = New System.Drawing.Point(67, 3)
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Size = New System.Drawing.Size(26, 20)
        Me.TextBox91.TabIndex = 21
        Me.TextBox91.Text = "0"
        Me.TextBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox92
        '
        Me.TextBox92.Location = New System.Drawing.Point(99, 3)
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Size = New System.Drawing.Size(26, 20)
        Me.TextBox92.TabIndex = 22
        Me.TextBox92.Text = "0"
        Me.TextBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox93
        '
        Me.TextBox93.Location = New System.Drawing.Point(131, 3)
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Size = New System.Drawing.Size(26, 20)
        Me.TextBox93.TabIndex = 23
        Me.TextBox93.Text = "0"
        Me.TextBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox94
        '
        Me.TextBox94.Location = New System.Drawing.Point(163, 3)
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Size = New System.Drawing.Size(26, 20)
        Me.TextBox94.TabIndex = 24
        Me.TextBox94.Text = "0"
        Me.TextBox94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox95
        '
        Me.TextBox95.Location = New System.Drawing.Point(195, 3)
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Size = New System.Drawing.Size(26, 20)
        Me.TextBox95.TabIndex = 25
        Me.TextBox95.Text = "0"
        Me.TextBox95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(249, 231)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(228, 27)
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
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(6, 231)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboDuration)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btnStopNoteAbove)
        Me.GroupBox3.Controls.Add(Me.btnPlay1Note)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(711, 813)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 142)
        Me.GroupBox3.TabIndex = 171
        Me.GroupBox3.TabStop = False
        '
        'cboDuration
        '
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"10", "100", "500", "1000", "2000", "5000"})
        Me.cboDuration.Location = New System.Drawing.Point(175, 112)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(69, 21)
        Me.cboDuration.TabIndex = 22
        Me.cboDuration.Text = "1000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightBlue
        Me.Label13.Location = New System.Drawing.Point(18, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 16)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Note Duration (ms)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightBlue
        Me.Label12.Location = New System.Drawing.Point(10, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 16)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Play and Stop a Specific NOTE"
        '
        'btnStopNoteAbove
        '
        Me.btnStopNoteAbove.Location = New System.Drawing.Point(80, 73)
        Me.btnStopNoteAbove.Name = "btnStopNoteAbove"
        Me.btnStopNoteAbove.Size = New System.Drawing.Size(116, 23)
        Me.btnStopNoteAbove.TabIndex = 18
        Me.btnStopNoteAbove.Text = "Stop Note above"
        Me.btnStopNoteAbove.UseVisualStyleBackColor = True
        '
        'btnPlay1Note
        '
        Me.btnPlay1Note.Location = New System.Drawing.Point(80, 44)
        Me.btnPlay1Note.Name = "btnPlay1Note"
        Me.btnPlay1Note.Size = New System.Drawing.Size(116, 23)
        Me.btnPlay1Note.TabIndex = 17
        Me.btnPlay1Note.Text = "Play 1 Note"
        Me.btnPlay1Note.UseVisualStyleBackColor = True
        '
        'lblClickMe
        '
        Me.lblClickMe.BackColor = System.Drawing.Color.PowderBlue
        Me.lblClickMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClickMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickMe.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblClickMe.Location = New System.Drawing.Point(475, 814)
        Me.lblClickMe.Name = "lblClickMe"
        Me.lblClickMe.Size = New System.Drawing.Size(127, 127)
        Me.lblClickMe.TabIndex = 170
        Me.lblClickMe.Text = "Click in this box.  The Lower you click down the box, the higher the note."
        Me.lblClickMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.META_Copyright_Input)
        Me.GroupBox8.Location = New System.Drawing.Point(14, 216)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(165, 78)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Copyright Eintrag"
        Me.ToolTip1.SetToolTip(Me.GroupBox8, "Copyright Eintrag in den META Tag des MIDI Files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Der Eintrag darf die Länge von " & _
                "255 Zeichen nicht überschreiten!")
        '
        'META_Copyright_Input
        '
        Me.META_Copyright_Input.Location = New System.Drawing.Point(11, 21)
        Me.META_Copyright_Input.MaxLength = 255
        Me.META_Copyright_Input.Multiline = True
        Me.META_Copyright_Input.Name = "META_Copyright_Input"
        Me.META_Copyright_Input.Size = New System.Drawing.Size(142, 48)
        Me.META_Copyright_Input.TabIndex = 2
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.ToolTip_OFF)
        Me.GroupBox17.Controls.Add(Me.ToolTip_ON)
        Me.GroupBox17.Location = New System.Drawing.Point(23, 29)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(176, 54)
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
        Me.GroupBox7.Size = New System.Drawing.Size(195, 422)
        Me.GroupBox7.TabIndex = 172
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Zusatzinformationen (Optional)"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.META_Autor_Input)
        Me.GroupBox16.Location = New System.Drawing.Point(14, 81)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(164, 46)
        Me.GroupBox16.TabIndex = 5
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Autor"
        '
        'META_Autor_Input
        '
        Me.META_Autor_Input.Location = New System.Drawing.Point(12, 17)
        Me.META_Autor_Input.Name = "META_Autor_Input"
        Me.META_Autor_Input.Size = New System.Drawing.Size(142, 20)
        Me.META_Autor_Input.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label4)
        Me.GroupBox11.Controls.Add(Me.Label3)
        Me.GroupBox11.Controls.Add(Me.META_SpurnamenLH_Input)
        Me.GroupBox11.Controls.Add(Me.META_SpurnamenRH_Input)
        Me.GroupBox11.Location = New System.Drawing.Point(14, 133)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(165, 77)
        Me.GroupBox11.TabIndex = 4
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = " Spurnamen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "LH:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "RH:"
        '
        'META_SpurnamenLH_Input
        '
        Me.META_SpurnamenLH_Input.Location = New System.Drawing.Point(41, 50)
        Me.META_SpurnamenLH_Input.Name = "META_SpurnamenLH_Input"
        Me.META_SpurnamenLH_Input.Size = New System.Drawing.Size(113, 20)
        Me.META_SpurnamenLH_Input.TabIndex = 0
        '
        'META_SpurnamenRH_Input
        '
        Me.META_SpurnamenRH_Input.Location = New System.Drawing.Point(41, 24)
        Me.META_SpurnamenRH_Input.Name = "META_SpurnamenRH_Input"
        Me.META_SpurnamenRH_Input.Size = New System.Drawing.Size(113, 20)
        Me.META_SpurnamenRH_Input.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.META_Bemerkung_Input)
        Me.GroupBox9.Location = New System.Drawing.Point(14, 300)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(165, 100)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Bemerkung"
        '
        'META_Bemerkung_Input
        '
        Me.META_Bemerkung_Input.Location = New System.Drawing.Point(12, 19)
        Me.META_Bemerkung_Input.MaxLength = 255
        Me.META_Bemerkung_Input.Multiline = True
        Me.META_Bemerkung_Input.Name = "META_Bemerkung_Input"
        Me.META_Bemerkung_Input.Size = New System.Drawing.Size(142, 69)
        Me.META_Bemerkung_Input.TabIndex = 1
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.META_Dateiname_Input)
        Me.GroupBox10.Location = New System.Drawing.Point(14, 27)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(165, 46)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Dateiname (im META)"
        '
        'META_Dateiname_Input
        '
        Me.META_Dateiname_Input.Location = New System.Drawing.Point(12, 17)
        Me.META_Dateiname_Input.Name = "META_Dateiname_Input"
        Me.META_Dateiname_Input.Size = New System.Drawing.Size(142, 20)
        Me.META_Dateiname_Input.TabIndex = 0
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.FlowLayoutPanel6)
        Me.GroupBox18.Location = New System.Drawing.Point(775, 252)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(457, 123)
        Me.GroupBox18.TabIndex = 184
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "GroupBox18"
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar2)
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar7)
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar8)
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar9)
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar10)
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar11)
        Me.FlowLayoutPanel6.Controls.Add(Me.TrackBar12)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(18, 19)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(424, 92)
        Me.FlowLayoutPanel6.TabIndex = 0
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(3, 3)
        Me.TrackBar2.Maximum = 1
        Me.TrackBar2.Minimum = -1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar2.TabIndex = 183
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrackBar7
        '
        Me.TrackBar7.Location = New System.Drawing.Point(54, 3)
        Me.TrackBar7.Maximum = 1
        Me.TrackBar7.Minimum = -1
        Me.TrackBar7.Name = "TrackBar7"
        Me.TrackBar7.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar7.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar7.TabIndex = 184
        Me.TrackBar7.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrackBar8
        '
        Me.TrackBar8.Location = New System.Drawing.Point(105, 3)
        Me.TrackBar8.Maximum = 1
        Me.TrackBar8.Minimum = -1
        Me.TrackBar8.Name = "TrackBar8"
        Me.TrackBar8.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar8.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar8.TabIndex = 185
        Me.TrackBar8.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrackBar9
        '
        Me.TrackBar9.Location = New System.Drawing.Point(156, 3)
        Me.TrackBar9.Maximum = 1
        Me.TrackBar9.Minimum = -1
        Me.TrackBar9.Name = "TrackBar9"
        Me.TrackBar9.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar9.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar9.TabIndex = 186
        Me.TrackBar9.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrackBar10
        '
        Me.TrackBar10.Location = New System.Drawing.Point(207, 3)
        Me.TrackBar10.Maximum = 1
        Me.TrackBar10.Minimum = -1
        Me.TrackBar10.Name = "TrackBar10"
        Me.TrackBar10.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar10.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar10.TabIndex = 187
        Me.TrackBar10.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrackBar11
        '
        Me.TrackBar11.Location = New System.Drawing.Point(258, 3)
        Me.TrackBar11.Maximum = 1
        Me.TrackBar11.Minimum = -1
        Me.TrackBar11.Name = "TrackBar11"
        Me.TrackBar11.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar11.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar11.TabIndex = 188
        Me.TrackBar11.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrackBar12
        '
        Me.TrackBar12.Location = New System.Drawing.Point(309, 3)
        Me.TrackBar12.Maximum = 1
        Me.TrackBar12.Minimum = -1
        Me.TrackBar12.Name = "TrackBar12"
        Me.TrackBar12.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar12.Size = New System.Drawing.Size(45, 73)
        Me.TrackBar12.TabIndex = 189
        Me.TrackBar12.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.hsbModWheel)
        Me.GroupBox6.Controls.Add(Me.hsbPan)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Controls.Add(Me.hsbVolume)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(196, 187)
        Me.GroupBox6.TabIndex = 167
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Direct Play"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Efeckt:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Balance:"
        '
        'hsbModWheel
        '
        Me.hsbModWheel.Location = New System.Drawing.Point(67, 80)
        Me.hsbModWheel.Maximum = 255
        Me.hsbModWheel.Name = "hsbModWheel"
        Me.hsbModWheel.Size = New System.Drawing.Size(115, 17)
        Me.hsbModWheel.TabIndex = 172
        '
        'hsbPan
        '
        Me.hsbPan.Location = New System.Drawing.Point(67, 52)
        Me.hsbPan.Name = "hsbPan"
        Me.hsbPan.Size = New System.Drawing.Size(115, 17)
        Me.hsbPan.TabIndex = 172
        Me.hsbPan.Value = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Volume:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 109)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(184, 54)
        Me.GroupBox5.TabIndex = 163
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Empfangende Noten abspielen"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(101, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Nein"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(27, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Ja"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'hsbVolume
        '
        Me.hsbVolume.Location = New System.Drawing.Point(67, 23)
        Me.hsbVolume.Maximum = 127
        Me.hsbVolume.Name = "hsbVolume"
        Me.hsbVolume.Size = New System.Drawing.Size(115, 17)
        Me.hsbVolume.TabIndex = 6
        Me.hsbVolume.Value = 127
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox6)
        Me.GroupBox12.Location = New System.Drawing.Point(774, 13)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(220, 220)
        Me.GroupBox12.TabIndex = 173
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Direct Play"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Button37)
        Me.GroupBox14.Controls.Add(Me.Button36)
        Me.GroupBox14.Controls.Add(Me.GroupBox17)
        Me.GroupBox14.Location = New System.Drawing.Point(1016, 18)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(215, 214)
        Me.GroupBox14.TabIndex = 185
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Programmeinstellungen"
        '
        'Button37
        '
        Me.Button37.Location = New System.Drawing.Point(23, 159)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(175, 43)
        Me.Button37.TabIndex = 2
        Me.Button37.Text = "Über"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button36
        '
        Me.Button36.Location = New System.Drawing.Point(23, 102)
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
        Me.ClientSize = New System.Drawing.Size(1274, 995)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox18)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblClickMe)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.NoteC)
        Me.Controls.Add(Me.Einstellungen_GroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIDI Harfe"
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
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        CType(Me.Messintervall_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessungenProS_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Notenverschiebung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_Comport As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Disconnect As System.Windows.Forms.Button
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents D2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents E2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents F2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents G2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents A2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents H2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents D4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents E4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents F4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents G4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents A4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents H4_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents D5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents E5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents F5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents G5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents A5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents H5_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents C6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents D6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents E6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents F6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents G6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents A6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents H6_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
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
    Private WithEvents C2_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MIDI_Save As System.Windows.Forms.Button
    Public WithEvents SaveMIDIDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Einstellungen_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MIDI_Start As System.Windows.Forms.Button
    Friend WithEvents Tackt As System.Windows.Forms.Timer
    Friend WithEvents Tackt_Ausgabefenster As System.Windows.Forms.Label
    Friend WithEvents C2_Grenzwert As System.Windows.Forms.TextBox
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
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox62 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox63 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents NoteC As System.Windows.Forms.Button
    Friend WithEvents Messintervall As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Notenverschiebung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Oktavenverschiebung As System.Windows.Forms.ComboBox
    Friend WithEvents Transpose_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MIDI_Pausieren As System.Windows.Forms.Button
    Friend WithEvents cboInstruments As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnStopNoteAbove As System.Windows.Forms.Button
    Friend WithEvents btnPlay1Note As System.Windows.Forms.Button
    Friend WithEvents lblClickMe As System.Windows.Forms.Label
    Friend WithEvents Tempo_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Tackt_Naenner_Input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Tackt_Zaehler_Input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
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
    Friend WithEvents META_SpurnamenRH_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Bemerkung_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Dateiname_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Copyright_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar7 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar8 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar9 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar10 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar11 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar12 As System.Windows.Forms.TrackBar
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents FlowLayoutPanel11 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox103 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox104 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox105 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox106 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox107 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox108 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox109 As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel10 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox96 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox97 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox98 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox99 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox100 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox101 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox102 As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel9 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox89 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox90 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox91 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox92 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox93 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox94 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox95 As System.Windows.Forms.TextBox
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
    Friend WithEvents META_SpurnamenLH_Input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Metronom_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents Metronom_ON As System.Windows.Forms.RadioButton
    Friend WithEvents Metronom_Betont As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents hsbModWheel As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbPan As System.Windows.Forms.HScrollBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents hsbVolume As System.Windows.Forms.HScrollBar
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip_ON As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents META_Autor_Input As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents C3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents D3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents E3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents F3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents G3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents A3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents H3_VerticalProgessBar As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents MIDI_SpecialMode As System.Windows.Forms.RadioButton
    Friend WithEvents MIDI_NormalMode As System.Windows.Forms.RadioButton
    Friend WithEvents Com_Search_Timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Messintervall_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MessungenProS_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
