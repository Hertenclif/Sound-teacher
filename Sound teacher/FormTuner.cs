using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using Microsoft.Xna.Framework;

namespace Sound_teacher
{
    public partial class FormTuner : Form
    {
        public FormTuner()
        {
            InitializeComponent();
        }
        //Microsoft.Xna.Framework.Audio.Microphone mic = Microsoft.Xna.Framework.Audio.Microphone.Default;
        //byte[] buffer = new byte[Microsoft.Xna.Framework.Audio.Microphone.Default.GetSampleSizeInBytes(TimeSpan.FromSeconds(3.0))];
        //int bytesRead = 0, timeSpentRecording = 0;
       // bool isMicrophoneRecording = false, hasData = false;
        /*
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);  
        */
        private void buttonStartTuner_Click(object sender, EventArgs e)
        {
            Initialize();
          //  if (!isMicrophoneRecording)
         //   {
                // we are starting to record
          //      timeSpentRecording = 0;
     //       Microsoft.Xna.Framework.Audio.Microphone.Default.Start();
          //  }

         //   isMicrophoneRecording = !isMicrophoneRecording;
            //      bytesRead += Microphone.Default.GetData(buffer, bytesRead, (buffer.Length - bytesRead));
            /*
            timerTunerRecord.Enabled = true;
            timerTunerRecord.Start();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
             */

        }
        private void buttonStopTuner_Click(object sender, EventArgs e)
        {
           // if (!isMicrophoneRecording)
         //   {
         //   }

         //   else
         //   {

            Microsoft.Xna.Framework.Audio.Microphone.Default.Stop();

                // mark the flag that we have some data available.
        //        hasData = true;
       //     }
            /*
            timerTunerRecord.Stop();
            timerTunerRecord.Enabled = false;
            record("save recsound d:\\mic.wav", "", 0, 0);
            record("close recsound", "", 0, 0); 
             */
        }

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
     //       MessageBox.Show("" + bytesRead);
     /*   }
        public class XNAFrameworkDispatcherService
        {
            private DispatcherTimer frameworkDispatcherTimer;
            public XNAFrameworkDispatcherService()
            {
                this.frameworkDispatcherTimer = new DispatcherTimer();
                this.frameworkDispatcherTimer.Interval = TimeSpan.FromTicks(333333);
              //  this.frameworkDispatcherTimer.Tick += frameworkDispatcherTimer_Tick;
                FrameworkDispatcher.Update();
            }*/
        }
        private void Initialize()
        {
            Microsoft.Xna.Framework.Audio.Microphone microphone = Microsoft.Xna.Framework.Audio.Microphone.Default;
            // 100 ms is a minimum buffer duration
            microphone.BufferDuration = TimeSpan.FromMilliseconds(100);

            DispatcherTimer updateTimer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(0.1)
            };
            updateTimer.Tick += (s, e) =>
            {
                FrameworkDispatcher.Update();
            };
            updateTimer.Start();

            byte[] microphoneSignal = new byte[microphone.GetSampleSizeInBytes(microphone.BufferDuration)];
            microphone.BufferReady += (s, e) =>
            {
                int microphoneDataSize = microphone.GetData(microphoneSignal);
                double amplitude = GetSignalAmplitude(microphoneSignal);
                label1.Text = "" + amplitude;
                label2.Text = "" + microphone.SampleRate;
                // do your stuff with amplitude here
            };
            microphone.Start();
        }
        private double GetSignalAmplitude(byte[] signal)
        {
            int BytesInSample = 2;

            int signalSize = signal.Length / BytesInSample;

            double Sum = 0.0;

            for (int i = 0; i < signalSize; i++)
            {
                int sample = Math.Abs(BitConverter.ToInt16(signal, i * BytesInSample));
                Sum += sample;
            }

            double amplitude = Sum / signalSize;

            return amplitude;
        }

    }

}
