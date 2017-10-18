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
    public partial class FormGuideGuitarClassicalNeck : Form
    {
        public FormGuideGuitarClassicalNeck(Form outerForm)
        {
            InitializeComponent();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
            this.outerForm = (FormGuideGuitar)outerForm;
        }
        
        FormGuide guideForm;
        FormGuideGuitar outerForm;

        private void labelGuideGuitarHeadFret_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "fret is a raised element on the neck of a stringed instrument. Frets usually extend across the full " +
                    "width of the neck. On most modern western fretted instruments, frets are metal strips inserted into the fingerboard." +
                    "Frets divide the neck into fixed segments at intervals related to a musical framework. On instruments such as guitars, " +
                    "each fret represents one semitone in the standard western system, in which one octave is divided into twelve semitones";
        }

        private void labelGuideGuitarClassicalNeckNeck_MouseHover(object sender, EventArgs e)
        {
            if (outerForm != null) outerForm.labelGuideGuitarText.Text = "Neck is the part of certain string instruments that projects from the main body and is the base " +
                    "of the fingerboard, where the fingers are placed to stop the strings at different pitches.";
        }

        private void buttonGuideGuitarElectricNeckExit_Click(object sender, EventArgs e)
        {
            FormGuideGuitar newGuideGuitar = new FormGuideGuitar(2);
            guideForm.reopenInnerForm(this, newGuideGuitar);

        }

    }
}
