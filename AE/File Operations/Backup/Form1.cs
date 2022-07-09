using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string DirectoryName = @"D:\\urDirectory";
        string s = @"D:\\";
        string imagename;
    
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo dv = new DriveInfo(s);
            textBox1.Text = dv.AvailableFreeSpace.ToString();
            textBox1.Text  += dv.Name;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DirectoryName))
            { MessageBox.Show("Dir Exists"); }

            else
            {
                DirectoryInfo d = new DirectoryInfo(DirectoryName);
                d.Create();
                Directory.CreateDirectory(DirectoryName);
                MessageBox.Show("created");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = @"C:\\Settings\\CurrentSettings-2012-01-09.vssettings.txt";
MessageBox .Show (Path .GetFileName (s));
            MessageBox .Show (Path .GetFullPath (s));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string FileName = @"D:\\urDirectory\\yyx.dat";
            if (File.Exists(FileName))
                MessageBox.Show("Exits ");
            else
            {
                FileInfo f = new FileInfo(s);
                f.Create();
                File.Create(FileName);
                MessageBox.Show("file created");
            }
   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            { //first use this code to write a number from textbox1 to file then comment it and open code for reading
                //FileStream fs = new FileStream("D:\\urDirectory\\myfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //BinaryWriter bw = new BinaryWriter(fs);
                //int x = Convert.ToInt32(textBox1.Text);
                //bw.Write(x);
                //bw.Close();
                //fs.Close();
                FileStream fs = new FileStream(@"D:\\urDirectory\\myfile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                MessageBox.Show(br.ReadInt32().ToString());
                br.Close();
                fs.Close();
            }
            catch (Exception m)
            { Console.Write(m.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog();
                //specify your own initial directory   fldlg.InitialDirectory = @":D\";    
                //this will allow only those file extensions to be added  
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                if (fldlg.ShowDialog() == DialogResult.OK)
                {
                    imagename = fldlg.FileName;
                    Bitmap newimg = new Bitmap(imagename);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictureBox1.Image = (Image)newimg;
                    pictureBox1.Image = Image.FromFile(imagename);
                }
                fldlg = null;


            }
            catch (System.ArgumentException ae)
            {
                imagename = " ";
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //code  to store in database as binary data.
            FileStream fs;
            fs = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
            //a byte array to read the image      
            //byte[] picbyte = new byte[fs.Length];
           
            //fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            //fs.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
