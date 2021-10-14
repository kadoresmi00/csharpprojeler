using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace civciv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = pictureBox1.Left;
            i += 10;
            pictureBox1.Left = i;
            if (i >= 570)
            {
                pictureBox1.Left = 12;                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = pictureBox1.Left;
            i += 25;
            pictureBox1.Left = i;
            if (i >= 570)
            {
                pictureBox1.Left = 12;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = pictureBox2.Left;
            i += 10;
            pictureBox2.Left = i;
            if (i >= 570)
            {
                pictureBox2.Left = 12;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = pictureBox2.Left;
            i += 25;
            pictureBox2.Left = i;
            if (i >= 570)
            {
                pictureBox2.Left = 12;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 12;
            pictureBox2.Left = 12;
        }
    }
}
