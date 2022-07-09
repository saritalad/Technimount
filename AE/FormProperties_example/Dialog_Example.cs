using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormProperties_example
{
    public partial class Dialog_Example : Form
    {
        public Dialog_Example()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe m = new AboutMe();
            m.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr =
                    new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.OverwritePrompt = true;
           saveFileDialog1.Filter = "Text Files(*.*)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Please Give FileName";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
               
             //   textBox1.Font= fontDialog1.Font;
            }
        }
         
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().
                GetDataPresent(DataFormats.Text))
                richTextBox1.Paste(); 

        }

        private void Dialog_Example_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(this, 
                "Good Bye", "Hello ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop);
            if (result == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                saveFileDialog1.CreatePrompt = true;
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.Filter = "Text Files(*.*)|*.txt|All Files(*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.Title = "Please Give FileName";
                DialogResult r = saveFileDialog1.ShowDialog();
                if (r == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
            }

        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut ();

        }

        private void cocopypyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Clipboard.GetDataObject().
                GetDataPresent(DataFormats.Text))
                richTextBox1.Paste(); 
        }

       
    }
}
