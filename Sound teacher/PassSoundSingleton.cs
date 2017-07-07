using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sound_teacher
{
    class PassSoundSingleton
    {
        private volatile static PassSoundSingleton soundSingleton;
        public int sound;
        public bool change, on;
        PassSoundSingleton() { }

        public static PassSoundSingleton getInstance()
        {
            if (soundSingleton == null)
            {
                lock (typeof(PassSoundSingleton))
                {
                    if (soundSingleton == null)
                    {
                        soundSingleton = new PassSoundSingleton();
                        return soundSingleton;
                    }
                }
            }
            return soundSingleton;
        }
        public void PassDataSingleton()
        {
            MessageBox.Show("" + sound);
        }
    }
}
