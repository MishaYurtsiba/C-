using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double epsilon = double.Parse(textBox1.Text);
            
            double x = double.Parse(textBox2.Text);
            double sum = 0;
            int f = 1;
            double add = 1;



            for (int i = 0; add > epsilon; i++)
            {
                if (i > 0)
                {
                    f *= i;
                    add = Math.Pow(x, i) / f;
                    sum += add;

                }
                else
                {
                    sum = 1;

                }

            }
            textBox3.Text = sum.ToString();
        }
    }
}
