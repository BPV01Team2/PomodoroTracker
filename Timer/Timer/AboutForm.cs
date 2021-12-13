using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_teamlead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Demonity543");
        }

        private void linkLabel_develop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielMikitiuk");
        }

        private void linkLabel1_develop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IitzSergo");
        }

        private void linkLabel_develop2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/OwerMoon");
        }

        private void linkLabel_develop3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Andiry-sys");
        }

        private void linkLabel_teacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pertsov");
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
