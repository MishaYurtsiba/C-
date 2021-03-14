using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_2_1
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
          
            int n = int.Parse(textBox2.Text);
            double sum = 0;
            double add = 1;

            for (int i = 0; i < n; i++)
            {
                sum += add;
                add *= 1 / (a + 1);
            }
            textBox3.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
