using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Pen p1 = new Pen(Color.Black, 2);
            Rectangle aRect = new Rectangle(70, 70, 50, 50);
            Point[] p2 = new Point[4];
            p2[0].X = 90; p2[0].Y = 240;
            p2[1].X = 110; p2[1].Y = 260;
            p2[2].X = 90; p2[2].Y = 280;
            p2[3].X = 70; p2[3].Y = 260;
            Point[] p = new Point[3];
            p[0].X = 80; p[0].Y = 80;
            p[1].X = 100; p[1].Y = 90;
            p[2].X = 85; p[2].Y = 100;
            gr.FillEllipse(Brushes.Gold, aRect);
            gr.DrawEllipse(p1, aRect);
            gr.FillPolygon(Brushes.Red, p);
            gr.DrawPolygon(p1, p);
            p[0].X = 60; p[0].Y = 120;
            p[1].X = 130; p[1].Y = 120;
            p[2].X = 90; p[2].Y = 170;
            gr.FillPolygon(Brushes.Pink, p);
            gr.DrawPolygon(p1, p);
            p[0].X = 10; p[0].Y = 130;
            p[1].X = 60; p[1].Y = 120;
            p[2].X = 40; p[2].Y = 165;
            gr.FillPolygon(Brushes.Blue, p);
            gr.DrawPolygon(p1, p);
            p[0].X = 130; p[0].Y = 120;
            p[1].X = 165; p[1].Y = 95;
            p[2].X = 170; p[2].Y = 140;
            gr.FillPolygon(Brushes.Blue, p);
            gr.DrawPolygon(p1, p);
            p[0].X = 90; p[0].Y = 170;
            p[1].X = 160; p[1].Y = 180;
            p[2].X = 90; p[2].Y = 240;
            gr.FillPolygon(Brushes.Pink, p);
            gr.DrawPolygon(p1, p);
            gr.FillPolygon(Brushes.Yellow, p2);
            gr.DrawPolygon(p1, p2);
            p2[0].X = 160; p2[0].Y = 180;
            p2[1].X = 180; p2[1].Y = 160;
            p2[2].X = 200; p2[2].Y = 180;
            p2[3].X = 180; p2[3].Y = 200;
            gr.FillPolygon(Brushes.Yellow, p2);
            gr.DrawPolygon(p1, p2);
            p[0].X = 90; p[0].Y = 280;
            p[1].X = 110; p[1].Y = 300;
            p[2].X = 90; p[2].Y = 320;
            gr.FillPolygon(Brushes.Blue, p);
            gr.DrawPolygon(p1, p);
            p[0].X = 200; p[0].Y = 180;
            p[1].X = 240; p[1].Y = 180;
            p[2].X = 220; p[2].Y = 200;
            gr.FillPolygon(Brushes.Blue, p);
            gr.DrawPolygon(p1, p);
            pictureBox1.Image = bmp;
        }
    }
}
