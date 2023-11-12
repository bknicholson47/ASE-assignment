using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_assignment
{
    class Triangle : Shape
    {
        protected int length;
        protected int z;

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        public Triangle(int x, int y, int length, int z) : base(x, y) 
        { 

        }

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        public override void draw(Graphics g, Pen p, bool fill)
        {
            if (fill)
            {
                SolidBrush b = new SolidBrush(p.Color);
            }
            //g.DrawPolygon(b, new Point)
        }
    }
}
