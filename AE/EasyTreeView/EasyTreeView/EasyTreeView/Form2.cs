using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyTreeView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
     
         e.Graphics.DrawString("Welcome To Seed Infotech",
             new Font("Arial", 20, FontStyle.Bold),
             Brushes.BlueViolet , 120, 30); 
       //   e.GraphirawString("SampleText", new Font("Arial",20, FontStyle.Bold), Brushes.Beige, 120, 300);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
        
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //g.DrawString("SampleText", new Font("Arial", 20, FontStyle.Bold), Brushes.BlueViolet , 120, 30);

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
           // pageSetupDialog1.Document.DefaultPageSettings.Color = false;
            pageSetupDialog1.ShowDialog();

        }
    }
}
