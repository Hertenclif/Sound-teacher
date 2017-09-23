using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sound_teacher
{
    public partial class FormFretBoard : Form
    {

        int fretBoardSoundToDisplay;
        bool startStopFretBoardFlag = true;
        String[] fretBoardSounds = new String[] { "A", "Ais", "B", "C", "Cis", "D", "Dis", "E", "F", "Fis", "G", "Gis" };
        String[] fretBoardSoundImageNames = new String[] { "FretBoardA", "FretBoardAis", "FretBoardB", "FretBoardC", "FretBoardCis", "FretBoardD", "FretBoardDis", "FretBoardE", "FretBoardF", "FretBoardFis", "FretBoardG", "FretBoardGis" };
        String[] pictures = new String[] { "FretBoard_StartButton", "FretBoard_StopButton", "FretBoard_StartFretBoardButton", "FretBoard_StopFretBoardButton", "FretBoard_NewFretBoard" };
        String previousSound = "A", currentSound = "";

        public FormFretBoard()
        {
            InitializeComponent();
        }
        public void setSoundPicture(String current)
        {
            currentSound = current;
            if (buttonFretBoardStartStop.Tag == "off")
            {
                cleanPrevious(previousSound);
                setAdditionalSound();
                showSound(current);
                if (checkBoxFretBoardShowNextTo.Checked)
                {
                    if (current == "A")
                    {
                        showSound(fretBoardSounds[11]);
                        showSound(fretBoardSounds[Array.IndexOf(fretBoardSounds, current) + 1]);
                    }
                    else if (current == "Gis")
                    {
                        showSound(fretBoardSounds[Array.IndexOf(fretBoardSounds, current) - 1]);
                        showSound(fretBoardSounds[0]);
                    }
                    else
                    {
                        showSound(fretBoardSounds[Array.IndexOf(fretBoardSounds, current) - 1]);
                        showSound(fretBoardSounds[Array.IndexOf(fretBoardSounds, current) + 1]);
                    }
                    
                }
                previousSound = current;
            }

        }

        private void buttonStopFretboard_Click(object sender, EventArgs e)
        {
            if (buttonFretBoardStartStop.Tag == "on")
            {
                cleanPrevious(previousSound);
                setAdditionalSound();
                showSound(currentSound);
                buttonFretBoardStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[3]);
                buttonFretBoardStartStop.Tag = "off";
                comboBoxScaleChoice.Text = "" + buttonFretBoardStartStop.Tag;
            }
            else
            {
                cleanPrevious(previousSound);
                setAdditionalSound();
                buttonFretBoardStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[2]);
                buttonFretBoardStartStop.Tag = "on";
                comboBoxScaleChoice.Text = ""+buttonFretBoardStartStop.Tag;
                cleanPrevious(currentSound);
            }

        }
        private void setAdditionalSound()
        {
            cleanAll();
            if (checkBoxFretBoardA.Checked) showSound("A");
            if (checkBoxFretBoardAis.Checked) showSound("Ais");
            if (checkBoxFretBoardB.Checked) showSound("B");
            if (checkBoxFretBoardC.Checked) showSound("C");
            if (checkBoxFretBoardCis.Checked) showSound("Cis");
            if (checkBoxFretBoardD.Checked) showSound("D");
            if (checkBoxFretBoardDis.Checked) showSound("Dis");
            if (checkBoxFretBoardE.Checked) showSound("E");
            if (checkBoxFretBoardF.Checked) showSound("F");
            if (checkBoxFretBoardFis.Checked) showSound("Fis");
            if (checkBoxFretBoardG.Checked) showSound("G");
            if (checkBoxFretBoardGis.Checked) showSound("Gis");
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
                foreach (String a in fretBoardSounds)
                {
                    cleanPrevious(a);
                }
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
            if (buttonFretBoardStartStop.Tag == "off") showSound(currentSound);
        }

        private void buttonStartExternal_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
                mainForm.initializeStartButton();
            cleanPrevious(previousSound);
        }

        private void numericUpDownChangeSound_ValueChanged(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
                mainForm.changeTime(System.Convert.ToInt32(numericUpDownChangeSound.Value));
        }

        private void cleanPrevious (String prev)
        {
            foreach (Control x in this.Controls)
            {
                try
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[Array.IndexOf(fretBoardSounds, prev)]) ((PictureBox)x).Visible = false;
                    }
                }
                catch (Exception dispo)
                {

                }
            }
        }
        private void showSound (String current)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    try
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[Array.IndexOf(fretBoardSounds, current)]) ((PictureBox)x).Visible = true;
                    }
                    catch (Exception dispo)
                    {

                    }
                }
            }
        }
        private void cleanAll()
        {
            foreach (String soundImage in fretBoardSounds)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (((PictureBox)x).Tag == fretBoardSoundImageNames[Array.IndexOf(fretBoardSounds, soundImage)]) ((PictureBox)x).Visible = false;
                    }
                }
            }
        }

        private void checkBoxFretBoard_CheckedChanged(object sender, EventArgs e)
        {
            setAdditionalSound();
        }
    }
}
