using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace netipood
{
    public partial class Form1 : Form
    {
        int tootekogus = 0;
        int kohvikogus1 = 0;
        int kohvikogus2 = 0;
        int kohvikogus3 = 0;
        string kohvisort1 = " ";
        string kohvisort2 = " ";
        string kohvisort3 = " ";
        string kohvisort;
        double hind1 = 0;
        double hind2 = 0;
        double hind3 = 0;
        double summa;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont
            , IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadFont()
        {
            byte[] fontArray = netipood.Properties.Resources.Cookie_Regular;
            int dataLength = netipood.Properties.Resources.Cookie_Regular.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;

            c.Font = new Font(ff, size, fontStyle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFont();
            AllocFont(font, this.label10, 24);
            AllocFont(font, this.checkBox1, 24);
            AllocFont(font, this.label12, 16);
            AllocFont(font, this.label9, 14);
            AllocFont(font, this.checkBox2, 24);
            AllocFont(font, this.label27, 16);
            AllocFont(font, this.label8, 14);
            AllocFont(font, this.checkBox3, 24);
            AllocFont(font, this.label28, 16);
            AllocFont(font, this.label7, 14);
            AllocFont(font, this.button2, 26);
            AllocFont(font, this.button5, 14);
            AllocFont(font, this.label26, 16);
            AllocFont(font, this.button3, 14);
            AllocFont(font, this.label29, 16);
            AllocFont(font, this.label26, 16);
            AllocFont(font, this.label11, 26);
            AllocFont(font, this.label2, 20);
            AllocFont(font, this.label3, 20);
            AllocFont(font, this.label5, 20);
            AllocFont(font, this.label6, 20);
            AllocFont(font, this.button1, 26);
            AllocFont(font, this.label16, 22);
            AllocFont(font, this.label17, 22);
            AllocFont(font, this.label18, 22);
            AllocFont(font, this.label16, 16);
            AllocFont(font, this.label17, 16);
            AllocFont(font, this.label18, 16);
            AllocFont(font, this.button4, 16);
            AllocFont(font, this.label31, 40);
            AllocFont(font, this.tabControl1, 20);
            AllocFont(font, this.label32, 20);
            AllocFont(font, this.label30, 20);
            AllocFont(font, this.label13, 22);
            AllocFont(font, this.button6, 26);
            AllocFont(font, this.button7, 16);
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
            label31.Text = "Täname tellimuse eest, " + eesnimi + "!";
            label32.Text = "Kuller toimetab tellimuse aadressile: " + aadress;
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
                kohvisort1 = "Americano";
                kohvikogus1 = Convert.ToInt32(numericUpDown1.Value);
                hind1 = kohvikogus1 * 3.5;
                listBox1.Items.Add(kohvisort1);
                listBox1.Items.Add(" ");
                listBox2.Items.Add(kohvikogus1 + "tk");
                listBox2.Items.Add(" ");
                listBox3.Items.Add(hind1 + "€");
                listBox3.Items.Add(" ");

            }
            if (checkBox2.Checked)
            {
                kohvisort2 = "Cappuccino";
                kohvikogus2 = Convert.ToInt32(numericUpDown2.Value);
                hind2 = kohvikogus2 * 4;
                listBox1.Items.Add(kohvisort2);
                listBox1.Items.Add(" ");
                listBox2.Items.Add(kohvikogus2 + "tk");
                listBox2.Items.Add(" ");
                listBox3.Items.Add(hind2 + "€");
                listBox3.Items.Add(" ");
            }
            if (checkBox3.Checked)
            {
                kohvisort3 = "Caffe Latte";
                kohvikogus3 = Convert.ToInt32(numericUpDown3.Value);
                hind3 = kohvikogus3 * 4;
                listBox1.Items.Add(kohvisort3);
                listBox1.Items.Add(" ");
                listBox2.Items.Add(kohvikogus3 + "tk");
                listBox2.Items.Add(" ");
                listBox3.Items.Add(hind3 + "€");
                listBox3.Items.Add(" ");
            }
            summa = hind1 + hind2 + hind3;
            label30.Text = summa.ToString() + "€";
            tootekogus = kohvikogus1 + kohvikogus2 + kohvikogus3;
            label26.Text = tootekogus.ToString() + " toodet";
            label29.Text = tootekogus.ToString() + " toodet";
            tabControl1.SelectedIndex = 1;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndex = 3;
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click_1(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
