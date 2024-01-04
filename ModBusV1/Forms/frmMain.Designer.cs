
using System.Drawing;
using System.Windows.Forms;

namespace ModBusV1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stsComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.title = new System.Windows.Forms.Label();
            this.voltageReading = new System.Windows.Forms.Label();
            this.ampereReading = new System.Windows.Forms.Label();
            this.powerReading = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.ampereLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.powerUnit = new System.Windows.Forms.Label();
            this.voltageUnit = new System.Windows.Forms.Label();
            this.ampereUnit = new System.Windows.Forms.Label();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.BackColor = System.Drawing.SystemColors.MenuBar;
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsComPort,
            this.stsBaudRate,
            this.stsDataBits,
            this.stsParity,
            this.stsStopBits,
            this.stsState});
            this.stsMain.Location = new System.Drawing.Point(0, 689);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(1184, 22);
            this.stsMain.TabIndex = 3;
            this.stsMain.Text = "statusStrip1";
            // 
            // stsComPort
            // 
            this.stsComPort.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsComPort.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsComPort.Name = "stsComPort";
            this.stsComPort.Size = new System.Drawing.Size(4, 17);
            this.stsComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsBaudRate
            // 
            this.stsBaudRate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsBaudRate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsBaudRate.Name = "stsBaudRate";
            this.stsBaudRate.Size = new System.Drawing.Size(4, 17);
            this.stsBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsDataBits
            // 
            this.stsDataBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsDataBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsDataBits.Name = "stsDataBits";
            this.stsDataBits.Size = new System.Drawing.Size(4, 17);
            this.stsDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsParity
            // 
            this.stsParity.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsParity.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsParity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsParity.Name = "stsParity";
            this.stsParity.Size = new System.Drawing.Size(4, 17);
            // 
            // stsStopBits
            // 
            this.stsStopBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsStopBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsStopBits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsStopBits.Name = "stsStopBits";
            this.stsStopBits.Size = new System.Drawing.Size(4, 17);
            // 
            // stsState
            // 
            this.stsState.AutoSize = false;
            this.stsState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsState.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsState.ForeColor = System.Drawing.Color.DarkRed;
            this.stsState.Name = "stsState";
            this.stsState.Size = new System.Drawing.Size(1149, 17);
            this.stsState.Spring = true;
            this.stsState.Text = "Disconnected";
            this.stsState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.DimGray;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(95, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1122, 52);
            this.title.TabIndex = 15;
            this.title.Text = "HAND TOOLS RATED VOLTAGE AND RATED CURRENT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voltageReading
            // 
            this.voltageReading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voltageReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.voltageReading.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageReading.ForeColor = System.Drawing.Color.Gold;
            this.voltageReading.Location = new System.Drawing.Point(651, 432);
            this.voltageReading.Margin = new System.Windows.Forms.Padding(0);
            this.voltageReading.Name = "voltageReading";
            this.voltageReading.Size = new System.Drawing.Size(237, 80);
            this.voltageReading.TabIndex = 4;
            this.voltageReading.Text = "Volt";
            this.voltageReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ampereReading
            // 
            this.ampereReading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ampereReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ampereReading.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampereReading.ForeColor = System.Drawing.Color.Gold;
            this.ampereReading.Location = new System.Drawing.Point(651, 575);
            this.ampereReading.Margin = new System.Windows.Forms.Padding(0);
            this.ampereReading.Name = "ampereReading";
            this.ampereReading.Size = new System.Drawing.Size(237, 80);
            this.ampereReading.TabIndex = 8;
            this.ampereReading.Text = "Amp";
            this.ampereReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerReading
            // 
            this.powerReading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.powerReading.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerReading.ForeColor = System.Drawing.Color.Gold;
            this.powerReading.Location = new System.Drawing.Point(651, 288);
            this.powerReading.Margin = new System.Windows.Forms.Padding(0);
            this.powerReading.Name = "powerReading";
            this.powerReading.Size = new System.Drawing.Size(237, 80);
            this.powerReading.TabIndex = 16;
            this.powerReading.Text = "Power";
            this.powerReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voltageLabel
            // 
            this.voltageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voltageLabel.BackColor = System.Drawing.Color.White;
            this.voltageLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.ForeColor = System.Drawing.Color.Red;
            this.voltageLabel.Location = new System.Drawing.Point(45, 432);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(614, 80);
            this.voltageLabel.TabIndex = 17;
            this.voltageLabel.Text = "Rated Voltage";
            this.voltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ampereLabel
            // 
            this.ampereLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ampereLabel.BackColor = System.Drawing.Color.White;
            this.ampereLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampereLabel.ForeColor = System.Drawing.Color.Red;
            this.ampereLabel.Location = new System.Drawing.Point(45, 575);
            this.ampereLabel.Name = "ampereLabel";
            this.ampereLabel.Size = new System.Drawing.Size(614, 80);
            this.ampereLabel.TabIndex = 18;
            this.ampereLabel.Text = "Rated Current";
            this.ampereLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerLabel
            // 
            this.powerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerLabel.BackColor = System.Drawing.Color.White;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.ForeColor = System.Drawing.Color.Red;
            this.powerLabel.Location = new System.Drawing.Point(45, 288);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(614, 80);
            this.powerLabel.TabIndex = 19;
            this.powerLabel.Text = "Power Consumption";
            this.powerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerUnit
            // 
            this.powerUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerUnit.BackColor = System.Drawing.Color.Red;
            this.powerUnit.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUnit.ForeColor = System.Drawing.Color.White;
            this.powerUnit.Location = new System.Drawing.Point(879, 288);
            this.powerUnit.Margin = new System.Windows.Forms.Padding(0);
            this.powerUnit.Name = "powerUnit";
            this.powerUnit.Size = new System.Drawing.Size(232, 80);
            this.powerUnit.TabIndex = 20;
            this.powerUnit.Text = "Watt";
            this.powerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voltageUnit
            // 
            this.voltageUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voltageUnit.BackColor = System.Drawing.Color.Red;
            this.voltageUnit.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageUnit.ForeColor = System.Drawing.Color.White;
            this.voltageUnit.Location = new System.Drawing.Point(879, 432);
            this.voltageUnit.Margin = new System.Windows.Forms.Padding(0);
            this.voltageUnit.Name = "voltageUnit";
            this.voltageUnit.Size = new System.Drawing.Size(232, 80);
            this.voltageUnit.TabIndex = 21;
            this.voltageUnit.Text = "Volt";
            this.voltageUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ampereUnit
            // 
            this.ampereUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ampereUnit.BackColor = System.Drawing.Color.Red;
            this.ampereUnit.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampereUnit.ForeColor = System.Drawing.Color.White;
            this.ampereUnit.Location = new System.Drawing.Point(879, 575);
            this.ampereUnit.Margin = new System.Windows.Forms.Padding(0);
            this.ampereUnit.Name = "ampereUnit";
            this.ampereUnit.Size = new System.Drawing.Size(232, 80);
            this.ampereUnit.TabIndex = 22;
            this.ampereUnit.Text = "Ampere";
            this.ampereUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.ampereUnit);
            this.Controls.Add(this.voltageUnit);
            this.Controls.Add(this.powerUnit);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.ampereLabel);
            this.Controls.Add(this.voltageLabel);
            this.Controls.Add(this.powerReading);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ampereReading);
            this.Controls.Add(this.voltageReading);
            this.Controls.Add(this.stsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACI RS485 Modbus Comunication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stsComPort;
        private System.Windows.Forms.ToolStripStatusLabel stsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel stsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel stsParity;
        private System.Windows.Forms.ToolStripStatusLabel stsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel stsState;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label title;
        private Label voltageReading;
        private Label ampereReading;
        private Label powerReading;
        private Label voltageLabel;
        private Label ampereLabel;
        private Label powerLabel;
        private Label powerUnit;
        private Label voltageUnit;
        private Label ampereUnit;
    }
}

