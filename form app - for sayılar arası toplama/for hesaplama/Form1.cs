using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int start = Convert.ToInt32(textBox1.Text);
            int stop = Convert.ToInt32(textBox2.Text);
            if (start > stop)
            {

            for (int i = start; i < stop; i++)
            {
                toplam = toplam + i;
            }

            }
            else
            {
                for (int i = stop; i > start; i--)
                {
                toplam = toplam + i;
                    
                }

            }
            MessageBox.Show("Sonuç: "+toplam.ToString(),"For Toplam Sayı Hesaplama");
        }
    }
}
