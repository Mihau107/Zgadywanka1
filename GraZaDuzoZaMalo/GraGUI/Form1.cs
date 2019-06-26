using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNowaGra_Click(object sender, EventArgs e)
        {
            grpBoxLosowanie.Visible = true;
            btnNowaGra.Enabled = false;
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            // todo: try-catch
            int a = int.Parse(textBoxOd.Text);
            int b = int.Parse(textBoxDo.Text);
            g = new Gra(a, b);

            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            btnLosuj.Enabled = false;
        }
    }
}
