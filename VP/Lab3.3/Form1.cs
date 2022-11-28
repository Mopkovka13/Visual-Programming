using System;
using System.Windows.Forms;

namespace Lab3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = CreateSpecificTriangle();
            label7.Text = triangle.GetType().Name.ToString();
            label8.Text = triangle.Square().ToString();
            label9.Text = triangle.Perimeter().ToString();
        }

        Triangle CreateSpecificTriangle() //
        {
            double sideA = double.Parse(textBoxA.Text);
            double sideB = double.Parse(textBoxB.Text);
            double angle = double.Parse(textBoxAngle.Text);
            if (angle == 90)
                return new RightTriangle(sideA, sideB, angle);
            else if (sideA == sideB)
            {
                if(angle == 60)
                    return new EquilateralTriangle(sideA, sideB, angle);
                else
                    return new IsoscelesTriangle(sideA, sideB, angle);
            }      
            else
                throw new Exception("Not found");
        }
    }
}
