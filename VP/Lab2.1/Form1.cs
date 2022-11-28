using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int hours1 = int.Parse(textBox1.Text);
                int minutes1 = int.Parse(textBox2.Text);
                int seconds1 = int.Parse(textBox3.Text);

                int hours2 = int.Parse(textBox6.Text);
                int minutes2 = int.Parse(textBox5.Text);
                int seconds2 = int.Parse(textBox4.Text);

                Timer timer1 = new Timer(hours1, minutes1, seconds1);
                Timer timer2 = new Timer(hours2, minutes2, seconds2);
                if(timer2.GetSeconds() > timer1.GetSeconds())
                {
                    MessageBox.Show("Second time is too big");
                    return;
                }    
                if(radioButton1.Checked == true)
                {
                    Timer result = timer1 + timer2;
                    label4.Text = "Result Addition";
                    textBox9.Text = result.Hours.ToString();
                    textBox8.Text = result.Minutes.ToString();
                    textBox7.Text = result.Seconds.ToString();
                }
                else if(radioButton2.Checked == true)
                {
                    Timer result = timer1 - timer2;
                    label4.Text = "Result Subtraction";
                    textBox9.Text = result.Hours.ToString();
                    textBox8.Text = result.Minutes.ToString();
                    textBox7.Text = result.Seconds.ToString();
                }
                else
                {
                    MessageBox.Show("Choose Action !");
                }
            }
            catch { }
            
        }
    }
}
