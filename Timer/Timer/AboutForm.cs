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
            _parentForm = timer;
            InitializeComponent(); 
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
    }
}
