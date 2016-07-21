using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Diagnostics;

namespace COM_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Populates the COM List. Is executed once per second. 
        Handler of the Com_Search_Timer.Tick event.
        */
        private void Com_Search_Timer_Tick(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            ComboBox_Comport.Items.Clear();

            //Comports suchen
            foreach (var port in ports)
            {
                ComboBox_Comport.Items.Add(port);
            }

            ComboBox_Comport.Sorted = true;
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            //verbinden
            try
            {
                //Buttons freigeben-/sperren
                Button_Connect.Enabled = false;
                Button_Disconnect.Enabled = true;
                ComboBox_Comport.Enabled = false;

                //Comport öffnen
                SerialPort1.PortName = ComboBox_Comport.Text;
                SerialPort1.BaudRate = 230400; //Baudrate
                SerialPort1.DataBits = 8;
                SerialPort1.Encoding = System.Text.Encoding.Default;
                SerialPort1.Open();


                Com_Search_Timer.Enabled = false;
                Serial_BackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                //Fehlermeldung
                MessageBox.Show("Unter dem gewählten COM Port wurde kein Mikrokontroller erkannt. " + Environment.NewLine +
                                "Stellen Sie sicher, das Sie den Richtigen Port gewählt haben und der" + Environment.NewLine +
                                "Mikrokontroller korrekt mit dem Computer verbunden, und" + Environment.NewLine +
                                "nicht schon von einem anderen Programm besetzt ist." + Environment.NewLine +
                                "Fehler: " + ex.ToString() + Environment.NewLine +
                                "Support E-Mail Adresse: nico@bosshome.ch" + Environment.NewLine +
                                "Fehlercode: 1 (Verbindungsfehler)",
                                "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Button_Connect.Enabled = true;
                Button_Disconnect.Enabled = false;
                ComboBox_Comport.Enabled = true;
            }
        }

        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            /*
            Handler for the disconnect button and programm close event
            Stop the serial connection thread. Clean up GUI. 
            */
            Serial_BackgroundWorker.CancelAsync();
            Anz_Messungen_TextBox.Text = "0";
            Anz_Verbindungsfehler_TextBox.Text = "0";
            MessungenProS_TexBox.Text = "0 M/s";
            Messintervall_TextBox.Text = "0 ms";
            Com_Search_Timer.Enabled = true;
            Button_Connect.Enabled = true;
            Button_Disconnect.Enabled = false;
            ComboBox_Comport.Enabled = true;
            SerialPort1.Close();
        }

        private void ComboBox_Comport_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comport auswählen
            if (ComboBox_Comport.SelectedItem != "")
            {
                Button_Connect.Enabled = true;
            }
        }

        private void SerialPort1_DataReceived(object sender, DoWorkEventArgs e)
        {
            var ShowResultsCount = 0;
            double Messintervall_Zahl = 0;
            double Anz_Messungen = 0;
            double AnzMessungen_alt = 0;
            var Anz_Verbindungsfehler = 0;
            Anz_Messungen_TextBox.Text = "0";
            Anz_Verbindungsfehler_TextBox.Text = "0";
            Stopwatch stopWatch = new Stopwatch();

            //while (SerialPort1.ReadByte() != 250) ;
            int serial;

            stopWatch.Start();
            while (true)
            {
                while (true)
                {
                    //serial = SerialPort1.ReadByte();
                    //MessageBox.Show(SerialPort1.ReadByte().ToString());
                    //Invoke((MethodInvoker)delegate ()
                    //{
                    //    textBox1.AppendText(((char)serial).ToString());
                    //});
                    if (SerialPort1.ReadByte() == 13)
                    {
                        break;
                    }
                    //Console.WriteLine(SerialPort1.ReadByte().ToString());
                }
                ShowResultsCount++;
                Anz_Messungen++;
                if (ShowResultsCount == 500)
                {
                    stopWatch.Stop();
                    //MessageBox.Show("");
                    ShowResultsCount = 0;
                    Invoke((MethodInvoker)delegate ()
                    {
                        try
                        {
                            //250ms
                            Anz_Messungen_TextBox.Text = Anz_Messungen.ToString();
                            //Anz_Messungen_TextBox.Text = (Anz_Messungen - AnzMessungen_alt).ToString();
                            //Anz_Messungen_TextBox.Text = stopWatch.ElapsedMilliseconds.ToString();
                            Messintervall_Zahl = (Anz_Messungen - AnzMessungen_alt) / (stopWatch.ElapsedMilliseconds / 1000.0); //Achtung: Komischerweise Divison durch 0 wenn AnzMessungen_alt > Anz_Messungen! Wieso habe ich keine Ahnung.
                            MessungenProS_TexBox.Text = String.Format(Messintervall_Zahl.ToString(), "000") + " M/s";
                            Messintervall_TextBox.Text = String.Format((1000 / Messintervall_Zahl).ToString(), "00.0") + " ms";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        AnzMessungen_alt = Anz_Messungen;
                        //textBox1.AppendText(Environment.NewLine);
                        stopWatch.Restart();
                    });
                }
                
            }
        }

    }
}

