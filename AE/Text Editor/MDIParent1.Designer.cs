namespace Text_Editor
{
    partial class MDIParent1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.formPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPropertiesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // formPropertiesToolStripMenuItem
            // 
            this.formPropertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textExampleToolStripMenuItem});
            this.formPropertiesToolStripMenuItem.Name = "formPropertiesToolStripMenuItem";
            this.formPropertiesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.formPropertiesToolStripMenuItem.Text = "FormProperties";
            // 
            // textExampleToolStripMenuItem
            // 
            this.textExampleToolStripMenuItem.Name = "textExampleToolStripMenuItem";
            this.textExampleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.textExampleToolStripMenuItem.Text = "Text_Example";
            this.textExampleToolStripMenuItem.Click += new System.EventHandler(this.textExampleToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem formPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textExampleToolStripMenuItem;
    }
}



