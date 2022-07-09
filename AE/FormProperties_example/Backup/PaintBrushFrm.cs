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
    public partial class PaintBrushFrm : Form
    {
        public PaintBrushFrm()
        {
            InitializeComponent();
        }
        bool paint = false;
        SolidBrush mybrush;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                mybrush = new SolidBrush(Color .CornflowerBlue );
                Graphics g = panel1.CreateGraphics();
                g.FillEllipse(mybrush , e.X, e.Y, 6, 6);
                g.Dispose();
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }
    }
}
