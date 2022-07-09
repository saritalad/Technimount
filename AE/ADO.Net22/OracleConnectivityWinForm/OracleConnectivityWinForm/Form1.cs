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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DEMO' table. You can move, or remove it, as needed.
        
            OracleConnection con = new OracleConnection("TNS_ADMIN=C:\\Users\\HP\\Oracle\\network\\admin;USER ID=SARITA;DATA SOURCE=abccomputer");
            //TNS_ADMIN=C:\Users\HP\Oracle\network\admin;USER ID=SARITA;DATA SOURCE=abccomputer:1521/xe
        }

      
        private void LoadData()
        {
            try
            {
                string ConString = "TNS_ADMIN = C:\\Users\\HP\\Oracle\\network\\admin; USER ID = SARITA; password=sarita; DATA SOURCE = abccomputer";
        
                using (OracleConnection con = new OracleConnection(ConString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM Demo", con);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}