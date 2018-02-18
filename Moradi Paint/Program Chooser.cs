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
    public partial class Program_Chooser : Form
    {
        public Program_Chooser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Moradi_PhotoShop mp = new Moradi_PhotoShop();

            if (comboBox1.SelectedItem == "Moradi Paint")
            {
                f1.Show();
                Program_Chooser pc = new Program_Chooser();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (comboBox1.SelectedItem == "Moradi Photoshop")
                {
                    mp.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    MessageBox.Show("Please make a selection then click open.", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }
    }
}
