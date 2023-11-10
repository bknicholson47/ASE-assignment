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
        public Triangle(Color colour, int x, int y, int length, int z) : base(colour, x, y) 
        { 

        }
        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            //g.DrawPolygon(b, new Point)
        }
    }
}
