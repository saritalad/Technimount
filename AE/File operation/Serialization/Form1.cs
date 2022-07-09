using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Employee
        {
            public int emp_no;
            public String Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\Ser.txt", FileMode.Create, FileAccess.Write);

            Employee e1 = new Employee();
            e1.emp_no = Convert.ToInt32(textBox1.Text);
            e1.Name = textBox2.Text;

            BinaryFormatter bfs = new BinaryFormatter();
            bfs.Serialize(fs, e1);
            MessageBox.Show("Ok!!!!!!!!!");
            textBox1.Clear();
            textBox2.Clear();
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("D:\\Ser.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bfs = new BinaryFormatter();
            Employee e2 = (Employee)bfs.Deserialize(fs1);
            textBox1.Text = Convert.ToString(e2.emp_no);
            textBox2.Text = e2.Name;

        }
    }
}
