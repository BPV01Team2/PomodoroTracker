using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class AboutForm : Form
    {
        private Form1 _parentForm = null;
        public AboutForm(Form1 timer)
        {
            //
            _parentForm = timer;
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(PomodoroPictureBox.Location.X + 7, PomodoroPictureBox.Location.Y + 29, PomodoroPictureBox.Width, PomodoroPictureBox.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }        

        
        private void button_about_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel_teamlead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/Demonity543");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        private void linkLabel_develop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/DanielMikitiuk");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        private void linkLabel1_develop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/IitzSergo");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        private void linkLabel_develop2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/OwerMoon");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        private void linkLabel_develop3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/Andiry-sys");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        private void linkLabel_teacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/pertsov");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        private void PomodoroPictureBox_MouseDown_1(object sender, MouseEventArgs e)
        {
            PomodoroPictureBox.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PomodoroPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
