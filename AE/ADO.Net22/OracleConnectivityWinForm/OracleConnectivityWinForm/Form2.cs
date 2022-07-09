using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace OracleConnectivityWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OracleCommand com;
        OracleDataAdapter da;
        OracleCommandBuilder bldr;
        DataSet ds;


        private void Form2_Load(object sender, EventArgs e)
        {
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            try {
                OracleConnection con = new OracleConnection(connectstring);
              
               
                com = new OracleCommand();
                com.Connection = con;
                com.CommandText = "select id, name from demo";
                da = new OracleDataAdapter(com);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds,"cust");
                           
                dataGridView1.DataSource = ds.Tables[0];
                textBox1.DataBindings.Add("text", ds.Tables[0], "id");
                textBox2.DataBindings.Add("text", ds.Tables[0], "name");
                bldr = new OracleCommandBuilder(da);
            }
           catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow drnew = ds.Tables["cust"].NewRow();
            drnew["id"] = textBox1.Text;
            drnew["name"] = textBox2.Text;
            ds.Tables["cust"].Rows.Add(drnew);
            da.Update(ds, "cust");
            MessageBox.Show("Record added");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows.Find(textBox1.Text);
            dr["name"] = textBox2.Text;
            da.Update(ds, "cust");
            MessageBox.Show("updated..");
            dataGridView1.DataSource = ds.Tables[0];
        }

        
    }
}
