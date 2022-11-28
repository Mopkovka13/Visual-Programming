using System;
using System.Windows.Forms;

namespace NewFormsTest
{
    public partial class Form2 : Form
    {
        public bool IsCorrectValue { get; private set; } = false;
        private double[] array  = new double[5];
        public Form2()
        {
            InitializeComponent();
        }
        public bool checkMatrix()
        {
            IsCorrectValue = true;
            try
            {
                array[0] = Double.Parse(textBox1.Text);
                array[1] = Double.Parse(textBox1.Text);
                array[2] = Double.Parse(textBox1.Text);
                array[3] = Double.Parse(textBox1.Text);
                array[4] = Double.Parse(textBox1.Text);
            }
            catch
            {
                IsCorrectValue = false;
            }

            return IsCorrectValue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkMatrix())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }
        public double[] getArray()
        {
            return new double[] {1,2,3,4,5};
        }
    }
}
