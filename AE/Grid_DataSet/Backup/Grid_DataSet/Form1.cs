using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grid_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal t = Convert.ToDecimal(textBox1.Text);
            employeeTableAdapter1.Fill(dataSet11.Employee, t);
            dataGridView1 .DataSource =dataSet11.Employee;
        }
    }
}
