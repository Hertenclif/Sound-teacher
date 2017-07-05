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
    public partial class MainForm : Form
    {
        String[] soundImageNames = new String[] {"A", "Ais", "B", "C", "Cis", "D", "Dis", "E", "F", "Fis", "G", "Gis" };
        int currentSound = 0, previousSound = 0, timeLeft;
        Random randomSound = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = System.Convert.ToInt32(numericUpDownChangeSound.Value);
            progressBar1.Maximum = timeLeft+1;
            if (timerPictures.Enabled == true)
            {
                timerPictures.Enabled = false;
                buttonChangeSound.Text = "Start!";
            }

            else
            {
                timerPictures.Enabled = true;
                buttonChangeSound.Text = "Stop!";
                progressBar1.Value = 1;
            }
        }

        private void timerPictures_Tick(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                currentSound = randomSound.Next(0, 11);
                while (currentSound == previousSound)
                {
                    currentSound = randomSound.Next(0, 11);
                }
                previousSound = currentSound;
                pictureBoxSound.Image = (Image)Properties.Resources.ResourceManager.GetObject(soundImageNames[currentSound]);
                timeLeft = System.Convert.ToInt32(numericUpDownChangeSound.Value);
                progressBar1.Maximum = timeLeft + 1;
                progressBar1.Value = 1;
            }
            labelSoundTimeLeft.Text = "" + timeLeft;
            timeLeft--;
            progressBar1.PerformStep();
            
        }
    }
}
