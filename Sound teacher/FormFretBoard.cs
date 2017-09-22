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
        bool startStopFretBoardFlag = true;
        String[] fretBoardSoundImageNames = new String[] { "FretBoardA", "FretBoardAis", "FretBoardB", "FretBoardC", "FretBoardCis", "FretBoardD", "FretBoardDis", "FretBoardE", "FretBoardF", "FretBoardFis", "FretBoardG", "FretBoardGis" };
        String[] pictures = new String[] { "FretBoard_StartButton", "FretBoard_StopButton", "FretBoard_StartFretBoardButton", "FretBoard_StopFretBoardButton", "FretBoard_NewFretBoard" };
        public FormFretBoard()
        {
            InitializeComponent();
            if (PassSoundSingleton.getInstance().on)
            {
                timerFretBoardChangeImages.Enabled = true;
            }
            comboBoxScaleChoice.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (timerFretBoardChangeImages.Enabled) 
            {
                timerFretBoardChangeImages.Enabled = false;
                buttonFretBoardStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[2]);
               // buttonFretBoardStartStop.Tag = "stopFret";
                startStopFretBoardFlag = false;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[fretBoardSoundToDisplay = PassSoundSingleton.getInstance().sound]) ((PictureBox)x).Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("");
                timerFretBoardChangeImages.Enabled = true;
                //buttonFretBoardStartStop.Tag = "startFret";
                startStopFretBoardFlag = true;
                buttonFretBoardStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[3]);
            }
        }

        private void timerFretBoardChangeImages_Tick(object sender, EventArgs e)
        {
            if (PassSoundSingleton.getInstance().on == false) timerFretBoardChangeImages.Enabled = false;
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
                setAdditionalSound();
                setPictures(fretBoardSoundToDisplay, true);
            }
        }

        private void comboBoxSoundChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxScaleChoice.SelectedIndex != 0)
            {
                timerFretBoardChangeImages.Enabled = false;
                buttonFretBoardStartStop.Enabled = false;
                buttonFretBoardStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[2]);
                //startStopFretBoardFlag = false;
            }
            else
            {
                timerFretBoardChangeImages.Enabled = true;
                buttonFretBoardStartStop.Enabled = true;
                buttonFretBoardStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[3]);
               // startStopFretBoardFlag = true;

            }

        }

        private void groupBoxFretBoardSounds_Enter(object sender, EventArgs e)
        {

        }
        private void setPictures(int displaySound, bool showHide)
        {
            if (showHide == true && timerFretBoardChangeImages.Enabled == true)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[displaySound]) ((PictureBox)x).Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[displaySound] == true) ((PictureBox)x).Visible = false;
                    }
                }
            }
            
        }
        private void setAdditionalSound()
        {
            if (checkBoxFretBoardA.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 0)) setPictures(0, true);
            else setPictures(0, false);

            if (checkBoxFretBoardAis.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 1)) setPictures(1, true);
            else setPictures(1, false);

            if (checkBoxFretBoardB.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 2)) setPictures(2, true);
            else setPictures(2, false);

            if (checkBoxFretBoardC.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 3))  setPictures(3, true);
            else  setPictures(3, false);

           if (checkBoxFretBoardCis.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 4))  setPictures(4, true);
            else setPictures(4, false);

            if (checkBoxFretBoardD.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 5))  setPictures(5, true);
            else setPictures(5, false);

            if (checkBoxFretBoardDis.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 6))  setPictures(6, true);
            else setPictures(6, false);

            if (checkBoxFretBoardE.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 7))  setPictures(7, true);
            else setPictures(7, false);

            if (checkBoxFretBoardF.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 8))  setPictures(8, true);
            else setPictures(8, false);

            if (checkBoxFretBoardFis.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 9))  setPictures(9, true);
            else setPictures(9, false);

            if (checkBoxFretBoardG.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 10))  setPictures(10, true);
            else setPictures(10, false);

            if (checkBoxFretBoardGis.Checked || (PassSoundSingleton.getInstance().on && fretBoardSoundToDisplay == 11))  setPictures(11, true);
            else setPictures(11, false);
            
            if (checkBoxFretBoardAll.Checked)
            {
                checkBoxFretBoardA.Checked = true;
                checkBoxFretBoardAis.Checked = true;
                checkBoxFretBoardB.Checked = true;
                checkBoxFretBoardC.Checked = true;
                checkBoxFretBoardCis.Checked = true;
                checkBoxFretBoardD.Checked = true;
                checkBoxFretBoardDis.Checked = true;
                checkBoxFretBoardE.Checked = true;
                checkBoxFretBoardF.Checked = true;
                checkBoxFretBoardFis.Checked = true;
                checkBoxFretBoardG.Checked = true;
                checkBoxFretBoardGis.Checked = true;
                checkBoxFretBoardAll.Checked = false;
            } 
            if (checkBoxFretBoardNone.Checked)
            {
                checkBoxFretBoardA.Checked = false;
                checkBoxFretBoardAis.Checked = false;
                checkBoxFretBoardB.Checked = false;
                checkBoxFretBoardC.Checked = false;
                checkBoxFretBoardCis.Checked = false;
                checkBoxFretBoardD.Checked = false;
                checkBoxFretBoardDis.Checked = false;
                checkBoxFretBoardE.Checked = false;
                checkBoxFretBoardF.Checked = false;
                checkBoxFretBoardFis.Checked = false;
                checkBoxFretBoardG.Checked = false;
                checkBoxFretBoardGis.Checked = false;
                checkBoxFretBoardAll.Checked = false;
                checkBoxFretBoardNone.Checked = false;
            }
            if (checkBoxFretBoardShowNextTo.Checked)
            {
                if (fretBoardSoundToDisplay == 0) setPictures(11, true);
                else setPictures(fretBoardSoundToDisplay - 1, true);

                if (fretBoardSoundToDisplay == 11) setPictures(0, true);
                else setPictures(fretBoardSoundToDisplay + 1, true);
            }
        }

        private void timerCheckAdditional_Tick(object sender, EventArgs e)
        {
            if (PassSoundSingleton.getInstance().on && startStopFretBoardFlag==true)//buttonFretBoardStartStop.Tag == "startFret")
            {
                timerFretBoardChangeImages.Enabled = true;
                buttonStartExternal.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[1]);
            }
            if (PassSoundSingleton.getInstance().on == false)
            {
                buttonStartExternal.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[0]);
            }

            setAdditionalSound();

        }

        private void buttonFretBoardNew_Click(object sender, EventArgs e)
        {
            FormFretBoard fretBoardWindow = new FormFretBoard();
            fretBoardWindow.Show();
        }

        private void buttonStartExternal_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
                mainForm.initializeStartButton();
        }

        private void numericUpDownChangeSound_ValueChanged(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
                mainForm.changeTime(System.Convert.ToInt32(numericUpDownChangeSound.Value));
        }

        private void buttonFretBoardOpenMetronome_Click(object sender, EventArgs e)
        {
            FormMetronome metronomeWindow = new FormMetronome();
            metronomeWindow.Show();
        }

        private void buttonFretBoardOpenTuner_Click(object sender, EventArgs e)
        {
            FormTuner tunerWindow = new FormTuner();
            tunerWindow.Show();
        }
    }
}
