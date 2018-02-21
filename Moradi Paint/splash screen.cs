using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradi_Paint
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int progress = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();

                //open main form
                Form1 f1 = new Form1();
                f1.Show();
            }
            progressBar1.Value = progress;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 30;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }
    }
}
