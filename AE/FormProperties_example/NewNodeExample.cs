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
    public partial class NewNodeExample : Form
    {
        public NewNodeExample()
        {
            InitializeComponent();
        }

        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNodeFrm fr = new NewNodeFrm();
            fr.ShowDialog();

            TreeNode nod = new TreeNode();
            nod.Name = fr.NewNodeName.ToString();
            nod.Text = fr.NewNodeText.ToString();
            nod.Tag = fr.NewNodeTag.ToString();
            treeView1.SelectedNode.Nodes.Add(nod);


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
       //   MessageBox.Show(treeView1.SelectedNode.Text);
        }

      
    }
}
