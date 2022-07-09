using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet_Typed_UnTyped_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   Dataset has one table with column name firstName.

             DataSet ds = new DataSet();

            DataTable dt = new DataTable();

            DataColumn one = new DataColumn("FirstName");

            dt.Columns.Add(one);

            ds.Tables.Add(dt);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
