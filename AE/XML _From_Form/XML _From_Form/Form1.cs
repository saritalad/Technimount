using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml ;

namespace XML__From_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            XmlTextWriter wtr = new XmlTextWriter(@"E:\Employee.xml", null);
            //wtr.Formatting = Formatting.Indented;
            wtr.WriteStartDocument();
            wtr.WriteStartElement("Employee");
            wtr.WriteStartElement("EmpNo");
            wtr.WriteString(txtNo.Text);
            wtr.WriteEndElement();
            wtr.WriteStartElement("Name");
            wtr.WriteString(txtName.Text);
            wtr.WriteEndElement();
            wtr.WriteStartElement("Salary");
            wtr.WriteString(txtSalary.Text);
            wtr.WriteEndElement();
            wtr.WriteEndElement();
            wtr.Close();
            MessageBox.Show("XML File Written");
            txtNo.Clear();
            txtName.Clear();
            txtSalary.Clear();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            XmlTextReader rdr = new XmlTextReader(@"E:\Employee.xml");
            string sName = null;
            while (rdr.Read())
            {
                switch (rdr.NodeType)
                {

                    case XmlNodeType.Element:
                        sName = rdr.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (sName)
                        {
                            case "EmpNo":
                                txtNo.Text = rdr.Value;
                                break;
                            case "Name":
                                txtName.Text = rdr.Value;
                                break;
                            case "Salary":
                                txtSalary.Text = rdr.Value;
                                break;

                        }
                        break;
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}