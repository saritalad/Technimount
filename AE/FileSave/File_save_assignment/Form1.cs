using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FILESAVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtRoll.Text = "";
            txtName.Text = "";
            txtMarks.Text = "";
            txtRoll.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//FileMode.Append
         //                .Create
            //             .CreateNew
            //            .Open
            //            .OpenOrCreate
            //            .Truncate
            //FileAccess.Read
            //                  .ReadWrite
            //                  .Write
            FileStream fs = new FileStream(@"e:\Student.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            int RollNo = Convert.ToInt32(txtRoll.Text);
            string Name = txtName.Text;
            double Marks = Convert.ToDouble(txtMarks.Text);
            sw.WriteLine(RollNo);
            sw.WriteLine(Name);
            sw.WriteLine (Marks);
            sw.WriteLine();
            sw.Close();
            MessageBox.Show("Data saved successfully!!!");
            clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream(@"e:\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            while ((s=sr.ReadLine())!=null)
            {
                lstDiplay.Items.Add(s);
            }    
           sr.Close();
        }

    }
}
