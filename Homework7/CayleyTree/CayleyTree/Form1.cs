using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private int n;
        private double leng;
        private double per1;
        private double per2;
        private double th1;
        private double th2;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
            cb.SelectedIndex = 0;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.n = Convert.ToInt32(tb1.Text);
            this.leng = Convert.ToDouble(tb2.Text);
            this.per1 = Convert.ToDouble(tb3.Text);
            this.per2 = Convert.ToDouble(tb4.Text);
            this.th1 = Convert.ToDouble(tb5.Text) * Math.PI/180;
            this.th2 = Convert.ToDouble(tb6.Text) * Math.PI/180;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = panel4.CreateGraphics();
            DrawCrayleyTree(n, 200, 310, leng, -Math.PI / 2);
            
        }


        private Graphics graphics;
        
        void DrawCrayleyTree(int n,double x0, double y0, double leng, double th)
        {
            if (n == 0)return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            MyDrawLine(x0, y0, x1, y1);

            DrawCrayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCrayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void MyDrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cb.SelectedIndex)
            {
                case 0:
                    pen = Pens.Black;
                    break;
                case 1:
                    pen = Pens.Blue;
                    break;
                case 2:
                    pen = Pens.Yellow;
                    break;
                case 3:
                    pen = Pens.Green;
                    break;
                default:
                    pen = Pens.Black;
                    break;
            }
        }
    }
}