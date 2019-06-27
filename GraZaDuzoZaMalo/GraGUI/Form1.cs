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
        public Form1()
        {
            InitializeComponent();
        }

        private Gra g;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            NowaGra.Enabled = false;
        }


        private void Losuj_Click(object sender, EventArgs e)
        {




            string test = textBoxod.Text;
            string test2 = textBoxdo.Text;

            if(string.IsNullOrEmpty(test) || string.IsNullOrEmpty(test2))
            {
                MessageBox.Show("Musisz podać poprawny zakres");
            }else
            {
                int a = int.Parse(textBoxod.Text);
                int b = int.Parse(textBoxdo.Text);
                g = new Gra(a, b);
                textBoxod.Enabled = false;
                textBoxdo.Enabled = false;
                Losuj.Visible = false;
                Sprawdzanie_Box.Visible = true;
                Poddanie.Visible = true;
            }


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Poddanie_Click(object sender, EventArgs e)
        {

            string message = "Przegrałeś... Grasz jeszcze raz?";
            string title = "PRZEGRANA";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                NowaGra.Enabled = true;
                textBoxdo.Clear();
                textBoxod.Clear();
                PodanaLiczba.Clear();
                textBoxod.Enabled = true;
                textBoxdo.Enabled = true;
                groupBox1.Visible = false;
                Losuj.Visible = true;
                Sprawdzanie_Box.Visible = false;
            }


        }

        private void Sprawdz_Click_Click(object sender, EventArgs e)
        {
            komunikat.Visible = true;

            string test3 = PodanaLiczba.Text;
            if (string.IsNullOrEmpty(test3))
            {
                MessageBox.Show("Podaj swoją propozycję");
            }
            else
            {
                int c = int.Parse(PodanaLiczba.Text);
                if (Convert.ToString(g.Ocena(c)) == "ZaMalo")
                    komunikat.Text = "Źle, za mało";
                else if (Convert.ToString(g.Ocena(c)) == "ZaDuzo")
                    komunikat.Text = "Źle, za dużo";
                else
                {
                    string message = $"Brawo! Wygrałeś! Grasz jeszcze raz? \n Ilość Ruchów: {Convert.ToString(g.LicznikRuchow - 1)}\n";
                    string title = "WYGRANA";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        NowaGra.Enabled = true;
                        textBoxdo.Clear();
                        textBoxod.Clear();
                        PodanaLiczba.Clear();
                        textBoxod.Enabled = true;
                        textBoxdo.Enabled = true;
                        groupBox1.Visible = false;
                        Losuj.Visible = true;
                        Sprawdzanie_Box.Visible = false;
                    }
                }
            }
        }

        private void Sprawdzanie_Box_Enter(object sender, EventArgs e)
        {

        }
    }
}

