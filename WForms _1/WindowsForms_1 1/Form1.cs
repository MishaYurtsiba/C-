using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }                
        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            int x3 = Convert.ToInt32(textBox5.Text);
            int y3 = Convert.ToInt32(textBox6.Text);
            int AC = ((x3 - x1) ^ 2 + (y3 - y1) ^ 2) ^ (1 / 2);
            int BC = ((x3 - x2) ^ 2 + (y3 - y2) ^ 2) ^ (1 / 2);
            int AB = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2) ^ (1 / 2);
            int p = AC + BC + AB;
            textBox7.Text =p.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
