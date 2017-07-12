using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Sound_teacher
{
    public partial class FormMetronome : Form
    {
        SoundPlayer metronomeBeat = new SoundPlayer(@"d:\VisualProjects\Sound teacher\Sound teacher\Resources\metronomeBit.wav");
        SoundPlayer metronomeBeat2 = new SoundPlayer(@"d:\VisualProjects\Sound teacher\Sound teacher\Resources\metronomeBit2.wav");
        String[] pictures = new String[] { "LEDGrey", "LEDRed", "LEDGreen", "ButtonStartMedium", "ButtonStopMedium" };
        String[] tempoNames = new String[] { "Grave", "Largo", "Lento", "Adagio", "Andante", "Moderato", "Allegretto", "Allegro", "Presto", "Prestissimo" };
       
        //     LedFlash oLedFlash = new LedFlash();
        //   Thread ledThread = new Thread(new ThreadStart(oLedFlash.ledFlash));

        //double metrum = 1;
        int bpm = 1, currentSound = 0;
        public FormMetronome()
        {
            InitializeComponent();
        }


        private void buttonMetronomeStartStop_Click(object sender, EventArgs e)
        {

            if (buttonMetronomeStartStop.Tag == "off")
            {
                buttonMetronomeStartStop.Tag = "on";
                buttonMetronomeStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[4]);
                currentSound = 0;
            }
            else
            {
                buttonMetronomeStartStop.Tag = "off";
                buttonMetronomeStartStop.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[3]);
            }
        }

        private void timerMetronomeBPM_Tick(object sender, EventArgs e)
        {
            
            if (timerMetronomeBPM.Interval != 1) timerMetronomeBPM.Interval = 1;
            if (buttonMetronomeStartStop.Tag == "on")
            {
                currentSound+=1;
                try
                {
                    bpm = 60000 / System.Convert.ToInt32(numericUpDownMetronomeBPM.Text);
                    timerMetronomeBPM.Interval = bpm;
                    hScrollBarMetronomeBPS.Value = System.Convert.ToInt32(numericUpDownMetronomeBPM.Text);
                }
                catch (Exception exception)
                {
                    bpm = 1;
                }
                    labelTimeTick.Text = System.Convert.ToString(currentSound);
                    if (currentSound < 4)
                    {
                        metronomeBeat.Play();
                    }
                    else
                    {
                        pictureBoxDiode.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[2]);
                        metronomeBeat2.Play();
                        currentSound = 0;
                    }
                pictureBoxDiode.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictures[0]);
            }
        }
        public class LedFlash
        {
            public void ledFlash(String choice)
            {
                FormMetronome formMetronome = Application.OpenForms.OfType<FormMetronome>().FirstOrDefault();
                if (formMetronome != null)
                    formMetronome.pictureBoxDiode.Image = (Image)Properties.Resources.ResourceManager.GetObject(choice);
            }
        }

        private void hScrollBarMetronomeBPS_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownMetronomeBPM.Value = hScrollBarMetronomeBPS.Value;
            currentSound = 0;
            timerMetronomeBPM.Interval = 360;
            tempoNamesDisplay(numericUpDownMetronomeBPM.Value);
        }

        private void numericUpDownMetronomeBPM_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarMetronomeBPS.Value = System.Convert.ToInt32(numericUpDownMetronomeBPM.Value);
            currentSound = 0;
            timerMetronomeBPM.Interval = 360;
            tempoNamesDisplay(numericUpDownMetronomeBPM.Value);
        }
        private void tempoNamesDisplay(decimal bpm)
        {
            if (bpm < 40) labelMetronomeTempo.Text = tempoNames[0];
            else if (bpm > 40 && bpm <= 60) labelMetronomeTempo.Text = tempoNames[1];
            else if (bpm > 60 && bpm <= 66) labelMetronomeTempo.Text = tempoNames[2];
            else if (bpm > 66 && bpm <= 76) labelMetronomeTempo.Text = tempoNames[3];
            else if (bpm > 76 && bpm <= 108) labelMetronomeTempo.Text = tempoNames[4];
            else if (bpm > 108 && bpm <= 120) labelMetronomeTempo.Text = tempoNames[5];
            else if (bpm > 120 && bpm <= 132) labelMetronomeTempo.Text = tempoNames[6];
            else if (bpm > 132 && bpm <= 168) labelMetronomeTempo.Text = tempoNames[7];
            else if (bpm > 168 && bpm <= 199) labelMetronomeTempo.Text = tempoNames[8];
            else labelMetronomeTempo.Text = tempoNames[9];
        }
    }
}