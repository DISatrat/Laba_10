using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_10
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int xc = this.Width / 2;
            int yc = this.Height / 2;
            g.TranslateTransform(xc, yc);
            double a = 0.5;
            double b = 1;
            Pen pen2 = new Pen(Color.Black, 2f);
            g.DrawLine(pen2, -xc, 0, xc, 0);
            g.DrawLine(pen2, 0, -yc, 0, yc);
            
            int k = 0;
            Pen pen = new Pen(Color.Blue, 2f);

            List<PointF> points = new List<PointF>();

            for (int i = -xc; i < xc; i+=20)
            {
                g.DrawLine(pen2, i , -4, i, 4);
                g.DrawLine(pen2, -4, i , 4, i);
               
            }
            
            for (double x =a; x < b; x += 0.05)
            {
                float y = -(float)(Math.Sqrt(x + 1) - (1 / x));
                
                points.Add(new PointF((float)x*200, y*200));
             

                if (k == 0)
                {
                    k++;
                    continue;
                }

                g.DrawLine(pen, points[k], points[k - 1]);
                
                k++;
            }
        }
    }
}
