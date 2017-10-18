using System;
using System.Windows.Forms;

namespace Sound_teacher
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void buttonGuideOpenGuitar_Click(object sender, EventArgs e)
        {
            Form insideForm = new FormGuideGuitar();
            panelGuide.Controls.Clear();
            insideForm.TopLevel = false;
            insideForm.Dock = DockStyle.Fill;
            panelGuide.Controls.Add(insideForm);
            insideForm.Show();
        }

        private void buttonGuideTechniques_Click(object sender, EventArgs e)
        {
            Form insideForm = new FormGuideTechniques();
            panelGuide.Controls.Clear();
            insideForm.TopLevel = false;
            insideForm.Dock = DockStyle.Fill;
            panelGuide.Controls.Add(insideForm);
            insideForm.Show();
        }

        private void buttonGuideBasicChords_Click(object sender, EventArgs e)
        {
            Form insideForm = new FormGuideBasicChords();
            panelGuide.Controls.Clear();
            insideForm.TopLevel = false;
            insideForm.Dock = DockStyle.Fill;
            panelGuide.Controls.Add(insideForm);
            insideForm.Show();
        }

        private void buttonGuideBasicExercises_Click(object sender, EventArgs e)
        {
            Form insideForm = new FormGuideBasicExercises();
            panelGuide.Controls.Clear();
            insideForm.TopLevel = false;
            insideForm.Dock = DockStyle.Fill;
            panelGuide.Controls.Add(insideForm);
            insideForm.Show();
        }

        private void buttonGuideTips_Click(object sender, EventArgs e)
        {
            Form insideForm = new FormGuideTips();
            panelGuide.Controls.Clear();
            insideForm.TopLevel = false;
            insideForm.Dock = DockStyle.Fill;
            panelGuide.Controls.Add(insideForm);
            insideForm.Show();
        }

        private void buttonGuideExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void reopenInnerForm(Form innerFormToClose, Form innerFormToReopen)
        {
            innerFormToClose.Close();
            panelGuide.Controls.Clear();
            innerFormToReopen.TopLevel = false;
            innerFormToReopen.Dock = DockStyle.Fill;
            panelGuide.Controls.Add(innerFormToReopen);
            innerFormToReopen.Show();
        }
    }
}
