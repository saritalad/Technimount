using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace OracleConnectivityWinForm
{
    public partial class Form5 : Form
    {
        public static OracleCommand com;
        public static OracleDataAdapter da;
        public static DataTable dt;
        public static OracleConnection con;
        public static DataSet ds;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            try
            {

                con = new OracleConnection(connectstring);
                con.Open();
                da = new OracleDataAdapter("select id,depname from dept", con);
                ds = new DataSet();
                da.Fill(ds);
                listBox1.DataSource = ds.Tables[0];
                listBox1.DisplayMember = "depname";
                listBox1.ValueMember = "Id";

            }
            catch (OracleException ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OracleCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "remove_dept";
                OracleParameter p = new OracleParameter("1", OracleDbType.Int32, txtId.Text, ParameterDirection.Input);
                com.Parameters.Add(p);
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Recored removed");
               
            }
            catch (OracleException ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OracleCommand();
                com.Connection = con;
                com.CommandText="select max(id) from dept";
                con.Open();
                int count = Convert.ToInt32(com.ExecuteScalar());

                //   MessageBox.Show(count.ToString());
                com.Parameters.Clear();
                count++;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Add_dept";
                OracleParameter p1 = new OracleParameter("1", OracleDbType.Int32,count, ParameterDirection.Input);
                com.Parameters.Add(p1);
                OracleParameter p2 = new OracleParameter("2", OracleDbType.Varchar2, txtDept.Text, ParameterDirection.Input);
                com.Parameters.Add(p2);
                com.ExecuteNonQuery();
                MessageBox.Show("Dept added successfully");

            }
            catch (OracleException ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}