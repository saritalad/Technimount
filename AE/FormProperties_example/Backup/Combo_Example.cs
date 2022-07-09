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
    public partial class Combo_Example : Form
    {
        public Combo_Example()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
            label2.Text = comboBox1.SelectedIndex.ToString();
            label3.Text = comboBox1.Text;
        }

       
    }
}
