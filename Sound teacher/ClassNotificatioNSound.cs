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
        static String[] soundRealArray = new String[] { "A2", "Ais2", "B2", "C2", "Cis2", "D2", "Dis2", "E2", "F2", "Fis2", "G2", "Gis2", "A3", "Ais3", "B3", "C3", "Cis3", "D3", "Dis3", "E3", "F3", "Fis3", "G3", "Gis3", "A4", "Ais4", "B4", "C4", "Cis4", "D4", "Dis4", "E4", "F4", "Fis4", "G4", "Gis4", "A5", "Ais5", "B5", "C5", "Cis5", "D5", "Dis5", "E5", "F5", "Fis5", "G5", "Gis5" };
        System.IO.Stream strSound;
        SoundPlayer playedSound;
        
        public void notificatioNSoundChosen(int choice, int currentSound, int octave)
        {
            if (choice == 0)
            {
                  strSound = Properties.Resources.MainFomrChangeSound;
                  playedSound = new SoundPlayer(strSound);
                  MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                  if (mainForm != null)
                  {
                  mainForm.notificationSound(playedSound);
                  }
            }
            if (choice == 1)
            {
                strSound = Properties.Resources.ResourceManager.GetStream(soundspeechArray[currentSound]);
                playedSound = new SoundPlayer(strSound);
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.notificationSound(playedSound);
                }
            }
            else if (choice == 2)
            {
                if (octave == 3) currentSound += 12;
                else if (octave == 4) currentSound += 24;
                else if (octave == 5) currentSound += 36;
                strSound = Properties.Resources.ResourceManager.GetStream(soundRealArray[currentSound]);
                playedSound = new SoundPlayer(strSound);
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.notificationSound(playedSound);
                }
            }
            else
            {
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    strSound = Properties.Resources.MainFomrChangeSound;
                    playedSound = new SoundPlayer(strSound);
                    mainForm.notificationSound(playedSound);
                }
            }
           

        }
    }
}
