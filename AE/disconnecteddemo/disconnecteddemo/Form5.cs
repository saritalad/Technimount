using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.currencymanager?view=windowsdesktop-6.0
namespace disconnecteddemo
{
    public partial class Form5 : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        SqlConnection con;
        SqlCommandBuilder bldr;
        CurrencyManager myCurrencyManager;
        DataTable dt;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=abccomputer;Database=synergeticsDB;Integrated security=true");
            da = new SqlDataAdapter("Select customerid,contactname,city,country from customers", con);
            ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "cust");
            bldr = new SqlCommandBuilder(da);
            dt = new DataTable();
            dt = ds.Tables["cust"];
            dataGridView1.DataSource = ds.Tables["cust"];
            myCurrencyManager = (CurrencyManager)this.BindingContext[dt];
            // Set the initial Position of the control.
            myCurrencyManager.Position = 0;
            textBox1.DataBindings.Add("text", ds.Tables[0], "customerId");
            textBox2.DataBindings.Add("text", ds.Tables[0], "contactName");
            textBox3.DataBindings.Add("text", ds.Tables[0], "City");
            textBox4.DataBindings.Add("text", ds.Tables[0], "country");
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            myCurrencyManager.Position = 0;
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
              myCurrencyManager.Position = myCurrencyManager.Count - 1;
        }
    }
}
