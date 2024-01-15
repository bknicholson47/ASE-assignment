namespace Software_assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Run = new System.Windows.Forms.Button();
            this.Syntax = new System.Windows.Forms.Button();
            Form1.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            Form1.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.newProgWind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(Form1.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(386, 547);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Syntax
            // 
            this.Syntax.Location = new System.Drawing.Point(467, 547);
            this.Syntax.Name = "Syntax";
            this.Syntax.Size = new System.Drawing.Size(75, 23);
            this.Syntax.TabIndex = 1;
            this.Syntax.Text = "Syntax";
            this.Syntax.UseVisualStyleBackColor = true;
            this.Syntax.Click += new System.EventHandler(this.Syntax_Click);
            // 
            // pictureBox1
            // 
            Form1.pictureBox1.BackColor = System.Drawing.Color.White;
            Form1.pictureBox1.Location = new System.Drawing.Point(585, 12);
            Form1.pictureBox1.Name = "pictureBox1";
            Form1.pictureBox1.Size = new System.Drawing.Size(600, 500);
            Form1.pictureBox1.TabIndex = 2;
            Form1.pictureBox1.TabStop = false;
            Form1.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 500);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 549);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(467, 518);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(386, 518);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // richTextBoxOutput
            // 
            Form1.richTextBoxOutput.Location = new System.Drawing.Point(12, 576);
            Form1.richTextBoxOutput.Name = "richTextBoxOutput";
            Form1.richTextBoxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            Form1.richTextBoxOutput.Size = new System.Drawing.Size(530, 96);
            Form1.richTextBoxOutput.TabIndex = 7;
            Form1.richTextBoxOutput.Text = "";
            // 
            // newProgWind
            // 
            this.newProgWind.Location = new System.Drawing.Point(12, 518);
            this.newProgWind.Name = "newProgWind";
            this.newProgWind.Size = new System.Drawing.Size(141, 23);
            this.newProgWind.TabIndex = 8;
            this.newProgWind.Text = "New Program Window";
            this.newProgWind.UseVisualStyleBackColor = true;
            this.newProgWind.Click += new System.EventHandler(this.newProgWind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 687);
            this.Controls.Add(this.newProgWind);
            this.Controls.Add(Form1.richTextBoxOutput);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(Form1.pictureBox1);
            this.Controls.Add(this.Syntax);
            this.Controls.Add(this.Run);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(Form1.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Syntax;
        static public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        static public System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button newProgWind;
    }
}

