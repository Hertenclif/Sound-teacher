﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Sound_teacher
{
    public partial class MainForm : Form
    {
        String[] soundImageNames = new String[] {"A", "Ais", "B", "C", "Cis", "D", "Dis", "E", "F", "Fis", "G", "Gis"};
        String[] pictures = new String[] { "MainForm_StartButton", "MainForm_StopButton", "ST" };
        bool[] activeForms = new bool[] { false, false, false, false }; //metronome, tuner, Guide, fretboard
        int currentSound = 0, previousSound = 0, timeLeft, notificationChoice = 0, octave = 2;
        Random randomSound = new Random();
        ClassNotificatioNSound classNotificationSound = new ClassNotificatioNSound();

        //forms
        FormMetronome metronomeWindow = new FormMetronome();
        FormTuner tunerWindow = new FormTuner();
        FormGuide GuideWindow = new FormGuide();
        FormFretBoard fretBoardWindow = new FormFretBoard();

        //initialize
        public MainForm()
        {
            InitializeComponent();
        }

        //public methods
        public void initializeStartButton()
        {
            buttonChangeSound.PerformClick();
        }
        public void changeTime(int current)
        {
            numericUpDownChangeSound.Value = current;
        }
        public void notificationSound(SoundPlayer path)
        {
            path.Play();
        }

        private void timerPictures_Tick(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                currentSound = randomSound.Next(0, 12);
                while (currentSound == previousSound)
                {
                    currentSound = randomSound.Next(0, 12);
                }
                previousSound = currentSound;
                pictureBoxSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(soundImageNames[currentSound]);
                timeLeft = System.Convert.ToInt32(numericUpDownChangeSound.Value);
                changeSoundFretBoard(soundImageNames[currentSound]);
                progressBarMainFormTimeLeft.Maximum = timeLeft + 1;
                progressBarMainFormTimeLeft.Value = 1;
                if(!(radioButtonMainFormNoSound.Checked)) classNotificationSound.notificatioNSoundChosen(notificationChoice, currentSound, octave);
            }
            labelSoundTimeLeft.Text = "" + timeLeft;
            timeLeft--;
            progressBarMainFormTimeLeft.PerformStep();
            
        }
        private void changeSoundFretBoard(String current)
        {
                FormFretBoard fretBoard = Application.OpenForms.OfType<FormFretBoard>().FirstOrDefault();
                if (fretBoard != null)
                    fretBoard.setSoundPicture(current);
        }
        private void notifyFretBoardStartStop(bool onOff)
        {
            FormFretBoard fretBoard = Application.OpenForms.OfType<FormFretBoard>().FirstOrDefault();
            if (fretBoard != null)
                fretBoard.notificationStartStopButton(onOff);
        }

        private void radioButtonMainFormTickSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationChoice = 0;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayout");
            this.Height = 467;
        }


        private void buttonMainFormStart_Click(object sender, EventArgs e)
        {

            timeLeft = System.Convert.ToInt32(numericUpDownChangeSound.Value);
            progressBarMainFormTimeLeft.Maximum = timeLeft + 1;
            if (timerPictures.Enabled == true)
            {
                timerPictures.Enabled = false;
                buttonChangeSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[0]);
                progressBarMainFormTimeLeft.Value = 1;
                labelSoundTimeLeft.Text = "0";
                pictureBoxSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[2]);
                notifyFretBoardStartStop(true);
            }

            else
            {
                timerPictures.Enabled = true;
                buttonChangeSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[1]);
                progressBarMainFormTimeLeft.Value = 1;
                notifyFretBoardStartStop(false);
            }
        }

        private void buttonMainFormFastForward_Click(object sender, EventArgs e)
        {
            progressBarMainFormTimeLeft.Value = 1;
            timeLeft = 0;
            labelSoundTimeLeft.Text = "0";

        }
        private void radioButtonMainFormspeechSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationChoice = 1;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayout");
            this.Height = 467;
        }

        private void radioButtonMainFormRealSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationChoice = 2;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayoutExtended");
            this.Height = 498;
        }

        private void radioButtonMainFormNoSound_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayout");
            this.Height = 467;
        }
        private void octave_changed(object sender, EventArgs e)
        {
            if (radioButtonMainFormOctave2.Checked) octave = 2;
            if (radioButtonMainFormOctave3.Checked) octave = 3;
            if (radioButtonMainFormOctave4.Checked) octave = 4;
            if (radioButtonMainFormOctave5.Checked) octave = 5;

        }

        //open forms Buttons

        private void buttonMainFormOpenMetronome_Click(object sender, EventArgs e)
        {
            if (metronomeWindow.Visible)
            {
                activeForms[0] = false;
                metronomeWindow.Hide();
            }
            else
            {
                activeForms[0] = true;
                metronomeWindow.Show();
            }

        }


        private void buttonMainFormOpenTuner_Click(object sender, EventArgs e)
        {
            if (tunerWindow.Visible)
            {
                activeForms[1] = false;
                tunerWindow.Hide();
            }
            else
            {
                activeForms[1] = true;
                tunerWindow.Show();
            }
        }

        private void buttonMainFormOpenGuide_Click(object sender, EventArgs e)
        {
            if (GuideWindow.Visible)
            {
                activeForms[2] = false;
                GuideWindow.Hide();
            }
            else
            {
                activeForms[2] = true;
                GuideWindow.Show();
            }
        }
        
        private void buttonMainFormOpenFretBoard_Click(object sender, EventArgs e)
        {
            if (fretBoardWindow.Visible)
            {
                activeForms[3] = false;
                fretBoardWindow.Hide();
            }
            else
            {
                activeForms[2] = true;
                fretBoardWindow.Show();
            }
        }

        private void buttonMainFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
