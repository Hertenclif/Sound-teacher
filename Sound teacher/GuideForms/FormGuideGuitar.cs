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
    public partial class FormGuideGuitar : Form
    {
        public FormGuideGuitar()
        {
            InitializeComponent();
            openGuitarElectricInner();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
        }
        public FormGuideGuitar(short lastClosed)
        {
            InitializeComponent();
            if (lastClosed == 0) openGuitarElectricInner();
            else if (lastClosed == 1) openGuitarAcousticInner();
            else openGuitarClassicalInner();
            guideForm = Application.OpenForms.OfType<FormGuide>().FirstOrDefault();
        }

        FormGuide guideForm;

        private void openGuitarElectricInner()
        {
            Form insideFormGuitarElectric = new FormGuideGuitarElectric(this);
            panelGuideGuitar.Controls.Clear();
            insideFormGuitarElectric.TopLevel = false;
            insideFormGuitarElectric.Dock = DockStyle.Fill;
            panelGuideGuitar.Controls.Add(insideFormGuitarElectric);
            insideFormGuitarElectric.Show();
        }
        private void openGuitarAcousticInner()
        {
            Form insideFormGuitarAcoustic = new FormGuideGuitarAcoustic(this);
            panelGuideGuitar.Controls.Clear();
            insideFormGuitarAcoustic.TopLevel = false;
            insideFormGuitarAcoustic.Dock = DockStyle.Fill;
            panelGuideGuitar.Controls.Add(insideFormGuitarAcoustic);
            insideFormGuitarAcoustic.Show();
        }
        private void openGuitarClassicalInner()
        {
            Form insideFormGuitarClassical = new FormGuideGuitarClassical(this);
            panelGuideGuitar.Controls.Clear();
            insideFormGuitarClassical.TopLevel = false;
            insideFormGuitarClassical.Dock = DockStyle.Fill;
            panelGuideGuitar.Controls.Add(insideFormGuitarClassical);
            insideFormGuitarClassical.Show();
        }

        private void buttonGuideGuitarPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonGuideGuitarElectric_Click(object sender, EventArgs e)
        {
            openGuitarElectricInner();
        }

        private void ButtonGuideGuitarAcoustic_Click(object sender, EventArgs e)
        {
            openGuitarAcousticInner();
        }

        private void ButtonGuideGuitarClassical_Click(object sender, EventArgs e)
        {
            openGuitarClassicalInner();
        }
    }
}
