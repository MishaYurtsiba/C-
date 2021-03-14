using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int x1 = Convert.ToInt32(textBox1.Text);
            
            int y1 = Convert.ToInt32(textBox2.Text);
            
            int x2 = Convert.ToInt32(textBox3.Text);
            
            int y2 = Convert.ToInt32(textBox4.Text);
            
            int x3 = Convert.ToInt32(textBox5.Text);
            
            int y3 = Convert.ToInt32(textBox6.Text);
            
            int x4 = Convert.ToInt32(textBox7.Text);
            
            int y4 = Convert.ToInt32(textBox8.Text);
            int AB = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2) ^ (1 / 2);
            int BC = ((x3 - x2) ^ 2 + (y3 - y2) ^ 2) ^ (1 / 2);
            int DC = ((x4 - x3) ^ 2 + (y4 - y3) ^ 2) ^ (1 / 2);
            int AD = ((x4 - x1) ^ 2 + (y4 - y1) ^ 2) ^ (1 / 2);
            if (AB == BC && BC == DC && DC == AD)
            {
                textBox9.Text = ("Буде ромбом");
            }
            else
            {
                textBox9.Text = ("Не буде ромбом");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
