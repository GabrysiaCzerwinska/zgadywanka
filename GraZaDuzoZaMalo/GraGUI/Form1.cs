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
        public static Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            try
            {
                a = int.Parse(textBoxZakresOd.Text);
                b = int.Parse(textBoxZakresDo.Text);
            }
            catch
            {
                a = 1;
                b = 100;
            }

            g = new Gra(a, b);

            button_historia.Enabled = true;
            buttonLosuj.Enabled = false;
            textBoxZakresOd.Enabled = false;
            textBoxZakresDo.Enabled = false;
            groupBoxLosowanie.Visible = true;


            // pokazać następne elementy formularza
            // przycisk przerwij/poddaj

        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Baton1_Click(object sender, EventArgs e)

        {

            Gra.Odpowiedz odp;

            try
            {
                odp = g.Ocena(int.Parse(pole.Text));

            }
            catch
            {

                odp = g.Ocena(0);

            }
            switch (odp)

            {

                case Gra.Odpowiedz.Trafiono:

                    info.Text = "trafione";


                    break;

                case Gra.Odpowiedz.ZaMalo:

                    info.Text = "za mało";

                    break;

                case Gra.Odpowiedz.ZaDuzo:

                    info.Text = "za dużo";

                    break;
            }

            if (g.Stan == Gra.StanGry.Odgadnieta)
            {

                DialogResult nazwajakas = MessageBox.Show("brawo", "trafiłeś", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (nazwajakas == DialogResult.OK)
                {
                    groupBoxLosowanie.Visible = false;
                    groupBoxLosuj.Visible = false;
                    buttonNowaGra.Enabled = true;
                    groupBoxLosuj.Enabled = true;
                    textBoxZakresOd.Enabled = true;
                    textBoxZakresDo.Enabled = true;
                    buttonLosuj.Enabled = true;
                    info.Text = " ";
                    g.ZerujLicznik();
                }

            }

            liczba.Text = g.LicznikRuchow.ToString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Liczba_Click(object sender, EventArgs e)
        {

        }

        private void Baton2_Click(object sender, EventArgs e)
        {
            g.Poddaj();

            if (g.Stan == Gra.StanGry.Poddana)


            {

                DialogResult nazwajakas = MessageBox.Show("przegrałeś", "poddałeś się", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (nazwajakas == DialogResult.OK)
                {
                    groupBoxLosowanie.Visible = false;
                    groupBoxLosuj.Visible = false;
                    buttonNowaGra.Enabled = true;
                    groupBoxLosuj.Enabled = true;
                    textBoxZakresOd.Enabled = true;
                    textBoxZakresDo.Enabled = true;
                    buttonLosuj.Enabled = true;
                    info.Text = " ";
                    g.ZerujLicznik();

                }

            }

        }

        private void button_historia_Click(object sender, EventArgs e)
        {
            Form2 historia = new Form2();
            historia.Show();
        }
    }
}