using System.Windows.Forms;

namespace Lab6._8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ticTacToe1 = new TicTacToe.TicTacToe();
            this.SuspendLayout();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            MessageBox.Show("Привет");
        }
    }
}
