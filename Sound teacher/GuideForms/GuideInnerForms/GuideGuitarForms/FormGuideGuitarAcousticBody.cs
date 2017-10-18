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
    public partial class FormGuideGuitarAcousticBody : Form
    {
        public FormGuideGuitarAcousticBody(Form outerForm)
        {
            InitializeComponent();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
            this.outerForm = (FormGuideGuitar)outerForm;
        }

        FormGuide guideForm;
        FormGuideGuitar outerForm;


        private void labelGuideGuitarAcousticSoundBoard_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Soundboard is the surface of a string instrument that the strings vibrate against. " +
                    "The resonant properties of the sound board and the interior of the instrument greatly increase the loudness of the vibrating strings.";
        }
        
        private void labelGuideGuitarAcousticSoundHole_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A sound hole is an opening in the upper sound board of a guitar.Though the purpose of sound holes is to help a guitar " +
                    "project their sound more efficiently, the sound does not emanate solely (nor even mostly) from the location of the sound hole. " +
                    "The majority of sound emanates from the surface area of both sounding boards, with sound holes playing a part by allowing the sounding boards " +
                    "to vibrate more freely, and by allowing some of the vibrations which have been set in motion inside the instrument to travel outside the instrument.";
        }

        private void labelGuideGuitarAcousticSaddleAndFixingPegs_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The saddles is a pieces of the bridge that hold the strings in place, raises them above " +
                    "the bridge and angles them for playing. On acoustic and classical guitars they are either made out of bone or plastic and often cannot be adjusted. ";
        }

        private void labelGuideGuitarAcousticBridge_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A bridge is a device that supports the strings on a guitar and transmits the vibration of those strings " +
                    "to another structural component of the instrument — a soundboard, which transfers the sound to the surrounding air.";
        }

        private void labelGuideGuitarAcousticPickUp_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A pickup device is a transducer (specifically a variable reluctance sensor) that captures or senses " +
                    "mechanical vibrations produced by an electric guitar and converts them to an electrical signal that is amplified using an instrument amplifier " +
                    "to produce musical sounds through a loudspeaker in a speaker enclosure. Acoustic guitars often use a piezoelectric pickup.";
        }

        private void labelGuideGuitarAcousticCutaway_MouseHover(object sender, EventArgs e)
        {
            if(outerForm != null) outerForm.labelGuideGuitarText.Text = "A cutaway on the guitar construction is an indentation in the upper bout of the guitar " +
                    "body adjacent to the guitar neck, designed to allow easier access to the upper frets. They are rarely used in classical guitar as they can affect the sound" +
                    "of an instrument";
        }

        private void labelGuideGuitarAcousticOutputConnector_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Output Connector (also Connector Jack) is used to connect an output cable connected to the amplifier.";
        }

        private void buttonGuideGuitarElectricExit_Click(object sender, EventArgs e)
        {
            FormGuideGuitar newGuideGuitar = new FormGuideGuitar(1);
            guideForm.reopenInnerForm(this, newGuideGuitar);

        }
    }
}
