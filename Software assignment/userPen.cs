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
        /// <summary>
        /// Positions pen to user inpputed position.
        /// </summary>
        /// <param name="x">The pen's x pos to set.</param>
        /// <param name="y">The pen's y pos to set.</param>
        public void positionPen(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Sets pen to user inpputed color for future operations.
        /// </summary>
        /// <param name="color">String parsed to color.</param>
        public void setColor(string color)
        {
            Console.WriteLine(color);
            this.colour = Color.FromName(color);
            pen.Color = colour;
        }
        /// <summary>
        /// Draws line from pen position to drawto input position.
        /// </summary>
        /// <param name="g">The graphics context to draw to.</param>
        /// <param name="x">The pen's x pos to draw to.</param>
        /// <param name="y">The pen's y pos to draw to.</param>
        public void drawTo(Graphics g, int x2, int y2)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x2, y2));
            this.x = x2;
            this.y = y2;
        }

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
