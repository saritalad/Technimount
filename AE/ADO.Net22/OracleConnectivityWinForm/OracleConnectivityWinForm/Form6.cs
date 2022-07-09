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

namespace OracleConnectivityWinForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static OracleCommand com;
        public static OracleDataAdapter da;
        public static DataTable dt;
        public static OracleConnection con;
        public static DataSet ds;

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            con = new OracleConnection(connectstring);
            com = new OracleCommand();
            com.Connection = con;
            com.CommandText = "select Id,name ,dob from birthdates";
            da = new OracleDataAdapter();
            ds = new DataSet();
            da.SelectCommand = com;
            da.Fill(ds);
           dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Parameters.Clear();
            com.CommandText = "insert into birthdates(id,name,dob) values(birthday_id.nextval,:1,:2)";
            OracleParameter p1 = new OracleParameter("1", OracleDbType.Varchar2, txtname.Text, ParameterDirection.Input);
            OracleParameter p2 = new OracleParameter("2", OracleDbType.Date,dobpker.Text, ParameterDirection.Input);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Record added successfully !");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com.Parameters.Clear();
            com.CommandText = "update  birthdates set name =:1,dob=:2 where id=:3";
            OracleParameter p1 = new OracleParameter("1", OracleDbType.Varchar2, txtname.Text, ParameterDirection.Input);
            OracleParameter p2 = new OracleParameter("2", OracleDbType.Date, dobpker.Text, ParameterDirection.Input);
            OracleParameter p3 = new OracleParameter("3", OracleDbType.Int32, txtid.Text, ParameterDirection.Input);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Record updated  successfully !");
            con.Close();
        }
    }
}
