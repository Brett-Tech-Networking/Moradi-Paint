using System;
using System.Drawing;
using System.Windows.Forms;

namespace Moradi_Paint
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Red, 5);
        public Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (radioButton1.Checked)
                p.Width = 1;
            else if (radioButton2.Checked)
                p.Width = 5;
            else if (radioButton3.Checked)
                p.Width = 10;
            else if (radioButton4.Checked)
                p.Width = 15;
            else if (radioButton5.Checked)
                p.Width = 30;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Lime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

  
        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Invalidate();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
    

