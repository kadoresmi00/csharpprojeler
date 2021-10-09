using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamba_sistem_raporu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Lamba Açık!");
            }
            else
            {
                listBox1.Items.Add("Lamba Kapalı!");
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Kapı Açık!");
            }
            else
            {
                listBox1.Items.Add("Kapı Kapalı!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
