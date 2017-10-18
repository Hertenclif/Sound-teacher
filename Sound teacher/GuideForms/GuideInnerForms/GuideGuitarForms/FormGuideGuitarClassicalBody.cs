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
    public partial class FormGuideGuitarClassicalBody : Form
    {
        public FormGuideGuitarClassicalBody(Form outerForm)
        {
            InitializeComponent();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
            this.outerForm = (FormGuideGuitar)outerForm;
        }

        FormGuide guideForm;
        FormGuideGuitar outerForm;

        private void labelGuideGuitarClassicalSoundBoard_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Soundboard is the surface of a string instrument that the strings vibrate against. " +
                    "The resonant properties of the sound board and the interior of the instrument greatly increase the loudness of the vibrating strings.";
        }

        private void labelGuideGuitarClassicalSaddle_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "The saddles is a pieces of the bridge that hold the strings in place, raises them above " +
                    "the bridge and angles them for playing. On acoustic and classical guitars they are either made out of bone or plastic and often cannot be adjusted. ";
        }

        private void labelGuideGuitarClassicalBridge_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A bridge is a device that supports the strings on a guitar and transmits the vibration of those strings " +
                    "to another structural component of the instrument — a soundboard, which transfers the sound to the surrounding air.";
        }

        private void labelGuideGuitarClassicalSoundHole_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "A sound hole is an opening in the upper sound board of a guitar.Though the purpose of sound holes is to help a guitar " +
                    "project their sound more efficiently, the sound does not emanate solely (nor even mostly) from the location of the sound hole. " +
                    "The majority of sound emanates from the surface area of both sounding boards, with sound holes playing a part by allowing the sounding boards " +
                    "to vibrate more freely, and by allowing some of the vibrations which have been set in motion inside the instrument to travel outside the instrument.";
        }

        private void labelGuideGuitarClassicalRosette_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Rosette's role is solely aesthetic. It can be often found on classical guitars, but sometimes appear also on" +
                    "acoustic ones.";
        }

        private void buttonGuideGuitarElectricExit_Click(object sender, EventArgs e)
        {
            FormGuideGuitar newGuideGuitar = new FormGuideGuitar(2);
            guideForm.reopenInnerForm(this, newGuideGuitar);

        }
    }
}
