﻿using System;
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
    public partial class FormGuideTechniques : Form
    {
        public FormGuideTechniques()
        {
            InitializeComponent();
        }

        private void buttonGuideTechniquesPick_Click(object sender, EventArgs e)
        {
            labelGuideTechniquesText.Text = "If you want to hold a pick properly, you should do this with your thumb and index finger. Do this by placing a pick upwards on " +
                "your index finger and covering it with your thumb (as in the pictures to the right). For a better grip, try holding it with your fist clenched. " +
                "Also, it's very important not to hold it too firm as your muscles will tire very fast and the sound produced will not sound natural. Another important thing is that " +
                "you should only move your wrist, not the whole hand (the only exception is if you play chords that cover the whole fretboard).";
            labelGuideTechniquesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTechniquesPick");
        }

        private void buttonGuideTechniquesPowerchord_Click(object sender, EventArgs e)
        {
            labelGuideTechniquesText.Text = "Powerchord is a technique of playing a desired sound with 2 or 3 fingers. It's mostly used while playing an electric guitar. " +
                "Basically the main purpose of powerchord is to make a sound louder and more profound. While playing with 2 fingers, you should use your index and ring finger " +
                "(if you are an advanced player, you can also try doing this with your pinky and middle finger). If you want it to be even louder and sound better, you can " +
                "also use your pinky and strum 3 strings (e.g. if you place your index finger on 5th fret, high E string, you should place your ring finger on 7th fret, " +
                "A string and your pinky on the harmonic sound - 7th fret, D string).";
            labelGuideTechniquesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTechniquesPowerchord");
        }

        private void buttonGuideTechniquesTremolo_Click(object sender, EventArgs e)
        {
            labelGuideTechniquesText.Text = "Tremolo is basically picking up and down constantly. While strumming only one string may be easy, getting used to strumming all the strings " +
                "may be a bit difficult. Always (or at least mostly) try playing tremolo, as it's a lot faster than strumming from the top and only with mastering this technique will you " +
                "become a true master of guitar playing.";
            labelGuideTechniquesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTechniquesTremolo");
        }

        private void buttonGuideTechniquesPalmMute_Click(object sender, EventArgs e)
        {
            labelGuideTechniquesText.Text = "Palm muting is done with the right hand by placing your palm at the end of the strings at the base of the bridge. " +
                "This technique is mostly used with electric (but not only) guitars. It provides muted, short sounds. Remember though, that if you push too hard, " +
                "the sound will be muted too much and will sound clunky. The same if you push too weak - the sound may be too long and will sound like something in " +
                "between a muted and open sound (that's usually not what you desire).";
            labelGuideTechniquesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTechniquesPalmMute");
        }

        private void buttonGuideTechniquesSlide_Click(object sender, EventArgs e)
        {
            labelGuideTechniquesText.Text = "Sliding is performed with your left hand. You just need to slide your fingers to a desired sound after strumming with your right hand. " +
                "With this technique you can a change a sound more gently and it will sound softer that if it was made in a traditional way.";
            labelGuideTechniquesPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("GuideTechniquesSlide");
        }

        private void buttonGuideTechniquesPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
