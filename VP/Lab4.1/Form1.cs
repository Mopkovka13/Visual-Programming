using System;
using System.Windows.Forms;

namespace Lab4._4
{
    public partial class Form1 : Form
    {
        Quque<string> quque = new Quque<string>();
        public Form1()
        {
            InitializeComponent();
        }
        public void refreshList()
        {
            listBox1.Items.Clear();
            Node<string> currentNode = quque.Head();
            for (int i = 0; i < quque.Count; i++)
            {
                listBox1.Items.Add(currentNode.Data);
                currentNode = currentNode.Next;
                
            }
            label1.Text = "count = " + quque.Count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                quque.Enqueue(textBox1.Text);
                refreshList();
            }
            catch
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = quque.First;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                quque.Dequeue();
                refreshList();
            }
            catch
            {

            }
            
        }
    }
}
