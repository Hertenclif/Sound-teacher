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
            this.buttonChangeSound = new System.Windows.Forms.Button();
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.timerPictures = new System.Windows.Forms.Timer(this.components);
            this.labelSoundTimeLeft = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDownChangeSound = new System.Windows.Forms.NumericUpDown();
            this.buttonOpenFretBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeSound)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeSound
            // 
            this.buttonChangeSound.Location = new System.Drawing.Point(12, 321);
            this.buttonChangeSound.Name = "buttonChangeSound";
            this.buttonChangeSound.Size = new System.Drawing.Size(104, 20);
            this.buttonChangeSound.TabIndex = 1;
            this.buttonChangeSound.Text = "Start!";
            this.buttonChangeSound.UseVisualStyleBackColor = true;
            this.buttonChangeSound.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSound.Image = global::Sound_teacher.Properties.Resources.A;
            this.pictureBoxSound.Location = new System.Drawing.Point(12, 33);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(216, 264);
            this.pictureBoxSound.TabIndex = 2;
            this.pictureBoxSound.TabStop = false;
            // 
            // timerPictures
            // 
            this.timerPictures.Interval = 1000;
            this.timerPictures.Tick += new System.EventHandler(this.timerPictures_Tick);
            // 
            // labelSoundTimeLeft
            // 
            this.labelSoundTimeLeft.AutoSize = true;
            this.labelSoundTimeLeft.Location = new System.Drawing.Point(215, 303);
            this.labelSoundTimeLeft.Name = "labelSoundTimeLeft";
            this.labelSoundTimeLeft.Size = new System.Drawing.Size(13, 13);
            this.labelSoundTimeLeft.TabIndex = 3;
            this.labelSoundTimeLeft.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 303);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 12);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 1;
            // 
            // numericUpDownChangeSound
            // 
            this.numericUpDownChangeSound.Location = new System.Drawing.Point(124, 321);
            this.numericUpDownChangeSound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChangeSound.Name = "numericUpDownChangeSound";
            this.numericUpDownChangeSound.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownChangeSound.TabIndex = 5;
            this.numericUpDownChangeSound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOpenFretBoard
            // 
            this.buttonOpenFretBoard.Location = new System.Drawing.Point(234, 33);
            this.buttonOpenFretBoard.Name = "buttonOpenFretBoard";
            this.buttonOpenFretBoard.Size = new System.Drawing.Size(109, 23);
            this.buttonOpenFretBoard.TabIndex = 6;
            this.buttonOpenFretBoard.Text = "Open fretboard";
            this.buttonOpenFretBoard.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this.buttonOpenFretBoard);
            this.Controls.Add(this.numericUpDownChangeSound);
            this.Controls.Add(this.labelSoundTimeLeft);
            this.Controls.Add(this.pictureBoxSound);
            this.Controls.Add(this.buttonChangeSound);
            this.Controls.Add(this.progressBar1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeSound;
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.Timer timerPictures;
        private System.Windows.Forms.Label labelSoundTimeLeft;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDownChangeSound;
        private System.Windows.Forms.Button buttonOpenFretBoard;
    }
}

