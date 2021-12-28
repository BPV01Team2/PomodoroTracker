using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int id = 1;
        private int m;
        private double s;
        private AboutForm _about = null;
        public Form1()
        {
            InitializeComponent();
            _about = new AboutForm(this);
            GraphicsPath myPath = new GraphicsPath();
            button_Settinges.Text = "Music";
            myPath.AddEllipse(PomodoroPictureBox.Location.X + 7, PomodoroPictureBox.Location.Y + 29, PomodoroPictureBox.Width, PomodoroPictureBox.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            m = 15;
            s = 00;
            labelMinutes.Text = m.ToString();
            labelSeconds.Text = s.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (id == 1)
            {
                TimerTicker.Start();
            }else if (id == 0)
            {
                TimerTickerRest.Start();
            }
        }

        private void TimerTicker_Tick_1(object sender, EventArgs e)
        {
            id = 1;
            if (m == 0 && s == 00)
            {
                TimerTicker.Stop();
                MessageBox.Show("Не можна почати таймер. Час = 0");
            }
            else
            {

                m = Convert.ToInt32(labelMinutes.Text);
                s = Convert.ToDouble(labelSeconds.Text);

                s--;
                labelMinutes.Text = m.ToString();
                labelSeconds.Text = s.ToString();
                if (s < 10)
                {
                    labelSeconds.Text = "0" + s.ToString();
                }
                if (s <= 00 && m > 0)
                {
                    s = 59;
                    m--;
                    labelMinutes.Text = m.ToString();
                    labelSeconds.Text = s.ToString();
                }
            }
            if (m == 0 && s == 0)
            {
               TimerTicker.Stop();
                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = button_Settinges.Text;
                    if (button_Settinges.Text != string.Empty)
                    {
                        player.Load();
                        player.PlaySync();
                        MessageBox.Show("Час вийшов!");
                    }
                    else
                    {
                        MessageBox.Show("Ви не вибрали музику.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult result= MessageBox.Show("Пора Відпочити","Перерва",MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    m = 5;
                    s = 00;
                    labelMinutes.Text = m.ToString();
                    labelSeconds.Text = s.ToString();

                    TimerTickerRest.Start();
                }
                else
                {
                    m = 15;
                    s = 00;
                    labelMinutes.Text = m.ToString();
                    labelSeconds.Text = s.ToString();
                    TimerTicker.Start();
                    
                    if (s < 10)
                    {
                        labelSeconds.Text = "0" + s.ToString();
                    }
                    if (s == 00 && m > 0)
                    {
                        s = 59;
                        m--;
                        labelMinutes.Text = m.ToString();
                        labelSeconds.Text = s.ToString();
                    }
                }

            }
        }

        private void buttonPlusSeconds_Click(object sender, EventArgs e)
        {
            s += 10;
            if (s>=60 && m == 59)
            {
                s = 59;
                m = 59;
                MessageBox.Show("Більше години зараз ставити не можна");
            }
            else  if (s >= 60&&m<60)
            {
                s = 00;
                m++;
            }
            labelMinutes.Text = m.ToString();
            if ( s < 10)
            {
                labelSeconds.Text = "0" + s.ToString();
            }
            else
            {
                labelSeconds.Text = s.ToString();
            }
        }

        private void buttonMinusSeconds_Click_1(object sender, EventArgs e)
        {
            s -= 10;
            if (s <= 00)
            {
                if (m <= 0)
                {
                    s = 00;
                    m = 00;
                    MessageBox.Show("Не можна вибирати час з мінусовими значеннями");
                }
                else
                {
                    s = 59;
                    m--;
                }
            }

            labelMinutes.Text = m.ToString();
            if ( s < 10)
            {
                labelSeconds.Text = "0" + s.ToString();
            }
            else
            {
                labelSeconds.Text = s.ToString();
            }
        }

        private void buttonMinusMinutes_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(labelSeconds.Text);
            labelSeconds.Text = "0" + s.ToString();
            m -= 1;
            if (m < 0)
            {
                MessageBox.Show("Не можна вибирати хвилини мінусовим числом");
                m = 0;
            }
            if (m == 00)
            {
                m = 00;
                s = Convert.ToInt32(labelSeconds.Text);
            }
            if (m < 10)
            {
                labelMinutes.Text = "0" + m.ToString();
            }
            labelMinutes.Text = m.ToString();
            if (s<10)
            {
                labelSeconds.Text = "0" + s.ToString();
            }
            else
            {
                labelSeconds.Text = s.ToString();
            }
        }

        private void buttonPlusMinutes_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(labelSeconds.Text);
            labelSeconds.Text = "0" + s.ToString();
            m += 1;
            if (m == 60)
            {
                m = 59;
                MessageBox.Show("Більше години зараз ставити не можна");
            }
            labelMinutes.Text = m.ToString();
            if ( s < 10)
            {
                labelSeconds.Text = "0" + s.ToString();
            }
            else
            {
                labelSeconds.Text = s.ToString();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            TimerTicker.Stop();
            TimerTickerRest.Stop();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            labelMinutes.Text = "";
            labelSeconds.Text = "";
            labelMinutes.Text += m.ToString();
            labelSeconds.Text += "0" + s.ToString();            
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            if(_about != null )
            {
                _about = new AboutForm(this);
                _about.Show();
            }
            else
            {
                _about = new AboutForm(this);
            }
        }      

        private void TimerTickerRest_Tick(object sender, EventArgs e)
        {
            id = 0;
            if (m == 0 && s == 00)
            {
                TimerTickerRest.Stop();
                MessageBox.Show("Не можна почати таймер. Час = 0");
            }
            else
            {

                m = Convert.ToInt32(labelMinutes.Text);
                s = Convert.ToDouble(labelSeconds.Text);
                s--;
                labelMinutes.Text = m.ToString();
                labelSeconds.Text = s.ToString();
                if (s < 10)
                {
                    labelSeconds.Text = "0" + s.ToString();
                }
                if (s <= 00 && m > 0)
                {
                    s = 59;
                    m--;
                    labelMinutes.Text = m.ToString();
                    labelSeconds.Text = s.ToString();
                }
            }
            if (m == 0 && s == 0)
            {
                TimerTickerRest.Stop();
                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = button_Settinges.Text;
                    if (button_Settinges.Text != string.Empty)
                    {
                        player.Load();
                        player.PlaySync();
                        MessageBox.Show("Час вийшов!");
                    }
                    else
                    {
                        MessageBox.Show("Ви не вибрали музику.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult result = MessageBox.Show("Пора працювати", "Робота", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    m = 15;
                    s = 00;
                    labelMinutes.Text = m.ToString();
                    labelSeconds.Text = s.ToString();
                    TimerTicker.Start();
                }
                else
                {
                    m = 5;
                    s = 00;
                    labelMinutes.Text = m.ToString();
                    labelSeconds.Text = s.ToString();
                    TimerTickerRest.Start();
                    if (s < 10)
                    {
                        labelSeconds.Text = "0" + s.ToString();
                    }
                    if (s == 00 && m > 0)
                    {
                        s = 59;
                        m--;
                        labelMinutes.Text = m.ToString();
                        labelSeconds.Text = s.ToString();
                    }
                }

            }
        }
        private void PomodoroPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PomodoroPictureBox.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_Settinges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут ви виберете музику,яка спрацьовуватиме при закінченні часу в таймері. Вибирайте музику в форматі .wav\n(інші формати та файли можуть не спрацювати,або програма видасть помилку)");
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.button_Settinges.Text = openFile.FileName;
            }
        }
    }
}
