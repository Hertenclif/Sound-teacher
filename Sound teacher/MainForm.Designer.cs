namespace Sound_teacher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonChangeSound = new System.Windows.Forms.Button();
            this.timerPictures = new System.Windows.Forms.Timer(this.components);
            this.labelSoundTimeLeft = new System.Windows.Forms.Label();
            this.progressBarMainFormTimeLeft = new System.Windows.Forms.ProgressBar();
            this.numericUpDownChangeSound = new System.Windows.Forms.NumericUpDown();
            this.buttonMainFormMetronome = new System.Windows.Forms.Button();
            this.buttonMainFormOpen = new System.Windows.Forms.Button();
            this.buttonMainFormExit = new System.Windows.Forms.Button();
            this.buttonMainFormOpenTuner = new System.Windows.Forms.Button();
            this.panelMainFormNotificationSound = new System.Windows.Forms.Panel();
            this.radioButtonMainFormNoSound = new System.Windows.Forms.RadioButton();
            this.radioButtonMainFormRealSound = new System.Windows.Forms.RadioButton();
            this.radioButtonMainFormspeechSound = new System.Windows.Forms.RadioButton();
            this.radioButtonMainFormTickSound = new System.Windows.Forms.RadioButton();
            this.panelMainFormOctave = new System.Windows.Forms.Panel();
            this.radioButtonMainFormOctave5 = new System.Windows.Forms.RadioButton();
            this.radioButtonMainFormOctave4 = new System.Windows.Forms.RadioButton();
            this.radioButtonMainFormOctave3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMainFormOctave2 = new System.Windows.Forms.RadioButton();
            this.buttonMainFormOpenFretBoard = new System.Windows.Forms.Button();
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.buttonMainFormFastForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeSound)).BeginInit();
            this.panelMainFormNotificationSound.SuspendLayout();
            this.panelMainFormOctave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeSound
            // 
            this.buttonChangeSound.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonChangeSound.BackgroundImage = global::Sound_teacher.Properties.Resources.MainForm_StartButton;
            this.buttonChangeSound.FlatAppearance.BorderSize = 0;
            this.buttonChangeSound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeSound.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonChangeSound.Location = new System.Drawing.Point(21, 398);
            this.buttonChangeSound.Name = "buttonChangeSound";
            this.buttonChangeSound.Size = new System.Drawing.Size(103, 21);
            this.buttonChangeSound.TabIndex = 0;
            this.buttonChangeSound.UseVisualStyleBackColor = false;
            this.buttonChangeSound.Click += new System.EventHandler(this.buttonMainFormStart_Click);
            // 
            // timerPictures
            // 
            this.timerPictures.Interval = 1000;
            this.timerPictures.Tick += new System.EventHandler(this.timerPictures_Tick);
            // 
            // labelSoundTimeLeft
            // 
            this.labelSoundTimeLeft.AutoSize = true;
            this.labelSoundTimeLeft.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelSoundTimeLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSoundTimeLeft.Location = new System.Drawing.Point(224, 368);
            this.labelSoundTimeLeft.Name = "labelSoundTimeLeft";
            this.labelSoundTimeLeft.Size = new System.Drawing.Size(13, 13);
            this.labelSoundTimeLeft.TabIndex = 3;
            this.labelSoundTimeLeft.Text = "0";
            // 
            // progressBarMainFormTimeLeft
            // 
            this.progressBarMainFormTimeLeft.BackColor = System.Drawing.SystemColors.WindowText;
            this.progressBarMainFormTimeLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.progressBarMainFormTimeLeft.Location = new System.Drawing.Point(21, 368);
            this.progressBarMainFormTimeLeft.Maximum = 5;
            this.progressBarMainFormTimeLeft.Minimum = 1;
            this.progressBarMainFormTimeLeft.Name = "progressBarMainFormTimeLeft";
            this.progressBarMainFormTimeLeft.Size = new System.Drawing.Size(198, 12);
            this.progressBarMainFormTimeLeft.Step = 1;
            this.progressBarMainFormTimeLeft.TabIndex = 4;
            this.progressBarMainFormTimeLeft.Value = 1;
            // 
            // numericUpDownChangeSound
            // 
            this.numericUpDownChangeSound.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownChangeSound.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDownChangeSound.Location = new System.Drawing.Point(132, 399);
            this.numericUpDownChangeSound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChangeSound.Name = "numericUpDownChangeSound";
            this.numericUpDownChangeSound.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownChangeSound.TabIndex = 1;
            this.numericUpDownChangeSound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonMainFormMetronome
            // 
            this.buttonMainFormMetronome.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonMainFormMetronome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMainFormMetronome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMainFormMetronome.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMainFormMetronome.Image = global::Sound_teacher.Properties.Resources.MainForm_MetronomeButton;
            this.buttonMainFormMetronome.Location = new System.Drawing.Point(255, 154);
            this.buttonMainFormMetronome.Name = "buttonMainFormMetronome";
            this.buttonMainFormMetronome.Size = new System.Drawing.Size(109, 62);
            this.buttonMainFormMetronome.TabIndex = 3;
            this.buttonMainFormMetronome.UseVisualStyleBackColor = false;
            this.buttonMainFormMetronome.Click += new System.EventHandler(this.buttonMainFormMetronome_Click);
            // 
            // buttonMainFormOpen
            // 
            this.buttonMainFormOpen.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonMainFormOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainFormOpen.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMainFormOpen.Location = new System.Drawing.Point(255, 290);
            this.buttonMainFormOpen.Name = "buttonMainFormOpen";
            this.buttonMainFormOpen.Size = new System.Drawing.Size(109, 62);
            this.buttonMainFormOpen.TabIndex = 5;
            this.buttonMainFormOpen.Text = "I don\'t know, but certainly sth great";
            this.buttonMainFormOpen.UseVisualStyleBackColor = false;
            this.buttonMainFormOpen.Click += new System.EventHandler(this.buttonMainFormOpen_Click);
            // 
            // buttonMainFormExit
            // 
            this.buttonMainFormExit.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonMainFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMainFormExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMainFormExit.Image = global::Sound_teacher.Properties.Resources.MainForm_ExitButton;
            this.buttonMainFormExit.Location = new System.Drawing.Point(255, 356);
            this.buttonMainFormExit.Name = "buttonMainFormExit";
            this.buttonMainFormExit.Size = new System.Drawing.Size(109, 62);
            this.buttonMainFormExit.TabIndex = 6;
            this.buttonMainFormExit.UseVisualStyleBackColor = false;
            this.buttonMainFormExit.Click += new System.EventHandler(this.buttonMainFormExit_Click);
            // 
            // buttonMainFormOpenTuner
            // 
            this.buttonMainFormOpenTuner.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonMainFormOpenTuner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMainFormOpenTuner.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMainFormOpenTuner.Image = global::Sound_teacher.Properties.Resources.MainForm_TunerButton;
            this.buttonMainFormOpenTuner.Location = new System.Drawing.Point(255, 222);
            this.buttonMainFormOpenTuner.Name = "buttonMainFormOpenTuner";
            this.buttonMainFormOpenTuner.Size = new System.Drawing.Size(109, 62);
            this.buttonMainFormOpenTuner.TabIndex = 4;
            this.buttonMainFormOpenTuner.UseVisualStyleBackColor = false;
            this.buttonMainFormOpenTuner.Click += new System.EventHandler(this.buttonMainFormOpenTuner_Click);
            // 
            // panelMainFormNotificationSound
            // 
            this.panelMainFormNotificationSound.Controls.Add(this.radioButtonMainFormNoSound);
            this.panelMainFormNotificationSound.Controls.Add(this.radioButtonMainFormRealSound);
            this.panelMainFormNotificationSound.Controls.Add(this.radioButtonMainFormspeechSound);
            this.panelMainFormNotificationSound.Controls.Add(this.radioButtonMainFormTickSound);
            this.panelMainFormNotificationSound.Location = new System.Drawing.Point(32, 436);
            this.panelMainFormNotificationSound.Name = "panelMainFormNotificationSound";
            this.panelMainFormNotificationSound.Size = new System.Drawing.Size(324, 14);
            this.panelMainFormNotificationSound.TabIndex = 11;
            // 
            // radioButtonMainFormNoSound
            // 
            this.radioButtonMainFormNoSound.AutoSize = true;
            this.radioButtonMainFormNoSound.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormNoSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormNoSound.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormNoSound.Location = new System.Drawing.Point(275, -1);
            this.radioButtonMainFormNoSound.Name = "radioButtonMainFormNoSound";
            this.radioButtonMainFormNoSound.Size = new System.Drawing.Size(54, 17);
            this.radioButtonMainFormNoSound.TabIndex = 10;
            this.radioButtonMainFormNoSound.Text = "Muted";
            this.radioButtonMainFormNoSound.UseVisualStyleBackColor = false;
            this.radioButtonMainFormNoSound.CheckedChanged += new System.EventHandler(this.radioButtonMainFormNoSound_CheckedChanged);
            // 
            // radioButtonMainFormRealSound
            // 
            this.radioButtonMainFormRealSound.AutoSize = true;
            this.radioButtonMainFormRealSound.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormRealSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormRealSound.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormRealSound.Location = new System.Drawing.Point(188, -1);
            this.radioButtonMainFormRealSound.Name = "radioButtonMainFormRealSound";
            this.radioButtonMainFormRealSound.Size = new System.Drawing.Size(80, 17);
            this.radioButtonMainFormRealSound.TabIndex = 9;
            this.radioButtonMainFormRealSound.Text = "Real Sound";
            this.radioButtonMainFormRealSound.UseVisualStyleBackColor = false;
            this.radioButtonMainFormRealSound.CheckedChanged += new System.EventHandler(this.radioButtonMainFormRealSound_CheckedChanged);
            // 
            // radioButtonMainFormspeechSound
            // 
            this.radioButtonMainFormspeechSound.AutoSize = true;
            this.radioButtonMainFormspeechSound.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormspeechSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormspeechSound.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormspeechSound.Location = new System.Drawing.Point(86, -1);
            this.radioButtonMainFormspeechSound.Name = "radioButtonMainFormspeechSound";
            this.radioButtonMainFormspeechSound.Size = new System.Drawing.Size(95, 17);
            this.radioButtonMainFormspeechSound.TabIndex = 8;
            this.radioButtonMainFormspeechSound.Text = "Speech Sound";
            this.radioButtonMainFormspeechSound.UseVisualStyleBackColor = false;
            this.radioButtonMainFormspeechSound.CheckedChanged += new System.EventHandler(this.radioButtonMainFormspeechSound_CheckedChanged);
            // 
            // radioButtonMainFormTickSound
            // 
            this.radioButtonMainFormTickSound.AutoSize = true;
            this.radioButtonMainFormTickSound.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormTickSound.Checked = true;
            this.radioButtonMainFormTickSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormTickSound.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormTickSound.Location = new System.Drawing.Point(0, -1);
            this.radioButtonMainFormTickSound.Name = "radioButtonMainFormTickSound";
            this.radioButtonMainFormTickSound.Size = new System.Drawing.Size(79, 17);
            this.radioButtonMainFormTickSound.TabIndex = 7;
            this.radioButtonMainFormTickSound.TabStop = true;
            this.radioButtonMainFormTickSound.Text = "Tick Sound";
            this.radioButtonMainFormTickSound.UseVisualStyleBackColor = false;
            this.radioButtonMainFormTickSound.CheckedChanged += new System.EventHandler(this.radioButtonMainFormTickSound_CheckedChanged);
            // 
            // panelMainFormOctave
            // 
            this.panelMainFormOctave.Controls.Add(this.radioButtonMainFormOctave5);
            this.panelMainFormOctave.Controls.Add(this.radioButtonMainFormOctave4);
            this.panelMainFormOctave.Controls.Add(this.radioButtonMainFormOctave3);
            this.panelMainFormOctave.Controls.Add(this.radioButtonMainFormOctave2);
            this.panelMainFormOctave.Location = new System.Drawing.Point(32, 467);
            this.panelMainFormOctave.Name = "panelMainFormOctave";
            this.panelMainFormOctave.Size = new System.Drawing.Size(329, 12);
            this.panelMainFormOctave.TabIndex = 12;
            // 
            // radioButtonMainFormOctave5
            // 
            this.radioButtonMainFormOctave5.AutoSize = true;
            this.radioButtonMainFormOctave5.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormOctave5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormOctave5.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormOctave5.Location = new System.Drawing.Point(254, -2);
            this.radioButtonMainFormOctave5.Name = "radioButtonMainFormOctave5";
            this.radioButtonMainFormOctave5.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMainFormOctave5.TabIndex = 14;
            this.radioButtonMainFormOctave5.Tag = "RadioButtonOctave";
            this.radioButtonMainFormOctave5.Text = "5th Octave";
            this.radioButtonMainFormOctave5.UseVisualStyleBackColor = false;
            this.radioButtonMainFormOctave5.CheckedChanged += new System.EventHandler(this.octave_changed);
            // 
            // radioButtonMainFormOctave4
            // 
            this.radioButtonMainFormOctave4.AutoSize = true;
            this.radioButtonMainFormOctave4.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormOctave4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormOctave4.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormOctave4.Location = new System.Drawing.Point(169, -2);
            this.radioButtonMainFormOctave4.Name = "radioButtonMainFormOctave4";
            this.radioButtonMainFormOctave4.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMainFormOctave4.TabIndex = 13;
            this.radioButtonMainFormOctave4.Text = "4th Octave";
            this.radioButtonMainFormOctave4.UseVisualStyleBackColor = false;
            this.radioButtonMainFormOctave4.CheckedChanged += new System.EventHandler(this.octave_changed);
            // 
            // radioButtonMainFormOctave3
            // 
            this.radioButtonMainFormOctave3.AutoSize = true;
            this.radioButtonMainFormOctave3.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormOctave3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormOctave3.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonMainFormOctave3.Location = new System.Drawing.Point(86, -2);
            this.radioButtonMainFormOctave3.Name = "radioButtonMainFormOctave3";
            this.radioButtonMainFormOctave3.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMainFormOctave3.TabIndex = 12;
            this.radioButtonMainFormOctave3.Text = "3rd Octave";
            this.radioButtonMainFormOctave3.UseVisualStyleBackColor = false;
            this.radioButtonMainFormOctave3.CheckedChanged += new System.EventHandler(this.octave_changed);
            // 
            // radioButtonMainFormOctave2
            // 
            this.radioButtonMainFormOctave2.AutoSize = true;
            this.radioButtonMainFormOctave2.BackColor = System.Drawing.SystemColors.WindowText;
            this.radioButtonMainFormOctave2.Checked = true;
            this.radioButtonMainFormOctave2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonMainFormOctave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainFormOctave2.ForeColor = System.Drawing.Color.White;
            this.radioButtonMainFormOctave2.Location = new System.Drawing.Point(0, -2);
            this.radioButtonMainFormOctave2.Name = "radioButtonMainFormOctave2";
            this.radioButtonMainFormOctave2.Size = new System.Drawing.Size(80, 17);
            this.radioButtonMainFormOctave2.TabIndex = 11;
            this.radioButtonMainFormOctave2.TabStop = true;
            this.radioButtonMainFormOctave2.Text = "2nd Octave";
            this.radioButtonMainFormOctave2.UseVisualStyleBackColor = false;
            this.radioButtonMainFormOctave2.CheckedChanged += new System.EventHandler(this.octave_changed);
            // 
            // buttonMainFormOpenFretBoard
            // 
            this.buttonMainFormOpenFretBoard.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonMainFormOpenFretBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMainFormOpenFretBoard.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMainFormOpenFretBoard.Image = global::Sound_teacher.Properties.Resources.MainForm_FretBoardButton;
            this.buttonMainFormOpenFretBoard.Location = new System.Drawing.Point(255, 86);
            this.buttonMainFormOpenFretBoard.Name = "buttonMainFormOpenFretBoard";
            this.buttonMainFormOpenFretBoard.Size = new System.Drawing.Size(109, 62);
            this.buttonMainFormOpenFretBoard.TabIndex = 2;
            this.buttonMainFormOpenFretBoard.UseVisualStyleBackColor = false;
            this.buttonMainFormOpenFretBoard.Click += new System.EventHandler(this.buttonOpenFretBoard_Click);
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.BackgroundImage = global::Sound_teacher.Properties.Resources.ST;
            this.pictureBoxSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSound.Location = new System.Drawing.Point(22, 86);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(216, 263);
            this.pictureBoxSound.TabIndex = 2;
            this.pictureBoxSound.TabStop = false;
            // 
            // buttonMainFormFastForward
            // 
            this.buttonMainFormFastForward.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonMainFormFastForward.BackgroundImage = global::Sound_teacher.Properties.Resources.MainForm_FForwardButton;
            this.buttonMainFormFastForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMainFormFastForward.FlatAppearance.BorderSize = 0;
            this.buttonMainFormFastForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMainFormFastForward.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMainFormFastForward.Location = new System.Drawing.Point(212, 397);
            this.buttonMainFormFastForward.Name = "buttonMainFormFastForward";
            this.buttonMainFormFastForward.Size = new System.Drawing.Size(24, 24);
            this.buttonMainFormFastForward.TabIndex = 13;
            this.buttonMainFormFastForward.UseVisualStyleBackColor = false;
            this.buttonMainFormFastForward.Click += new System.EventHandler(this.buttonMainFormFastForward_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Sound_teacher.Properties.Resources.MainLayout;
            this.ClientSize = new System.Drawing.Size(383, 467);
            this.Controls.Add(this.buttonMainFormFastForward);
            this.Controls.Add(this.panelMainFormOctave);
            this.Controls.Add(this.panelMainFormNotificationSound);
            this.Controls.Add(this.buttonMainFormOpenTuner);
            this.Controls.Add(this.buttonMainFormExit);
            this.Controls.Add(this.buttonMainFormOpen);
            this.Controls.Add(this.buttonMainFormMetronome);
            this.Controls.Add(this.buttonMainFormOpenFretBoard);
            this.Controls.Add(this.numericUpDownChangeSound);
            this.Controls.Add(this.labelSoundTimeLeft);
            this.Controls.Add(this.pictureBoxSound);
            this.Controls.Add(this.buttonChangeSound);
            this.Controls.Add(this.progressBarMainFormTimeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sound Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeSound)).EndInit();
            this.panelMainFormNotificationSound.ResumeLayout(false);
            this.panelMainFormNotificationSound.PerformLayout();
            this.panelMainFormOctave.ResumeLayout(false);
            this.panelMainFormOctave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeSound;
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.Timer timerPictures;
        private System.Windows.Forms.Label labelSoundTimeLeft;
        private System.Windows.Forms.ProgressBar progressBarMainFormTimeLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownChangeSound;
        private System.Windows.Forms.Button buttonMainFormOpenFretBoard;
        private System.Windows.Forms.Button buttonMainFormMetronome;
        private System.Windows.Forms.Button buttonMainFormOpen;
        private System.Windows.Forms.Button buttonMainFormExit;
        private System.Windows.Forms.Button buttonMainFormOpenTuner;
        private System.Windows.Forms.Panel panelMainFormNotificationSound;
        private System.Windows.Forms.RadioButton radioButtonMainFormRealSound;
        private System.Windows.Forms.RadioButton radioButtonMainFormspeechSound;
        private System.Windows.Forms.RadioButton radioButtonMainFormTickSound;
        private System.Windows.Forms.RadioButton radioButtonMainFormNoSound;
        private System.Windows.Forms.Panel panelMainFormOctave;
        private System.Windows.Forms.RadioButton radioButtonMainFormOctave5;
        private System.Windows.Forms.RadioButton radioButtonMainFormOctave4;
        private System.Windows.Forms.RadioButton radioButtonMainFormOctave3;
        private System.Windows.Forms.RadioButton radioButtonMainFormOctave2;
        private System.Windows.Forms.Button buttonMainFormFastForward;
    }
}

