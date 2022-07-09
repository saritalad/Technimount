using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace disconnecteddemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void depttableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.depttableBindingSource.EndEdit();
            this.depttableTableAdapter.Update(this.northwindDataSet1.Depttable);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Emptable' table. You can move, or remove it, as needed.
            this.emptableTableAdapter.Fill(this.northwindDataSet1.Emptable);
            // TODO: This line of code loads data into the 'northwindDataSet1.Depttable' table. You can move, or remove it, as needed.
            this.depttableTableAdapter.Fill(this.northwindDataSet1.Depttable);

        }
    }
}