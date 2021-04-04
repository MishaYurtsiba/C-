using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string ex = listBox2.Text;
            int color = Convert.ToInt32(listBox1.Text);
            int h = Convert.ToInt32(textBox3.Text);
            int w = Convert.ToInt32(textBox4.Text);
            File f = new File(n, ex, color, h, w);
            textBox5.Text = Convert.ToString(f.Size());
            textBox6.Text = Convert.ToString(f.Namber_of_color());
            textBox8.Text = ex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_name1 n = new New_name1(textBox7.Text);
            textBox1.Text = n.Nname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_expansion nex = new New_expansion(listBox3.Text);
            textBox8.Text = nex.Newex();
        }
    }
}
