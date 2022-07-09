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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static OracleCommand com;
        public static OracleDataReader dr;
        public static DataTable dt;
        public static OracleConnection con;
        public CurrencyManager myCurrencyManager;
        [Obsolete]
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.STUDENTS' table. You can move, or remove it, as needed.
       
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            try
            {
                 con = new OracleConnection(connectstring);


                com = new OracleCommand();
                com.Connection = con;
                com.CommandText = "select id,firstname,lastname,marks from students";
                con.Open();
                dr = com.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView1.DataSource = dt;
                myCurrencyManager = (CurrencyManager)this.BindingContext[dt];
                myCurrencyManager.Position = 0;
            }
            catch (System.Data.OracleClient.OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try { 
            com = new OracleCommand();
                com.Connection = con;
                com.CommandText = "insert into students(id,firstname,lastname,marks)values(:1,:2,:3,:4)";
             
                OracleParameter p1 = new OracleParameter("1", OracleDbType.Int32, txtId.Text, ParameterDirection.Input);
                com.Parameters.Add(p1);
                OracleParameter p2 = new OracleParameter("2", OracleDbType.Varchar2, txtfname.Text, ParameterDirection.Input);
                com.Parameters.Add(p2);
                OracleParameter p3 = new OracleParameter("3", OracleDbType.Varchar2, txtlname.Text, ParameterDirection.Input);
                com.Parameters.Add(p3);
                OracleParameter p4 = new OracleParameter("4", OracleDbType.Int32, txtmarks.Text, ParameterDirection.Input);
                com.Parameters.Add(p4);
              
                con.Open();

                int aff=  com.ExecuteNonQuery();
                MessageBox.Show("Record added successfully" +aff);
               

                }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OracleCommand();
                com.Connection = con;
                com.CommandText = "update students set firstname=:2,lastname=:3,marks=:4 where id =:1";
               // com.CommandText = "update students set firstname=:fname,lastname=:lname,marks=:marks where id =:id";
                com.BindByName = true;
                //OracleParameter fname = new OracleParameter( );
                //fname.ParameterName = "fname";
                //fname.OracleDbType = OracleDbType.Varchar2;
                //fname.Value = txtfname.Text;
                //com.Parameters.Add(fname);
                //OracleParameter lname = new OracleParameter();
                //lname.ParameterName = "lname";
                //lname.OracleDbType = OracleDbType.Varchar2;
                //lname.Value = txtlname.Text;
                //com.Parameters.Add(lname);
                //OracleParameter marks = new OracleParameter();
                //marks.ParameterName = "marks";
                //marks.OracleDbType = OracleDbType.Int32;
                //marks.Value = Convert.ToInt32(txtmarks.Text);
                //com.Parameters.Add(marks);
                //OracleParameter id = new OracleParameter();
                //id.ParameterName = "id";
                //id.OracleDbType = OracleDbType.Int32;
                //id.Value = Convert.ToInt32(txtId.Text);
                //com.Parameters.Add(id);
                OracleParameter p1 = new OracleParameter("1", OracleDbType.Int32, txtId.Text, ParameterDirection.Input);
                com.Parameters.Add(p1);
                OracleParameter p2 = new OracleParameter("2", OracleDbType.Varchar2, txtfname.Text, ParameterDirection.Input);
                com.Parameters.Add(p2);
                OracleParameter p3 = new OracleParameter("3", OracleDbType.Varchar2, txtlname.Text, ParameterDirection.Input);
                com.Parameters.Add(p3);
                OracleParameter p4 = new OracleParameter("4", OracleDbType.Int32, txtmarks.Text, ParameterDirection.Input);
                com.Parameters.Add(p4);

                con.Open();
                int aff= com.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully "+ aff);

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCurrencyManager.Position = myCurrencyManager.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCurrencyManager.Position = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myCurrencyManager.Position == 0)
            {
                MessageBox.Show("You're at the beginning of the records.");
            }
            else
            {
                myCurrencyManager.Position -= 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myCurrencyManager.Position == myCurrencyManager.Count - 1)
            {
                MessageBox.Show("You're at end of the records");
            }
            else
            {
                myCurrencyManager.Position += 1;
            }
        }
    }
}