using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Text_Editor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", 
      "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(res==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = pDoc;
            pDoc.Print();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = pDoc;
            printPreviewDialog1.ShowDialog();
        }

        PageSettings pg = new PageSettings();
        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = pg;
            pageSetupDialog1.ShowDialog();
        }

       
    }
}
