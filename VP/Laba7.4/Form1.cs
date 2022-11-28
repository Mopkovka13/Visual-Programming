using Matrix;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Laba7._4
{
    public partial class Form1 : Form
    {
        List<Matrix3x3> list = new List<Matrix3x3>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            list.Add(new Matrix3x3(new double[,] { { 1, 2, 3 }, { 3, 2, 1 }, { 2, 3, 2 } }));
            list.Add(new Matrix3x3(new double[,] { { 1, 2, 3 }, { 3, 2, 1 }, { 2, 3, 2 } }));
            list.Add(new Matrix3x3(new double[,] { { 1, 5, 6 }, { 1, 3, 2 }, { 4, 6, 4 } }));
            list.Add(new Matrix3x3(new double[,] { { 1, 4, 12 }, { 8, 3, 2 }, { 5, 6, 6 } }));
            list.Add(new Matrix3x3(new double[,] { { 1, 5, 18 }, { 2, 3, 2 }, { 7, 6, 4 } }));
            list.Add(new Matrix3x3(new double[,] { { 1, 12, 36 }, { 4, 3, 2 }, { 4, 17, 4 } }));
            list.Add(new Matrix3x3(new double[,] { { 1, 5, 2 }, { 1, 3, 2 }, { 17, 6, 4 } }));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            list.Add(new Matrix3x3(true));
            refreshTable(list);
        }

        private void refreshTable(List<Matrix3x3> ListMatrix)
        {
            table.Controls.Clear();
            foreach (var item in ListMatrix)
            {
                table.Controls.Add(item);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMatrix createMatrix = new CreateMatrix();
            createMatrix.ShowDialog();
            if(createMatrix.IsCorrectMatrix)
            {
                list.Add(new Matrix3x3(createMatrix.GetCreateMatrix()));
            }
            refreshTable(list);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(var item in list)
            {
                list = list.Where(x => x.IsChose == false).ToList();
            }
            refreshTable(list);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            IEnumerable<Matrix3x3> result = list;
            if(rbDuplicateFalse.Checked) // Дубликаты
            {
                result = result.Distinct();
            }

            if(rbDeterminant.Checked) // Сортировка по
            {
                result = result.OrderBy(x => x.GetDet());
            }
            else if(rbMainDiagonal.Checked)
            {
                result = result.OrderBy(x => x.GetMainDiagSum());
            }
            else if(rbSideDiagonal.Checked)
            {
                result = result.OrderBy(x => x.GetSideDiagSum());
            }

            try
            {
                if (checkBoxFilter.Checked) //Фильтр
                {
                    if (tbDetFrom.Text != "")
                    {
                        double detFrom = Convert.ToDouble(tbDetFrom.Text);
                        result = result.Where(x => x.GetDet() >= detFrom);
                    }
                    if(tbDetTo.Text != "")
                    {
                        double detTo = Convert.ToDouble(tbDetTo.Text);
                        result = result.Where(x => x.GetDet() <= detTo);
                    }
                    if(tbMainDiagFrom.Text != "")
                    {
                        double mainDiagFrom = Convert.ToDouble(tbMainDiagFrom.Text);
                        result = result.Where(x => x.GetMainDiagSum() >= mainDiagFrom);
                    }
                    if(tbMainDiagTo.Text != "")
                    {
                        double mainDiagTo = Convert.ToDouble(tbMainDiagTo.Text);
                        result = result.Where(x => x.GetMainDiagSum() <= mainDiagTo);
                    }
                    if(tbSideDiagFrom.Text != "")
                    {
                        double sideDiagFrom = Convert.ToDouble(tbSideDiagFrom.Text);
                        result = result.Where(x => x.GetSideDiagSum() >= sideDiagFrom);
                    }
                    if(tbSideDiagTo.Text != "")
                    {
                        double sideDiagTo = Convert.ToDouble(tbSideDiagTo.Text);
                        result = result.Where(x => x.GetSideDiagSum() <= sideDiagTo);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Values");
                checkBoxFilter.Checked = false; //Сбросить фильтр при некорректном вводе
            }
            

            refreshTable(result.ToList());
        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilter.Checked)
            {
                tbDetFrom.Enabled = true;
                tbDetTo.Enabled = true;
                tbMainDiagFrom.Enabled = true;
                tbMainDiagTo.Enabled = true;
                tbSideDiagFrom.Enabled = true;
                tbSideDiagTo.Enabled = true;
            }
            else
            {
                tbDetFrom.Enabled = false;
                tbDetFrom.Text = "";
                tbDetTo.Enabled = false;
                tbDetTo.Text = "";
                tbMainDiagFrom.Enabled = false;
                tbMainDiagFrom.Text = "";
                tbMainDiagTo.Enabled = false;
                tbMainDiagTo.Text = "";
                tbSideDiagFrom.Enabled = false;
                tbSideDiagFrom.Text = "";
                tbSideDiagTo.Enabled = false;
                tbSideDiagTo.Text = "";
            }
        }
    }
}
