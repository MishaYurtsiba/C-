using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a = double.Parse(textBox1.Text);
           
            double b = double.Parse(textBox2.Text);
           
            double c = double.Parse(textBox3.Text);
            if (a < b && b < c)
            {
                double min = Math.Pow(a, 2);
                textBox4.Text = min.ToString();
            }
            else if (b < a && a < c)
            {
                double min = Math.Pow(b, 2);
                textBox4.Text = min.ToString();
            }
            else if (c < b && b < a)
            {
                double min = Math.Pow(c, 2);
                
            }
        }
    }
}
