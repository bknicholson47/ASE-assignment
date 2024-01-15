using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_assignment
{
    public unsafe partial class ProgramWindow : Form
    {
        Parser Parse = new Parser(Form1.bmG, Form1.pen);
        public ProgramWindow()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            string prog = richTextBox1.Text;
            Form1.richTextBoxOutput.Invoke((Action)delegate { Form1.richTextBoxOutput.Text = Form1.richTextBoxOutput.Text + Parse.ParseCommand(mytext, prog, false); });
            //Form1.richTextBoxOutput.Text = Form1.richTextBoxOutput.Text + Form1.Parse.ParseCommand(mytext, prog, false);
            Form1.pictureBox1.Invoke((Action)delegate { Form1.pictureBox1.Image = Form1.myBitmap; });
            //Form1.pictureBox1.Image = Form1.myBitmap;
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

        private void Syntax_Click(object sender, EventArgs e)
        {

        }
    }
}