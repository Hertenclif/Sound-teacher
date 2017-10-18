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
    public partial class FormGuideGuitarAcoustic : Form
    {
        public FormGuideGuitarAcoustic(Form outerForm)
        {
            InitializeComponent();
            this.outerForm = (FormGuideGuitar)outerForm;
        }
        
        FormGuideGuitar outerForm;


        private void labelGuideGuitarAcousticHead_MouseClick(object sender, MouseEventArgs e)
        {
            Form insideFormGuitarAcousticHead = new FormGuideGuitarAcousticHead(outerForm);
            panelGuideGuitarAcoustic.Controls.Clear();
            insideFormGuitarAcousticHead.TopLevel = false;
            insideFormGuitarAcousticHead.Dock = DockStyle.Fill;
            panelGuideGuitarAcoustic.Controls.Add(insideFormGuitarAcousticHead);
            insideFormGuitarAcousticHead.Show();

        }

        private void labelGuideGuitarAcousticNeck_MouseClick(object sender, MouseEventArgs e)
        {
            Form insideFormGuitarAcousticNeck = new FormGuideGuitarAcousticNeck(outerForm);
            panelGuideGuitarAcoustic.Controls.Clear();
            insideFormGuitarAcousticNeck.TopLevel = false;
            insideFormGuitarAcousticNeck.Dock = DockStyle.Fill;
            panelGuideGuitarAcoustic.Controls.Add(insideFormGuitarAcousticNeck);
            insideFormGuitarAcousticNeck.Show();
        }

        private void labelGuideGuitarAcousticBody_MouseClick(object sender, MouseEventArgs e)
        {
            Form insideFormGuitarAcousticBody = new FormGuideGuitarAcousticBody(outerForm);
            panelGuideGuitarAcoustic.Controls.Clear();
            insideFormGuitarAcousticBody.TopLevel = false;
            insideFormGuitarAcousticBody.Dock = DockStyle.Fill;
            panelGuideGuitarAcoustic.Controls.Add(insideFormGuitarAcousticBody);
            insideFormGuitarAcousticBody.Show();
        }

        private void labelGuideGuitarAcousticHead_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The main function of a headstock is to house the pegs or mechanism that holds the strings at the head " +
                    "of the instrument. Machine heads on the headstock are commonly used to tune the instrument by adjusting the tension of strings and, consequentially, " +
                    "the pitch of sound they produce.";
        }

        private void labelGuideGuitarAcousticNeck_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Neck is the part of certain string instruments that projects from the main body and is the base " +
                    "of the fingerboard, where the fingers are placed to stop the strings at different pitches.";
        }

        private void labelGuideGuitarAcousticBody_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Soundboard is the surface of a string instrument that the strings vibrate against. " +
                    "The resonant properties of the sound board and the interior of the instrument greatly increase the loudness of the vibrating strings.";
        }

        private void panelGuideGuitarAcousticc_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Click on either guitar head, neck or body to proceed!";
        }

    }
}
