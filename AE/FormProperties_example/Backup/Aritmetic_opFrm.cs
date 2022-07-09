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
    public partial class Aritmetic_opFrm : Form
    {
        int a, b, c;
        public Aritmetic_opFrm()
        {
            InitializeComponent();
        }
        int i, j,total=0; 
        string[] perfumes = { "Sandalwood", "Jasmine", "Rose", "Park Avenue" };
        string[] soaps = { "Liril", "Doves", "Pears", "Hamam", "Rexona" };
        int[] costofperfume = { 160, 240, 340, 670 };
        int[] costofsoap = { 25, 34, 45, 18, 15 };

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(txtnumberA.Text);
                b = Convert.ToInt32(txtnumberB.Text);
                c = a + b;
                txtResult.Text = c.ToString();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnumberA.Clear();
            txtnumberB.Clear();
            txtResult.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(txtnumberA.Text);
                b = Convert.ToInt32(txtnumberB.Text);
                c = a - b;
                txtResult.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Aritmetic_opFrm_Load(object sender, EventArgs e)
        {
            SoapCombo.Items.AddRange(soaps);
            Perfumecombo.Items.AddRange(perfumes);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s1 = SoapCombo.Text;
            string s2 = Perfumecombo.Text;
            listBox1.Items.Add(s1);
            listBox1.Items.Add(s2);


            i = costofsoap[SoapCombo.SelectedIndex];
            j = costofperfume[Perfumecombo.SelectedIndex];
            total += i;
            total += j;
            MessageBox.Show("cost of selected soap and perfume is " + total.ToString());

                  }
    }
}
