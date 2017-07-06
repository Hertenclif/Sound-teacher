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
    public partial class FormFretBoard : Form
    {
        public FormFretBoard()
        {
            InitializeComponent();
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach ()
        }
    }
}
