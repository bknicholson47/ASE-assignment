using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_assignment
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap = new Bitmap(600, 500);
        Bitmap CursorBitmap = new Bitmap(600, 500);
        Graphics bmG;
        CommandBehavior C;
        public Form1()
        {
            InitializeComponent();
            bmG = Graphics.FromImage(myBitmap);
        }

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitmap, 0, 0);
            //g.DrawImageUnscaled(CursorBitmap, 0, 0);
        }

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        private void Run_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            Parser Parse = new Parser(bmG);
            Parse.ParseCommand(mytext);
            pictureBox1.Image = myBitmap;

        }

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        private void Syntax_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
