namespace COM_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Connect_GroupBox = new System.Windows.Forms.GroupBox();
            this.ComboBox_Comport = new System.Windows.Forms.ComboBox();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Com_Search_Timer = new System.Windows.Forms.Timer(this.components);
            this.Messintervall_GroupBox = new System.Windows.Forms.GroupBox();
            this.Messintervall_TextBox = new System.Windows.Forms.TextBox();
            this.MessungenProS_TexBox = new System.Windows.Forms.TextBox();
            this.Messintervall_Label = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Anz_Messungen_TextBox = new System.Windows.Forms.TextBox();
            this.Anz_Verbindungsfehler_TextBox = new System.Windows.Forms.TextBox();
            this.Serial_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Connect_GroupBox.SuspendLayout();
            this.Messintervall_GroupBox.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect_GroupBox
            // 
            this.Connect_GroupBox.Controls.Add(this.ComboBox_Comport);
            this.Connect_GroupBox.Controls.Add(this.Button_Disconnect);
            this.Connect_GroupBox.Controls.Add(this.Button_Connect);
            this.Connect_GroupBox.Location = new System.Drawing.Point(17, 18);
            this.Connect_GroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Connect_GroupBox.Name = "Connect_GroupBox";
            this.Connect_GroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Connect_GroupBox.Size = new System.Drawing.Size(559, 110);
            this.Connect_GroupBox.TabIndex = 189;
            this.Connect_GroupBox.TabStop = false;
            this.Connect_GroupBox.Text = "Comport - Verbindungseinstellungen für Mikrokontroller";
            // 
            // ComboBox_Comport
            // 
            this.ComboBox_Comport.FormattingEnabled = true;
            this.ComboBox_Comport.Location = new System.Drawing.Point(381, 43);
            this.ComboBox_Comport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComboBox_Comport.Name = "ComboBox_Comport";
            this.ComboBox_Comport.Size = new System.Drawing.Size(144, 33);
            this.ComboBox_Comport.Sorted = true;
            this.ComboBox_Comport.TabIndex = 6;
            this.ComboBox_Comport.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Comport_SelectedIndexChanged);
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Location = new System.Drawing.Point(173, 36);
            this.Button_Disconnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(149, 44);
            this.Button_Disconnect.TabIndex = 5;
            this.Button_Disconnect.Text = "Trennen";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(12, 36);
            this.Button_Connect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(149, 44);
            this.Button_Connect.TabIndex = 4;
            this.Button_Connect.Text = "Verbinden";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Com_Search_Timer
            // 
            this.Com_Search_Timer.Enabled = true;
            this.Com_Search_Timer.Interval = 2000;
            this.Com_Search_Timer.Tick += new System.EventHandler(this.Com_Search_Timer_Tick);
            // 
            // Messintervall_GroupBox
            // 
            this.Messintervall_GroupBox.Controls.Add(this.Messintervall_TextBox);
            this.Messintervall_GroupBox.Controls.Add(this.MessungenProS_TexBox);
            this.Messintervall_GroupBox.Controls.Add(this.Messintervall_Label);
            this.Messintervall_GroupBox.Location = new System.Drawing.Point(586, 30);
            this.Messintervall_GroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Messintervall_GroupBox.Name = "Messintervall_GroupBox";
            this.Messintervall_GroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Messintervall_GroupBox.Size = new System.Drawing.Size(433, 98);
            this.Messintervall_GroupBox.TabIndex = 191;
            this.Messintervall_GroupBox.TabStop = false;
            this.Messintervall_GroupBox.Text = "Messintervall vom Mikrokontroller";
            // 
            // Messintervall_TextBox
            // 
            this.Messintervall_TextBox.Enabled = false;
            this.Messintervall_TextBox.Location = new System.Drawing.Point(336, 42);
            this.Messintervall_TextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Messintervall_TextBox.Name = "Messintervall_TextBox";
            this.Messintervall_TextBox.ReadOnly = true;
            this.Messintervall_TextBox.Size = new System.Drawing.Size(87, 31);
            this.Messintervall_TextBox.TabIndex = 181;
            this.Messintervall_TextBox.Text = "0 ms";
            // 
            // MessungenProS_TexBox
            // 
            this.MessungenProS_TexBox.Enabled = false;
            this.MessungenProS_TexBox.Location = new System.Drawing.Point(115, 42);
            this.MessungenProS_TexBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MessungenProS_TexBox.Name = "MessungenProS_TexBox";
            this.MessungenProS_TexBox.ReadOnly = true;
            this.MessungenProS_TexBox.Size = new System.Drawing.Size(211, 31);
            this.MessungenProS_TexBox.TabIndex = 180;
            this.MessungenProS_TexBox.Text = "0 M/s";
            // 
            // Messintervall_Label
            // 
            this.Messintervall_Label.AutoSize = true;
            this.Messintervall_Label.Location = new System.Drawing.Point(19, 48);
            this.Messintervall_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Messintervall_Label.Name = "Messintervall_Label";
            this.Messintervall_Label.Size = new System.Drawing.Size(79, 25);
            this.Messintervall_Label.TabIndex = 179;
            this.Messintervall_Label.Text = "Mes/S:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Anz_Messungen_TextBox);
            this.GroupBox3.Controls.Add(this.Anz_Verbindungsfehler_TextBox);
            this.GroupBox3.Location = new System.Drawing.Point(1043, 41);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GroupBox3.Size = new System.Drawing.Size(397, 86);
            this.GroupBox3.TabIndex = 192;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Anz.Messungen + Verbindungsfehler";
            // 
            // Anz_Messungen_TextBox
            // 
            this.Anz_Messungen_TextBox.Enabled = false;
            this.Anz_Messungen_TextBox.Location = new System.Drawing.Point(24, 39);
            this.Anz_Messungen_TextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Anz_Messungen_TextBox.Name = "Anz_Messungen_TextBox";
            this.Anz_Messungen_TextBox.ReadOnly = true;
            this.Anz_Messungen_TextBox.Size = new System.Drawing.Size(164, 31);
            this.Anz_Messungen_TextBox.TabIndex = 0;
            this.Anz_Messungen_TextBox.Text = "0";
            this.Anz_Messungen_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Anz_Verbindungsfehler_TextBox
            // 
            this.Anz_Verbindungsfehler_TextBox.Enabled = false;
            this.Anz_Verbindungsfehler_TextBox.Location = new System.Drawing.Point(204, 39);
            this.Anz_Verbindungsfehler_TextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Anz_Verbindungsfehler_TextBox.Name = "Anz_Verbindungsfehler_TextBox";
            this.Anz_Verbindungsfehler_TextBox.ReadOnly = true;
            this.Anz_Verbindungsfehler_TextBox.Size = new System.Drawing.Size(177, 31);
            this.Anz_Verbindungsfehler_TextBox.TabIndex = 187;
            this.Anz_Verbindungsfehler_TextBox.Text = "0";
            this.Anz_Verbindungsfehler_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Serial_BackgroundWorker
            // 
            this.Serial_BackgroundWorker.WorkerSupportsCancellation = true;
            this.Serial_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SerialPort1_DataReceived);
            // 
            // SerialPort1
            // 
            this.SerialPort1.BaudRate = 230400;
            this.SerialPort1.DtrEnable = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1421, 719);
            this.textBox1.TabIndex = 193;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 872);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Messintervall_GroupBox);
            this.Controls.Add(this.Connect_GroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Connect_GroupBox.ResumeLayout(false);
            this.Messintervall_GroupBox.ResumeLayout(false);
            this.Messintervall_GroupBox.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox Connect_GroupBox;
        internal System.Windows.Forms.ComboBox ComboBox_Comport;
        internal System.Windows.Forms.Button Button_Disconnect;
        internal System.Windows.Forms.Button Button_Connect;
        internal System.Windows.Forms.Timer Com_Search_Timer;
        internal System.Windows.Forms.GroupBox Messintervall_GroupBox;
        internal System.Windows.Forms.TextBox Messintervall_TextBox;
        internal System.Windows.Forms.TextBox MessungenProS_TexBox;
        internal System.Windows.Forms.Label Messintervall_Label;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox Anz_Messungen_TextBox;
        internal System.Windows.Forms.TextBox Anz_Verbindungsfehler_TextBox;
        internal System.ComponentModel.BackgroundWorker Serial_BackgroundWorker;
        internal System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

