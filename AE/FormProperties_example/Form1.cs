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
    public partial class Form1 : Form
    {
        string salutation = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)

                salutation = "Mr ";
            else
                salutation = "Ms ";
   
    //  
        //  
            MessageBox.Show("Hello " +salutation + textBox1.Text + " " + textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(212, 120, 210);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orange;
        }

        private void s(object sender, EventArgs e)
        {

        }
    }
}
