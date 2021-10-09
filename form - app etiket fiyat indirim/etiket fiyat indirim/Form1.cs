using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etiket_fiyat_indirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            double indirimfiyat = fiyat - fiyat * 0.10;
            label3.Text = indirimfiyat.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            double indirimfiyat = fiyat - fiyat * 0.25;
            label3.Text = indirimfiyat.ToString() + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            double indirimfiyat = fiyat - fiyat * 0.50;
            label3.Text = indirimfiyat.ToString() + " TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            double indirimfiyat = fiyat - fiyat * 0.75;
            label3.Text = indirimfiyat.ToString() + " TL";
        }
    }
}
