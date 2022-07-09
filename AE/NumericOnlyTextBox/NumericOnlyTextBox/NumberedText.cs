using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumericOnlyTextBox
{
    public partial class NumberedText : UserControl
    {
        public NumberedText()
        {
            InitializeComponent();
        }
        bool flag =false;
        public bool IsNumeric
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (flag == true)
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                    flag = true;
                }
                else
                {
                    // does not allow other controls to handle the events
                    e.Handled = true;
                    MessageBox.Show("Pls enter numbers only");
                }
            }
            


        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
