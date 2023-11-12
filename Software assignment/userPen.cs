﻿using System;
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
        protected bool fill;
        System.Drawing.Pen pen;
        /// <summary>
        /// Initialises userpen parameters
        /// </summary>
        /// <param name="color">The pen's colour</param>
        /// <param name="x">The pen's x pos.</param>
        /// <param name="y">The pen's y pos.</param>
        public userPen(Color colour, int x, int y, int radius, bool fill)
        {

            this.colour = colour;
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.pen = new System.Drawing.Pen(colour);
            this.fill = fill;
        }
        /// <summary>
        /// Positions pen to user inpputed position.
        /// </summary>
        /// <param name="x">The pen's x pos to set.</param>
        /// <param name="y">The pen's y pos to set.</param>
        public void moveTo(int x, int y)
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
        /// <param name="x2">The pen's x pos to draw to.</param>
        /// <param name="y2">The pen's y pos to draw to.</param>
        public void drawTo(Graphics g, int x2, int y2)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x2, y2));
            this.x = x2;
            this.y = y2;
        }
        /// <summary>
        /// Gets pen object, usually for handing to draw functions.
        /// </summary>
        /// <returns>Pen object</returns>
        public Pen getPen()
        {
            return pen;
        }
        /// <summary>
        /// Gets fill bool state.
        /// </summary>
        /// <returns>Fill state</returns>
        public bool getFill()
        {
            return fill;
        }
        /// <summary>
        /// Sets pen to user inpputed color for future operations.
        /// </summary>
        /// <param name="fill">Bool state to set fill to.</param>
        public void setFill(bool fill)
        {
            this.fill = fill;
        }

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
