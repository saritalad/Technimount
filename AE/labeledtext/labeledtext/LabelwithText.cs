﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace labeledtext
{
    public partial class LabelwithText : UserControl 
    {
        public LabelwithText()
        {
            InitializeComponent();
        }
        public string myLabel
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string myText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }



    }
}
