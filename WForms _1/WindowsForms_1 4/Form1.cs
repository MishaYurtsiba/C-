using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            if (1 <= x && x <= 3)
            {
                double z = Math.Log(x) - Math.Tan(x);
                textBox2.Text =  z.ToString();
            }
            else if (3 <= x && x <= 4)
            {
                double z = Math.Tan(x);
                textBox2.Text =  z.ToString();
            }
            else
            {
                double z = 0;
                textBox2.Text =  z.ToString();
            }
        }
    }
}
