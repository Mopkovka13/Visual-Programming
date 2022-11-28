using System;
using System.Windows.Forms;

namespace Lab6._8
{
    public partial class Form1 : Form
    {
        TicTacToe TTT;
        public Form1()
        {
            InitializeComponent();
            TTT = new TicTacToe();
            Controls.Add(TTT);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
