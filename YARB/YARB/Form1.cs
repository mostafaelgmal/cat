using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace YARB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Icon = Icon.ExtractAssociatedIcon("YIKGUI");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void fsound(string namesound)
        {
            SoundPlayer sp = new SoundPlayer(@namesound);
            sp.Play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fsound("14550_1460040283.wav");
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fsound("‪14550_1460040283.wav");
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics gobject = CreateGraphics();
            Brush Gray = new SolidBrush(Color.Indigo);
            Pen GrayPen = new Pen(Gray,50);
            gobject.FillRectangle(Gray, 0,0, 1145, 142);
            gobject.Dispose(); */

 
        }
    }                                     
}
