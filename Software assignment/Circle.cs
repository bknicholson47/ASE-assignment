using Software_assignment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Software_assignment
{
    public class Circle : Shape
    {
        protected int radius;

        /// <summary>
        /// Initializes circle parameters.
        /// </summary>
        /// <returns>Nothing.</returns>
        public Circle(int x, int y, int radius) : base(x, y)
        {

            this.radius = radius;
        }


        /// <summary>
        /// Creates circle based on parameters.
        /// </summary>
        /// <param name="g">The Graphics context.</param>
        /// <param name="p">The pen to use.</param>
        /// <param name="fill">Whether to fill.</param>
        public override void draw(Graphics g, Pen p, bool fill)
        {
            if (fill) {
                SolidBrush b = new SolidBrush(p.Color);
                g.FillEllipse(b, x, y, radius * 2, radius * 2);
            }
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

        }

        public override string ToString()
        {
            return base.ToString() + "  " + this.radius;
        }

    }
}
