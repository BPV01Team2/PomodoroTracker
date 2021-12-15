﻿using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {   
        private int m;
        private double s;
        private AboutForm _about = null;
        public Form1()
        {
            InitializeComponent();
            _about = new AboutForm(this);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            m = Convert.ToInt32(labelMinutes.Text);
            s = Convert.ToDouble(labelSeconds.Text);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            TimerTicker.Enabled = true;
        }

        private void TimerTicker_Tick_1(object sender, EventArgs e)
        {
            if (m <= 0 && s <= 00)
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
                    s--;
                }
                if (m == 0 && s == 0)
                {
                    TimerTicker.Stop();
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
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            labelMinutes.Text = "25";
            labelSeconds.Text = "00";
            m = Convert.ToInt32(labelMinutes.Text);
            s = Convert.ToDouble(labelSeconds.Text);
            
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

        private void PomodoroPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
