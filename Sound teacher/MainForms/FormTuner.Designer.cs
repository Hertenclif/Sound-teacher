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
            this.labelTunerFrequency = new System.Windows.Forms.Label();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.radioButtonMicrophone = new System.Windows.Forms.RadioButton();
            this.radioButtonSoundCard = new System.Windows.Forms.RadioButton();
            this.labelTunerSoundNames = new System.Windows.Forms.Label();
            this.labelTunerSoundImg = new System.Windows.Forms.Label();
            this.labelTunerArrows = new System.Windows.Forms.Label();
            this.buttonTunerExit = new System.Windows.Forms.Button();
            this.panelTunerDevice = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonTunerConstantNone = new System.Windows.Forms.RadioButton();
            this.radioButtonTunerConstantE5 = new System.Windows.Forms.RadioButton();
            this.radioButtonTunerConstantB4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTunerConstantG4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTunerConstantD4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTunerConstantA3 = new System.Windows.Forms.RadioButton();
            this.radioButtonTunerConstantE3 = new System.Windows.Forms.RadioButton();
            this.timerBeepBeep = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.panelTunerDevice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartTuner
            // 
            this.buttonStartTuner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartTuner.Image = global::Sound_teacher.Properties.Resources.TunerButtonStart;
            this.buttonStartTuner.Location = new System.Drawing.Point(448, 99);
            this.buttonStartTuner.Name = "buttonStartTuner";
            this.buttonStartTuner.Size = new System.Drawing.Size(70, 56);
            this.buttonStartTuner.TabIndex = 0;
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
            this.trackBarFrequency.Location = new System.Drawing.Point(20, 167);
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
            this.radioButtonMicrophone.Location = new System.Drawing.Point(8, 5);
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
            this.radioButtonSoundCard.Location = new System.Drawing.Point(8, 28);
            this.radioButtonSoundCard.Name = "radioButtonSoundCard";
            this.radioButtonSoundCard.Size = new System.Drawing.Size(81, 17);
            this.radioButtonSoundCard.TabIndex = 3;
            this.radioButtonSoundCard.TabStop = true;
            this.radioButtonSoundCard.Text = "Sound Card";
            this.radioButtonSoundCard.UseVisualStyleBackColor = true;
            // 
            // labelTunerSoundNames
            // 
            this.labelTunerSoundNames.Image = global::Sound_teacher.Properties.Resources.TunerBarSounds;
            this.labelTunerSoundNames.Location = new System.Drawing.Point(23, 185);
            this.labelTunerSoundNames.Name = "labelTunerSoundNames";
            this.labelTunerSoundNames.Size = new System.Drawing.Size(498, 22);
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
            this.buttonTunerExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTunerExit.Image = global::Sound_teacher.Properties.Resources.TunerButtonExit;
            this.buttonTunerExit.Location = new System.Drawing.Point(448, 41);
            this.buttonTunerExit.Name = "buttonTunerExit";
            this.buttonTunerExit.Size = new System.Drawing.Size(70, 56);
            this.buttonTunerExit.TabIndex = 1;
            this.buttonTunerExit.UseVisualStyleBackColor = true;
            this.buttonTunerExit.Click += new System.EventHandler(this.buttonTunerExit_Click);
            // 
            // panelTunerDevice
            // 
            this.panelTunerDevice.Controls.Add(this.radioButtonSoundCard);
            this.panelTunerDevice.Controls.Add(this.radioButtonMicrophone);
            this.panelTunerDevice.Location = new System.Drawing.Point(223, 97);
            this.panelTunerDevice.Name = "panelTunerDevice";
            this.panelTunerDevice.Size = new System.Drawing.Size(97, 48);
            this.panelTunerDevice.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonTunerConstantNone);
            this.panel1.Controls.Add(this.radioButtonTunerConstantE5);
            this.panel1.Controls.Add(this.radioButtonTunerConstantB4);
            this.panel1.Controls.Add(this.radioButtonTunerConstantG4);
            this.panel1.Controls.Add(this.radioButtonTunerConstantD4);
            this.panel1.Controls.Add(this.radioButtonTunerConstantA3);
            this.panel1.Controls.Add(this.radioButtonTunerConstantE3);
            this.panel1.Location = new System.Drawing.Point(338, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 93);
            this.panel1.TabIndex = 39;
            // 
            // radioButtonTunerConstantNone
            // 
            this.radioButtonTunerConstantNone.AutoSize = true;
            this.radioButtonTunerConstantNone.Location = new System.Drawing.Point(7, 5);
            this.radioButtonTunerConstantNone.Name = "radioButtonTunerConstantNone";
            this.radioButtonTunerConstantNone.Size = new System.Drawing.Size(56, 17);
            this.radioButtonTunerConstantNone.TabIndex = 6;
            this.radioButtonTunerConstantNone.TabStop = true;
            this.radioButtonTunerConstantNone.Text = "NONE";
            this.radioButtonTunerConstantNone.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantNone.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // radioButtonTunerConstantE5
            // 
            this.radioButtonTunerConstantE5.AutoSize = true;
            this.radioButtonTunerConstantE5.Location = new System.Drawing.Point(51, 74);
            this.radioButtonTunerConstantE5.Name = "radioButtonTunerConstantE5";
            this.radioButtonTunerConstantE5.Size = new System.Drawing.Size(38, 17);
            this.radioButtonTunerConstantE5.TabIndex = 5;
            this.radioButtonTunerConstantE5.TabStop = true;
            this.radioButtonTunerConstantE5.Text = "E5";
            this.radioButtonTunerConstantE5.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantE5.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // radioButtonTunerConstantB4
            // 
            this.radioButtonTunerConstantB4.AutoSize = true;
            this.radioButtonTunerConstantB4.Location = new System.Drawing.Point(51, 51);
            this.radioButtonTunerConstantB4.Name = "radioButtonTunerConstantB4";
            this.radioButtonTunerConstantB4.Size = new System.Drawing.Size(38, 17);
            this.radioButtonTunerConstantB4.TabIndex = 4;
            this.radioButtonTunerConstantB4.TabStop = true;
            this.radioButtonTunerConstantB4.Text = "B4";
            this.radioButtonTunerConstantB4.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantB4.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // radioButtonTunerConstantG4
            // 
            this.radioButtonTunerConstantG4.AutoSize = true;
            this.radioButtonTunerConstantG4.Location = new System.Drawing.Point(51, 28);
            this.radioButtonTunerConstantG4.Name = "radioButtonTunerConstantG4";
            this.radioButtonTunerConstantG4.Size = new System.Drawing.Size(39, 17);
            this.radioButtonTunerConstantG4.TabIndex = 3;
            this.radioButtonTunerConstantG4.TabStop = true;
            this.radioButtonTunerConstantG4.Text = "G4";
            this.radioButtonTunerConstantG4.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantG4.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // radioButtonTunerConstantD4
            // 
            this.radioButtonTunerConstantD4.AutoSize = true;
            this.radioButtonTunerConstantD4.Location = new System.Drawing.Point(7, 74);
            this.radioButtonTunerConstantD4.Name = "radioButtonTunerConstantD4";
            this.radioButtonTunerConstantD4.Size = new System.Drawing.Size(39, 17);
            this.radioButtonTunerConstantD4.TabIndex = 2;
            this.radioButtonTunerConstantD4.TabStop = true;
            this.radioButtonTunerConstantD4.Text = "D4";
            this.radioButtonTunerConstantD4.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantD4.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // radioButtonTunerConstantA3
            // 
            this.radioButtonTunerConstantA3.AutoSize = true;
            this.radioButtonTunerConstantA3.Location = new System.Drawing.Point(7, 51);
            this.radioButtonTunerConstantA3.Name = "radioButtonTunerConstantA3";
            this.radioButtonTunerConstantA3.Size = new System.Drawing.Size(38, 17);
            this.radioButtonTunerConstantA3.TabIndex = 1;
            this.radioButtonTunerConstantA3.TabStop = true;
            this.radioButtonTunerConstantA3.Text = "A3";
            this.radioButtonTunerConstantA3.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantA3.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // radioButtonTunerConstantE3
            // 
            this.radioButtonTunerConstantE3.AutoSize = true;
            this.radioButtonTunerConstantE3.Location = new System.Drawing.Point(7, 28);
            this.radioButtonTunerConstantE3.Name = "radioButtonTunerConstantE3";
            this.radioButtonTunerConstantE3.Size = new System.Drawing.Size(38, 17);
            this.radioButtonTunerConstantE3.TabIndex = 0;
            this.radioButtonTunerConstantE3.TabStop = true;
            this.radioButtonTunerConstantE3.Text = "E3";
            this.radioButtonTunerConstantE3.UseVisualStyleBackColor = true;
            this.radioButtonTunerConstantE3.CheckedChanged += new System.EventHandler(this.ConstantSound);
            // 
            // timerBeepBeep
            // 
            this.timerBeepBeep.Interval = 5000;
            this.timerBeepBeep.Tick += new System.EventHandler(this.beepBeep);
            // 
            // FormTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Sound_teacher.Properties.Resources.TunerBack;
            this.ClientSize = new System.Drawing.Size(552, 233);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTunerDevice);
            this.Controls.Add(this.buttonTunerExit);
            this.Controls.Add(this.labelTunerArrows);
            this.Controls.Add(this.labelTunerSoundNames);
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
            this.panelTunerDevice.ResumeLayout(false);
            this.panelTunerDevice.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartTuner;
        private System.Windows.Forms.Label labelTunerFrequency;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.RadioButton radioButtonMicrophone;
        private System.Windows.Forms.RadioButton radioButtonSoundCard;
        private System.Windows.Forms.Label labelTunerSoundNames;
        private System.Windows.Forms.Label labelTunerSoundImg;
        private System.Windows.Forms.Label labelTunerArrows;
        private System.Windows.Forms.Button buttonTunerExit;
        private System.Windows.Forms.Panel panelTunerDevice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantE5;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantB4;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantG4;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantD4;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantA3;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantE3;
        private System.Windows.Forms.RadioButton radioButtonTunerConstantNone;
        private System.Windows.Forms.Timer timerBeepBeep;
    }
}