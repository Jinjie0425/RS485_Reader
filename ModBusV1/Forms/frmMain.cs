using Modbus.Device;
using ModBusV1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ModBusV1
{
    public partial class FrmMain : Form
    {
        //private Rectangle originalFormSize;
        //private Rectangle ampereReadingSize;

        SerialPort serialPort;
        IModbusSerialMaster master;
        byte slaveAddress = Properties.Settings.Default.Address;

        public static int[] BaudRate = new int[] { 4800, 9600, 19200, 38400, 57600, 115200 };
        public static int[] DataBits = new int[] { 7, 8 };
        public static int[] StepBits = new int[] { 1, 2 };

        public FrmMain()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            comm_setting();
            connectDevice();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Resize
            //originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            //originalFormSize = this.Size;
            //ampereReadingSize = new Rectangle(title.Location.X, title.Location.Y, title.Width, title.Height);

            UpdateStatus();
            tmr.Interval = Properties.Settings.Default.Refresh;
        }

        /*private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width)/(float)(originalFormSize.Width);
            float yRatio = (float)(this.Height)/(float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Size.Width * xRatio);
            int newHeight = (int)(r.Size.Height * yRatio);

            c.Location = new System.Drawing.Point(newX, newY);
            c.Size = new System.Drawing.Size(newWidth, newHeight);
        }*/

        /*private void resizeChildrenControl()
        {
            resizeControl(ampereReadingSize, title);
            resizeControl(ampereReadingSize, ampereLabel);
            resizeControl(ampereReadingSize, ampereReading);
        }*/

        /*private void FrmMain_Resize(object sender, EventArgs e)
        {
            
        }*/

        private void MnuFileSettings_Click(object sender, EventArgs e)
        {
            //FrmSettings frmSettings = new FrmSettings();
            //var result = frmSettings.ShowDialog(this);

            //if (result == DialogResult.OK)
            //{
                /*
                Properties.Settings.Default.ComPort = frmSettings.cmbComPort.Text;
                Properties.Settings.Default.Baudrate = int.Parse(frmSettings.cmbBaudrate.Text);
                Properties.Settings.Default.DataBits = int.Parse(frmSettings.cmbDataBits.Text);
                Properties.Settings.Default.ParityBits = frmSettings.cmbParityBits.SelectedIndex;
                Properties.Settings.Default.StopBits = frmSettings.cmbStopBits.SelectedIndex;
                Properties.Settings.Default.Refresh = int.Parse(frmSettings.NumRefresh.Value.ToString());
                Properties.Settings.Default.Address = byte.Parse(frmSettings.NumAddress.Value.ToString());
                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;
                */

                Properties.Settings.Default.ComPort = "COM5";
                Properties.Settings.Default.Baudrate = 9600;
                Properties.Settings.Default.DataBits = 8;
                Properties.Settings.Default.ParityBits = 0;
                Properties.Settings.Default.StopBits = 1;
                Properties.Settings.Default.Refresh = 2000;
                Properties.Settings.Default.Address = 1;

                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;

                Properties.Settings.Default.Save();
                UpdateStatus();
            //}

            //frmSettings.Dispose();
        }

        private void comm_setting()
        {
            FrmSettings frmSettings = new FrmSettings();
            //var result = frmSettings.ShowDialog(this);

            //Window com port setting
            //Properties.Settings.Default.ComPort = "COM5";
            //Raspberry com port setting
            Properties.Settings.Default.ComPort = "/dev/ttyUSB0";
            Properties.Settings.Default.Baudrate = 9600;
            Properties.Settings.Default.DataBits = 8;
            Properties.Settings.Default.ParityBits = 0;
            Properties.Settings.Default.StopBits = 1;
            Properties.Settings.Default.Refresh = 2000;
            Properties.Settings.Default.Address = 1;

            slaveAddress = Properties.Settings.Default.Address;
            tmr.Interval = Properties.Settings.Default.Refresh;

            Properties.Settings.Default.Save();
            UpdateStatus();

           // frmSettings.Dispose();
        }

        private void UpdateStatus()
        {
            stsComPort.Text = "Port: " + Properties.Settings.Default.ComPort;
            stsBaudRate.Text = "Baud Rate: " + Properties.Settings.Default.Baudrate;
            stsDataBits.Text = "Data Bits: " + Properties.Settings.Default.DataBits;
            stsParity.Text = "Parity: " + (Parity)Properties.Settings.Default.ParityBits;
            stsStopBits.Text = "Stop Bits: " + (StopBits)Properties.Settings.Default.StopBits;
        }

        private void connectDevice()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = Properties.Settings.Default.ComPort;
                serialPort.BaudRate = Properties.Settings.Default.Baudrate;
                serialPort.DataBits = Properties.Settings.Default.DataBits;
                serialPort.Parity = (Parity)Properties.Settings.Default.ParityBits;
                serialPort.StopBits = (StopBits)Properties.Settings.Default.StopBits;

                if (!serialPort.IsOpen) serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.ReadTimeout = 1000;
                master.Transport.WriteTimeout = 1000;

                stsState.Text = "Connected";
                stsState.ForeColor = Color.DarkGreen;
                /*mnuFileConnect.Enabled = false;
                mnuFileSettings.Enabled = false;
                mnuFileDisConnect.Enabled = true;*/
                voltageReading.Visible = true;
                /*numAddress.Visible = false;
                numValue.Visible = false;
                BtnSend.Visible = false;*/
                ampereReading.Visible = true;
                powerReading.Visible = true;
                powerUnit.Visible = true;
                /*LblAddress.Visible = true;
                LblValue.Visible = true;*/

                BackgroundImage = null;

                tmr.Start();
            }
            catch (IOException exIO)
            {
               /* if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "SerialPort is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
            catch (Exception ex)
            {
               /* MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }

        private void MnuFileConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = Properties.Settings.Default.ComPort;
                serialPort.BaudRate = Properties.Settings.Default.Baudrate;
                serialPort.DataBits = Properties.Settings.Default.DataBits;
                serialPort.Parity = (Parity)Properties.Settings.Default.ParityBits;
                serialPort.StopBits = (StopBits)Properties.Settings.Default.StopBits;

                if (!serialPort.IsOpen) serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.ReadTimeout = 1000;
                master.Transport.WriteTimeout = 1000;

                stsState.Text = "Connected";
                stsState.ForeColor = Color.DarkGreen;
               /* mnuFileConnect.Enabled = false;
                mnuFileSettings.Enabled = false;
                mnuFileDisConnect.Enabled = true;*/
                voltageReading.Visible = true;
                /*numAddress.Visible = false;
                numValue.Visible = false;
                BtnSend.Visible = false;*/
                ampereReading.Visible = true;
                powerReading.Visible = true;
                /*BtnInc.Visible = true;
                BtnDec.Visible = true;*/
                /* LblAddress.Visible = true;
                 LblValue.Visible = true;*/

                BackgroundImage = null;

                tmr.Start();
            }
            catch (IOException exIO)
            {
               /* if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "SerialPort is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
            catch (Exception ex)
            {
                /*MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(this, "Do you want to close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.btnPlayPause) == DialogResult.Yes)
            {
                serialPort.Close();
                serialPort.Dispose();
                this.Dispose();
            }*/
        }

        private void MnuFileDisConnect_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            serialPort.Close();
            serialPort.Dispose();
            master.Dispose();

            stsState.Text = "Disconnected";
            stsState.ForeColor = Color.DarkRed;
            /*mnuFileConnect.Enabled = true;
            mnuFileSettings.Enabled = true;
            mnuFileDisConnect.Enabled = false;*/
           /* numAddress.Visible = false;
            numValue.Visible = false;
            BtnSend.Visible = false;*/
            voltageReading.Visible = true;
            ampereReading.Visible = true;
            powerReading.Visible = true;
            powerUnit.Visible = true;
            /*BtnInc.Visible = false;
            BtnDec.Visible = false;*/
            /*LblAddress.Visible = false;
            LblValue.Visible = false;*/
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            int val = 0;
            double d_val_w = 0.0;

            try
            {
                if (serialPort.IsOpen && master != null)
                {
                    //Voltage Address
                    val = master.ReadHoldingRegisters(slaveAddress, 1, 1)[0];
                    double d_val_v = val / 100.0;
                    voltageReading.Text = d_val_v.ToString("0.00");

                    //Ampere Address
                    val = master.ReadHoldingRegisters(slaveAddress, 7, 1)[0];
                    double d_val_a = val / 1000.0;
                    ampereReading.Text = d_val_a.ToString("0.00");

                    //PowerFactor Address
                    /* val = master.ReadHoldingRegisters(slaveAddress, 30, 1)[0];
                     double d_val_pf = val / 1000.0;*/

                    //Calc Watt
                    d_val_w = d_val_v * d_val_a;
                    powerReading.Text = d_val_w.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MnuFileDisConnect_Click(this, new EventArgs());

               /* if (ex.HResult == -2146233083)
                    MessageBox.Show(this, "Check SlaveAddress then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }

            Invalidate();
        }

        private void fondaLogo_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frmVideo fv = new frmVideo())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    fv.Owner = formBackground;
                    fv.ShowDialog();

                     formBackground.Dispose();
                }
                
            }

            catch (Exception ex)
            {

            }

        }
    }
}

/*private void btnPlayAgain_Click(object sender, EventArgs e)
{
    master.WriteSingleRegister(slaveAddress, Convert.ToUInt16(numAddress.Value.ToString()), Convert.ToUInt16(numValue.Value.ToString()));
}

private void numAddress_ValueChanged(object sender, EventArgs e)
{
    try
    {
        if (serialPort.IsOpen && master != null)
        {
            numValue.Value = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value.ToString()), 1)[0];
            if (numValue.Value == 0)
                ampere.Text = numValue.Value.ToString("0#.0");
        }
    }
    catch (Exception ex)
    {
        if (ex.HResult == -2146233088)
            MessageBox.Show(this, "Address is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}*/