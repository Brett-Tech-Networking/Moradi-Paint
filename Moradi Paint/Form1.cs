using System;
using System.Drawing;
using System.Windows.Forms;

namespace Moradi_Paint
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public TextBox t = new TextBox();
        public Pen p = new Pen(Color.Red, 5);
        public Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = Panel2.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            // Enable drag-and-drop operations and 
            // add handlers for DragEnter and DragDrop.
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(this.Form1_Load);
            this.DragEnter += new DragEventHandler(this.Form1_Load);
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
            else if (radioButton6.Checked)
                p.Width = 40;
            else if (radioButton7.Checked)
                p.Width = 50;
            else if (radioButton8.Checked)
                p.Width = 60;
            else if (radioButton9.Checked)
                p.Width = 70;
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
            Panel2.Invalidate();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.Color = Color.DodgerBlue;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Not Yet Activated By Owner Please Wait For Newer Release", "Error");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Panel2.Invalidate();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.BackColor = Color.Red;
            p.Color = Color.Black;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.BackColor = Color.Black;

        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.BackColor = Color.Lime;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Panel2.BackColor == Color.Black)
            {
                p.Color = Color.Black;
                p.Width = 50;
            }
            {
                if (Panel2.BackColor == Color.Red)
                {
                    p.Color = Color.Red;
                    p.Width = 50;
                }
                {
                    if (Panel2.BackColor == Color.Lime)
                    {
                        p.Color = Color.Lime;
                        p.Width = 50;
                    }
                   
                }
              
            }
        }

        private void faderMinimalTheme1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void faderControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.BackColor = Color.White;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}






