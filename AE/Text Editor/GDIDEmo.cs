using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;



namespace Text_Editor
{
    public partial class GDI_DEmo : Form
    {
        public GDI_DEmo()
        {
            InitializeComponent();
        }
        InstalledFontCollection fnt = new InstalledFontCollection();
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red);
            Point p1 = new Point(20, 80);
            Point p2 = new Point(50, 190);
            dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            dc.DrawLine(redPen, p1, p2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue);
            Rectangle rect = new Rectangle(new Point(50, 100), new Size(50, 100));
            dc.DrawRectangle(bluePen, rect);
            Brush br = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Firebrick,Color.Yellow);
            dc.FillRectangle(br, rect);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Chocolate);
          //  Rectangle rect = new Rectangle(new Point(150, 100), new Size(50, 50));
           // dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            dc.DrawEllipse(bluePen, 10,10,200,200);
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen myPen = new Pen(Color.Violet, 3);

            Point[] points = new Point[3];
            points[0] = new Point(25, 30);
            points[1] = new Point(50, 45); 
            points[2] = new Point(80, 30);

            dc.DrawPolygon(myPen, points);
            dc.FillPolygon(Brushes.Aqua, points);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font font = new Font("Ärial", 14);
            SolidBrush s = new SolidBrush(Color.BurlyWood);
            g.DrawString("Welcome  to Seed Infotech", font, s, 2, 3);
                     
        
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush s1 = new SolidBrush(Color.Red);
            Font font1 = new Font("Arial", 7);
            e.Graphics.DrawString("Hello", font1, s1, 2, 2);
        }

        private void GDI_DEmo_Load(object sender, EventArgs e)
        {
            foreach (FontFamily f in fnt.Families)
                comboBox1.Items.Add(f.Name  );
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { string f=comboBox1 .SelectedItem .ToString ();
        textBox1.Font = new Font(f,12, FontStyle.Bold);
        }
    } 
}
