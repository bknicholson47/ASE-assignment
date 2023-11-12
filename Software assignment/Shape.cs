using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Software_assignment
{
    public abstract class Shape
    {
        protected int x, y;

        /// <summary>
        /// Abstract initialization
        /// </summary>
        public Shape( int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Abstract draw function.
        /// </summary>
        /// <param name="g">The Graphics context.</param>
        /// <param name="p">The pen to use.</param>
        /// <param name="fill">Whether to fill.</param>
        public abstract void draw(Graphics g, Pen p, bool fill);

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
