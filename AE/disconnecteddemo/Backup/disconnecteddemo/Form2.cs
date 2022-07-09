using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace disconnecteddemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=lab1-demo;Database=Northwind;Uid=sa;pwd=sa");
            SqlDataAdapter masterda = new SqlDataAdapter("Select * from Depttable", con);
            SqlDataAdapter detailda = new SqlDataAdapter("Select * from Emptable", con);
            DataSet ds = new DataSet();
            masterda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            detailda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            masterda.Fill(ds, "Dept");
            detailda.Fill(ds, "Emp");
            DataRelation relation = new DataRelation("Dept_Emp", ds.Tables["Dept"].Columns["Deptid"], ds.Tables["Emp"].Columns["Deptid"]);
            ds.Relations.Add(relation);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.DataMember = "Dept_Emp";

        }
    }
}