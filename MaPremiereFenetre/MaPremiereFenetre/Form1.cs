using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaPremiereFenetre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TraduireClick_Click(object sender, EventArgs e)
        {
            if (this.rbAnglais.Checked == true) {
                MessageBox.Show("Hello " + tbNom.Text);
            }
            if (this.rbAllemand.Checked == true)
            {
                MessageBox.Show("Guten Tag " + tbNom.Text);
            }
            if (this.rbTurc.Checked == true)
            {
                MessageBox.Show("Merahba " + tbNom.Text);
            }
            else {
                MessageBox.Show("Hola " + tbNom.Text);
            }
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEspagnol_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
