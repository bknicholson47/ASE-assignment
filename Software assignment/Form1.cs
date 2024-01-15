using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Software_assignment
{
    public unsafe partial class Form1 : Form
    {
        static public Bitmap myBitmap = new Bitmap(600, 500);
        static public Bitmap CursorBitmap = new Bitmap(600, 500);
        static public Graphics bmG;
        static public userPen pen = new userPen(Color.Black,0,0,1,true);
        static public Parser Parse;
        CommandBehavior C;
        public Form1()
        {
            InitializeComponent();
            bmG = Graphics.FromImage(myBitmap);
            Parse = new Parser(bmG, pen);
        }

        /// <summary>
        /// The Graphics box that the user draws on.
        /// </summary>
        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitmap, 0, 0);
            //g.DrawImageUnscaled(CursorBitmap, 0, 0);
        }

        /// <summary>
        /// The run button for the command line.
        /// </summary>
        private void Run_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            string prog = richTextBox1.Text;
            richTextBoxOutput.Text = richTextBoxOutput.Text + Parse.ParseCommand(mytext, prog, false, 0);
            pictureBox1.Image = myBitmap;

        }

        /// <summary>
        /// The button for syntax checking.
        /// </summary>
        private void Syntax_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            string prog = richTextBox1.Text;
            Parser Parse = new Parser(bmG,pen);
            richTextBoxOutput.Text = richTextBoxOutput.Text + Parse.ParseCommand("syntax", prog, false, 0);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>+
        /// The button that opens the save file dialogue.
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();  
        }
        /// <summary>
        /// The button that opens the load file dialogue.
        /// </summary>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }
        /// <summary>
        /// Opens the file from the load file dialogue.
        /// </summary>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }
        /// <summary>
        /// Saves the file to the save file dialogue address.
        /// </summary>
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
        }

        private void newWindowThread()
        {
            ProgramWindow progform = new ProgramWindow();
            progform.ShowDialog();
            while (true) { }
        }

        private void newProgWind_Click(object sender, EventArgs e)
        {
            Thread newWindowThrd = new Thread(new ThreadStart(this.newWindowThread));
            newWindowThrd.SetApartmentState(ApartmentState.STA);
            newWindowThrd.Start();
        }
    }
}
