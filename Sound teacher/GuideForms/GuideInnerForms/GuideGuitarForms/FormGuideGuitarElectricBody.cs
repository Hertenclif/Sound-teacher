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
    public partial class FormGuideGuitarElectricBody : Form
    {
        public FormGuideGuitarElectricBody(Form outerForm)
        {
            InitializeComponent();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
            this.outerForm = (FormGuideGuitar)outerForm;
        }

        FormGuide guideForm;
        FormGuideGuitar outerForm;

        private void labelGuideGuitarElectricBodyBody_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Electric guitar has a different type of body than it's more traditional cousins. " +
                    "It's made of a solid block of wood built without its normal sound box and relying on an electric pickup system to directly receive the vibrations of the strings";
        }
        private void labelGuideGuitarElectricPickup_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A pickup device is a transducer (specifically a variable reluctance sensor) that captures or senses " +
                    "mechanical vibrations produced by an electric guitar and converts them to an electrical signal that is amplified using an instrument amplifier " +
                    "to produce musical sounds through a loudspeaker in a speaker enclosure";
        }

        private void labelGuideGuitarBodySaddles_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The saddles are the pieces of the bridge that hold the strings in place, raises them above " +
                    "the bridge and angles them for playing. On electic guitars they are normally made out of metal and can be adjusted. " +
                    "There can either be individual saddles for each string or strings can share a saddle. ";
        }

        private void labelGuideGuitarBodyBridge_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A bridge is a device that supports the strings on a guitar and transmits the vibration of those strings " +
                    "to another structural component of the instrument — a soundboard, which transfers the sound to the surrounding air.";
        }

        private void labelGuideGuitarElectricStarpButtons_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Strap Buttons are used to attach a strap so the player can play while standing.";
        }

        private void labelGuideGuitarElectricVolumeKnob_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Volume control knob is used to control the volume of the instrument. It's often used to prevent damaging " +
                    "guitar amplifier when turning on (guitar volume should be then set to 0)";
        }

        private void labelGuideGuitarElectricToneKnobs_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Tone control knobs are used to adjust tones of the guitar separately from the amplifier.";
        }

        private void labelGuideGuitarElectricOutputConnector_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Output Connector (also Connector Jack) is used to connect an output cable connected to the amplifier.";
        }
        
        private void labelGuideGuitarElectricBodyCutaway_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A cutaway on the guitar construction is an indentation in the upper bout of the guitar " +
                    "body adjacent to the guitar neck, designed to allow easier access to the upper frets.";
        }

        private void buttonGuideGuitarElectricExit_Click(object sender, EventArgs e)
        {
            FormGuideGuitar newGuideGuitar = new FormGuideGuitar(0);
            guideForm.reopenInnerForm(this, newGuideGuitar);

        }
    }
}
