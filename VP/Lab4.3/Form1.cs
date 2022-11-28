using System;
using System.Windows.Forms;

namespace Laba4._3
{
    public partial class Form1 : Form
    {
        RingedList<string> ringedList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, System.EventArgs e)
        {
            try
            {
                bool correctCapacity = int.TryParse(TBmaxCapacity.Text, out int result);
                if (!correctCapacity)
                    throw new Exception("Uncorrect Capacity");
                TBmaxCapacity.Enabled = false;
                ringedList = new RingedList<string>(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                if (ringedList == null)
                    throw new Exception("Ringed list was null");
                if(TBpush.Text == "")
                    throw new Exception("Enter Item");
                ringedList.Push(TBpush.Text);
                lbCount.Text = "Count: " + ringedList.GetCount();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                if(ringedList != null)
                {
                    bool correctIndex = int.TryParse(TBindex.Text, out int index);
                    if (correctIndex == false || index < 0 || index >= ringedList.GetCount())
                        throw new Exception("Uncorrect Index");
                    TBresult.Text = ringedList[index];
                }
                else
                {
                    throw new Exception("Ringed list was null");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            try
            {
                if (ringedList != null)
                {
                    TBresult.Text = ringedList.Head();
                }
                else
                {
                    throw new Exception("Ringed list was null");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ringedList == null)
                    throw new Exception("Ringed list was null");
                ringedList.Clear();
                TBmaxCapacity.Enabled = true;
                TBindex.Text = "";
                TBmaxCapacity.Text = "";
                TBpush.Text = "";
                TBresult.Text = "";
                lbCount.Text = "Count: null";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
