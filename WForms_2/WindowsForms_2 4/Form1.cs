using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = int.Parse(textBox1.Text);
            double x0 = 1;
            double x1 = 1;
            for (int i = 2; n > i; i++)
            {
                double x2 = (Math.Sin(x1) + x0) / Math.Cos(x1);
                x0 = x1;
                x1 = x2;
            }
            textBox2.Text = x1.ToString();
        }
    }
}
