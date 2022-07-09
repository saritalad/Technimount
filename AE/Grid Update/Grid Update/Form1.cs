using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grid_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connetionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder cmdBuilder;
        DataSet ds = new DataSet();
        DataSet changes;
        string Sql;
 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connetionString = "Data Source=nalanda;Initial Catalog=SaritaDB;Integrated security=true";
            connection = new SqlConnection(connetionString);
            Sql = "select * from Employee";
            try
            {
           
                adapter = new SqlDataAdapter(Sql, connection);
                adapter.Fill(ds,"Emp");
            
                dataGridView1.DataSource = ds.Tables["Emp"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmdBuilder = new SqlCommandBuilder(adapter);
                changes = ds.GetChanges();
              
                if (changes != null)
                {
                    adapter.Update(changes,"Emp");
                }
                MessageBox.Show("Changes Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
