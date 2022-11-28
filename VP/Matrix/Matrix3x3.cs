using System;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Matrix3x3: UserControl, IEquatable<Matrix3x3>
    {
        private double[,] _matrix = new double[3, 3];
        static Random rand = new Random();
        public Matrix3x3(bool isRandomMatrix)
        {
            InitializeComponent();
            if(isRandomMatrix)
            {
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        _matrix[i, j] = rand.Next(1, 20);
                    }
                }
            }
            RefreshTableData();
            GetResults();
        }
        public Matrix3x3(double[,] matrix)
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _matrix[i, j] = matrix[i, j];
                }
            }
            RefreshTableData();
            GetResults();
        }
        public bool IsChose { get; private set; } = false;
        public object this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = Convert.ToDouble(value); }
        }
        public double GetMainDiagSum()
        {
            double res = 0;
            for (int i = 0; i < 3; i++)
                res += _matrix[i, i];
            return res;
        }
        public double GetSideDiagSum()
        {
            double res = 0;
            for (int i = 0; i < 3; i++)
                res += _matrix[i, 2 - i];
            return res;
        }
        public double GetDet() //По правилу Саррюса
        {
            return _matrix[0, 0] * _matrix[1, 1] * _matrix[2, 2] +
                       _matrix[0, 1] * _matrix[1, 2] * _matrix[2, 0] +
                       _matrix[0, 2] * _matrix[1, 0] * _matrix[2, 1] -
                       _matrix[0, 2] * _matrix[1, 1] * _matrix[2, 0] -
                       _matrix[0, 0] * _matrix[1, 2] * _matrix[2, 1] -
                       _matrix[0, 1] * _matrix[1, 0] * _matrix[2, 2];
        }
        public void GetResults()
        {
            lbMainDiagonal.Text = "MainDiagonal: " + GetMainDiagSum();
            lbSideDiagonal.Text = "SideDiagonal: " + GetSideDiagSum();
            lbDeterminant.Text = "Determinant: " + GetDet();
        }
        private void RefreshTableData()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tableMatrix.GetControlFromPosition(i, j).Text = _matrix[i, j].ToString();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        _matrix[i, j] = Convert.ToDouble(tableMatrix.GetControlFromPosition(i, j).Text);
                    }
                }
                GetResults();
            }
            catch
            {
                MessageBox.Show("Incorrect Values");
            }
            RefreshTableData();
        }
        public bool Equals(Matrix3x3 other)
        {
            return this._matrix[0, 0] == other._matrix[0, 0] &&
                    this._matrix[0, 1] == other._matrix[0, 1] &&
                    this._matrix[0, 2] == other._matrix[0, 2] &&
                    this._matrix[1, 0] == other._matrix[1, 0] &&
                    this._matrix[1, 1] == other._matrix[1, 1] &&
                    this._matrix[1, 2] == other._matrix[1, 2] &&
                    this._matrix[2, 0] == other._matrix[2, 0] &&
                    this._matrix[2, 1] == other._matrix[2, 1] &&
                    this._matrix[2, 2] == other._matrix[2, 2];
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + _matrix[0, 0].GetHashCode();
            hash = hash * 31 + _matrix[0, 1].GetHashCode();
            hash = hash * 31 + _matrix[0, 2].GetHashCode();
            hash = hash * 31 + _matrix[1, 0].GetHashCode();
            hash = hash * 31 + _matrix[1, 1].GetHashCode();
            hash = hash * 31 + _matrix[1, 2].GetHashCode();
            hash = hash * 31 + _matrix[2, 0].GetHashCode();
            hash = hash * 31 + _matrix[2, 1].GetHashCode();
            hash = hash * 31 + _matrix[2, 2].GetHashCode();
            return hash;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            IsChose = checkBox.Checked ? true : false;
        }
    }
}
