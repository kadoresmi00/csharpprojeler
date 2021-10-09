using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boy_kilo_endeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo = Convert.ToDouble(textBox1.Text);
            double boy = Convert.ToDouble(textBox2.Text);
            double sonuc = kilo / (boy * 2);
            if (sonuc <= 18.49)
            {
                MessageBox.Show("Endeksi= "+sonuc+" \nİdeal Kilonun Altı","Kado");
            }
            else if (sonuc >=18.5 && sonuc <= 24.99)
            {
                MessageBox.Show("Endeksi= " + sonuc + " \nİdeal Kilo", "Kado");
            }
            else if (sonuc >= 25 && sonuc <= 29.99)
            {
                MessageBox.Show("Endeksi= " + sonuc + " \nİdeal Kilo Üzeri", "Kado");
            }
            else if (sonuc > 30)
            {
                MessageBox.Show("Endeksi= " + sonuc + " \nİdeal Kilonun Çok Üzeri", "Kado");
            }
        }
    }
}
