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
    public partial class FormGuideTips : Form
    {
        public FormGuideTips()
        {
            InitializeComponent();
        }
        
        private void buttonGuideTipsPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuideTipsFasterLeft_Click(object sender, EventArgs e)
        {
            labelGuideTipsText.Text = "If you want your left hand fingers play faster, you need to remember, that you should lift them as low as possible. " +
                "It's the most important thing with fast solo playing, but also it helps to change chords faster. At the picture on the right, only index finger " +
                "touches the string.";
            labelGuideTipsPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTipsLowLift");
        }

        private void buttonGuideTipsQuickChords_Click(object sender, EventArgs e)
        {
            labelGuideTipsText.Text = "If you want your quickly change chords, try to be relaxed. It's alway harder if you stress your muscless too much. Try doing as " +
                "less work ass possible and you will see the results in no-time!";
            labelGuideTipsPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTipsRelax");
        }

        private void buttonGuideTipsQuickTremolo_Click(object sender, EventArgs e)
        {
            labelGuideTipsText.Text = "If you have problems with fast tremolo playing (especially if you strum one string constatntly) you can bend your pick a little. " +
                "By doing this, your pick will slide on strings providing you that much desired speed. Remember though, that sometimes sound you produce may sound a bit " +
                "clunky as it will be slightly muted";
            labelGuideTipsPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTipsEasyTremolo");
        }

        private void buttonGuideTipsEasierBending_Click(object sender, EventArgs e)
        {
            labelGuideTipsText.Text = "If you are having problems with bending, as sometimes (especially with harder strings) it may be a bit painfull and you need to use much " +
                "force, try placing as many fingers on the string, as possible. Remember - every finger placed makes it two times easier!";
            labelGuideTipsPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTipsBend");
        }

        private void buttonGuideTipsEasierChords_Click(object sender, EventArgs e)
        {
            labelGuideTipsText.Text = "If are having problem with chords, try this easy, but suprisingly effective tip: Try placing your fingers on a fretboard beggining from " +
                "pinky. Sometimes it's a lot easier doing that way - especially with barre chords.";
            labelGuideTipsPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTipsEasyGrip");
        }
    }
}
