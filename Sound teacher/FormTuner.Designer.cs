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
            this.buttonStopTuner = new System.Windows.Forms.Button();
            this.buttonPlaySound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartTuner
            // 
            this.buttonStartTuner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTuner.Location = new System.Drawing.Point(737, 375);
            this.buttonStartTuner.Name = "buttonStartTuner";
            this.buttonStartTuner.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTuner.TabIndex = 0;
            this.buttonStartTuner.Text = "Start!";
            this.buttonStartTuner.UseVisualStyleBackColor = true;
            this.buttonStartTuner.Click += new System.EventHandler(this.buttonStartTuner_Click);
            // 
            // buttonStopTuner
            // 
            this.buttonStopTuner.Location = new System.Drawing.Point(737, 333);
            this.buttonStopTuner.Name = "buttonStopTuner";
            this.buttonStopTuner.Size = new System.Drawing.Size(75, 23);
            this.buttonStopTuner.TabIndex = 1;
            this.buttonStopTuner.Text = "Stop Tuner";
            this.buttonStopTuner.UseVisualStyleBackColor = true;
            this.buttonStopTuner.Click += new System.EventHandler(this.buttonStopTuner_Click);
            // 
            // buttonPlaySound
            // 
            this.buttonPlaySound.Location = new System.Drawing.Point(737, 304);
            this.buttonPlaySound.Name = "buttonPlaySound";
            this.buttonPlaySound.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaySound.TabIndex = 2;
            this.buttonPlaySound.Text = "Play Sound";
            this.buttonPlaySound.UseVisualStyleBackColor = true;
            this.buttonPlaySound.Click += new System.EventHandler(this.buttonPlaySound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // FormTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(843, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlaySound);
            this.Controls.Add(this.buttonStopTuner);
            this.Controls.Add(this.buttonStartTuner);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "FormTuner";
            this.Text = "FormTuner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartTuner;
        private System.Windows.Forms.Timer timerTunerRecord;
        private System.Windows.Forms.Button buttonStopTuner;
        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}