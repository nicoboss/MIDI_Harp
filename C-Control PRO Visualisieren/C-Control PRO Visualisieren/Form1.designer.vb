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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Comport = New System.Windows.Forms.ComboBox()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tackt_Ausgabefenster = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.SaveMIDIDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tackt = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MIDI_Start = New System.Windows.Forms.Button()
        Me.Chart1_3D_LightStyle = New System.Windows.Forms.CheckBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NoteC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1_TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Chart1_3D_Rotation = New System.Windows.Forms.NumericUpDown()
        Me.Chart1_3D_Neigungswinkel = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chart1_3D_PointDepth_Text = New System.Windows.Forms.Label()
        Me.Chart1_3D_PointDepth = New System.Windows.Forms.NumericUpDown()
        Me.Chart1_3D_PointGrabDepth_Text = New System.Windows.Forms.Label()
        Me.Chart1_3D_PointGrabDepth = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MTech010VerticalProgessBar29 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar30 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar31 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar32 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar33 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar34 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar35 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar22 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar23 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar24 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar25 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar26 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar27 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar28 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar15 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar16 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar17 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar18 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar19 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar20 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar21 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar8 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar9 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar10 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar11 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar12 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar13 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar14 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar1 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar2 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar3 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar4 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar5 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar6 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.MTech010VerticalProgessBar7 = New C_Control_PRO_Visualisieren.MTech010VerticalProgessBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Chart1_TableLayoutPanel1.SuspendLayout()
        CType(Me.Chart1_3D_Rotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1_3D_Neigungswinkel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1_3D_PointDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1_3D_PointGrabDepth, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Controls.Add(Me.Tackt_Ausgabefenster)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 359)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausgabe"
        '
        'Tackt_Ausgabefenster
        '
        Me.Tackt_Ausgabefenster.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Tackt_Ausgabefenster.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tackt_Ausgabefenster.ForeColor = System.Drawing.Color.Black
        Me.Tackt_Ausgabefenster.Location = New System.Drawing.Point(6, 25)
        Me.Tackt_Ausgabefenster.Name = "Tackt_Ausgabefenster"
        Me.Tackt_Ausgabefenster.Padding = New System.Windows.Forms.Padding(25, 5, 20, 10)
        Me.Tackt_Ausgabefenster.Size = New System.Drawing.Size(288, 123)
        Me.Tackt_Ausgabefenster.TabIndex = 1
        Me.Tackt_Ausgabefenster.Text = "1/1"
        Me.Tackt_Ausgabefenster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 65)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Aufnahme Starten"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(6, 251)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(288, 65)
        Me.Save.TabIndex = 11
        Me.Save.Text = "Aufnahme Speichern"
        Me.Save.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar2)
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar3)
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar4)
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar5)
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar6)
        Me.FlowLayoutPanel1.Controls.Add(Me.MTech010VerticalProgessBar7)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox5)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox6)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox7)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox36)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox37)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox38)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox39)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox40)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox41)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox42)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 452)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(228, 158)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(35, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(26, 20)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(67, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(26, 20)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "0"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(99, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(26, 20)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(131, 106)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(26, 20)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "0"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(163, 106)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(26, 20)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "0"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(195, 106)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(26, 20)
        Me.TextBox7.TabIndex = 17
        Me.TextBox7.Text = "0"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox36
        '
        Me.TextBox36.Location = New System.Drawing.Point(3, 132)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(26, 20)
        Me.TextBox36.TabIndex = 18
        Me.TextBox36.Text = "200"
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox37
        '
        Me.TextBox37.Location = New System.Drawing.Point(35, 132)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(26, 20)
        Me.TextBox37.TabIndex = 19
        Me.TextBox37.Text = "200"
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox38
        '
        Me.TextBox38.Location = New System.Drawing.Point(67, 132)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(26, 20)
        Me.TextBox38.TabIndex = 20
        Me.TextBox38.Text = "200"
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox39
        '
        Me.TextBox39.Location = New System.Drawing.Point(99, 132)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(26, 20)
        Me.TextBox39.TabIndex = 21
        Me.TextBox39.Text = "200"
        Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox40
        '
        Me.TextBox40.Location = New System.Drawing.Point(131, 132)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(26, 20)
        Me.TextBox40.TabIndex = 22
        Me.TextBox40.Text = "200"
        Me.TextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox41
        '
        Me.TextBox41.Location = New System.Drawing.Point(163, 132)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(26, 20)
        Me.TextBox41.TabIndex = 23
        Me.TextBox41.Text = "200"
        Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(195, 132)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(26, 20)
        Me.TextBox42.TabIndex = 24
        Me.TextBox42.Text = "200"
        Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar8)
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar9)
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar10)
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar11)
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar12)
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar13)
        Me.FlowLayoutPanel2.Controls.Add(Me.MTech010VerticalProgessBar14)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox8)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox9)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox10)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox11)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox12)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox13)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox14)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox43)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox44)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox45)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox46)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox47)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox48)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox49)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(259, 452)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(230, 158)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(3, 106)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(26, 20)
        Me.TextBox8.TabIndex = 12
        Me.TextBox8.Text = "0"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(35, 106)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(26, 20)
        Me.TextBox9.TabIndex = 13
        Me.TextBox9.Text = "0"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(67, 106)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(26, 20)
        Me.TextBox10.TabIndex = 14
        Me.TextBox10.Text = "0"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(99, 106)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(26, 20)
        Me.TextBox11.TabIndex = 15
        Me.TextBox11.Text = "0"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(131, 106)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(26, 20)
        Me.TextBox12.TabIndex = 16
        Me.TextBox12.Text = "0"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(163, 106)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(26, 20)
        Me.TextBox13.TabIndex = 17
        Me.TextBox13.Text = "0"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(195, 106)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(26, 20)
        Me.TextBox14.TabIndex = 18
        Me.TextBox14.Text = "0"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox43
        '
        Me.TextBox43.Location = New System.Drawing.Point(3, 132)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(26, 20)
        Me.TextBox43.TabIndex = 25
        Me.TextBox43.Text = "150"
        Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(35, 132)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(26, 20)
        Me.TextBox44.TabIndex = 26
        Me.TextBox44.Text = "150"
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(67, 132)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(26, 20)
        Me.TextBox45.TabIndex = 27
        Me.TextBox45.Text = "150"
        Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(99, 132)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(26, 20)
        Me.TextBox46.TabIndex = 28
        Me.TextBox46.Text = "150"
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox47
        '
        Me.TextBox47.Location = New System.Drawing.Point(131, 132)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(26, 20)
        Me.TextBox47.TabIndex = 29
        Me.TextBox47.Text = "150"
        Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox48
        '
        Me.TextBox48.Location = New System.Drawing.Point(163, 132)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(26, 20)
        Me.TextBox48.TabIndex = 30
        Me.TextBox48.Text = "150"
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox49
        '
        Me.TextBox49.Location = New System.Drawing.Point(195, 132)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(26, 20)
        Me.TextBox49.TabIndex = 31
        Me.TextBox49.Text = "150"
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar15)
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar16)
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar17)
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar18)
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar19)
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar20)
        Me.FlowLayoutPanel3.Controls.Add(Me.MTech010VerticalProgessBar21)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox15)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox16)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox17)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox18)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox19)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox20)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox21)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox50)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox51)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox52)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox53)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox54)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox55)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBox56)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(506, 452)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(232, 158)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(3, 106)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(26, 20)
        Me.TextBox15.TabIndex = 12
        Me.TextBox15.Text = "0"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(35, 106)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(26, 20)
        Me.TextBox16.TabIndex = 13
        Me.TextBox16.Text = "0"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(67, 106)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(26, 20)
        Me.TextBox17.TabIndex = 14
        Me.TextBox17.Text = "0"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(99, 106)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(26, 20)
        Me.TextBox18.TabIndex = 15
        Me.TextBox18.Text = "0"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(131, 106)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(26, 20)
        Me.TextBox19.TabIndex = 16
        Me.TextBox19.Text = "0"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(163, 106)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(26, 20)
        Me.TextBox20.TabIndex = 17
        Me.TextBox20.Text = "0"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(195, 106)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(26, 20)
        Me.TextBox21.TabIndex = 18
        Me.TextBox21.Text = "0"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox50
        '
        Me.TextBox50.Location = New System.Drawing.Point(3, 132)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(26, 20)
        Me.TextBox50.TabIndex = 25
        Me.TextBox50.Text = "100"
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox51
        '
        Me.TextBox51.Location = New System.Drawing.Point(35, 132)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(26, 20)
        Me.TextBox51.TabIndex = 26
        Me.TextBox51.Text = "100"
        Me.TextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox52
        '
        Me.TextBox52.Location = New System.Drawing.Point(67, 132)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(26, 20)
        Me.TextBox52.TabIndex = 27
        Me.TextBox52.Text = "100"
        Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox53
        '
        Me.TextBox53.Location = New System.Drawing.Point(99, 132)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(26, 20)
        Me.TextBox53.TabIndex = 28
        Me.TextBox53.Text = "100"
        Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox54
        '
        Me.TextBox54.Location = New System.Drawing.Point(131, 132)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(26, 20)
        Me.TextBox54.TabIndex = 29
        Me.TextBox54.Text = "100"
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox55
        '
        Me.TextBox55.Location = New System.Drawing.Point(163, 132)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(26, 20)
        Me.TextBox55.TabIndex = 30
        Me.TextBox55.Text = "100"
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox56
        '
        Me.TextBox56.Location = New System.Drawing.Point(195, 132)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(26, 20)
        Me.TextBox56.TabIndex = 31
        Me.TextBox56.Text = "100"
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar22)
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar23)
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar24)
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar25)
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar26)
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar27)
        Me.FlowLayoutPanel4.Controls.Add(Me.MTech010VerticalProgessBar28)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox22)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox23)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox24)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox25)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox26)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox27)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox28)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox57)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox58)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox59)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox60)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox61)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox62)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox63)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(753, 452)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(231, 158)
        Me.FlowLayoutPanel4.TabIndex = 9
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(3, 106)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.ReadOnly = True
        Me.TextBox22.Size = New System.Drawing.Size(26, 20)
        Me.TextBox22.TabIndex = 12
        Me.TextBox22.Text = "0"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(35, 106)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.ReadOnly = True
        Me.TextBox23.Size = New System.Drawing.Size(26, 20)
        Me.TextBox23.TabIndex = 13
        Me.TextBox23.Text = "0"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(67, 106)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.ReadOnly = True
        Me.TextBox24.Size = New System.Drawing.Size(26, 20)
        Me.TextBox24.TabIndex = 14
        Me.TextBox24.Text = "0"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(99, 106)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.ReadOnly = True
        Me.TextBox25.Size = New System.Drawing.Size(26, 20)
        Me.TextBox25.TabIndex = 15
        Me.TextBox25.Text = "0"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(131, 106)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(26, 20)
        Me.TextBox26.TabIndex = 16
        Me.TextBox26.Text = "0"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(163, 106)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.ReadOnly = True
        Me.TextBox27.Size = New System.Drawing.Size(26, 20)
        Me.TextBox27.TabIndex = 17
        Me.TextBox27.Text = "0"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(195, 106)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.ReadOnly = True
        Me.TextBox28.Size = New System.Drawing.Size(26, 20)
        Me.TextBox28.TabIndex = 18
        Me.TextBox28.Text = "0"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox57
        '
        Me.TextBox57.Location = New System.Drawing.Point(3, 132)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(26, 20)
        Me.TextBox57.TabIndex = 25
        Me.TextBox57.Text = "75"
        Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(35, 132)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(26, 20)
        Me.TextBox58.TabIndex = 26
        Me.TextBox58.Text = "75"
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox59
        '
        Me.TextBox59.Location = New System.Drawing.Point(67, 132)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(26, 20)
        Me.TextBox59.TabIndex = 27
        Me.TextBox59.Text = "75"
        Me.TextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox60
        '
        Me.TextBox60.Location = New System.Drawing.Point(99, 132)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(26, 20)
        Me.TextBox60.TabIndex = 28
        Me.TextBox60.Text = "75"
        Me.TextBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox61
        '
        Me.TextBox61.Location = New System.Drawing.Point(131, 132)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(26, 20)
        Me.TextBox61.TabIndex = 29
        Me.TextBox61.Text = "75"
        Me.TextBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox62
        '
        Me.TextBox62.Location = New System.Drawing.Point(163, 132)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(26, 20)
        Me.TextBox62.TabIndex = 30
        Me.TextBox62.Text = "75"
        Me.TextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox63
        '
        Me.TextBox63.Location = New System.Drawing.Point(195, 132)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(26, 20)
        Me.TextBox63.TabIndex = 31
        Me.TextBox63.Text = "75"
        Me.TextBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar29)
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar30)
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar31)
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar32)
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar33)
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar34)
        Me.FlowLayoutPanel5.Controls.Add(Me.MTech010VerticalProgessBar35)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox29)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox30)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox31)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox32)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox33)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox34)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox35)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox64)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox65)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox66)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox67)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox68)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox69)
        Me.FlowLayoutPanel5.Controls.Add(Me.TextBox70)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(990, 452)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(237, 158)
        Me.FlowLayoutPanel5.TabIndex = 10
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(3, 106)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.ReadOnly = True
        Me.TextBox29.Size = New System.Drawing.Size(26, 20)
        Me.TextBox29.TabIndex = 12
        Me.TextBox29.Text = "0"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(35, 106)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.ReadOnly = True
        Me.TextBox30.Size = New System.Drawing.Size(26, 20)
        Me.TextBox30.TabIndex = 13
        Me.TextBox30.Text = "0"
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(67, 106)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.ReadOnly = True
        Me.TextBox31.Size = New System.Drawing.Size(26, 20)
        Me.TextBox31.TabIndex = 14
        Me.TextBox31.Text = "0"
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(99, 106)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.ReadOnly = True
        Me.TextBox32.Size = New System.Drawing.Size(26, 20)
        Me.TextBox32.TabIndex = 15
        Me.TextBox32.Text = "0"
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(131, 106)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.ReadOnly = True
        Me.TextBox33.Size = New System.Drawing.Size(26, 20)
        Me.TextBox33.TabIndex = 16
        Me.TextBox33.Text = "0"
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(163, 106)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.ReadOnly = True
        Me.TextBox34.Size = New System.Drawing.Size(26, 20)
        Me.TextBox34.TabIndex = 17
        Me.TextBox34.Text = "0"
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(195, 106)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.ReadOnly = True
        Me.TextBox35.Size = New System.Drawing.Size(26, 20)
        Me.TextBox35.TabIndex = 18
        Me.TextBox35.Text = "0"
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox64
        '
        Me.TextBox64.Location = New System.Drawing.Point(3, 132)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(26, 20)
        Me.TextBox64.TabIndex = 25
        Me.TextBox64.Text = "50"
        Me.TextBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox65
        '
        Me.TextBox65.Location = New System.Drawing.Point(35, 132)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(26, 20)
        Me.TextBox65.TabIndex = 26
        Me.TextBox65.Text = "50"
        Me.TextBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox66
        '
        Me.TextBox66.Location = New System.Drawing.Point(67, 132)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(26, 20)
        Me.TextBox66.TabIndex = 27
        Me.TextBox66.Text = "50"
        Me.TextBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox67
        '
        Me.TextBox67.Location = New System.Drawing.Point(99, 132)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(26, 20)
        Me.TextBox67.TabIndex = 28
        Me.TextBox67.Text = "50"
        Me.TextBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox68
        '
        Me.TextBox68.Location = New System.Drawing.Point(131, 132)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(26, 20)
        Me.TextBox68.TabIndex = 29
        Me.TextBox68.Text = "50"
        Me.TextBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox69
        '
        Me.TextBox69.Location = New System.Drawing.Point(163, 132)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(26, 20)
        Me.TextBox69.TabIndex = 30
        Me.TextBox69.Text = "50"
        Me.TextBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox70
        '
        Me.TextBox70.Location = New System.Drawing.Point(195, 132)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(26, 20)
        Me.TextBox70.TabIndex = 31
        Me.TextBox70.Text = "50"
        Me.TextBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(326, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 422)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Einstellungen"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(182, 238)
        Me.ListBox1.TabIndex = 165
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Harfe", "Klavier"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 304)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 164
        Me.ComboBox1.Text = "Harfe"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 362)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 54)
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
        'Tackt
        '
        Me.Tackt.Interval = 250
        '
        'MIDI_Start
        '
        Me.MIDI_Start.Location = New System.Drawing.Point(820, 22)
        Me.MIDI_Start.Name = "MIDI_Start"
        Me.MIDI_Start.Size = New System.Drawing.Size(154, 52)
        Me.MIDI_Start.TabIndex = 166
        Me.MIDI_Start.Text = "MIDI_Start"
        Me.MIDI_Start.UseVisualStyleBackColor = True
        '
        'Chart1_3D_LightStyle
        '
        Me.Chart1_3D_LightStyle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1_3D_LightStyle.AutoSize = True
        Me.Chart1_3D_LightStyle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Chart1_3D_LightStyle.Checked = True
        Me.Chart1_3D_LightStyle.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.Chart1_3D_LightStyle.Location = New System.Drawing.Point(167, 20)
        Me.Chart1_3D_LightStyle.Name = "Chart1_3D_LightStyle"
        Me.Chart1_3D_LightStyle.Size = New System.Drawing.Size(22, 24)
        Me.Chart1_3D_LightStyle.TabIndex = 152
        Me.Chart1_3D_LightStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Chart1_3D_LightStyle.ThreeState = True
        Me.Chart1_3D_LightStyle.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(558, 140)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(669, 295)
        Me.Chart1.TabIndex = 163
        Me.Chart1.Text = "Chart1"
        '
        'NoteC
        '
        Me.NoteC.Location = New System.Drawing.Point(558, 22)
        Me.NoteC.Name = "NoteC"
        Me.NoteC.Size = New System.Drawing.Size(235, 52)
        Me.NoteC.TabIndex = 165
        Me.NoteC.Text = "NoteC"
        Me.NoteC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(656, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(25, 5, 20, 10)
        Me.Label2.Size = New System.Drawing.Size(137, 43)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "0,000 V"
        '
        'Chart1_TableLayoutPanel1
        '
        Me.Chart1_TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Chart1_TableLayoutPanel1.ColumnCount = 5
        Me.Chart1_TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Chart1_TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Chart1_TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.Chart1_TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.Chart1_TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Label10, 1, 0)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_Rotation, 0, 1)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_Neigungswinkel, 0, 1)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_PointDepth_Text, 2, 0)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_PointDepth, 2, 1)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_PointGrabDepth_Text, 3, 0)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_PointGrabDepth, 3, 1)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Label8, 4, 0)
        Me.Chart1_TableLayoutPanel1.Controls.Add(Me.Chart1_3D_LightStyle, 4, 1)
        Me.Chart1_TableLayoutPanel1.Location = New System.Drawing.Point(1035, 47)
        Me.Chart1_TableLayoutPanel1.Name = "Chart1_TableLayoutPanel1"
        Me.Chart1_TableLayoutPanel1.RowCount = 2
        Me.Chart1_TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.Chart1_TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.Chart1_TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Chart1_TableLayoutPanel1.Size = New System.Drawing.Size(192, 47)
        Me.Chart1_TableLayoutPanel1.TabIndex = 164
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Wingdings 3", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 17)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "P"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chart1_3D_Rotation
        '
        Me.Chart1_3D_Rotation.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Chart1_3D_Rotation.Location = New System.Drawing.Point(42, 20)
        Me.Chart1_3D_Rotation.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.Chart1_3D_Rotation.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.Chart1_3D_Rotation.Name = "Chart1_3D_Rotation"
        Me.Chart1_3D_Rotation.Size = New System.Drawing.Size(32, 20)
        Me.Chart1_3D_Rotation.TabIndex = 157
        Me.Chart1_3D_Rotation.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Chart1_3D_Neigungswinkel
        '
        Me.Chart1_3D_Neigungswinkel.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Chart1_3D_Neigungswinkel.Location = New System.Drawing.Point(3, 20)
        Me.Chart1_3D_Neigungswinkel.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.Chart1_3D_Neigungswinkel.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.Chart1_3D_Neigungswinkel.Name = "Chart1_3D_Neigungswinkel"
        Me.Chart1_3D_Neigungswinkel.Size = New System.Drawing.Size(32, 20)
        Me.Chart1_3D_Neigungswinkel.TabIndex = 122
        Me.Chart1_3D_Neigungswinkel.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "∡"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chart1_3D_PointDepth_Text
        '
        Me.Chart1_3D_PointDepth_Text.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Chart1_3D_PointDepth_Text.AutoSize = True
        Me.Chart1_3D_PointDepth_Text.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Chart1_3D_PointDepth_Text.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Chart1_3D_PointDepth_Text.Location = New System.Drawing.Point(87, 0)
        Me.Chart1_3D_PointDepth_Text.Name = "Chart1_3D_PointDepth_Text"
        Me.Chart1_3D_PointDepth_Text.Size = New System.Drawing.Size(27, 17)
        Me.Chart1_3D_PointDepth_Text.TabIndex = 154
        Me.Chart1_3D_PointDepth_Text.Text = ""
        '
        'Chart1_3D_PointDepth
        '
        Me.Chart1_3D_PointDepth.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Chart1_3D_PointDepth.Location = New System.Drawing.Point(81, 20)
        Me.Chart1_3D_PointDepth.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Chart1_3D_PointDepth.Name = "Chart1_3D_PointDepth"
        Me.Chart1_3D_PointDepth.Size = New System.Drawing.Size(38, 20)
        Me.Chart1_3D_PointDepth.TabIndex = 123
        Me.Chart1_3D_PointDepth.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'Chart1_3D_PointGrabDepth_Text
        '
        Me.Chart1_3D_PointGrabDepth_Text.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Chart1_3D_PointGrabDepth_Text.AutoSize = True
        Me.Chart1_3D_PointGrabDepth_Text.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Chart1_3D_PointGrabDepth_Text.Location = New System.Drawing.Point(131, 0)
        Me.Chart1_3D_PointGrabDepth_Text.Name = "Chart1_3D_PointGrabDepth_Text"
        Me.Chart1_3D_PointGrabDepth_Text.Size = New System.Drawing.Size(24, 17)
        Me.Chart1_3D_PointGrabDepth_Text.TabIndex = 156
        Me.Chart1_3D_PointGrabDepth_Text.Text = "n"
        Me.Chart1_3D_PointGrabDepth_Text.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chart1_3D_PointGrabDepth
        '
        Me.Chart1_3D_PointGrabDepth.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Chart1_3D_PointGrabDepth.Location = New System.Drawing.Point(126, 20)
        Me.Chart1_3D_PointGrabDepth.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Chart1_3D_PointGrabDepth.Name = "Chart1_3D_PointGrabDepth"
        Me.Chart1_3D_PointGrabDepth.Size = New System.Drawing.Size(35, 20)
        Me.Chart1_3D_PointGrabDepth.TabIndex = 121
        Me.Chart1_3D_PointGrabDepth.Value = New Decimal(New Integer() {85, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(167, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 17)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = ""
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 661)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 167
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'MTech010VerticalProgessBar29
        '
        Me.MTech010VerticalProgessBar29.Location = New System.Drawing.Point(3, 3)
        Me.MTech010VerticalProgessBar29.Maximum = 1023
        Me.MTech010VerticalProgessBar29.Name = "MTech010VerticalProgessBar29"
        Me.MTech010VerticalProgessBar29.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar29.TabIndex = 3
        '
        'MTech010VerticalProgessBar30
        '
        Me.MTech010VerticalProgessBar30.Location = New System.Drawing.Point(35, 3)
        Me.MTech010VerticalProgessBar30.Maximum = 1023
        Me.MTech010VerticalProgessBar30.Name = "MTech010VerticalProgessBar30"
        Me.MTech010VerticalProgessBar30.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar30.TabIndex = 4
        '
        'MTech010VerticalProgessBar31
        '
        Me.MTech010VerticalProgessBar31.Location = New System.Drawing.Point(67, 3)
        Me.MTech010VerticalProgessBar31.Maximum = 1023
        Me.MTech010VerticalProgessBar31.Name = "MTech010VerticalProgessBar31"
        Me.MTech010VerticalProgessBar31.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar31.TabIndex = 5
        '
        'MTech010VerticalProgessBar32
        '
        Me.MTech010VerticalProgessBar32.Location = New System.Drawing.Point(99, 3)
        Me.MTech010VerticalProgessBar32.Maximum = 1023
        Me.MTech010VerticalProgessBar32.Name = "MTech010VerticalProgessBar32"
        Me.MTech010VerticalProgessBar32.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar32.TabIndex = 6
        '
        'MTech010VerticalProgessBar33
        '
        Me.MTech010VerticalProgessBar33.Location = New System.Drawing.Point(131, 3)
        Me.MTech010VerticalProgessBar33.Maximum = 1023
        Me.MTech010VerticalProgessBar33.Name = "MTech010VerticalProgessBar33"
        Me.MTech010VerticalProgessBar33.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar33.TabIndex = 7
        '
        'MTech010VerticalProgessBar34
        '
        Me.MTech010VerticalProgessBar34.Location = New System.Drawing.Point(163, 3)
        Me.MTech010VerticalProgessBar34.Maximum = 1023
        Me.MTech010VerticalProgessBar34.Name = "MTech010VerticalProgessBar34"
        Me.MTech010VerticalProgessBar34.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar34.TabIndex = 8
        '
        'MTech010VerticalProgessBar35
        '
        Me.MTech010VerticalProgessBar35.Location = New System.Drawing.Point(195, 3)
        Me.MTech010VerticalProgessBar35.Maximum = 1023
        Me.MTech010VerticalProgessBar35.Name = "MTech010VerticalProgessBar35"
        Me.MTech010VerticalProgessBar35.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar35.TabIndex = 9
        '
        'MTech010VerticalProgessBar22
        '
        Me.MTech010VerticalProgessBar22.Location = New System.Drawing.Point(3, 3)
        Me.MTech010VerticalProgessBar22.Maximum = 1023
        Me.MTech010VerticalProgessBar22.Name = "MTech010VerticalProgessBar22"
        Me.MTech010VerticalProgessBar22.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar22.TabIndex = 3
        '
        'MTech010VerticalProgessBar23
        '
        Me.MTech010VerticalProgessBar23.Location = New System.Drawing.Point(35, 3)
        Me.MTech010VerticalProgessBar23.Maximum = 1023
        Me.MTech010VerticalProgessBar23.Name = "MTech010VerticalProgessBar23"
        Me.MTech010VerticalProgessBar23.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar23.TabIndex = 4
        '
        'MTech010VerticalProgessBar24
        '
        Me.MTech010VerticalProgessBar24.Location = New System.Drawing.Point(67, 3)
        Me.MTech010VerticalProgessBar24.Maximum = 1023
        Me.MTech010VerticalProgessBar24.Name = "MTech010VerticalProgessBar24"
        Me.MTech010VerticalProgessBar24.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar24.TabIndex = 5
        '
        'MTech010VerticalProgessBar25
        '
        Me.MTech010VerticalProgessBar25.Location = New System.Drawing.Point(99, 3)
        Me.MTech010VerticalProgessBar25.Maximum = 1023
        Me.MTech010VerticalProgessBar25.Name = "MTech010VerticalProgessBar25"
        Me.MTech010VerticalProgessBar25.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar25.TabIndex = 6
        '
        'MTech010VerticalProgessBar26
        '
        Me.MTech010VerticalProgessBar26.Location = New System.Drawing.Point(131, 3)
        Me.MTech010VerticalProgessBar26.Maximum = 1023
        Me.MTech010VerticalProgessBar26.Name = "MTech010VerticalProgessBar26"
        Me.MTech010VerticalProgessBar26.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar26.TabIndex = 7
        '
        'MTech010VerticalProgessBar27
        '
        Me.MTech010VerticalProgessBar27.Location = New System.Drawing.Point(163, 3)
        Me.MTech010VerticalProgessBar27.Maximum = 1023
        Me.MTech010VerticalProgessBar27.Name = "MTech010VerticalProgessBar27"
        Me.MTech010VerticalProgessBar27.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar27.TabIndex = 8
        '
        'MTech010VerticalProgessBar28
        '
        Me.MTech010VerticalProgessBar28.Location = New System.Drawing.Point(195, 3)
        Me.MTech010VerticalProgessBar28.Maximum = 1023
        Me.MTech010VerticalProgessBar28.Name = "MTech010VerticalProgessBar28"
        Me.MTech010VerticalProgessBar28.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar28.TabIndex = 9
        '
        'MTech010VerticalProgessBar15
        '
        Me.MTech010VerticalProgessBar15.Location = New System.Drawing.Point(3, 3)
        Me.MTech010VerticalProgessBar15.Maximum = 1023
        Me.MTech010VerticalProgessBar15.Name = "MTech010VerticalProgessBar15"
        Me.MTech010VerticalProgessBar15.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar15.TabIndex = 3
        '
        'MTech010VerticalProgessBar16
        '
        Me.MTech010VerticalProgessBar16.Location = New System.Drawing.Point(35, 3)
        Me.MTech010VerticalProgessBar16.Maximum = 1023
        Me.MTech010VerticalProgessBar16.Name = "MTech010VerticalProgessBar16"
        Me.MTech010VerticalProgessBar16.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar16.TabIndex = 4
        '
        'MTech010VerticalProgessBar17
        '
        Me.MTech010VerticalProgessBar17.Location = New System.Drawing.Point(67, 3)
        Me.MTech010VerticalProgessBar17.Maximum = 1023
        Me.MTech010VerticalProgessBar17.Name = "MTech010VerticalProgessBar17"
        Me.MTech010VerticalProgessBar17.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar17.TabIndex = 5
        '
        'MTech010VerticalProgessBar18
        '
        Me.MTech010VerticalProgessBar18.Location = New System.Drawing.Point(99, 3)
        Me.MTech010VerticalProgessBar18.Maximum = 1023
        Me.MTech010VerticalProgessBar18.Name = "MTech010VerticalProgessBar18"
        Me.MTech010VerticalProgessBar18.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar18.TabIndex = 6
        '
        'MTech010VerticalProgessBar19
        '
        Me.MTech010VerticalProgessBar19.Location = New System.Drawing.Point(131, 3)
        Me.MTech010VerticalProgessBar19.Maximum = 1023
        Me.MTech010VerticalProgessBar19.Name = "MTech010VerticalProgessBar19"
        Me.MTech010VerticalProgessBar19.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar19.TabIndex = 7
        '
        'MTech010VerticalProgessBar20
        '
        Me.MTech010VerticalProgessBar20.Location = New System.Drawing.Point(163, 3)
        Me.MTech010VerticalProgessBar20.Maximum = 1023
        Me.MTech010VerticalProgessBar20.Name = "MTech010VerticalProgessBar20"
        Me.MTech010VerticalProgessBar20.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar20.TabIndex = 8
        '
        'MTech010VerticalProgessBar21
        '
        Me.MTech010VerticalProgessBar21.Location = New System.Drawing.Point(195, 3)
        Me.MTech010VerticalProgessBar21.Maximum = 1023
        Me.MTech010VerticalProgessBar21.Name = "MTech010VerticalProgessBar21"
        Me.MTech010VerticalProgessBar21.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar21.TabIndex = 9
        '
        'MTech010VerticalProgessBar8
        '
        Me.MTech010VerticalProgessBar8.Location = New System.Drawing.Point(3, 3)
        Me.MTech010VerticalProgessBar8.Maximum = 1023
        Me.MTech010VerticalProgessBar8.Name = "MTech010VerticalProgessBar8"
        Me.MTech010VerticalProgessBar8.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar8.TabIndex = 3
        '
        'MTech010VerticalProgessBar9
        '
        Me.MTech010VerticalProgessBar9.Location = New System.Drawing.Point(35, 3)
        Me.MTech010VerticalProgessBar9.Maximum = 1023
        Me.MTech010VerticalProgessBar9.Name = "MTech010VerticalProgessBar9"
        Me.MTech010VerticalProgessBar9.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar9.TabIndex = 4
        '
        'MTech010VerticalProgessBar10
        '
        Me.MTech010VerticalProgessBar10.Location = New System.Drawing.Point(67, 3)
        Me.MTech010VerticalProgessBar10.Maximum = 1023
        Me.MTech010VerticalProgessBar10.Name = "MTech010VerticalProgessBar10"
        Me.MTech010VerticalProgessBar10.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar10.TabIndex = 5
        '
        'MTech010VerticalProgessBar11
        '
        Me.MTech010VerticalProgessBar11.Location = New System.Drawing.Point(99, 3)
        Me.MTech010VerticalProgessBar11.Maximum = 1023
        Me.MTech010VerticalProgessBar11.Name = "MTech010VerticalProgessBar11"
        Me.MTech010VerticalProgessBar11.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar11.TabIndex = 6
        '
        'MTech010VerticalProgessBar12
        '
        Me.MTech010VerticalProgessBar12.Location = New System.Drawing.Point(131, 3)
        Me.MTech010VerticalProgessBar12.Maximum = 1023
        Me.MTech010VerticalProgessBar12.Name = "MTech010VerticalProgessBar12"
        Me.MTech010VerticalProgessBar12.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar12.TabIndex = 7
        '
        'MTech010VerticalProgessBar13
        '
        Me.MTech010VerticalProgessBar13.Location = New System.Drawing.Point(163, 3)
        Me.MTech010VerticalProgessBar13.Maximum = 1023
        Me.MTech010VerticalProgessBar13.Name = "MTech010VerticalProgessBar13"
        Me.MTech010VerticalProgessBar13.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar13.TabIndex = 8
        '
        'MTech010VerticalProgessBar14
        '
        Me.MTech010VerticalProgessBar14.Location = New System.Drawing.Point(195, 3)
        Me.MTech010VerticalProgessBar14.Maximum = 1023
        Me.MTech010VerticalProgessBar14.Name = "MTech010VerticalProgessBar14"
        Me.MTech010VerticalProgessBar14.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar14.TabIndex = 9
        '
        'MTech010VerticalProgessBar1
        '
        Me.MTech010VerticalProgessBar1.AccessibleName = ""
        Me.MTech010VerticalProgessBar1.Location = New System.Drawing.Point(3, 3)
        Me.MTech010VerticalProgessBar1.Maximum = 1023
        Me.MTech010VerticalProgessBar1.Name = "MTech010VerticalProgessBar1"
        Me.MTech010VerticalProgessBar1.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar1.TabIndex = 3
        '
        'MTech010VerticalProgessBar2
        '
        Me.MTech010VerticalProgessBar2.Location = New System.Drawing.Point(35, 3)
        Me.MTech010VerticalProgessBar2.Maximum = 1023
        Me.MTech010VerticalProgessBar2.Name = "MTech010VerticalProgessBar2"
        Me.MTech010VerticalProgessBar2.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar2.TabIndex = 4
        '
        'MTech010VerticalProgessBar3
        '
        Me.MTech010VerticalProgessBar3.Location = New System.Drawing.Point(67, 3)
        Me.MTech010VerticalProgessBar3.Maximum = 1023
        Me.MTech010VerticalProgessBar3.Name = "MTech010VerticalProgessBar3"
        Me.MTech010VerticalProgessBar3.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar3.TabIndex = 5
        '
        'MTech010VerticalProgessBar4
        '
        Me.MTech010VerticalProgessBar4.Location = New System.Drawing.Point(99, 3)
        Me.MTech010VerticalProgessBar4.Maximum = 1023
        Me.MTech010VerticalProgessBar4.Name = "MTech010VerticalProgessBar4"
        Me.MTech010VerticalProgessBar4.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar4.TabIndex = 6
        '
        'MTech010VerticalProgessBar5
        '
        Me.MTech010VerticalProgessBar5.Location = New System.Drawing.Point(131, 3)
        Me.MTech010VerticalProgessBar5.Maximum = 1023
        Me.MTech010VerticalProgessBar5.Name = "MTech010VerticalProgessBar5"
        Me.MTech010VerticalProgessBar5.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar5.TabIndex = 7
        '
        'MTech010VerticalProgessBar6
        '
        Me.MTech010VerticalProgessBar6.Location = New System.Drawing.Point(163, 3)
        Me.MTech010VerticalProgessBar6.Maximum = 1023
        Me.MTech010VerticalProgessBar6.Name = "MTech010VerticalProgessBar6"
        Me.MTech010VerticalProgessBar6.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar6.TabIndex = 8
        '
        'MTech010VerticalProgessBar7
        '
        Me.MTech010VerticalProgessBar7.Location = New System.Drawing.Point(195, 3)
        Me.MTech010VerticalProgessBar7.Maximum = 1023
        Me.MTech010VerticalProgessBar7.Name = "MTech010VerticalProgessBar7"
        Me.MTech010VerticalProgessBar7.Size = New System.Drawing.Size(26, 97)
        Me.MTech010VerticalProgessBar7.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 995)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MIDI_Start)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.NoteC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chart1_TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.FlowLayoutPanel5)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Chart1_TableLayoutPanel1.ResumeLayout(False)
        Me.Chart1_TableLayoutPanel1.PerformLayout()
        CType(Me.Chart1_3D_Rotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1_3D_Neigungswinkel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1_3D_PointDepth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1_3D_PointGrabDepth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_Comport As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Disconnect As System.Windows.Forms.Button
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MTech010VerticalProgessBar2 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar3 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar4 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar5 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar6 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar7 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MTech010VerticalProgessBar8 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar9 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar10 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar11 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar12 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar13 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar14 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MTech010VerticalProgessBar15 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar16 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar17 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar18 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar19 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar20 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar21 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MTech010VerticalProgessBar22 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar23 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar24 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar25 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar26 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar27 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar28 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MTech010VerticalProgessBar29 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar30 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar31 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar32 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar33 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar34 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents MTech010VerticalProgessBar35 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents MTech010VerticalProgessBar1 As C_Control_PRO_Visualisieren.MTech010VerticalProgessBar
    Friend WithEvents Save As System.Windows.Forms.Button
    Public WithEvents SaveMIDIDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Tackt As System.Windows.Forms.Timer
    Friend WithEvents Tackt_Ausgabefenster As System.Windows.Forms.Label
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents MIDI_Start As System.Windows.Forms.Button
    Friend WithEvents Chart1_3D_LightStyle As System.Windows.Forms.CheckBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents NoteC As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Chart1_TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Chart1_3D_Rotation As System.Windows.Forms.NumericUpDown
    Friend WithEvents Chart1_3D_Neigungswinkel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Chart1_3D_PointDepth_Text As System.Windows.Forms.Label
    Friend WithEvents Chart1_3D_PointDepth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Chart1_3D_PointGrabDepth_Text As System.Windows.Forms.Label
    Friend WithEvents Chart1_3D_PointGrabDepth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
