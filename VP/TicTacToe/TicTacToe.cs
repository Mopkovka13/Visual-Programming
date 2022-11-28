using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe: UserControl
    {
        private delegate void cellClick(int x, int y);
        private event cellClick click;

        private short _counter = 0;
        private byte[,] _values;
        /// <summary>
        /// 0 - пустая ячейка
        /// 1 - X
        /// 2 - O
        /// </summary>
        public TicTacToe()
        {
            InitializeComponent();
            _values = new byte[3,3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            click = cell_Click;
        }

        public short CountWinsX { get; private set; } = 0;
        public short CountWinsO { get; private set; } = 0;
        private void game_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //Нажатая кнопка
            TableLayoutPanelCellPosition position = table.GetCellPosition(button); //Её местоположение
            click(position.Row, position.Column);
            refresh();
            GameCheck();
        }
        private void cell_Click(int x, int y)
        {
            if (_values[x, y] == 0)
            {
                _values[x, y] = _counter % 2 == 0 ? (byte)1 : (byte)2;
                _counter++;
            }
        }
        private void refresh()
        {
            for (int i = 0; i < _values.GetLength(0); i++)
            {
                for (int j = 0; j < _values.GetLength(1); j++)
                {
                    Control cell = table.GetControlFromPosition(j, i);
                    if (_values[i, j] == 0)
                    {
                        cell.Text = "";
                        cell.ForeColor = DefaultForeColor;
                    }
                    else if (_values[i, j] == 1)
                    {
                        cell.Text = "X";
                        cell.ForeColor = System.Drawing.Color.DarkGreen;

                    }
                    else if (_values[i, j] == 2)
                    {
                        cell.Text = "O";
                        cell.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
        }
        private void GameCheck()
        {
            for (int x = 0; x < 3; x++)
            {
                if (_values[x, 0] == _values[x, 1] && _values[x, 1] == _values[x, 2] && _values[x, 1] != 0) //Строки
                {
                    GameEnd(_values[x, 0]);
                    return;
                }
                if (_values[0, x] == _values[1, x] && _values[1, x] == _values[2, x] && _values[1, x] != 0) //Столбцы
                {
                    GameEnd(_values[0, x]);
                    return;
                }
            }

            if (_values[0, 0] == _values[1, 1] && _values[1, 1] == _values[2, 2] && _values[1, 1] != 0)
            {
                GameEnd(_values[0, 0]);
                return;
            }
            if (_values[0, 2] == _values[1, 1] && _values[1, 1] == _values[2, 0] && _values[1, 1] != 0)
            {
                GameEnd(_values[0, 2]);
                return;
            }
            if(_counter > 8)
            {
                GameEnd(0);
                return;
            }
        }
        private void GameEnd(byte winner)
        {
            if (winner == 1)
            {
                MessageBox.Show("Победили крестики");
                CountWinsX++;
            }
            else if (winner == 2)
            {
                MessageBox.Show("Победили нолики");
                CountWinsO++;
            }
            else if (winner == 0)
            {
                MessageBox.Show("Ничья");
            }
            _values = new byte[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            _counter = 0;
            refresh();
        }
    }
}
