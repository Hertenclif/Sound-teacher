namespace Sound_teacher
{
    partial class FormGuide
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
            this.panelGuide = new System.Windows.Forms.Panel();
            this.buttonGuideGuitar = new System.Windows.Forms.Button();
            this.buttonGuideTechniques = new System.Windows.Forms.Button();
            this.buttonGuideExit = new System.Windows.Forms.Button();
            this.buttonGuideBasicChords = new System.Windows.Forms.Button();
            this.buttonGuideBasicExercises = new System.Windows.Forms.Button();
            this.buttonGuideTips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelGuide
            // 
            this.panelGuide.BackgroundImage = global::Sound_teacher.Properties.Resources.ST;
            this.panelGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelGuide.Location = new System.Drawing.Point(159, 43);
            this.panelGuide.Name = "panelGuide";
            this.panelGuide.Size = new System.Drawing.Size(614, 400);
            this.panelGuide.TabIndex = 2;
            // 
            // buttonGuideGuitar
            // 
            this.buttonGuideGuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideGuitar.Image = global::Sound_teacher.Properties.Resources.GuideButtonGuitarTheory;
            this.buttonGuideGuitar.Location = new System.Drawing.Point(28, 47);
            this.buttonGuideGuitar.Name = "buttonGuideGuitar";
            this.buttonGuideGuitar.Size = new System.Drawing.Size(108, 65);
            this.buttonGuideGuitar.TabIndex = 0;
            this.buttonGuideGuitar.UseVisualStyleBackColor = true;
            this.buttonGuideGuitar.Click += new System.EventHandler(this.buttonGuideOpenGuitar_Click);
            // 
            // buttonGuideTechniques
            // 
            this.buttonGuideTechniques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideTechniques.Image = global::Sound_teacher.Properties.Resources.GuideButtonTechniques;
            this.buttonGuideTechniques.Location = new System.Drawing.Point(28, 118);
            this.buttonGuideTechniques.Name = "buttonGuideTechniques";
            this.buttonGuideTechniques.Size = new System.Drawing.Size(108, 65);
            this.buttonGuideTechniques.TabIndex = 3;
            this.buttonGuideTechniques.UseVisualStyleBackColor = true;
            this.buttonGuideTechniques.Click += new System.EventHandler(this.buttonGuideTechniques_Click);
            // 
            // buttonGuideExit
            // 
            this.buttonGuideExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideExit.Image = global::Sound_teacher.Properties.Resources.GuideButtonExit;
            this.buttonGuideExit.Location = new System.Drawing.Point(28, 402);
            this.buttonGuideExit.Name = "buttonGuideExit";
            this.buttonGuideExit.Size = new System.Drawing.Size(108, 41);
            this.buttonGuideExit.TabIndex = 4;
            this.buttonGuideExit.UseVisualStyleBackColor = true;
            this.buttonGuideExit.Click += new System.EventHandler(this.buttonGuideExit_Click);
            // 
            // buttonGuideBasicChords
            // 
            this.buttonGuideBasicChords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideBasicChords.Image = global::Sound_teacher.Properties.Resources.GuideButtonBasicChords;
            this.buttonGuideBasicChords.Location = new System.Drawing.Point(28, 189);
            this.buttonGuideBasicChords.Name = "buttonGuideBasicChords";
            this.buttonGuideBasicChords.Size = new System.Drawing.Size(108, 65);
            this.buttonGuideBasicChords.TabIndex = 5;
            this.buttonGuideBasicChords.UseVisualStyleBackColor = true;
            this.buttonGuideBasicChords.Click += new System.EventHandler(this.buttonGuideBasicChords_Click);
            // 
            // buttonGuideBasicExercises
            // 
            this.buttonGuideBasicExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideBasicExercises.Image = global::Sound_teacher.Properties.Resources.GuideButtonBasicExercises;
            this.buttonGuideBasicExercises.Location = new System.Drawing.Point(28, 260);
            this.buttonGuideBasicExercises.Name = "buttonGuideBasicExercises";
            this.buttonGuideBasicExercises.Size = new System.Drawing.Size(108, 65);
            this.buttonGuideBasicExercises.TabIndex = 6;
            this.buttonGuideBasicExercises.UseVisualStyleBackColor = true;
            this.buttonGuideBasicExercises.Click += new System.EventHandler(this.buttonGuideBasicExercises_Click);
            // 
            // buttonGuideTips
            // 
            this.buttonGuideTips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideTips.Image = global::Sound_teacher.Properties.Resources.GuideButtonTips;
            this.buttonGuideTips.Location = new System.Drawing.Point(28, 331);
            this.buttonGuideTips.Name = "buttonGuideTips";
            this.buttonGuideTips.Size = new System.Drawing.Size(108, 65);
            this.buttonGuideTips.TabIndex = 7;
            this.buttonGuideTips.UseVisualStyleBackColor = true;
            this.buttonGuideTips.Click += new System.EventHandler(this.buttonGuideTips_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Sound_teacher.Properties.Resources.GuideBackground;
            this.ClientSize = new System.Drawing.Size(796, 467);
            this.Controls.Add(this.buttonGuideTips);
            this.Controls.Add(this.buttonGuideBasicExercises);
            this.Controls.Add(this.buttonGuideBasicChords);
            this.Controls.Add(this.buttonGuideExit);
            this.Controls.Add(this.buttonGuideTechniques);
            this.Controls.Add(this.buttonGuideGuitar);
            this.Controls.Add(this.panelGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(935, 0);
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSthGreat";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGuide;
        private System.Windows.Forms.Button buttonGuideGuitar;
        private System.Windows.Forms.Button buttonGuideTechniques;
        private System.Windows.Forms.Button buttonGuideExit;
        private System.Windows.Forms.Button buttonGuideBasicChords;
        private System.Windows.Forms.Button buttonGuideBasicExercises;
        private System.Windows.Forms.Button buttonGuideTips;
    }
}