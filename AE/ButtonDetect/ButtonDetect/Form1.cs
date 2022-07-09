using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Submit(object sender, EventArgs args)
        {String b1 = ((Button)sender).Text;
  Console.WriteLine(" b1:"+b1);
  if (b1 == "Register")
  {
      MessageBox.Show("You have clicked Rgister Button");
  }
  else
      if (b1 == "Submit")
          MessageBox.Show("you have clicked submit Button");
        
        }
        public   bool flag = false;
        public string correct = "radioButton1";
        public int marks = 0;
        public void radio(Object sender, EventArgs args)
        {
           
           RadioButton  R = (RadioButton)sender;
            string r1=((RadioButton )sender ).Text ;
            if (flag == false)
            {
                if ((r1 == correct) && (R.Checked == true))

                    marks += 1;

                else
                    marks += 0;

            }
            flag = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(marks.ToString ());
        }

        

        



    }
}
