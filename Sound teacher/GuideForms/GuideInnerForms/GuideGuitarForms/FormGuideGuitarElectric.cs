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
    public partial class FormGuideGuitarElectric : Form
    {
        public FormGuideGuitarElectric(Form outerForm)
        {
            InitializeComponent();
            this.outerForm = (FormGuideGuitar)outerForm;
        }
        
        FormGuideGuitar outerForm;

        private void labelGuideGuitarElectricHead_Click(object sender, MouseEventArgs e)
        {
            Form insideFormGuitarElectricHead = new FormGuideGuitarElectricHead(outerForm);
            panelGuideGuitarElectric.Controls.Clear();
            insideFormGuitarElectricHead.TopLevel = false;
            insideFormGuitarElectricHead.Dock = DockStyle.Fill;
            panelGuideGuitarElectric.Controls.Add(insideFormGuitarElectricHead);
            insideFormGuitarElectricHead.Show();
        }

        private void labelGuideGuitarElectricNeck_Click(object sender, MouseEventArgs e)
        {
            Form insideFormGuitarElectricNeck = new FormGuideGuitarElectricNeck(outerForm);
            panelGuideGuitarElectric.Controls.Clear();
            insideFormGuitarElectricNeck.TopLevel = false;
            insideFormGuitarElectricNeck.Dock = DockStyle.Fill;
            panelGuideGuitarElectric.Controls.Add(insideFormGuitarElectricNeck);
            insideFormGuitarElectricNeck.Show();
        }

        private void labelGuideGuitarElectricBody_Click(object sender, MouseEventArgs e)
        {
            Form insideFormGuitarElectricBody = new FormGuideGuitarElectricBody(outerForm);
            panelGuideGuitarElectric.Controls.Clear();
            insideFormGuitarElectricBody.TopLevel = false;
            insideFormGuitarElectricBody.Dock = DockStyle.Fill;
            panelGuideGuitarElectric.Controls.Add(insideFormGuitarElectricBody);
            insideFormGuitarElectricBody.Show();
        }

        private void labelGuideGuitarElectricHead_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The main function of a headstock is to house the pegs or mechanism that holds the strings at the head " +
                    "of the instrument. Machine heads on the headstock are commonly used to tune the instrument by adjusting the tension of strings and, consequentially, " +
                    "the pitch of sound they produce.";

        }
        private void labelGuideGuitarElectricNeck_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Neck is the part of certain string instruments that projects from the main body and is the base " +
                    "of the fingerboard, where the fingers are placed to stop the strings at different pitches.";

        }

        private void labelGuideGuitarElectricBody_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Electric guitar has a different type of body than it's more traditional cousins. " +
                    "It's made of a solid block of wood built without its normal sound box and relying on an electric pickup system to directly receive the vibrations of the strings";

        }

        private void panelGuideGuitarElectric_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Click on either guitar head, neck or body to proceed!";

        }
    }
}
