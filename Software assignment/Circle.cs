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
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {

            this.radius = radius; //the only thingthat is different from shape
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
            g.FillEllipse(b, x, y, radius * 2, radius * 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

        }

        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }

    }
}
