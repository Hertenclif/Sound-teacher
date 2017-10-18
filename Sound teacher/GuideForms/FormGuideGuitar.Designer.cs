namespace Sound_teacher
{
    partial class FormGuideGuitar
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
            this.buttonGuideGuitarPrevious = new System.Windows.Forms.Button();
            this.labelGuideGuitarText = new System.Windows.Forms.Label();
            this.panelGuideGuitar = new System.Windows.Forms.Panel();
            this.ButtonGuideGuitarElectric = new System.Windows.Forms.Button();
            this.ButtonGuideGuitarAcoustic = new System.Windows.Forms.Button();
            this.ButtonGuideGuitarClassical = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGuideGuitarPrevious
            // 
            this.buttonGuideGuitarPrevious.BackColor = System.Drawing.Color.Black;
            this.buttonGuideGuitarPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonGuideGuitarPrevious.Location = new System.Drawing.Point(8, 365);
            this.buttonGuideGuitarPrevious.Name = "buttonGuideGuitarPrevious";
            this.buttonGuideGuitarPrevious.Size = new System.Drawing.Size(197, 23);
            this.buttonGuideGuitarPrevious.TabIndex = 1;
            this.buttonGuideGuitarPrevious.Text = "Previous";
            this.buttonGuideGuitarPrevious.UseVisualStyleBackColor = false;
            this.buttonGuideGuitarPrevious.Click += new System.EventHandler(this.buttonGuideGuitarPrevious_Click);
            // 
            // labelGuideGuitarText
            // 
            this.labelGuideGuitarText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGuideGuitarText.ForeColor = System.Drawing.Color.White;
            this.labelGuideGuitarText.Location = new System.Drawing.Point(9, 9);
            this.labelGuideGuitarText.Name = "labelGuideGuitarText";
            this.labelGuideGuitarText.Size = new System.Drawing.Size(196, 313);
            this.labelGuideGuitarText.TabIndex = 2;
            this.labelGuideGuitarText.Text = "Click on either guitar head, neck or body to proceed!";
            // 
            // panelGuideGuitar
            // 
            this.panelGuideGuitar.BackgroundImage = global::Sound_teacher.Properties.Resources.ST;
            this.panelGuideGuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelGuideGuitar.Location = new System.Drawing.Point(214, 0);
            this.panelGuideGuitar.Name = "panelGuideGuitar";
            this.panelGuideGuitar.Size = new System.Drawing.Size(400, 400);
            this.panelGuideGuitar.TabIndex = 4;
            // 
            // ButtonGuideGuitarElectric
            // 
            this.ButtonGuideGuitarElectric.BackColor = System.Drawing.Color.Black;
            this.ButtonGuideGuitarElectric.ForeColor = System.Drawing.Color.White;
            this.ButtonGuideGuitarElectric.Location = new System.Drawing.Point(8, 336);
            this.ButtonGuideGuitarElectric.Name = "ButtonGuideGuitarElectric";
            this.ButtonGuideGuitarElectric.Size = new System.Drawing.Size(65, 23);
            this.ButtonGuideGuitarElectric.TabIndex = 0;
            this.ButtonGuideGuitarElectric.Text = "Electric";
            this.ButtonGuideGuitarElectric.UseVisualStyleBackColor = false;
            this.ButtonGuideGuitarElectric.Click += new System.EventHandler(this.ButtonGuideGuitarElectric_Click);
            // 
            // ButtonGuideGuitarAcoustic
            // 
            this.ButtonGuideGuitarAcoustic.BackColor = System.Drawing.Color.Black;
            this.ButtonGuideGuitarAcoustic.ForeColor = System.Drawing.Color.White;
            this.ButtonGuideGuitarAcoustic.Location = new System.Drawing.Point(74, 336);
            this.ButtonGuideGuitarAcoustic.Name = "ButtonGuideGuitarAcoustic";
            this.ButtonGuideGuitarAcoustic.Size = new System.Drawing.Size(65, 23);
            this.ButtonGuideGuitarAcoustic.TabIndex = 5;
            this.ButtonGuideGuitarAcoustic.Text = "Acoustic";
            this.ButtonGuideGuitarAcoustic.UseVisualStyleBackColor = false;
            this.ButtonGuideGuitarAcoustic.Click += new System.EventHandler(this.ButtonGuideGuitarAcoustic_Click);
            // 
            // ButtonGuideGuitarClassical
            // 
            this.ButtonGuideGuitarClassical.BackColor = System.Drawing.Color.Black;
            this.ButtonGuideGuitarClassical.ForeColor = System.Drawing.Color.White;
            this.ButtonGuideGuitarClassical.Location = new System.Drawing.Point(140, 336);
            this.ButtonGuideGuitarClassical.Name = "ButtonGuideGuitarClassical";
            this.ButtonGuideGuitarClassical.Size = new System.Drawing.Size(65, 23);
            this.ButtonGuideGuitarClassical.TabIndex = 6;
            this.ButtonGuideGuitarClassical.Text = "Classical";
            this.ButtonGuideGuitarClassical.UseVisualStyleBackColor = false;
            this.ButtonGuideGuitarClassical.Click += new System.EventHandler(this.ButtonGuideGuitarClassical_Click);
            // 
            // FormGuideGuitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Sound_teacher.Properties.Resources.GuideInnerBackground;
            this.ClientSize = new System.Drawing.Size(614, 400);
            this.Controls.Add(this.ButtonGuideGuitarClassical);
            this.Controls.Add(this.ButtonGuideGuitarAcoustic);
            this.Controls.Add(this.ButtonGuideGuitarElectric);
            this.Controls.Add(this.panelGuideGuitar);
            this.Controls.Add(this.labelGuideGuitarText);
            this.Controls.Add(this.buttonGuideGuitarPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGuideGuitar";
            this.Text = "FormGuideGuitar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGuideGuitarPrevious;
        private System.Windows.Forms.Panel panelGuideGuitar;
        public System.Windows.Forms.Label labelGuideGuitarText;
        private System.Windows.Forms.Button ButtonGuideGuitarElectric;
        private System.Windows.Forms.Button ButtonGuideGuitarAcoustic;
        private System.Windows.Forms.Button ButtonGuideGuitarClassical;
    }
}