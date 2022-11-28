using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab5._7
{
    public partial class Form1 : Form
    {
        public delegate void Win();
        public event Win win;
        PictureBox[,] buttons;
        public int level = 100;
        enum Swap
        {
            Up = 0,
            Down = 1,
            Left = 2,
            Right = 3
        }
        public Form1()
        {
            InitializeComponent();
            buttons = new PictureBox[3, 3] { {pictureBox1, pictureBox4, pictureBox7 },
                                        {pictureBox2, pictureBox5, pictureBox8 },
                                        {pictureBox3, pictureBox6, null }};
            win = GameIsWin;
        }

        private void game_Click(object sender, EventArgs e) //Обработка нажатия всех кнопок
        {
            PictureBox button = (PictureBox)sender; //Нажатая кнопка
            TableLayoutPanelCellPosition position = table.GetCellPosition(button); //Её местоположение
            TableLayoutPanelCellPosition newPosition = GetNewPosition(position);
            table.SetCellPosition(button, newPosition);
            win?.Invoke();
        }
        private TableLayoutPanelCellPosition GetNewPosition(TableLayoutPanelCellPosition position)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row);
            if (position.Column + 1 < table.ColumnCount)
            {
                control = table.GetControlFromPosition(position.Column + 1, position.Row);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                }
            }

            if (position.Column - 1 >= 0)
            {
                control = table.GetControlFromPosition(position.Column - 1, position.Row);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                }
            }

            if (position.Row + 1 < table.RowCount)
            {
                control = table.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                }
            }

            if (position.Row - 1 >= 0)
            {
                control = table.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                }
            }
            return newPosition;
        }
        private void GameIsWin()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox control = (PictureBox)table.GetControlFromPosition(i, j);
                    if (control != buttons[i, j])
                        return;
                }
            }
            MessageBox.Show("Победа");
            table.Enabled = false;
            button9.Enabled = true;
            button10.Enabled = false;
        }
        private void start_Click(object sender, EventArgs e)
        {
            table.Enabled = true;
            button9.Enabled = false;
            button10.Enabled = true;
            TableLayoutPanelCellPosition nullCell = new TableLayoutPanelCellPosition(2, 2);
            Random random = new Random();
            for (int i = 0; i < level; i++)
            {
                int swap = random.Next(0, 4);
                if ((Swap)swap == Swap.Up)
                {
                    if (nullCell.Row - 1 >= 0)
                    {
                        PictureBox button = (PictureBox)table.GetControlFromPosition(nullCell.Column, nullCell.Row - 1);
                        table.SetCellPosition(button, nullCell);
                        nullCell.Row -= 1;
                    }
                    continue;
                }
                if ((Swap)swap == Swap.Left)
                {
                    if (nullCell.Column - 1 >= 0)
                    {
                        PictureBox button = (PictureBox)table.GetControlFromPosition(nullCell.Column - 1, nullCell.Row);
                        table.SetCellPosition(button, nullCell);
                        nullCell.Column -= 1;
                    }
                    continue;
                }
                if ((Swap)swap == Swap.Right)
                {
                    if (nullCell.Column + 1 < buttons.GetLength(1))
                    {
                        PictureBox button = (PictureBox)table.GetControlFromPosition(nullCell.Column + 1, nullCell.Row);
                        table.SetCellPosition(button, nullCell);
                        nullCell.Column += 1;
                    }
                    continue;
                }
                if ((Swap)swap == Swap.Down)
                {
                    if (nullCell.Row + 1 < buttons.GetLength(0))
                    {
                        PictureBox button = (PictureBox)table.GetControlFromPosition(nullCell.Column, nullCell.Row + 1);
                        table.SetCellPosition(button, nullCell);
                        nullCell.Row += 1;
                    }
                    continue;
                }
            }
        }
        private void solution_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] != null)
                        table.SetCellPosition(buttons[i, j], new TableLayoutPanelCellPosition(i, j));
                }
            }
            table.Enabled = false;
            button9.Enabled = true;
            button10.Enabled = false;
        }
    }
}
