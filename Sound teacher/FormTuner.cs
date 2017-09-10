using System;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Dsp;
using System.Diagnostics;
using NAudio.CoreAudioApi;

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
        private int SAMPLERATE = 44783;//14850ALPHA
        private SampleAggregator sampleAggregator = new SampleAggregator(fftLength);
        double[] freqArray = new double[] {
            32.70, 34.65, 36.71, 38.89, 41.20, 43.65, 46.25, 49.00, 51.91, 55.00, 58.27, 61.74,
            65.41, 69.30, 73.42, 77.78, 82.41, 87.31, 92.50, 98.00, 103.83, 110.00, 116.54, 123.47,
            130.81, 138.59, 146.83, 155.56, 164.81, 174.61, 185.00, 196.00, 207.65, 220.00, 233.08, 246.94,
            261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88,
            523.25, 554.37, 587.33, 622.25, 659.25, 698.46, 739.99, 783.99, 830.61, 880.00, 932.33, 987.77
        };
        String[] soundsArray = new String[] {
            "C1", "C#1", "D1", "D#1", "E1", "F1", "F#1", "G1", "G#1", "A1", "A#1", "B1",
            "C2", "C#2", "D2", "D#2", "E2", "F2", "F#2", "G2", "G#2", "A2", "A#2", "B2",
            "C3", "C#3", "D3", "D#3", "E3", "F3", "F#3", "G3", "G#3", "A3", "A#3", "B3",
            "C4", "C#4", "D4", "D#4", "E4", "F4", "F#4", "G4", "G#4", "A4", "A#4", "B4",
            "C5", "C#5", "D5", "D#5", "E5", "F5", "F#5", "G5", "G#5", "A5", "A#5", "B5"
        };

        

        public void record()
        {
            sampleAggregator.FftCalculated += new EventHandler<FftEventArgs>(FftCalculated);
            sampleAggregator.PerformFFT = true;

           
            if (radioButtonMicrophone.Checked)
            {
                label2.Text = "" + WasapiCapture.GetDefaultCaptureDevice() + " E2->E6! - 82Hz";

                //waveIn = new WasapiLoopbackCapture();
                waveIn = new WasapiCapture();
                hScrollBarMetronomeBPS.Value = 44783;

                waveIn.DataAvailable += OnDataAvailable;

                waveIn.StartRecording();
            }
            if (radioButtonSoundCard.Checked)
            {
                label2.Text = "" + WasapiCapture.GetDefaultCaptureDevice() + " E2->E6! - 82Hz";

                waveIn = new WasapiLoopbackCapture();
                //waveIn = new WasapiCapture();
                hScrollBarMetronomeBPS.Value = 45056;

                waveIn.DataAvailable += OnDataAvailable;

                waveIn.StartRecording();
            }
            





        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            SAMPLERATE = hScrollBarMetronomeBPS.Value;
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
                    // Remember the window function! There are many others as well.
                    fftBuffer[fftPos].X = (float)(value * FastFourierTransform.HammingWindow(fftPos, fftLength));
                    fftBuffer[fftPos].Y = 0; // This is always zero with audio.
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
            
            var currentFrequency = max_index * SAMPLERATE / 8192;

            label1.Text = "frequency be " + currentFrequency;
            try
            {
                trackBarFrequency.Value = System.Convert.ToInt32(currentFrequency);
            }
            catch (Exception dispo)
            {

            }
            
            foreach (double soundValue in freqArray)
            {
                if (currentFrequency >= soundValue - 2 && currentFrequency <= soundValue + 2) label4.Text = "" + soundsArray[Array.IndexOf(freqArray, soundValue)];
            //else label4.Text = "NONE";
                label3.Text = "" + Convert.ToString(soundValue) + " || " + Convert.ToString(currentFrequency);
                
            }
        }

        private void buttonStartTuner_Click(object sender, EventArgs e)
        {
            if (rec)
            {
                waveIn.StopRecording();
                rec = false;
                buttonStartTuner.Text = "START!";
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
            waveIn.StopRecording();
            rec = false;
        }

        private void hScrollBarMetronomeBPS_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = System.Convert.ToString(hScrollBarMetronomeBPS.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fftLength = System.Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Obecna dlugosc " + fftLength);
        }
    }
}