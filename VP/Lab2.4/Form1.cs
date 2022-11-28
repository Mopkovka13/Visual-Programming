using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2._4
{
    public partial class Form1 : Form
    {
        Matrix3x3 matrix1 = new Matrix3x3();
        Matrix3x3 matrix2 = new Matrix3x3();
        Matrix3x3 resultMatrix = new Matrix3x3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                matrix1[0, 0] = int.Parse(textBox1.Text);
                matrix1[0, 1] = int.Parse(textBox2.Text);
                matrix1[0, 2] = int.Parse(textBox3.Text);
                matrix1[1, 0] = int.Parse(textBox4.Text);
                matrix1[1, 1] = int.Parse(textBox5.Text);
                matrix1[1, 2] = int.Parse(textBox6.Text);
                matrix1[2, 0] = int.Parse(textBox7.Text);
                matrix1[2, 1] = int.Parse(textBox8.Text);
                matrix1[2, 2] = int.Parse(textBox9.Text);

                matrix2[0, 0] = int.Parse(textBox18.Text);
                matrix2[0, 1] = int.Parse(textBox17.Text);
                matrix2[0, 2] = int.Parse(textBox16.Text);
                matrix2[1, 0] = int.Parse(textBox15.Text);
                matrix2[1, 1] = int.Parse(textBox14.Text);
                matrix2[1, 2] = int.Parse(textBox13.Text);
                matrix2[2, 0] = int.Parse(textBox12.Text);
                matrix2[2, 1] = int.Parse(textBox11.Text);
                matrix2[2, 2] = int.Parse(textBox10.Text);

                resultMatrix = matrix1 + matrix2;

                textBox27.Text = resultMatrix[0, 0].ToString();
                textBox26.Text = resultMatrix[0, 1].ToString();
                textBox25.Text = resultMatrix[0, 2].ToString();
                textBox24.Text = resultMatrix[1, 0].ToString();
                textBox23.Text = resultMatrix[1, 1].ToString();
                textBox22.Text = resultMatrix[1, 2].ToString();
                textBox21.Text = resultMatrix[2, 0].ToString();
                textBox20.Text = resultMatrix[2, 1].ToString();
                textBox19.Text = resultMatrix[2, 2].ToString();

                MainDiag.Text = resultMatrix.getMainDiagSum().ToString();
                SideDiag.Text = resultMatrix.GetSideDiagSum().ToString();
                Determinant.Text = resultMatrix.GetDet().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                matrix1[0, 0] = int.Parse(textBox1.Text);
                matrix1[0, 1] = int.Parse(textBox2.Text);
                matrix1[0, 2] = int.Parse(textBox3.Text);
                matrix1[1, 0] = int.Parse(textBox4.Text);
                matrix1[1, 1] = int.Parse(textBox5.Text);
                matrix1[1, 2] = int.Parse(textBox6.Text);
                matrix1[2, 0] = int.Parse(textBox7.Text);
                matrix1[2, 1] = int.Parse(textBox8.Text);
                matrix1[2, 2] = int.Parse(textBox9.Text);

                matrix2[0, 0] = int.Parse(textBox18.Text);
                matrix2[0, 1] = int.Parse(textBox17.Text);
                matrix2[0, 2] = int.Parse(textBox16.Text);
                matrix2[1, 0] = int.Parse(textBox15.Text);
                matrix2[1, 1] = int.Parse(textBox14.Text);
                matrix2[1, 2] = int.Parse(textBox13.Text);
                matrix2[2, 0] = int.Parse(textBox12.Text);
                matrix2[2, 1] = int.Parse(textBox11.Text);
                matrix2[2, 2] = int.Parse(textBox10.Text);

                resultMatrix = matrix1 * matrix2;

                textBox27.Text = resultMatrix[0, 0].ToString();
                textBox26.Text = resultMatrix[0, 1].ToString();
                textBox25.Text = resultMatrix[0, 2].ToString();
                textBox24.Text = resultMatrix[1, 0].ToString();
                textBox23.Text = resultMatrix[1, 1].ToString();
                textBox22.Text = resultMatrix[1, 2].ToString();
                textBox21.Text = resultMatrix[2, 0].ToString();
                textBox20.Text = resultMatrix[2, 1].ToString();
                textBox19.Text = resultMatrix[2, 2].ToString();

                MainDiag.Text = resultMatrix.getMainDiagSum().ToString();
                SideDiag.Text = resultMatrix.GetSideDiagSum().ToString();
                Determinant.Text = resultMatrix.GetDet().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
