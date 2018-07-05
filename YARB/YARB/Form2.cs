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
using System.Media;

namespace YARB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void fsound(string namesound)
        {
            SoundPlayer sp = new SoundPlayer(@namesound);
            sp.Play();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fsound("14550_1460040283.wav");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string userData = textBox2.Text + ">"
                            + textBox1;
           
            if (textBox2.Text.Trim() != "")
            {
                StreamReader SR = new StreamReader("SignUp.txt");
                string line = "";
                bool found = false;
                do
                {
                    line = SR.ReadLine();
                    if (line != null)
                    {
                        string[] arrdata = line.Split('>');
                        if (arrdata[2] == textBox2.Text && arrdata[3] == textBox1.Text)
                        {
                            found = true;
                            Form4 frm4 = new Form4();
                            frm4.Show();
                        }
                    }
                }
                while (line != null);
                SR.Close();
                if (!found)
                {
                    
                    MessageBox.Show("This Email or This password isn't correct!");
                    textBox2.Text="";
                    textBox1.Text="";
                    textBox2.Focus();
                    textBox2.SelectAll();

           
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Email");
                textBox2.Focus();
            }


           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Show Password";
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.Text = "Hide Password";
                textBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
