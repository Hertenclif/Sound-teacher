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
    public partial class FormFretBoard : Form
    {

        int fretBoardSoundToDisplay;
        
        //MessageBox.Show(System.Convert.ToString(fretBoardSoundToDisplay));
        String[] fretBoardSoundImageNames = new String[] { "FretBoardA", "FretBoardAis", "FretBoardB", "FretBoardC", "FretBoardCis", "FretBoardD", "FretBoardDis", "FretBoardE", "FretBoardF", "FretBoardFis", "FretBoardG", "FretBoardGis" };

        public FormFretBoard()
        {
            InitializeComponent();
            timerFretBoardChangeImages.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timerFretBoardChangeImages_Tick(object sender, EventArgs e)
        {
            if (PassSoundSingleton.getInstance().change)
            {
                fretBoardSoundToDisplay = PassSoundSingleton.getInstance().sound;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Visible == true) ((PictureBox)x).Visible = false;
                    }
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[fretBoardSoundToDisplay]) ((PictureBox)x).Visible = true;
                        labelDev1.Text = System.Convert.ToString(fretBoardSoundToDisplay);
                        labelDev2.Text = fretBoardSoundImageNames[fretBoardSoundToDisplay];
                    }
                }
            }
        }
    }
}
