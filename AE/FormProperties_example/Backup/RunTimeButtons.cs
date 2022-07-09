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
    public partial class RunTimeButtons : Form
    {
        public RunTimeButtons()
        {
            InitializeComponent();
        }
        int counter, locY;

        private void mybuttoneventhandler(object sender, EventArgs e)
        {
            counter += 1;
            locY += button1.Height + 15;
            Button mybutton = new Button();
            mybutton.Name = "Button " + counter;
            mybutton.Text = "Button " + counter;
            mybutton.Location = new Point(button1.Location.X, locY);
            mybutton.Click += new System.EventHandler(this.mybuttoneventhandler);
            this.Controls.Add(mybutton);
        }
    }
}
