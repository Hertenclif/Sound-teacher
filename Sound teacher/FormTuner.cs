using System;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Dsp;
using System.Diagnostics;
using NAudio.CoreAudioApi;
using System.Runtime.InteropServices;

namespace Sound_teacher
{
    public partial class FormTuner : Form
    {
        public FormTuner()
        {
            InitializeComponent();
        }
        private bool rec = false;
        private IWaveIn waveIn;
        private static int fftLength = 8192;//16384;
        private int SAMPLERATE = 0;
        private SampleAggregator sampleAggregator = new SampleAggregator(fftLength);
        double[] freqArray = new double[] {
            32.70, 34.65, 36.71, 38.89, 41.20, 43.65, 46.25, 49.00, 51.91, 55.00, 58.27, 61.74,
            65.41, 69.30, 73.42, 77.78, 82.41, 87.31, 92.50, 98.00, 103.83, 110.00, 116.54, 123.47,
            130.81, 138.59, 146.75, 155.56, 164.81, 174.61, 185.00, 196.00, 207.65, 220.00, 233.08, 246.94,
            261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88,
            523.25, 554.37, 587.33, 622.25, 659.25, 698.46, 739.99, 783.99, 830.61, 880.00, 932.33, 987.77
        };
        String[] soundsArray = new String[] {
            "T_C", "T_Cis", "T_D", "T_Dis", "T_E", "T_F", "T_Fis", "T_G", "T_Gis", "T_A", "T_Ais", "T_B",
            "T_C", "T_Cis", "T_D", "T_Dis", "T_E", "T_F", "T_Fis", "T_G", "T_Gis", "T_A", "T_Ais", "T_B",
            "C", "Cis", "D", "Dis", "E", "F", "Fis", "G", "Gis", "A", "Ais", "B",
            "C", "Cis", "D", "Dis", "E", "F", "Fis", "G", "Gis", "A", "Ais", "B",
            "C", "Cis", "D", "Dis", "E", "F", "Fis", "G", "Gis", "A", "Ais", "B"
        };
        public void record()
        {
            sampleAggregator.FftCalculated += new EventHandler<FftEventArgs>(FftCalculated);
            sampleAggregator.PerformFFT = true;


            if (radioButtonMicrophone.Checked)
            {
                waveIn = new WasapiCapture();
                SAMPLERATE = 43910;

                waveIn.DataAvailable += OnDataAvailable;

                waveIn.StartRecording();
            }
            if (radioButtonSoundCard.Checked)
            {
                waveIn = new WasapiLoopbackCapture();
                SAMPLERATE = 48000;

                waveIn.DataAvailable += OnDataAvailable;

                waveIn.StartRecording();
            }
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                byte[] buffer = e.Buffer;
                int bytesRecorded = e.BytesRecorded;
                int bufferIncrement = waveIn.WaveFormat.BlockAlign;

                for (int index = 0; index < bytesRecorded; index += bufferIncrement)
                {
                    float sample32 = BitConverter.ToSingle(buffer, index);
                    sampleAggregator.Add(sample32);
                }
            }
        }


        class SampleAggregator
        {
            // FFT
            public event EventHandler<FftEventArgs> FftCalculated;
            public bool PerformFFT { get; set; }

            // This Complex is NAudio's own! 
            private Complex[] fftBuffer;
            private FftEventArgs fftArgs;
            private int fftPos;
            private int fftLength;
            private int m;

            public SampleAggregator(int fftLength)
            {
                if (!IsPowerOfTwo(fftLength))
                {
                    throw new ArgumentException("FFT Length must be a power of two");
                }
                this.m = (int)Math.Log(fftLength, 2.0);
                this.fftLength = fftLength;
                this.fftBuffer = new Complex[fftLength];
                this.fftArgs = new FftEventArgs(fftBuffer);
            }

            bool IsPowerOfTwo(int x)
            {
                return (x & (x - 1)) == 0;
            }

            public void Add(float value)
            {
                if (PerformFFT && FftCalculated != null)
                {
                    fftBuffer[fftPos].X = (float)(value * FastFourierTransform.HammingWindow(fftPos, fftLength));
                    fftBuffer[fftPos].Y = 0;
                    fftPos++;
                    if (fftPos >= fftLength)
                    {
                        fftPos = 0;
                        FastFourierTransform.FFT(true, m, fftBuffer);
                        FftCalculated(this, fftArgs);
                    }
                }
            }
        }

        public class FftEventArgs : EventArgs
        {
            [DebuggerStepThrough]
            public FftEventArgs(Complex[] result)
            {
                this.Result = result;
            }
            public Complex[] Result { get; private set; }
        }

        void FftCalculated(object sender, FftEventArgs e)
        {
            int length = e.Result.Length;
            float[] magnitudes = new float[length];

            for (int i = 0; i < length / 2; i++)
            {
                float real = e.Result[i].X;
                float imaginary = e.Result[i].Y;
                magnitudes[i] = (float)(10 * Math.Log10(Math.Sqrt((real * real) + (imaginary * imaginary))));
            }

            float max_mag = float.MinValue;
            float max_index = -1;
            for (int i = 0; i < length / 2; i++)
                if (magnitudes[i] > max_mag)
                {
                    max_mag = magnitudes[i];
                    max_index = i;
                }

            var currentFrequency = max_index * SAMPLERATE / fftLength;
            double currentSoundFrequency = 0.0;

            foreach (double soundValue in freqArray)
            {
                if (currentFrequency < 65.41) currentFrequency *= 2;
                currentSoundFrequency = currentFrequency;
                while (currentSoundFrequency > 125.47)
                {
                    currentSoundFrequency /= 2;
                }
                if (currentSoundFrequency >= soundValue - 1.9 && currentSoundFrequency <= soundValue + 1.9)
                {
                    labelTunerSoundImg.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(soundsArray[Array.IndexOf(freqArray, soundValue)]);

                    if (currentSoundFrequency >= soundValue - 0.5 && currentSoundFrequency <= soundValue + 0.5) labelTunerArrows.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("TunerArrowsOK");
                    else if (currentSoundFrequency > soundValue + 0.5) labelTunerArrows.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("TunerArrowsHigh");
                    else if (currentSoundFrequency < soundValue - 0.5) labelTunerArrows.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("TunerArrowsLow");
                }
            }
            currentSoundFrequency *= 1000;
            try
            {
                trackBarFrequency.Value = System.Convert.ToInt32(currentSoundFrequency);
            }
            catch (Exception dispo)
            {

            }

            labelTunerFrequency.Text = "" + currentFrequency;
        }

        private void buttonStartTuner_Click(object sender, EventArgs e)
        {
            if (rec)
            {
                waveIn.StopRecording();
                rec = false;
                buttonStartTuner.Text = "START!";
                labelTunerSoundImg.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("T_ST");
                labelTunerArrows.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("TunerArrowsNeutral");
                labelTunerFrequency.Text = "";
            }
            else
            {
                record();
                rec = true;
                buttonStartTuner.Text = "STOP!";
            }
        }
        private void FormTuner_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                waveIn.StopRecording();
                rec = false;
            }
            catch (Exception disp)
            {

            }
        }

        private void buttonTunerExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}