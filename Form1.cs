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
        public string kohvikogus = "õõõ";
        string kohvisort;
        double hind1;
        double hind2;
        double hind3;
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
            AllocFont(font, this.label19, 22);
            AllocFont(font, this.label13, 16);
            AllocFont(font, this.label14, 16);
            AllocFont(font, this.label15, 16);
            AllocFont(font, this.label16, 16);
            AllocFont(font, this.label17, 16);
            AllocFont(font, this.label18, 16);
            AllocFont(font, this.label19, 16);
            AllocFont(font, this.label20, 16);
            AllocFont(font, this.label21, 16);
            AllocFont(font, this.label19, 22);
            AllocFont(font, this.button4, 16);
            AllocFont(font, this.label31, 26);
            AllocFont(font, this.tabControl1, 20);

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
