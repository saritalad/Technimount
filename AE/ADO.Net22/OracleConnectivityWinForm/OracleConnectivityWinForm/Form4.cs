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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static OracleCommand com;
        public static OracleDataAdapter da;
        public static DataTable dt;
        public static OracleConnection con;
        public static DataSet ds;
       

        private void Form4_Load(object sender, EventArgs e)
        {
           
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            con = new OracleConnection(connectstring);
            com = new OracleCommand();
            com.Connection = con;
            com.CommandText = "select Id,countryname from country";
            da = new OracleDataAdapter();
            ds = new DataSet();
            da.SelectCommand = com;
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "countryname";
            //  refreshdata();


        }

    


            public void refreshdata()
        {
           // string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            //  con = new OracleConnection(connectstring);
             com = new OracleCommand();
              com.Connection = con;
              com.CommandText = "select Id,countryname from country";
             da = new OracleDataAdapter();
             ds = new DataSet();
            da.SelectCommand = com;
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "countryname";
            comboBox1.Text = "Select --- Country";

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label3.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            label4.Text = comboBox1.GetItemText(comboBox1.SelectedValue);
            int countryId = Convert.ToInt32(label4.Text);
            if(countryId!=null)
            {
                com = new OracleCommand();
                com.Connection = con;
                com.CommandText = "select Id,statename from State where countryid=:1";
                OracleParameter p = new OracleParameter("1", OracleDbType.Int32, label4.Text, ParameterDirection.Input);
                com.Parameters.Add(p);
                da = new OracleDataAdapter(com);
                ds = new DataSet();
                da.Fill(ds);

                comboBox2.DataSource = ds.Tables[0];
                comboBox2.ValueMember = "id";
                comboBox2.DisplayMember = "statename";
                comboBox2.Text = "Select --- State";

            }


        }
    }
}
