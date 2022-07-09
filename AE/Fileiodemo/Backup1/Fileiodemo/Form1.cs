using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Xml.Serialization;

namespace Fileiodemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        BinaryFormatter bf;
        XmlSerializer xser;
        ArrayList arr = new ArrayList();
       
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Z:\\Roles code.txt"))
            {
                File.Create("Z:\\Roles code.txt");
            }
            else
            {
                MessageBox.Show("file already exists..");
            }
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("Z:\\Roles code.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                emp._eid = Convert.ToInt32(textBox1.Text);
                emp._ename = textBox2.Text;
                sw.WriteLine(emp._eid);
                sw.WriteLine(emp._ename);
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("data written..");



            }
            catch (Exception ex)
            {
            }
            finally
            {
                sw.Close();

                fs.Close();
            }

        }
        Employee emp;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp = new Employee();
            arr = new ArrayList();
           
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("Z:\\Roles code.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(!File.Exists("Z:\\Roles code.txt"))
            {
                File.Create("Z:\\Roles code.txt");
            }

        }
        BinaryReader br;
        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("Z:\\Roles code.txt", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
               
                richTextBox1.Text = br.ReadInt32().ToString();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                br.Close();
                fs.Close();
            }
        }
        BinaryWriter bw;
        private void writwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("Z:\\Roles code.txt", FileMode.Append, FileAccess.Write);
                bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1.Text));
                bw.Close();
                
               
                fs.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
               
              
            }

        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Z:\\employees.dat", FileMode.Append, FileAccess.Write);
            bf = new BinaryFormatter();
            bf.Serialize(fs, arr);
            MessageBox.Show("serialized..");
            fs.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee eobj = new Employee();
            eobj._eid = Convert.ToInt32(textBox1.Text);
            eobj._ename = textBox2.Text;
            arr.Add(eobj);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
       {
        //    FileStream fs1 = new FileStream("Z:\\employees.dat", FileMode.Open, FileAccess.Read);
        //    BinaryFormatter bfs = new BinaryFormatter();
        //    Employee e2 = (Employee)bfs.Deserialize(fs1);
        //    textBox1.Text = Convert.ToString(e2._eid);
        //    textBox2.Text = e2._ename;
            ArrayList temp = new ArrayList();
            Employee tempemp;
            fs = new FileStream("Z:\\employees.dat", FileMode.Open, FileAccess.Read );
            bf = new BinaryFormatter();
            temp =(ArrayList)bf.Deserialize(fs);
            foreach (object o in temp)
            {
                tempemp = (Employee)o;
                textBox1.Text = tempemp._eid.ToString();
                textBox2.Text = tempemp._ename;
                //ListBox1.Items.Add(tempemp._eid.ToString() + " " + tempemp._ename);
            }
            fs.Close();
        }

        private void serializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee eobj = new Employee();
            eobj._eid = Convert.ToInt32(textBox1.Text);
            eobj._ename = textBox2.Text;
            fs = new FileStream("z:\\xmldata.xml", FileMode.Append, FileAccess.Write);
            xser = new XmlSerializer(typeof(Employee));
            xser.Serialize(fs, eobj);
            fs.Close();
            MessageBox.Show("serialized");

        }

        private void deserializeToolStripMenuItem1_Click(object sender, EventArgs e)

        {

            Employee eobj = new Employee();
            //eobj._eid = Convert.ToInt32(textBox1.Text);
            //eobj._ename = textBox2.Text;
            fs = new FileStream("Z:\\xmldata.xml", FileMode.Open, FileAccess.Read);
            xser = new XmlSerializer(typeof(Employee));
            eobj =(Employee)xser.Deserialize(fs);
            listBox1.Items.Add(eobj._eid.ToString() + " " + eobj._ename);
            fs.Close();
         //   MessageBox.Show("serialized");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}