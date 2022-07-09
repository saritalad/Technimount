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
    public partial class MDIParent1 : Form
    {
     

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void radioButtonExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRegForm sd = new StudentRegForm();
            sd.Show();
        }

        private void arithmeticOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aritmetic_opFrm f = new Aritmetic_opFrm();
            f.Show();
        }

        private void planetExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planet_Example p = new Planet_Example();
            p.Show();

        }

        private void trToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeViewExample t = new TreeViewExample();
            t.Show();
        }

        private void newNodeExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNodeExample n = new NewNodeExample();
            n.Show();
        }

        private void textBoxEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEventExample t = new TextEventExample();
            t.Show();
        }

        private void dialogOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog_Example d = new Dialog_Example();
            d.Show();

        }

        private void graphicMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GDI_Demo g = new GDI_Demo();
            g.Show();
        }

        private void printDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialogs p = new PrintDialogs();
            p.Show();

        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaintBrushFrm p = new PaintBrushFrm();
            p.Show();

        }

        private void buttonControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunTimeButtons r = new RunTimeButtons();
            r.Show();
        }

        private void comboPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combo_Example cb = new Combo_Example();
            cb.Show();
        }

      

       

    
      

      
        }
    }

