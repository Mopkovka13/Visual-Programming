using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6._8
{
    public partial class TicTacToe : UserControl
    {
        int counter = 0;
        string player1 = "X";
        string player2 = "O";
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void game_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text == "")
            {
                button.Text = counter % 2 == 0 ? player1 : player2;
                counter++;
                gameCheck();
            }
        }
        private void gameCheck()
        {
            if (counter < 4)
                return;
            if(button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                gameEnd(button1.Text);
                return;
            }
            else if(button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                gameEnd(button4.Text);
                return;
            }
            else if(button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                gameEnd(button7.Text);
                return;
            }
            else if(button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                gameEnd(button1.Text);
                return;
            }
            else if(button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                gameEnd(button2.Text);
                return;
            }
            else if(button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                gameEnd(button3.Text);
                return;
            }
            else if(button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                gameEnd(button1.Text);
                return;
            }
            else if(button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                gameEnd(button3.Text);
                return;
            }
            else if(counter == 9)
            {
                gameEnd("дружбы ;)");
                return;
            }
        }

        private void gameEnd(string winner)
        {
            MessageBox.Show("Победа " + winner);
            foreach(var item in tableLayoutPanel1.Controls)
            {
                if(item.GetType().Name == "Button")
                {
                    Button btn = (Button)item;
                    btn.Text = "";
                } 
            }
            counter = 0;
        }
    }
}
