using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netipood
{
    public partial class Form1 : Form
    {
        public string kohvikogus = "õõõ";
        string kohvisort;
        double hind1;
        double hind2;
        double hind3;
        double summa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void andmedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eesnimi = nimi_txt.Text;
            string perekonnanimi = prknimi_txt.Text;
            string aadress = aadress_txt.Text;
            string telefon = telnr_txt.Text;
            //label1.Text = eesnimi;
            tabControl1.SelectedIndex = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {


        }

        public void button2_Click(object sender, EventArgs e)
        {
                
            if (checkBox1.Checked)
            {
                kohvisort = "Americano";
                label13.Text = kohvisort;
                double kohvikogusx = Convert.ToInt32(numericUpDown1.Value);
                label20.Text = kohvikogusx.ToString() + "tk";
                hind1 = kohvikogusx * 3.5;
                label23.Text = hind1.ToString() + "€";

                
            }
            if (checkBox2.Checked)
            {
                kohvisort = "Cappuccino";
                label14.Text = kohvisort;
                double kohvikogusx = Convert.ToInt32(numericUpDown2.Value);
                label21.Text = kohvikogusx.ToString() + "tk";
                hind2 = kohvikogusx * 4;
                label24.Text = hind2.ToString() + "€";
            }
            if (checkBox3.Checked)
            {
                kohvisort = "Caffe Latte";
                label15.Text = kohvisort;
                double kohvikogusx = Convert.ToInt32(numericUpDown3.Value);
                label22.Text = kohvikogusx.ToString() + "tk";
                hind3 = kohvikogusx * 4;
                label25.Text = hind3.ToString() + "€";
            }
            summa = hind1 + hind2 + hind3;
            label30.Text = summa.ToString() + "€";
            tabControl1.SelectedIndex = 1;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
