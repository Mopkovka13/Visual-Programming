using System;
using System.Globalization;
using System.Windows.Forms;

namespace Laba7._4
{
    public partial class CreateMatrix : Form
    {
        private double[,] _createMatrix = new double[3, 3];
        public CreateMatrix()
        {
            InitializeComponent();
        }
        public bool IsCorrectMatrix { get; private set; } = false;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.CheckMatrix())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Values");
            }
        }
        public bool CheckMatrix()
        {
            IsCorrectMatrix = true;
            try
            {
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        _createMatrix[i, j] = Convert.ToDouble(tableLayoutPanel2.GetControlFromPosition(i, j).Text);
                    }
                }
            }
            catch
            {
                IsCorrectMatrix = false;
            }
            return IsCorrectMatrix;
        }
        public double[,] GetCreateMatrix()
        {
            return _createMatrix;
        }
    }
}
