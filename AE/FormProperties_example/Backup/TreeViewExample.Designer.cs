namespace FormProperties_example
{
    partial class TreeViewExample
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Apple");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Grapes");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fruits", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bringle");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Capsicum");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ladies Finger");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Potato");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Vegetables", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Rose");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Lotus");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Jasmine");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Flowers", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Apple");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Fruits", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewExample));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(37, 33);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Tag = "Apple";
            treeNode1.Text = "Apple";
            treeNode2.Name = "Node2";
            treeNode2.Tag = "Grapes";
            treeNode2.Text = "Grapes";
            treeNode3.Name = "Node0";
            treeNode3.Tag = "Fruits";
            treeNode3.Text = "Fruits";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Bringle";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Capsicum";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Ladies Finger";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Potato";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Vegetables";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(121, 205);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(185, 33);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 150);
            this.treeView2.TabIndex = 1;
            // 
            // treeView3
            // 
            this.treeView3.ImageIndex = 0;
            this.treeView3.ImageList = this.imageList1;
            this.treeView3.Location = new System.Drawing.Point(185, 217);
            this.treeView3.Name = "treeView3";
            treeNode9.Name = "Node2";
            treeNode9.Tag = "Rose";
            treeNode9.Text = "Rose";
            treeNode10.Name = "Node3";
            treeNode10.Tag = "Lotus";
            treeNode10.Text = "Lotus";
            treeNode11.Name = "Node4";
            treeNode11.Tag = "Jasmine";
            treeNode11.Text = "Jasmine";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Node0";
            treeNode12.Tag = "Flowers";
            treeNode12.Text = "Flowers";
            treeNode13.Name = "Node5";
            treeNode13.Tag = "Apple";
            treeNode13.Text = "Apple";
            treeNode14.Name = "Fruits";
            treeNode14.Tag = "Fruits";
            treeNode14.Text = "Fruits";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode14});
            this.treeView3.SelectedImageIndex = 0;
            this.treeView3.Size = new System.Drawing.Size(121, 97);
            this.treeView3.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sunset.jpg");
            this.imageList1.Images.SetKeyName(1, "Blue hills.jpg");
            // 
            // TreeViewExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 326);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeViewExample";
            this.Text = "TreeViewExample";
            this.Load += new System.EventHandler(this.TreeViewExample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.ImageList imageList1;
    }
}