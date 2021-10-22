using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasarıTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kado = 0;
        int kadoo = 0;
        string kadooxd;
        private void button1_Click(object sender, EventArgs e)
        {
            kado = 0;
            kadoo = 0;
            if (radioButton4.Checked == true)
            {
                kado = kado + 1;
            }
            else
            {
                kadoo = kadoo + 1;
            }
            if (radioButton6.Checked == true)
            {
                kado = kado + 1;
            }
            else
            {
                kadoo = kadoo + 1;
            }
            if (radioButton11.Checked == true)
            {
                kado = kado + 1;
            }
            else
            {
                kadoo = kadoo + 1;
            }
            if (radioButton16.Checked == true)
            {
                kado = kado + 1;
            }
            else
            {
                kadoo = kadoo + 1;
            }
            if (radioButton18.Checked == true)
            {
                kado = kado + 1;
            }
            else
            {
                kadoo = kadoo + 1;
            }
            int basarı = kado * 20;

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Bi Uyanık Sensin Kanka");
            }
            else
            {
                if (basarı == 100)
                {
                    MessageBox.Show("Tebrikler Başarınız %100", "Kado");
                }
            textBox1.Text = kado.ToString();
            textBox2.Text = kadoo.ToString();
            textBox3.Text = basarı.ToString();
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton4.Checked = true;
                radioButton6.Checked = true;
                radioButton11.Checked = true;
                radioButton16.Checked = true;
                radioButton18.Checked = true;
            }
            else
            {
                radioButton4.Checked = false;
                radioButton6.Checked = false;
                radioButton11.Checked = false;
                radioButton16.Checked = false;
                radioButton18.Checked = false;
            }
        }
    }
}
