using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayiprojeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kado = Convert.ToInt32(textBox1.Text);
            int toplam = kado-=1;
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kado = Convert.ToInt32(textBox1.Text);
            int toplam = kado += 1;
            textBox1.Text = toplam.ToString();
        }
    }
}
