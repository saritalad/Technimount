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
    public partial class StudentRegForm : Form
    {
        public StudentRegForm()
        {
            InitializeComponent();
        }
       
        private void StudentRegForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
          
            textBox4.Enabled = false;
        }
        string gen,other=" ";
        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked ==true )
            gen="Mr ";
        else 
            gen="Ms ";
        string s = "";

        if (checkBox1.Checked == true)
            other = textBox4.Text;

        for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            s = s +"   , "+ checkedListBox1.CheckedItems[i].ToString();
       
            
            
            txtdetails.Text = "Name :" + gen + txtfirstname.Text + " " +
            txtlastname.Text 
            + System.Environment.NewLine + "Address :"
            +txtaddress .Text +"Courses Selected: "+s+other+
           System.Environment.NewLine + "Date of Birth :" + dateTimePicker1.Text;
      
            
            string dob = dateTimePicker1.Text;
        MessageBox.Show(dob);
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox4.Enabled = true;
            else
                textBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Combo_Example f1 = new Combo_Example();
            f1.Show();
            this.Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

              
    }
}
