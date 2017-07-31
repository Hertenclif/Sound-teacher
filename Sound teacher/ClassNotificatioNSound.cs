using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Sound_teacher
{
    public class ClassNotificatioNSound
    {
        public ClassNotificatioNSound()
        { 
        }

        static String[] soundspeechArray = new String[] { "A_speech", "Ais_speech", "B_speech", "C_speech", "Cis_speech", "D_speech", "Dis_speech", "E_speech", "F_speech", "Fis_speech", "G_speech", "Gis_speech" };
       // static String[] soundRealArray = new String[] { "A_Real", "Ais_Real", "B_Real", "C_Real", "Cis_Real", "D_Real", "Dis_Real", "E_Real", "F_Real", "Fis_Real", "G_Real", "Gis_Real" };
        static String[] soundRealArray = new String[] { "A2", "Ais2", "B2", "C2", "Cis2", "D2", "Dis2", "E2", "F2", "Fis2", "G2", "Gis2", "A3", "Ais3", "B3", "C3", "Cis3", "D3", "Dis3", "E3", "F3", "Fis3", "G3", "Gis3", "A4", "Ais4", "B4", "C4", "Cis4", "D4", "Dis4", "E4", "F4", "Fis4", "G4", "Gis4", "A5", "Ais5", "B5", "C5", "Cis5", "D5", "Dis5", "E5", "F5", "Fis5", "G5", "Gis5" };
        SoundPlayer tickSound = new SoundPlayer(@"d:\VisualProjects\Sound teacher\Sound teacher\Resources\MainFormRes\MainFormSounds\OtherSounds\MainFomrChangeSound.wav");
        
        public void notificatioNSoundChosen(int choice, int currentSound, int octave)
        {
            if (choice == 0)
            {
                 MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                  if (mainForm != null)
                  {
                  mainForm.notificationSound(tickSound);
                  }
            }
            if (choice == 1)
            {
                SoundPlayer soundspeechSound = new SoundPlayer(@"d:\VisualProjects\Sound teacher\Sound teacher\Resources\MainFormRes\MainFormSounds\SpeechSounds\" + soundspeechArray[currentSound] + ".wav");
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.notificationSound(soundspeechSound);
                }
            }
            else if (choice == 2)
            {
                if (octave == 3) currentSound += 12;
                else if (octave == 4) currentSound += 24;
                else if (octave == 5) currentSound += 36;
                //MessageBox.Show("" + soundRealArray[currentSound]);
                SoundPlayer soundRealSound = new SoundPlayer(@"d:\VisualProjects\Sound teacher\Sound teacher\Resources\MainFormRes\MainFormSounds\RealSounds\" + soundRealArray[currentSound] + ".wav");
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.notificationSound(soundRealSound);
                }
            }
            else
            {
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.notificationSound(tickSound);
                }
            }
           

        }
    }
}
