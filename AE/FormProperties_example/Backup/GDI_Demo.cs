using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace FormProperties_example
{
    public partial class GDI_Demo : Form
    {
        public GDI_Demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red);
            Point p1 = new Point(20, 100);
            Point p2 = new Point(20, 200);
           // dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
          
            dc.DrawLine(redPen, p1, p2);
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue);
            Rectangle rect = new Rectangle(new Point(50, 100),
                new Size(400,700));
            dc.DrawRectangle(bluePen, rect);
            Brush br = new HatchBrush(HatchStyle.DashedDownwardDiagonal ,
                Color.Aquamarine, Color.BurlyWood);
            dc.FillRectangle(br, rect);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Chocolate);
            dc.DrawEllipse(bluePen, 30, 30, 200, 200);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen myPen = new Pen(Color.Violet, 2);

            Point[] points = new Point[3];
            points[0] = new Point(25, 30);
            points[1] = new Point(50, 45);
            points[2] = new Point(80, 30);
            dc.DrawPolygon(myPen, points);
            dc.FillPolygon(Brushes.Aqua, points);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font font = new Font("Ärial", 14);
            SolidBrush s = new SolidBrush(Color.CornflowerBlue );
            g.DrawString("Welcome  to Seed Infotech Ltd", font, 
                s, 12, 57);
            
               }
        private void button4_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush s1 = new SolidBrush(Color.Red);
            Font font1 = new Font("JokerMan", 10);
            e.Graphics.DrawString("Sarita", font1, s1, 7, 3);
        }
    }
}
