using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;

namespace ModBusV1.Forms
{
    public partial class frmVideo : Form
    {

        public LibVLC _libVLC;
        public MediaPlayer _mp;

        public frmVideo()
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }

            InitializeComponent();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mp.Stop();
            _mp.Dispose();
            _libVLC.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var media = new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
            _mp.Play(media);
            media.Dispose();
        }

        /*public frmVideo()
        {
            InitializeComponent();
            vid_setting();
        }

        private void vid_setting()
        {
            try
            {
                //Window
                //vlcControl1.Play(new Uri(@"C:\Users\User\Desktop\ModBusCommunicate\ModBusV1\Resources\video.mp4"));
                //Raspberry pi4
                //vlcControl1.Play(new Uri(@"/home/aci/Desktop/RS485_20221025_1/video.mp4"));
            }

            catch (Exception ex)
            {

            }
        }*/
         
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Window
            vlcControl1.Play(new Uri(@"C:\Users\User\Desktop\ModBusCommunicate\ModBusV1\Resources\video.mp4"));
            //Raspberry pi4
            //vlcControl1.Play(new Uri(@"/home/aci/Desktop/RS485_20221025_1/video.mp4"));
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            /*if(btnPlayPause.Text == "Pause")
            {
                vlcControl1.Pause();
                btnPlayPause.Text = "Play";
            }

            else
            {
                vlcControl1.Play();
                btnPlayPause.Text = "Pause";
            }*/
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
           /* vlcControl1.Stop();*/
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "((*.mp4) | *.mp4";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vlcControl1.SetMedia(new System.IO.FileInfo(ofd.FileName));
            }*/
        }
    }
}
