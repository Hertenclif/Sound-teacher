using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sound_teacher
{
    public partial class FormGuideGuitarClassical : Form
    {
        public FormGuideGuitarClassical(Form outerForm)
        {
            InitializeComponent();
            this.outerForm = (FormGuideGuitar)outerForm;
        }
        
        FormGuideGuitar outerForm;

        private void labelGuideGuitarClassicalHead_Click(object sender, EventArgs e)
        {
            Form insideFormGuitarClassicalHead = new FormGuideGuitarClassicalHead(outerForm);
            panelGuideGuitarClassical.Controls.Clear();
            insideFormGuitarClassicalHead.TopLevel = false;
            insideFormGuitarClassicalHead.Dock = DockStyle.Fill;
            panelGuideGuitarClassical.Controls.Add(insideFormGuitarClassicalHead);
            insideFormGuitarClassicalHead.Show();
        }

        private void labelGuideGuitarClassicalNeck_Click(object sender, EventArgs e)
        {
            Form insideFormGuitarClassicalNeck = new FormGuideGuitarClassicalNeck(outerForm);
            panelGuideGuitarClassical.Controls.Clear();
            insideFormGuitarClassicalNeck.TopLevel = false;
            insideFormGuitarClassicalNeck.Dock = DockStyle.Fill;
            panelGuideGuitarClassical.Controls.Add(insideFormGuitarClassicalNeck);
            insideFormGuitarClassicalNeck.Show();
        }

        private void labelGuideGuitarClassicalBodyUpper_Click(object sender, EventArgs e)
        {
            Form insideFormGuitarClassicalBody = new FormGuideGuitarClassicalBody(outerForm);
            panelGuideGuitarClassical.Controls.Clear();
            insideFormGuitarClassicalBody.TopLevel = false;
            insideFormGuitarClassicalBody.Dock = DockStyle.Fill;
            panelGuideGuitarClassical.Controls.Add(insideFormGuitarClassicalBody);
            insideFormGuitarClassicalBody.Show();
        }

        private void labelGuideGuitarClassicalBody_Click(object sender, MouseEventArgs e)
        {
        }
        
        private void labelGuideGuitarClassicalHead_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The main function of a headstock is to house the pegs or mechanism that holds the strings at the head " +
                    "of the instrument. Machine heads on the headstock are commonly used to tune the instrument by adjusting the tension of strings and, consequentially, " +
                    "the pitch of sound they produce.";
        }

        private void labelGuideGuitarClassicalNeck_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Neck is the part of certain string instruments that projects from the main body and is the base " +
                    "of the fingerboard, where the fingers are placed to stop the strings at different pitches.";
        }

        private void labelGuideGuitarClassicalBody_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Soundboard is the surface of a string instrument that the strings vibrate against. " +
                    "The resonant properties of the sound board and the interior of the instrument greatly increase the loudness of the vibrating strings.";
        }

        private void panelGuideGuitarClassical_MouseHover(object sender, EventArgs e)
        {
            if(outerForm != null) outerForm.labelGuideGuitarText.Text = "Click on either guitar head, neck or body to proceed!";
        }

    }
}
