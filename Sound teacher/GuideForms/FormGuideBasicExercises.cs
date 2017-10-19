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
    public partial class FormGuideBasicExercises : Form
    {
        public FormGuideBasicExercises()
        {
            InitializeComponent();
        }

        private void buttonGuideBasicExercisesAT1_Click(object sender, EventArgs e)
        {
            labelGuideBasicExercisesText.Text = "In this exercise, you need to play only one string with the pattern: 1, 2, 3, 4, 2, 3, 4, 5, 3, 4, 5, 6 and so on. " +
                "When you are at the 12th fret, try playing it backwards. Very important: you should always play tremolo!";
            labelGuideBasicExercisesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicExercisesAaT1");
        }

        private void buttonGuideBasicExercisesAT2_Click(object sender, EventArgs e)
        {
            labelGuideBasicExercisesText.Text = "In this exercise, you need to play 4 frets, each string with the pattern: 1, 2, 3, 4 beginning " +
                "at the low E string. When you are at the 4th fret of high e string, you should play each string again, beginning at the high e string and going upwards " +
                "with the pattern: 2, 3, 4, 5. Very important: you should always play tremolo!";
            labelGuideBasicExercisesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicExercisesAaT2");
        }

        private void buttonGuideBasicExercisesAT3_Click(object sender, EventArgs e)
        {
            labelGuideBasicExercisesText.Text = "In this exercise, you need to play 4 frets, each string with the pattern: 1, 2, 3, 4, 2, 3, 4, 5, 3, 4, 5, 6 and so on, beginning " +
                "at the low E string. When you are at the 9th fret of high e string, you should play each string again, begining at the high e string and going upwards. " +
                "When you are at the 14th fret of low E string, try playing it again backwards. Very important: you should always play tremolo!";
            labelGuideBasicExercisesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicExercisesAaT3");

        }

        private void buttonGuideBasicExercisesCharmonic_Click(object sender, EventArgs e)
        {
            labelGuideBasicExercisesText.Text = "In this exercise, you need to play the pattern (<STRING>:<FRET>): 1:5, 3:7, 2:7, 4:6, 3:7, 5:5, 4:6, 6:5, 6:9. " +
                "When you reach the high e string on 9th fret, you should play the pattern backwards. Very important: you should always play tremolo!";
            labelGuideBasicExercisesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicExercisesCharmonic");

        }

        private void buttonGuideTechniquesPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
