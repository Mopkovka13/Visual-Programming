using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true) // +
            {
                textBox9.Text = (double.Parse(textBox1.Text) + double.Parse(textBox6.Text)).ToString();
                textBox8.Text = (double.Parse(textBox2.Text) + double.Parse(textBox5.Text)).ToString();
                textBox7.Text = (double.Parse(textBox3.Text) + double.Parse(textBox4.Text)).ToString();
            }
            else if(radioButton4.Checked == true) // -
            {
                textBox9.Text = (double.Parse(textBox1.Text) - double.Parse(textBox6.Text)).ToString();
                textBox8.Text = (double.Parse(textBox2.Text) - double.Parse(textBox5.Text)).ToString();
                textBox7.Text = (double.Parse(textBox3.Text) - double.Parse(textBox4.Text)).ToString();
            }
            else if(radioButton5.Checked == true)
            {
                textBox9.Text = (double.Parse(textBox1.Text) * double.Parse(textBox6.Text)).ToString();
                textBox8.Text = (double.Parse(textBox2.Text) * double.Parse(textBox6.Text)).ToString();
                textBox7.Text = (double.Parse(textBox3.Text) * double.Parse(textBox6.Text)).ToString();
            }
        }
    }
}
