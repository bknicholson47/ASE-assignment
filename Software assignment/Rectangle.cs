using Software_assignment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_assignment
{
    public class Rectangle : Shape
    {
        protected int width, height;

        /// <summary>
        /// Initializes rectangle parameters.
        /// </summary>
        /// <returns>Nothing.</returns>
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }


        /// <summary>
        /// Creates rectangle based on parameters.
        /// </summary>
        /// <param name="g">The Graphics context.</param>
        /// <param name="p">The pen to use.</param>
        /// <param name="fill">Whether to fill.</param>
        /// <returns>Nothing.</returns>
        public override void draw(Graphics g, Pen p, bool fill)
        {
            if (fill)
            {
                SolidBrush b = new SolidBrush(p.Color);
                g.FillRectangle(b, x, y, width, height);
            }
            g.DrawRectangle(p, x, y, width, height);
        }
    }
}
