using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OracleAppsettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ConString
        public static OracleCommand com;
        public static OracleDataAdapter da;
        public static DataTable dt;
        public static OracleConnection con;
        public static DataSet ds;
        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            try
            {
  
                con = new OracleConnection(ConfigurationManager.ConnectionStrings["myconnect"].ConnectionString);
                con.Open();
                da = new OracleDataAdapter("select id,depname from dept", con);
                ds = new DataSet();
                da.Fill(ds);
                listBox1.DataSource = ds.Tables[0];
                listBox1.DisplayMember = "depname";
                listBox1.ValueMember = "Id";
               
            }
            catch(OracleException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com = new OracleCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "remove_dept";
            OracleParameter p = new OracleParameter("1", OracleDbType.Int32, txtId.Text, ParameterDirection.Input);
            com.Parameters.Add(p);
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Recored removed");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
