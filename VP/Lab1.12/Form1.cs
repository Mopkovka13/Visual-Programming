using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            double result = 0;
            result = Math.PI * Math.Pow((double.Parse(textBox4.Text) / 2), 2);
            textBox5.Text = result.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            double result = 0;
            result = double.Parse(textBox2.Text) * double.Parse(textBox3.Text);
            textBox5.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
