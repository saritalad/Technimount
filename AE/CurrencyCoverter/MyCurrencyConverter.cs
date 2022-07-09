using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyCoverter
{
    public partial class MyCurrencyConverter : UserControl 
    {
        public MyCurrencyConverter()
        {
            InitializeComponent();
        }
        public int d = 0,rs=0;
        private void button1_Click(object sender, EventArgs e)
        {
            d = Convert.ToInt32(textBox1.Text);
            rs = d / 50;
            label1.Text = rs.ToString();

        }

        
    }
}
