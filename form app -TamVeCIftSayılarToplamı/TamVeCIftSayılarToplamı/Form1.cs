using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamVeCIftSayılarToplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tamSayi = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            tamSayi = 1;
            for (int i = 1; i < 100; i++)
            {
                tamSayi = tamSayi + i++;
            }
            textBox1.Text = tamSayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tamSayi = 1;
            for (int i = 1; i < 100; i+=2)
            {
                tamSayi = tamSayi + i++;
            }
            textBox1.Text = tamSayi.ToString();
        }
    }
}
