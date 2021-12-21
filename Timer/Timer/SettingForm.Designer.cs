
namespace Timer
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MinForJob = new System.Windows.Forms.TextBox();
            this.textBox_SecondForJob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SecondForRest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MinForRest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Save.Location = new System.Drawing.Point(17, 241);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(170, 60);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Хвилини на роботу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_MinForJob
            // 
            this.textBox_MinForJob.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox_MinForJob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_MinForJob.Location = new System.Drawing.Point(17, 87);
            this.textBox_MinForJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MinForJob.Name = "textBox_MinForJob";
            this.textBox_MinForJob.Size = new System.Drawing.Size(170, 34);
            this.textBox_MinForJob.TabIndex = 14;
            // 
            // textBox_SecondForJob
            // 
            this.textBox_SecondForJob.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox_SecondForJob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_SecondForJob.Location = new System.Drawing.Point(219, 87);
            this.textBox_SecondForJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SecondForJob.Name = "textBox_SecondForJob";
            this.textBox_SecondForJob.Size = new System.Drawing.Size(173, 34);
            this.textBox_SecondForJob.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 64);
            this.label2.TabIndex = 15;
            this.label2.Text = "Секунди на роботу";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_SecondForRest
            // 
            this.textBox_SecondForRest.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox_SecondForRest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_SecondForRest.Location = new System.Drawing.Point(219, 200);
            this.textBox_SecondForRest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SecondForRest.Name = "textBox_SecondForRest";
            this.textBox_SecondForRest.Size = new System.Drawing.Size(172, 34);
            this.textBox_SecondForRest.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(219, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 71);
            this.label3.TabIndex = 19;
            this.label3.Text = "Секунди на відпочинок";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_MinForRest
            // 
            this.textBox_MinForRest.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox_MinForRest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_MinForRest.Location = new System.Drawing.Point(16, 200);
            this.textBox_MinForRest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MinForRest.Name = "textBox_MinForRest";
            this.textBox_MinForRest.Size = new System.Drawing.Size(171, 34);
            this.textBox_MinForRest.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 71);
            this.label4.TabIndex = 17;
            this.label4.Text = "Хвилини на відпочинок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(441, 328);
            this.Controls.Add(this.textBox_SecondForRest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MinForRest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SecondForJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MinForJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MinForJob;
        private System.Windows.Forms.TextBox textBox_SecondForJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SecondForRest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MinForRest;
        private System.Windows.Forms.Label label4;
    }
}