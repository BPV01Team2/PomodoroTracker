
using System;

namespace Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PomodoroPictureBox = new System.Windows.Forms.PictureBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.TimerTicker = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonMinusSeconds = new System.Windows.Forms.Button();
            this.buttonPlusSeconds = new System.Windows.Forms.Button();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labeltwopoints = new System.Windows.Forms.Label();
            this.buttonPlusMinutes = new System.Windows.Forms.Button();
            this.buttonMinusMinutes = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PomodoroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PomodoroPictureBox
            // 
            this.PomodoroPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PomodoroPictureBox.BackgroundImage")));
            this.PomodoroPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PomodoroPictureBox.Location = new System.Drawing.Point(10, 12);
            this.PomodoroPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PomodoroPictureBox.Name = "PomodoroPictureBox";
            this.PomodoroPictureBox.Size = new System.Drawing.Size(256, 264);
            this.PomodoroPictureBox.TabIndex = 0;
            this.PomodoroPictureBox.TabStop = false;
            this.PomodoroPictureBox.Click += new System.EventHandler(this.PomodoroPictureBox_Click);
            // 
            // labelMinutes
            // 
            this.labelMinutes.BackColor = System.Drawing.Color.LimeGreen;
            this.labelMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelMinutes.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinutes.Location = new System.Drawing.Point(48, 123);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(56, 55);
            this.labelMinutes.TabIndex = 1;
            this.labelMinutes.Text = "25";
            this.labelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerTicker
            // 
            this.TimerTicker.Interval = 1000;
            this.TimerTicker.Tag = "";
            this.TimerTicker.Tick += new System.EventHandler(this.TimerTicker_Tick_1);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStart.Location = new System.Drawing.Point(110, 88);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(46, 32);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStop.Location = new System.Drawing.Point(110, 181);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(46, 32);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonMinusSeconds
            // 
            this.buttonMinusSeconds.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonMinusSeconds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinusSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinusSeconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinusSeconds.Location = new System.Drawing.Point(160, 88);
            this.buttonMinusSeconds.Name = "buttonMinusSeconds";
            this.buttonMinusSeconds.Size = new System.Drawing.Size(29, 32);
            this.buttonMinusSeconds.TabIndex = 4;
            this.buttonMinusSeconds.Text = "-";
            this.buttonMinusSeconds.UseVisualStyleBackColor = false;
            this.buttonMinusSeconds.Click += new System.EventHandler(this.buttonMinusSeconds_Click_1);
            // 
            // buttonPlusSeconds
            // 
            this.buttonPlusSeconds.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPlusSeconds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlusSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlusSeconds.Location = new System.Drawing.Point(160, 181);
            this.buttonPlusSeconds.Name = "buttonPlusSeconds";
            this.buttonPlusSeconds.Size = new System.Drawing.Size(29, 32);
            this.buttonPlusSeconds.TabIndex = 5;
            this.buttonPlusSeconds.Text = "+";
            this.buttonPlusSeconds.UseVisualStyleBackColor = false;
            this.buttonPlusSeconds.Click += new System.EventHandler(this.buttonPlusSeconds_Click);
            // 
            // labelSeconds
            // 
            this.labelSeconds.BackColor = System.Drawing.Color.LimeGreen;
            this.labelSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeconds.Location = new System.Drawing.Point(161, 123);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(53, 55);
            this.labelSeconds.TabIndex = 6;
            this.labelSeconds.Text = "00";
            this.labelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltwopoints
            // 
            this.labeltwopoints.BackColor = System.Drawing.Color.LimeGreen;
            this.labeltwopoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labeltwopoints.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltwopoints.Location = new System.Drawing.Point(110, 123);
            this.labeltwopoints.Name = "labeltwopoints";
            this.labeltwopoints.Size = new System.Drawing.Size(46, 55);
            this.labeltwopoints.TabIndex = 7;
            this.labeltwopoints.Text = ":";
            this.labeltwopoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusMinutes
            // 
            this.buttonPlusMinutes.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPlusMinutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlusMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlusMinutes.Location = new System.Drawing.Point(75, 181);
            this.buttonPlusMinutes.Name = "buttonPlusMinutes";
            this.buttonPlusMinutes.Size = new System.Drawing.Size(29, 32);
            this.buttonPlusMinutes.TabIndex = 8;
            this.buttonPlusMinutes.Text = "+";
            this.buttonPlusMinutes.UseVisualStyleBackColor = false;
            this.buttonPlusMinutes.Click += new System.EventHandler(this.buttonPlusMinutes_Click);
            // 
            // buttonMinusMinutes
            // 
            this.buttonMinusMinutes.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonMinusMinutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinusMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinusMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinusMinutes.Location = new System.Drawing.Point(75, 88);
            this.buttonMinusMinutes.Name = "buttonMinusMinutes";
            this.buttonMinusMinutes.Size = new System.Drawing.Size(29, 32);
            this.buttonMinusMinutes.TabIndex = 9;
            this.buttonMinusMinutes.Text = "-";
            this.buttonMinusMinutes.UseVisualStyleBackColor = false;
            this.buttonMinusMinutes.Click += new System.EventHandler(this.buttonMinusMinutes_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefresh.Location = new System.Drawing.Point(74, 60);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(115, 25);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.LimeGreen;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_about.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_about.Location = new System.Drawing.Point(85, 219);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(91, 25);
            this.button_about.TabIndex = 11;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 341);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonMinusMinutes);
            this.Controls.Add(this.buttonPlusMinutes);
            this.Controls.Add(this.labeltwopoints);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.buttonPlusSeconds);
            this.Controls.Add(this.buttonMinusSeconds);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.PomodoroPictureBox);
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PomodoroPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonMinusSeconds_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox PomodoroPictureBox;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonMinusSeconds;
        private System.Windows.Forms.Button buttonPlusSeconds;
        private System.Windows.Forms.Timer TimerTicker;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labeltwopoints;
        private System.Windows.Forms.Button buttonPlusMinutes;
        private System.Windows.Forms.Button buttonMinusMinutes;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button_about;
    }
}

