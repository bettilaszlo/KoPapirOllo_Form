using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoPapirOllo_Form
{
    public partial class frnfo : Form
    {

        public int Jatekos { get; private set; }
        public int Szamitogep { get; private set; }
        public frnfo()
        {
            InitializeComponent();
            lbljatekos.Text = "";
            lblszamitogep.Text = "";
            lblgyoztes.Text = "";
        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnuj_Click(object sender, EventArgs e)
        {
            KezdetiBeallitas();
        }

        private void KezdetiBeallitas()
        {
            lblgyoztes.Text = "";
            lbljatekos.Text = "0";
            lblszamitogep.Text = "0";
        }

        private void btnko_Click(object sender, EventArgs e)
        {
            pbjatekos.Image = Image.FromFile("ko.jpg");
            Fordulo(1);
        }

        private void btnpapir_Click(object sender, EventArgs e)
        {
            pbjatekos.Image = Image.FromFile("papir.jpg");
            Fordulo(2);
        }

        private void btnollo_Click(object sender, EventArgs e)
        {
            pbjatekos.Image = Image.FromFile("ollo.jpg");
            Fordulo(3);
        }
        private void Fordulo(int jatekos)
        {
            Random rand = new Random();
            int gep = rand.Next(1, 4);

            switch (gep)
            {
                case 1:
                    pbszamitogep.Image = Image.FromFile("ko.jpg");
                    break;
                case 2:
                    pbszamitogep.Image = Image.FromFile("papir.jpg");
                    break;
                case 3:
                    pbszamitogep.Image = Image.FromFile("ollo.jpg");
                    break;
            }

            if (gep== jatekos)
            {
                Jatekos++;
                Szamitogep++;
                lblgyoztes.Text = "Döntetlen";
            }
            else
            {
                // Kő 1
                // Papir 2
                // Ollo 3

                if ((jatekos == 1 && gep == 3) ||
                    (jatekos == 2 && gep == 1) ||
                    (jatekos == 3 && gep == 2))
                {
                    Jatekos++;
                    lblgyoztes.Text = "Játékos nyert";
                }
                else 
                {
                    Szamitogep++;
                    lblgyoztes.Text = "Számítógép nyert";
                }
               
            }

        }
    }
}
