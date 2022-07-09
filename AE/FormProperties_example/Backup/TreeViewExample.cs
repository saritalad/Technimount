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
    public partial class TreeViewExample : Form
    {
        public TreeViewExample()
        {
            InitializeComponent();
        }

        private void TreeViewExample_Load(object sender, EventArgs e)
        {
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "mainNode";               
            mainNode.Text = "Main";
            this.treeView2.Nodes.Add(mainNode);
            TreeNode fruit = new TreeNode();
            fruit.Name = "fruit";
            fruit.Text = "fruits";
            mainNode.Nodes.Add(fruit);
            TreeNode app = new TreeNode();
            app.Name = "Apple";
            app.Text = "Apples";
            fruit.Nodes.Add(app);
            TreeNode veg = new TreeNode();
           veg.Name = "Vegetable";
           veg.Text = "Vegetables";
           this.treeView2.Nodes.Add(veg);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);

        }
    }
}
