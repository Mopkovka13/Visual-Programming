using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) //Rectangle
            {
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox2.Text);
                Rectangle rectangle = new Rectangle(width, height);
                if (radioButton4.Checked == true)
                {
                    label5.Text = rectangle.GetPerimeter().ToString();
                }
                else if(radioButton5.Checked == true)
                {
                    label5.Text = rectangle.GetArea().ToString();
                }
                
                
            }
            else if(radioButton2.Checked == true) //Circle
            {
                double radius = double.Parse(textBox1.Text);
                Circle circle = new Circle(radius);
                if (radioButton4.Checked == true)
                {
                    label5.Text = circle.GetPerimeter().ToString();
                }
                else if (radioButton5.Checked == true)
                {
                    label5.Text = circle.GetArea().ToString();
                }
            }
            else if(radioButton3.Checked == true) //Trapezia
            {
                double baseA = double.Parse(textBox1.Text);
                double baseB = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                Trapezium trapezium = new Trapezium(baseA, baseB, height);
                if (radioButton4.Checked == true)
                {
                    label5.Text = trapezium.GetPerimeter().ToString();
                }
                else if (radioButton5.Checked == true)
                {
                    label5.Text = trapezium.GetArea().ToString();
                }
            }
            else
            {
                MessageBox.Show("Choose Shape");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Width";
            label1.Visible = true;
            textBox1.Visible = true;

            label2.Text = "Height";
            label2.Visible = true;
            textBox2.Visible = true;

            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Radius";
            label1.Visible = true;
            textBox1.Visible = true;

            label2.Visible = false;
            textBox2.Visible=false;

            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "BaseA";
            label1.Visible = true;
            textBox1.Visible = true;

            label2.Text = "BaseB";
            label2.Visible = true;
            textBox2.Visible = true;

            label3.Text = "Height";
            label3.Visible = true;
            textBox3.Visible = true;
        }
    }
}
