namespace Sound_teacher
{
    partial class FormTuner
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
            this.buttonStartTuner = new System.Windows.Forms.Button();
            this.labelTunerFrequency = new System.Windows.Forms.Label();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.radioButtonMicrophone = new System.Windows.Forms.RadioButton();
            this.radioButtonSoundCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTunerSoundNames = new System.Windows.Forms.Label();
            this.labelTunerSoundImg = new System.Windows.Forms.Label();
            this.labelTunerArrows = new System.Windows.Forms.Label();
            this.buttonTunerExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartTuner
            // 
            this.buttonStartTuner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTuner.Location = new System.Drawing.Point(428, 100);
            this.buttonStartTuner.Name = "buttonStartTuner";
            this.buttonStartTuner.Size = new System.Drawing.Size(98, 56);
            this.buttonStartTuner.TabIndex = 0;
            this.buttonStartTuner.Text = "Start!";
            this.buttonStartTuner.UseVisualStyleBackColor = true;
            this.buttonStartTuner.Click += new System.EventHandler(this.buttonStartTuner_Click);
            // 
            // labelTunerFrequency
            // 
            this.labelTunerFrequency.AutoSize = true;
            this.labelTunerFrequency.Location = new System.Drawing.Point(78, 144);
            this.labelTunerFrequency.Name = "labelTunerFrequency";
            this.labelTunerFrequency.Size = new System.Drawing.Size(0, 13);
            this.labelTunerFrequency.TabIndex = 3;
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.AutoSize = false;
            this.trackBarFrequency.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBarFrequency.Enabled = false;
            this.trackBarFrequency.LargeChange = 10;
            this.trackBarFrequency.Location = new System.Drawing.Point(22, 163);
            this.trackBarFrequency.Maximum = 130000;
            this.trackBarFrequency.Minimum = 60000;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(512, 23);
            this.trackBarFrequency.TabIndex = 30;
            this.trackBarFrequency.TabStop = false;
            this.trackBarFrequency.Value = 116540;
            // 
            // radioButtonMicrophone
            // 
            this.radioButtonMicrophone.AutoSize = true;
            this.radioButtonMicrophone.Checked = true;
            this.radioButtonMicrophone.Location = new System.Drawing.Point(6, 23);
            this.radioButtonMicrophone.Name = "radioButtonMicrophone";
            this.radioButtonMicrophone.Size = new System.Drawing.Size(81, 17);
            this.radioButtonMicrophone.TabIndex = 2;
            this.radioButtonMicrophone.TabStop = true;
            this.radioButtonMicrophone.Text = "Microphone";
            this.radioButtonMicrophone.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoundCard
            // 
            this.radioButtonSoundCard.AutoSize = true;
            this.radioButtonSoundCard.Location = new System.Drawing.Point(6, 46);
            this.radioButtonSoundCard.Name = "radioButtonSoundCard";
            this.radioButtonSoundCard.Size = new System.Drawing.Size(81, 17);
            this.radioButtonSoundCard.TabIndex = 3;
            this.radioButtonSoundCard.TabStop = true;
            this.radioButtonSoundCard.Text = "Sound Card";
            this.radioButtonSoundCard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMicrophone);
            this.groupBox1.Controls.Add(this.radioButtonSoundCard);
            this.groupBox1.Location = new System.Drawing.Point(221, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 115);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelTunerSoundNames
            // 
            this.labelTunerSoundNames.Image = global::Sound_teacher.Properties.Resources.TunerBarSounds;
            this.labelTunerSoundNames.Location = new System.Drawing.Point(19, 182);
            this.labelTunerSoundNames.Name = "labelTunerSoundNames";
            this.labelTunerSoundNames.Size = new System.Drawing.Size(518, 22);
            this.labelTunerSoundNames.TabIndex = 34;
            // 
            // labelTunerSoundImg
            // 
            this.labelTunerSoundImg.Image = global::Sound_teacher.Properties.Resources.T_ST;
            this.labelTunerSoundImg.Location = new System.Drawing.Point(45, 41);
            this.labelTunerSoundImg.Name = "labelTunerSoundImg";
            this.labelTunerSoundImg.Size = new System.Drawing.Size(113, 115);
            this.labelTunerSoundImg.TabIndex = 36;
            // 
            // labelTunerArrows
            // 
            this.labelTunerArrows.Image = global::Sound_teacher.Properties.Resources.TunerArrowsNeutral;
            this.labelTunerArrows.Location = new System.Drawing.Point(179, 41);
            this.labelTunerArrows.Name = "labelTunerArrows";
            this.labelTunerArrows.Size = new System.Drawing.Size(21, 115);
            this.labelTunerArrows.TabIndex = 37;
            // 
            // buttonTunerExit
            // 
            this.buttonTunerExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTunerExit.Location = new System.Drawing.Point(428, 41);
            this.buttonTunerExit.Name = "buttonTunerExit";
            this.buttonTunerExit.Size = new System.Drawing.Size(98, 56);
            this.buttonTunerExit.TabIndex = 1;
            this.buttonTunerExit.Text = "Start!";
            this.buttonTunerExit.UseVisualStyleBackColor = true;
            this.buttonTunerExit.Click += new System.EventHandler(this.buttonTunerExit_Click);
            // 
            // FormTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Sound_teacher.Properties.Resources.TunerBack;
            this.ClientSize = new System.Drawing.Size(552, 233);
            this.Controls.Add(this.buttonTunerExit);
            this.Controls.Add(this.labelTunerArrows);
            this.Controls.Add(this.labelTunerSoundNames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarFrequency);
            this.Controls.Add(this.labelTunerFrequency);
            this.Controls.Add(this.buttonStartTuner);
            this.Controls.Add(this.labelTunerSoundImg);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(383, 234);
            this.Name = "FormTuner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sound Teacher Tuner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTuner_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartTuner;
        private System.Windows.Forms.Label labelTunerFrequency;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.RadioButton radioButtonMicrophone;
        private System.Windows.Forms.RadioButton radioButtonSoundCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTunerSoundNames;
        private System.Windows.Forms.Label labelTunerSoundImg;
        private System.Windows.Forms.Label labelTunerArrows;
        private System.Windows.Forms.Button buttonTunerExit;
    }
}