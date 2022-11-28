using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Lab9._2
{

    public partial class Form1 : Form
    {
        private int[,] table;
        private int rows;
        private int columns;
        Matrix matrix;
        int[] maxArr;
        bool check = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                rows = int.Parse(tbRows.Text);
                columns = int.Parse(tbColumns.Text);
                table = new int[rows, columns];
                dataGrid.ColumnCount = columns;
                dataGrid.RowCount = rows;
                btnSearch.Enabled = true;
                btnCreate.Enabled = false; // Block Create
                tbColumns.Enabled = false;
                tbRows.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Incorrect values");
            } 
        }
        void potokFun(object step)
        {
            int[] stepArr = (int[])step; //Приводим к массиву
            if (check)
            {
                maxArr = matrix.searchMax(stepArr[0], stepArr[1]);
                check = false;
            }
            else
            {
                int[] elem = matrix.searchMax(stepArr[0], stepArr[1]);
               
                if (elem[0] > maxArr[0]) maxArr = elem;
            }


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            check = true;
            try
            {
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        int value = dataGrid[j, i].Value != null ? int.Parse(dataGrid[j, i].Value.ToString()) : 0;
                        table[i, j] = value;
                        dataGrid[j, i].Value = value; //Set 0 in VoidCells
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect values");
            }

            matrix = new Matrix(rows, columns, table);

            List<Thread> threads = new List<Thread>(); //Лист с количеством потоков
            for (int i = 0; i < matrix.m * matrix.n; i++)
            {
                threads.Add(new Thread(new ParameterizedThreadStart(potokFun))); //Параметризированный поток принимает obj
            }

            int k = 0; //Запускаем потоки, передавая им как параметр i, j;
            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {

                    int[] q = { i + 1, j + 1 };
                    threads[k].Start(q);
                    k++;
                }
            }
            foreach (var thread in threads) //Ожидание потоков
            {
                thread.Join();
            }

            int deleI = maxArr[1],
            deleJ = maxArr[2],
            coordinateI = maxArr[3],
            coordinateJ = maxArr[4];
            dataGrid.ClearSelection(); //Снять выделение со всех ячеек
            for (int i = coordinateI; i < coordinateI + deleI; i++)
            {
                for (int j = coordinateJ; j < coordinateJ + deleJ; j++)
                {
                    dataGrid[j, i].Selected = true;
                }
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
