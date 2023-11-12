using Software_assignment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_assignment
{
    class Rectangle : Shape
    {
        protected int width, height;

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }


        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        public override void draw(Graphics g)
        {
            userPen p = new userPen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, x, y, width, height);
            g.DrawRectangle(p, x, y, width, height);
        }
    }
}
