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

        private void button2_Click(object sender, EventArgs e)
        {
            string kohvisort;
            if (checkBox1.Checked)
            {
                kohvisort = "Americano";
                label13.Text = kohvisort;
                int kohvikogusx = Convert.ToInt32(numericUpDown1.Value);
                label20.Text = kohvikogusx.ToString();
            }
            if (checkBox2.Checked)
            {
                kohvisort = "Cappuccino";
                label14.Text = kohvisort;
                int kohvikogusx = Convert.ToInt32(numericUpDown2.Value);
                label21.Text = kohvikogusx.ToString();
            }
            if (checkBox3.Checked)
            {
                kohvisort = "Caffe Latte";
                label15.Text = kohvisort;
                int kohvikogusx = Convert.ToInt32(numericUpDown3.Value);
                label22.Text = kohvikogusx.ToString();
            }
            tabControl1.SelectedIndex = 1;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
