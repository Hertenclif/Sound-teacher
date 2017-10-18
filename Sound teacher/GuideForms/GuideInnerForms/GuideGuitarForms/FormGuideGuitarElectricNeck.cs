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
    public partial class FormGuideGuitarElectricNeck : Form
    {
        public FormGuideGuitarElectricNeck(Form outerForm)
        {
            InitializeComponent();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
            this.outerForm = (FormGuideGuitar)outerForm;
        }
        
        FormGuide guideForm;
        FormGuideGuitar outerForm;

        private void labelGuideGuitarNeckFretMarkers_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Marker dots on the face of the fretboard are usually placed at frets " +
                    "3, 5, 7, 9, 12 (double dot to indicate the octave), 15, 17, 19, 21, 24 (double dot to indicate the second octave). It's also common " +
                    "that there are marker dots on the upper side of the neck, near the edge of the fretboard, where the player can easily see which fret he or she is on. " +
                    "Sometimes the dots are replaced with bars, the octave positions having a wider bar. Classical guitars almost never feature position markers, " +
                    "especially on the fretboard's face, whereas electric guitars usually do";
        }

        private void labelGuideGuitarNeckFrets_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "fret is a raised element on the neck of a stringed instrument. Frets usually extend across the full " +
                    "width of the neck. On most modern western fretted instruments, frets are metal strips inserted into the fingerboard." +
                    "Frets divide the neck into fixed segments at intervals related to a musical framework. On instruments such as guitars, " +
                    "each fret represents one semitone in the standard western system, in which one octave is divided into twelve semitones";

        }

        private void labelGuideGuitarElectricNeckNeck_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Neck is the part of certain string instruments that projects from the main body and is the base " +
                    "of the fingerboard, where the fingers are placed to stop the strings at different pitches.";
        }

        private void buttonGuideGuitarElectricNeckExit_Click(object sender, EventArgs e)
        {
            FormGuideGuitar newGuideGuitar = new FormGuideGuitar(0);
            guideForm.reopenInnerForm(this, newGuideGuitar);

        }
    }
}
