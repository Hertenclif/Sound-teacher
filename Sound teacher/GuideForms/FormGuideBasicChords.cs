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
    public partial class FormGuideBasicChords : Form
    {
        public FormGuideBasicChords()
        {
            InitializeComponent();
        }

        private void buttonGuideBasicChordsPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuideBasicChordsA_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsA");
        }

        private void buttonGuideBasicChordsAm_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsAm");
        }

        private void buttonGuideBasicChordsBm_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsBm");
        }

        private void buttonGuideBasicChordsC_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsC");
        }

        private void buttonGuideBasicChordsD_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsD");
        }

        private void buttonGuideBasicChordsDm_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsDm");
        }

        private void buttonGuideBasicChordsE_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsE");
        }

        private void buttonGuideBasicChordsEm_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsEm");
        }

        private void buttonGuideBasicChordsF_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsF");
        }

        private void buttonGuideBasicChordsG_Click(object sender, EventArgs e)
        {
            pictureBoxGuideBasicChordsPictures.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideBasicChordsG");
        }
    }
}
