using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormProperties_example
{
    public partial class Planet_Example : Form
    {
        public Planet_Example()
        {
            InitializeComponent();
        }
        string path;
       double  Ew, Pw;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  path = "D:\\A_Seed\\Window Applications\\FormProperties_example\\Images\\"+listBox1 .SelectedItem .ToString ()+ ".bmp";
            path = Application.StartupPath+"\\Images\\"+listBox1 .SelectedItem .ToString ()+ ".bmp";
            pictureBox1.Image = Image.FromFile(path);
            lblplanet.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ew = Convert.ToDouble(txtWt_Earth.Text );
            string planet=listBox1 .SelectedItem .ToString ();
            switch (planet)
            {
                case "Aircraft": lblWt_planet.Text = "Weight can not be found ,Zero gravity";
                    break;
                case "Sun": lblWt_planet.Text = "Weight can not be found You Get Burnt out!!!";
                    break;
                case "Earth": lblWt_planet.Text = txtWt_Earth.Text;
                    break ;
                case "saturn":
                    Pw = Ew * 95.2;
                    lblWt_planet.Text = Pw.ToString() + " Kg";
                    break;
                case "Mars":
                                 Pw = Ew * 0.107;
                                lblWt_planet.Text = Pw.ToString()+" Kg";
                                 break;
                case "Jupitor": Pw = Ew * 317.8;
                                 lblWt_planet.Text = Pw.ToString() + " Kg";
                                 break;
                case "Moon": Pw = Ew * 0.0123f;

                                 lblWt_planet.Text = Pw.ToString() + " Kg";
                                 break;
                case "Mercury": Pw = Ew * 0.0553f;

                                 lblWt_planet.Text = Pw.ToString() + " Kg";
                                 break;
                case "Venus": Pw = Ew*0.815f;
                                 lblWt_planet.Text = Pw.ToString() + " Kg";
                    break;
            }





            }

        private void Planet_Example_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

       






        }
    }

