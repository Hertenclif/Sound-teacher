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
    public partial class FormGuideGuitarAcousticHead : Form
    {
        public FormGuideGuitarAcousticHead(Form outerForm)
        {
            InitializeComponent();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
            this.outerForm = (FormGuideGuitar)outerForm;
        }

        FormGuide guideForm;
        FormGuideGuitar outerForm;
        
        private void labelGuideGuitarHeadTuningPegs_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Tuning peg (similar to machine head) is a geared apparatus for tuning stringed musical instruments by adjusting string tension." +
                    "Friction pegs hold the string in tune by way of friction caused by their tapered shape and by the string pull created by the tight string.";
        }
        
        private void labelGuideGuitarHeadNut_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Nut is a small piece of hard material that supports the strings at the end closest to the headstock. " +
                    "The nut marks one end of the vibrating length of each open string, sets the spacing of the strings across the neck, and usually holds the strings at the proper " +
                    "height from the fingerboard. Along with the bridge, the nut defines the vibrating lengths (scale lengths) of the open strings.";
        }

        private void labelGuideGuitarHeadHead_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The main function of a headstock is to house the pegs or mechanism that holds the strings at the head " +
                    "of the instrument. Machine heads on the headstock are commonly used to tune the instrument by adjusting the tension of strings and, consequentially, " +
                    "the pitch of sound they produce.";
        }

        private void buttonGuideGuitarElectricExit_Click(object sender, EventArgs e)
        {
            FormGuideGuitar newGuideGuitar = new FormGuideGuitar(1);
            guideForm.reopenInnerForm(this, newGuideGuitar);

        }

    }
}
