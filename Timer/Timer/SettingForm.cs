using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using System.Linq;

namespace Timer
{
    public partial class SettingForm : Form
    {
        private Form1 _parentForm = null;
        private FileIOStream _file = null;
        private double _secondJob = 0.0;
        private int _minutesJob = 0;
        private double _secondRest = 0.0;
        private int _minutesRest = 0;
        private readonly string _path = $"{Environment.CurrentDirectory }\\Parmeteres.json";
        public List<SaveClass> _timers = null;

        public double SecondesJob { get { return _secondJob; } set { _secondJob = _timers.Select(x => x.SecondesJob ).First (); } }
        public int MinutesJob { get { return _minutesJob ; } set { _minutesJob = _timers.Select(x => x.MinutesJob ).First(); } }
        public double SecondesRest { get { return _secondRest ; } set { _secondRest = _timers.Select(x => x.SecondesRest).First();  } }
        public int MinutesRest { get { return _minutesJob; } set{  _minutesRest = _timers.Select(x => x.MinutesRest).First(); }  }
            
        public SettingForm(Form1 form)
        {
            InitializeComponent();
            _parentForm = form;
            _file = new FileIOStream(_path);
            _timers = new List<SaveClass>();
            
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            _minutesJob = int.Parse(textBox_MinForJob.Text);
            _minutesRest = int.Parse(textBox_MinForRest.Text);

            _secondJob = double.Parse(textBox_SecondForJob.Text);
            _secondRest = double.Parse(textBox_SecondForRest.Text);

            SaveClass save = new() { MinutesJob = _minutesJob, MinutesRest = _minutesRest, SecondesJob = _secondJob, SecondesRest = _secondRest };
           
            _timers.Add(save);
            _file.SaveData(_timers);
          

            textBox_MinForJob.Text = "";
            textBox_MinForRest.Text = "";
            textBox_SecondForJob.Text = "";
            textBox_SecondForRest.Text = "";

            Close();
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //SaveClass save = new() { MinutesJob = _minutesJob, MinutesRest = _minutesRest, SecondesJob = _secondJob, SecondesRest = _secondRest };
            //listBox_parametres.Items.Add();
        }
    }
}
