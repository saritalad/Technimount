using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
namespace FormProperties_example
{
    public partial class PrintDialogs : Form
    {
        public PrintDialogs()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Welcome To Seed Infotech",
                new Font("Arial", 20, FontStyle.Bold),
                Brushes.BlueViolet, 120, 30); 
        }

       
        private PageSettings pgsettings = new PageSettings();
        private void pageSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog psdlg = new PageSetupDialog();
            psdlg.PageSettings = pgsettings;
            psdlg.AllowOrientation = true;
            psdlg.AllowMargins = true;
            psdlg.ShowDialog();
           

        }

        private void printPreViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDocument1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        
    }
}
