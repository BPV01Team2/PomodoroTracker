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

        
        private void button_about_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
