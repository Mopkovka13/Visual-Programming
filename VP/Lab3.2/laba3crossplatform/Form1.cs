using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3crossplatform
{
    
    public partial class Form1 : Form
    {
        public bool checker;
        public double dollar, euro;
        public double rateDollar, rateEuro;
        Dollar doll = new Dollar();
        Euro eur = new Euro();
        public abstract class Currency
        {
            public abstract void transfertorub(double rub, double rate);
            public abstract string viewvalue();
        }

        public class Dollar : Currency
        {
            private double rubfromdollar;

            public override void transfertorub(double rub, double rate)
            {
                rubfromdollar = rub * rate;
            }
            public override string viewvalue()
            {
                return Convert.ToString(Math.Round(rubfromdollar, 5));
            }
        }
        public class Euro : Currency
        {
            private double rubfromeuro;

            public override void transfertorub(double rub, double rate)
            {
                rubfromeuro = rub * rate;
            }
            public override string viewvalue()
            {
                return Convert.ToString(Math.Round(rubfromeuro, 5));
            }
        }
        async void choose()
        {
            while (checker)
            {
                try
                {
                    dollar = Convert.ToDouble(textBox1.Text);
                    euro = Convert.ToDouble(textBox2.Text);
                    rateDollar = Convert.ToDouble(textBox5.Text);
                    rateEuro = Convert.ToDouble(textBox6.Text);
                    button1.Enabled = true;
                }
                catch
                {
                    button1.Enabled = false;
                }
                await Task.Delay(100);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checker = true;
            choose();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doll.transfertorub(dollar, rateDollar);
            eur.transfertorub(euro, rateEuro);

            textBox3.Text = doll.viewvalue();
            textBox4.Text = eur.viewvalue();
        }
    }
}
