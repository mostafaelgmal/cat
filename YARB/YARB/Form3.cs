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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void fsound(string namesound)
        {
            SoundPlayer sp = new SoundPlayer(@namesound);
            sp.Play();


        }

        string gender;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fsound("14550_1460040283.wav");
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || comboBox4.Text.Trim() == "" || comboBox6.Text.Trim() == "" || comboBox5.Text.Trim() == "" || checkBox3.Text.Trim() == "" || checkBox4.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter All Data And Try Again.");
                return;
            }
            StreamReader SRcheck = new StreamReader("SignUp.txt");
            string strcheck = SRcheck.ReadToEnd();
            SRcheck.Close();
            if (strcheck.Contains(textBox5.Text + ">"))
            {
                MessageBox.Show("This Email is Exist ,Please change and try again. ");
                textBox5.Focus();
                textBox5.SelectAll();
            }
            else
            {
                StreamWriter SW = new StreamWriter("SignUp.txt", true);
                string userData = textBox1.Text + ">"
                                + textBox2.Text + ">"
                                + textBox5.Text + ">"
                                + textBox6.Text + ">"
                                + comboBox4.Text + ">"
                                + comboBox6.Text + ">"
                                + comboBox5.Text + ">";
                if (checkBox3.Checked)
                {
                    userData += checkBox3.Text;
                }
                else
                {
                    userData += checkBox4.Text;
                }
                SW.WriteLine(userData);
                SW.Close();
                Form4 frm4 = new Form4();
                frm4.Show();
                foreach (Control c in this.Controls)
                    if (c is TextBox || c is ComboBox)
                        c.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // button1.Image = Image.FromFile("C:\\image\\eye.open");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Show Password";
                textBox6.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.Text = "Hide Password";
                textBox6.UseSystemPasswordChar = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           /*char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && textBox5.Text.Contains("@"))
            {
                e.Handled = true;
            }*/
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "";
            textBox6.UseSystemPasswordChar = false;
        }

        private void comboBox4_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox4.Text = "";
        }

        private void comboBox6_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox6.Text = "";
        }

        private void comboBox5_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox5.Text = "";
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = true;
                checkBox4.Checked = false;

            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = true;
                checkBox3.Checked = false;

            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
