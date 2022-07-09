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
    public partial class TextEventExample : Form
    {
        public TextEventExample()
        {
            InitializeComponent();
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = Convert.ToInt32(e.KeyChar);
           
            if ((i >= 48) && (i <= 57) ||(i==8))
            {
                e.Handled = false;
            } 
            else
            {
                MessageBox.Show("enter only digits");
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 200)
            {
                i += 10;
                txtcounter.Text = i.ToString();
            }
           

        }
    }
}
