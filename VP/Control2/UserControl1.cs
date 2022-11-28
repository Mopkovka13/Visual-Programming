using System;
using System.Windows.Forms;

namespace Control2
{
    public partial class UserControl1: UserControl
    {
        public int[] array { get; set; }
        //public int[,] array { get; set; }
        public UserControl1()
        {
            InitializeComponent();
            array = new int[] { 1,2,3,4,5,6,7,8 };
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            array[0] = 5;
        }
    }
}
