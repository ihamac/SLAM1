using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MonAppli
{
    public partial class FListe : Form
    {
        private StreamReader srListe1;
        private StreamReader srListe2;
        private StreamWriter swListe1;
        private StreamWriter swListe2;
        public FListe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_saisie.Text))
            {
                MessageBox.Show("Votre saisie est vide...");
            }
            else {
                lb_liste.Items.Add(tb_saisie.Text);
                tb_saisie.Text = "";
                tb_saisie.Focus();
            }
        }

        private void bt_supp_Click(object sender, EventArgs e)
        {

            if (lb_liste.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez rien selectionné...");
            }
            else {
                lb_liste.Items.RemoveAt(lb_liste.SelectedIndex);
            }
        }

        private void bt_ajout2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_saisie2.Text))
            {
                MessageBox.Show("Votre saisie est vide...");
            }
            else
            {
                lb_liste2.Items.Add(tb_saisie2.Text);
                tb_saisie2.Text = "";
                tb_saisie2.Focus();
            }
        }

        private void bt_supp2_Click(object sender, EventArgs e)
        {
            if (lb_liste2.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez rien selectionné...");
            }
            else
            {
                lb_liste2.Items.RemoveAt(lb_liste2.SelectedIndex);
            }
        }

        private void tb_saisie2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_liste2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_gauche_Click(object sender, EventArgs e)
        {
            lb_liste.Items.Add(lb_liste2.SelectedItem);
            lb_liste2.Items.RemoveAt(lb_liste2.SelectedIndex);
        }

        private void bt_droite_Click(object sender, EventArgs e)
        {
            lb_liste2.Items.Add(lb_liste.SelectedItem);
            lb_liste.Items.RemoveAt(lb_liste.SelectedIndex);
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            DialogResult quit;
            quit = MessageBox.Show("Voulez vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void FListe_Load(object sender, EventArgs e)
        {
            try
            {
                srListe1 = new StreamReader("liste1.txt");
                string s = srListe1.ReadLine();
                while (s != null)
                {
                    lb_liste.Items.Add(s); 
                    s = srListe1.ReadLine();
                }

                srListe1.Close();

            }
            catch{
                swListe1 = new StreamWriter("liste1.txt");;
                swListe1.Close();
            }
        }
    }
}
