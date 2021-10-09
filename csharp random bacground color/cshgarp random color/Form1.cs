using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshgarp_random_color
{
    public partial class Form1 : Form
    {     
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void kado()
        {
            Random obj = new Random();
            int r = obj.Next(255);
            int g = obj.Next(255);
            int b = obj.Next(255);
            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac % 2 == 1)
            {
                kado();
            }

            if (sayac == 2)
            {
                kado();
                sayac = 0;
            }
        }
    }
}
