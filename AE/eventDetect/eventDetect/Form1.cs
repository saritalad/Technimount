using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eventDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        Button b = (Button)sender;
                        if (b == button2)
                            MessageBox.Show("button2");
                        else  if(b==button3 )

                            MessageBox.Show("button3");




        }

        private void button3_Click(object sender, EventArgs e)
        {Button [] buttonarry =new Button [3];
            Button b = (Button)sender;
         
            

            //string s = "unknown button";
            //if (b == button1)
            //{
            //    s = "button1";
            //}
            //else if (sender == button2)
            //{
            //    s = "button2";
            //}
            //MessageBox.Show("You pressed: " + s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
