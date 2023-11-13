using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        userPen pen = new userPen(Color.Black,0,0,1,true);
        CommandBehavior C;
        public Form1()
        {
            InitializeComponent();
            bmG = Graphics.FromImage(myBitmap);
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
            Parser Parse = new Parser(bmG,pen);
            richTextBoxOutput.Text = richTextBoxOutput.Text + Parse.ParseCommand(mytext, prog, false);
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
            richTextBoxOutput.Text = richTextBoxOutput.Text + Parse.ParseCommand("syntax", prog, false);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
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
    }
}
