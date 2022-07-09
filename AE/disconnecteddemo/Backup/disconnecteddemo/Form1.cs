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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter da;
        SqlConnection con;
        SqlCommandBuilder bldr;
        private void button4_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * from Emptable", con);
            ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds,"Emp");
          // bldr = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables["Emp"];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=lab1-demo;Database=Northwind;Uid=sa;pwd=sa");
            da = new SqlDataAdapter("Select * from Emptable", con);
            ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Emp");
             bldr = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables["Emp"];
            textBox1.DataBindings.Add("text", ds.Tables[0], "Eid");
            textBox2.DataBindings.Add("text", ds.Tables[0], "Ename");
            textBox3.DataBindings.Add("text", ds.Tables[0], "Location");
            textBox4.DataBindings.Add("text", ds.Tables[0], "Deptid");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow drnew = ds.Tables["Emp"].NewRow();
            drnew["Eid"] = textBox1.Text;
            drnew["Ename"] = textBox2.Text;
            drnew["Location"] = textBox3.Text;
            drnew["Deptid"] = textBox4.Text;
            ds.Tables["Emp"].Rows.Add(drnew);
            da.Update(ds,"Emp");
            MessageBox.Show("Record added");
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Tables["Emp"].Rows.Find(textBox1.Text).Delete();
            da.Update(ds, "Emp");
            MessageBox.Show("Record deleted..");
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows.Find(textBox1.Text);
            dr["Ename"] = textBox2.Text;
            dr["Location"] = textBox3.Text;
            dr["Deptid"] = textBox4.Text;
            da.Update(ds, "Emp");
            MessageBox.Show("updated..");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow drnew = ds.Tables["Emp"].NewRow();
            drnew["Eid"] = textBox1.Text;
            drnew["Ename"] = textBox2.Text;
            drnew["Location"] = textBox3.Text;
            drnew["Deptid"] = textBox4.Text;
            ds.Tables["Emp"].Rows.Add(drnew);
            da.InsertCommand = new SqlCommand("Insert into Emptable values(" + Convert.ToInt32(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + Convert.ToInt32(textBox4.Text) + ")", con);
                
            da.Update(ds, "Emp");
            MessageBox.Show("Record added");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ds.Tables["Emp"].Rows.Find(textBox1.Text).Delete();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@eid", textBox1.Text);

            cmd.Parameters.Add(p);
            da.DeleteCommand = cmd;
            da.Update(ds, "Emp");
            MessageBox.Show("Record deleted..");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = ds.Tables[0].Rows.Count - 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds.Tables[0]].Position > 0)
            {
                this.BindingContext[ds.Tables[0]].Position -= 1;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[ds.Tables[0]].Position < ds.Tables[0].Rows.Count-1)
            {
                this.BindingContext[ds.Tables[0]].Position += 1;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ds.WriteXml("D:\\data.xml", XmlWriteMode.WriteSchema);
        }
    }
}