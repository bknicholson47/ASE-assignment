using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Software_assignment
{
    public class userPen
    {

        protected Color colour;
        protected int x, y;
        protected int radius;
        System.Drawing.Pen pen;
        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="color">The pen's colour</param>
        /// <param name="x">The pen's x pos.</param>
        /// <param name="y">The pen's y pos.</param>
        public userPen(Color colour, int x, int y, int radius)
        {

            this.colour = colour;
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.pen = new System.Drawing.Pen(colour);
        }
        public void positionPen(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void drawTo(Graphics g, int x, int y)
        {
            g.DrawLine(pen, new Point(this.x, this.y), new Point(x, y));
        }

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
