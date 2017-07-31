using System;
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
        int currentSound = 0, previousSound = 0, timeLeft, notificationChoice = 0, octave = 2;
        Random randomSound = new Random();
        ClassNotificatioNSound classNotificationSound = new ClassNotificatioNSound();

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

        void button1_Click(object sender, EventArgs e)
        {
            timeLeft = System.Convert.ToInt32(numericUpDownChangeSound.Value);
            progressBar1.Maximum = timeLeft+1;
            if (timerPictures.Enabled == true)
            {
                timerPictures.Enabled = false;
                PassSoundSingleton.getInstance().on = false;
                buttonChangeSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[0]);
                progressBar1.Value = 1;
                labelSoundTimeLeft.Text = "0";
                pictureBoxSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[2]);

            }

            else
            {
                timerPictures.Enabled = true;
                buttonChangeSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[1]);
                PassSoundSingleton.getInstance().on = true;
                progressBar1.Value = 1;
            }
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
                PassSoundSingleton.getInstance().sound = currentSound;
                PassSoundSingleton.getInstance().change = true;
                progressBar1.Maximum = timeLeft + 1;
                progressBar1.Value = 1;
                if(!(radioButtonMainFormNoSound.Checked)) classNotificationSound.notificatioNSoundChosen(notificationChoice, currentSound, octave);
            }
            labelSoundTimeLeft.Text = "" + timeLeft;
            timeLeft--;
            progressBar1.PerformStep();
            
        }

        private void buttonOpenFretBoard_Click(object sender, EventArgs e)
        {
            FormFretBoard fretBoardWindow = new FormFretBoard();
            fretBoardWindow.Show();
        }

        private void buttonMainFormMetronome_Click(object sender, EventArgs e)
        {
            FormMetronome metronomeWindow = new FormMetronome();
            metronomeWindow.Show();
        }

        private void buttonMainFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMainFormOpenTuner_Click(object sender, EventArgs e)
        {
            FormTuner tunerWindow = new FormTuner();
            tunerWindow.Show();
        }

        private void radioButtonMainFormTickSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationChoice = 0;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayout");
            this.Height = 506;
        }

        private void radioButtonMainFormspeechSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationChoice = 1;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayout");
            this.Height = 506;
        }

        private void radioButtonMainFormRealSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationChoice = 2;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayoutExtended");
            this.Height = 540;
        }

        private void radioButtonMainFormNoSound_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainLayout");
            this.Height = 506;
        }
        private void octave_changed(object sender, EventArgs e)
        {
            if (radioButtonMainFormOctave2.Checked) octave = 2;
            if (radioButtonMainFormOctave3.Checked) octave = 3;
            if (radioButtonMainFormOctave4.Checked) octave = 4;
            if (radioButtonMainFormOctave5.Checked) octave = 5;

        }
    }
}
