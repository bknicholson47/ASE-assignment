using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_assignment
{
    class Triangle : Shape
    {
        protected int x2;
        protected int y2;
        protected int x3;
        protected int y3;

        /// <summary>
        /// Initializes triangle parameters.
        /// </summary>
        public Triangle(int x, int y, int x2, int y2, int x3, int y3) : base(x, y) 
        { 
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        /// <summary>
        /// Creates triangle based on parameters.
        /// </summary>
        /// <param name="g">The Graphics context.</param>
        /// <param name="p">The pen to use.</param>
        /// <param name="fill">Whether to fill.</param>
        public override void draw(Graphics g, Pen p, bool fill)
        {
        PointF[] points = new PointF[3];
        points[0] = new PointF(x, y);
        points[1] = new PointF(x2, y2);
        points[2] = new PointF(x3, y3);
            if (fill)
            {
                SolidBrush b = new SolidBrush(p.Color);
                g.FillPolygon(b, points);
            }
            g.DrawPolygon(p, points);
        }
    }
}
