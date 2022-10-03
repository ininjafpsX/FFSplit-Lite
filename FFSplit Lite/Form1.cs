using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Compression;

namespace FFSplit_Lite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mov;
        int movX;
        int movY;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }
        private void devBtn_MouseHover(object sender, EventArgs e)
        {
            devlblBar.Visible = true;
        }

        private void devBtn_MouseLeave(object sender, EventArgs e)
        {
            devlblBar.Visible = false;
        }

        private void siteoficial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ffsplit.com");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LOAD
        }

        private void devBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ininjafpsX");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files (x86)\FFsplit\FFsplit.exe");
            string zipPath = @"ffmpeg.zip";
            string extractPath = @"\FFsplit";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string local = lblText.Text = path + extractPath;


            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, local);

        }

        private void move_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void move_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void move_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("FFmodSetup.exe");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("setupFF.exe");
        }
    }
}
