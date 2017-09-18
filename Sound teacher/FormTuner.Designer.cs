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
            this.components = new System.ComponentModel.Container();
            this.buttonStartTuner = new System.Windows.Forms.Button();
            this.timerTunerRecord = new System.Windows.Forms.Timer(this.components);
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelTunerSound = new System.Windows.Forms.Label();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.radioButtonMicrophone = new System.Windows.Forms.RadioButton();
            this.radioButtonSoundCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTunerSoundNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartTuner
            // 
            this.buttonStartTuner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTuner.Location = new System.Drawing.Point(451, 110);
            this.buttonStartTuner.Name = "buttonStartTuner";
            this.buttonStartTuner.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTuner.TabIndex = 0;
            this.buttonStartTuner.Text = "Start!";
            this.buttonStartTuner.UseVisualStyleBackColor = true;
            this.buttonStartTuner.Click += new System.EventHandler(this.buttonStartTuner_Click);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(80, 120);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(73, 13);
            this.labelFrequency.TabIndex = 3;
            this.labelFrequency.Text = "FREQUENCY";
            // 
            // labelTunerSound
            // 
            this.labelTunerSound.AllowDrop = true;
            this.labelTunerSound.AutoSize = true;
            this.labelTunerSound.Location = new System.Drawing.Point(28, 120);
            this.labelTunerSound.Name = "labelTunerSound";
            this.labelTunerSound.Size = new System.Drawing.Size(46, 13);
            this.labelTunerSound.TabIndex = 6;
            this.labelTunerSound.Text = "SOUND";
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.AutoSize = false;
            this.trackBarFrequency.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBarFrequency.Enabled = false;
            this.trackBarFrequency.LargeChange = 10;
            this.trackBarFrequency.Location = new System.Drawing.Point(22, 139);
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
            this.radioButtonMicrophone.TabIndex = 31;
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
            this.radioButtonSoundCard.TabIndex = 32;
            this.radioButtonSoundCard.TabStop = true;
            this.radioButtonSoundCard.Text = "Sound Card";
            this.radioButtonSoundCard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMicrophone);
            this.groupBox1.Controls.Add(this.radioButtonSoundCard);
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 86);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelTunerSoundNames
            // 
            this.labelTunerSoundNames.Image = global::Sound_teacher.Properties.Resources.TunerBarSounds;
            this.labelTunerSoundNames.Location = new System.Drawing.Point(19, 158);
            this.labelTunerSoundNames.Name = "labelTunerSoundNames";
            this.labelTunerSoundNames.Size = new System.Drawing.Size(518, 22);
            this.labelTunerSoundNames.TabIndex = 34;
            // 
            // FormTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Sound_teacher.Properties.Resources.TunerBack;
            this.ClientSize = new System.Drawing.Size(552, 220);
            this.Controls.Add(this.labelTunerSoundNames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarFrequency);
            this.Controls.Add(this.labelTunerSound);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.buttonStartTuner);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(399, 247);
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
        private System.Windows.Forms.Timer timerTunerRecord;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelTunerSound;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.RadioButton radioButtonMicrophone;
        private System.Windows.Forms.RadioButton radioButtonSoundCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTunerSoundNames;
    }
}