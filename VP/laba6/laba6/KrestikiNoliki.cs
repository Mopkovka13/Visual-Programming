using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba6
{
    public class KrestikiNoliki : UserControl
    {

        private Pen mSimplePen; //Хранит экземпляр Пера
        private Color mPointerColor; //Цвет указателей стрелок
        private int[,] values = new int[3, 3];
        private bool hod = true;

        private Point mCenter; //Координты центра компонента
        public KrestikiNoliki() //Конструктор по умолчанию
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    values[i, j] = 0;
                }
            }
            mSimplePen = new Pen(Brushes.DarkGray, 1.5f);
            mPointerColor = Color.Black;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawLine(new Pen(mPointerColor, 1f),
                mCenter.X - ClientRectangle.Width/2,
                mCenter.Y + ClientRectangle.Height / 6,
                mCenter.X + ClientRectangle.Width/2,
                mCenter.Y + ClientRectangle.Height / 6);
            g.DrawLine(new Pen(mPointerColor, 1f),
               mCenter.X - ClientRectangle.Width / 2,
               mCenter.Y - ClientRectangle.Height / 6,
               mCenter.X + ClientRectangle.Width / 2,
               mCenter.Y - ClientRectangle.Height / 6);

            g.DrawLine(new Pen(mPointerColor, 1f),
                mCenter.X + ClientRectangle.Width / 6,
                mCenter.Y - ClientRectangle.Height / 2,
                mCenter.X + ClientRectangle.Width / 6,
                mCenter.Y + ClientRectangle.Height / 2);

            g.DrawLine(new Pen(mPointerColor, 1f),
                mCenter.X - ClientRectangle.Width / 6,
                mCenter.Y - ClientRectangle.Height / 2,
                mCenter.X - ClientRectangle.Width / 6,
                mCenter.Y + ClientRectangle.Height / 2);

            //g.FillEllipse(Brushes.Black, new Rectangle(ClientRectangle.Width / 12, ClientRectangle.Height / 12, ClientRectangle.Width / 6, ClientRectangle.Width / 6));
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(values[i,j] == 1)
                    {
                        int stepW = ClientRectangle.Width / 3;
                        int stepH = ClientRectangle.Height / 3;
                        g.DrawLine(new Pen(mPointerColor, 1f),
                            ClientRectangle.Width / 12 + stepW * i,
                            ClientRectangle.Height / 12 + stepH * j,
                            ClientRectangle.Width / 4 + stepW * i,
                            ClientRectangle.Height / 4 + stepH * j);
                        g.DrawLine(new Pen(mPointerColor, 1f),
                            ClientRectangle.Width / 12 + stepW * i,
                            ClientRectangle.Height / 4 + stepH * j,
                            ClientRectangle.Width / 4 + stepW * i,
                            ClientRectangle.Height / 12 + stepH * j);
                    }
                    if (values[i, j] == 2)
                    {
                        int stepW = ClientRectangle.Width / 3;
                        int stepH = ClientRectangle.Height / 3;
                        g.FillEllipse(Brushes.Black, new Rectangle(
                            ClientRectangle.Width / 12 + stepW * i, 
                            ClientRectangle.Height / 12 + stepH * j, 
                            ClientRectangle.Width / 6, 
                            ClientRectangle.Width / 6));
                    }
                }
            }

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            mCenter.X = ClientRectangle.Width / 2;
            mCenter.Y = ClientRectangle.Height / 2;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int w = (ClientRectangle.Width / 3);
            int h = (ClientRectangle.Height / 3);
            int i = e.X / w;
            int j = e.Y / h;
            if(values[i,j] == 0)
            {
                if (hod)
                {
                    values[i, j] = 1;
                }
                else
                {
                    values[i, j] = 2;
                }
                hod = !hod;
            }
            Invalidate();
            bool win = false;
            for ( int x = 0; x < 3; x++)
            {
                if(values[x, 0] == values[x, 1] && values[x, 1] == values[x, 2] && values[x, 1] != 0)
                {
                    win = true;
                }
                if (values[0, x] == values[1, x] && values[1, x] == values[2, x] && values[1, x] != 0)
                {
                    win = true;
                }
            }
            if (values[0, 0] == values[1, 1] && values[1, 1] == values[2, 2] && values[1, 1] != 0)
            {
                win = true;
            }
            if (values[0, 2] == values[1, 1] && values[1, 1] == values[2, 0] && values[1, 1] != 0)
            {
                win = true;
            }
            if (win)
            {
                if (!hod)
                {
                    MessageBox.Show("Победа крестиков");
                }
                else
                {
                    MessageBox.Show("Победа ноликов");
                }
            }
        }

    }
}