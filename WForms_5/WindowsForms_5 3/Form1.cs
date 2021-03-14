using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_5_3
{
    public partial class Form1 : Form
    {
        static double Rec(double n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1 || n == 2 || n == 3)
            {
                return 7;
            }
            else
            {
                return Rec(n - 1) * (1 + Rec(n - 2) + Rec(n - 3) / Rec(n - 4));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double n = Convert.ToDouble(textBox1.Text);
            double s = Rec(n);
            textBox2.Text = s.ToString();
        }
    }
}
