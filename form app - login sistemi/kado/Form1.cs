using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if (textBox1.Text.Length < 3)
            {
                label3.Text = "Lütfen Bir Kullanıcı Adı Gir!";
            }
            else if (textBox2.Text.Length < 3)
            {
                label3.Text = "Lütfen Geçerli Bir Sifre Belirt!";
            }
            else
            {

                if (textBox1.Text == "Kado" && textBox2.Text == "0000")
                {
                    label3.Text = "Giris Başarili";     
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    label3.Text = "Hatalı Giris!";
                }
            }
        }
    }
}
