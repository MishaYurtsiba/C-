using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_5_1
{
    public partial class Form1 : Form
    {
        static int Nsd(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(textBox1.Text);
            
            int b = Convert.ToInt32(textBox2.Text);
            int s = Nsd(a, b) + Nsd(a, 4) + Nsd(24, b);
            textBox3.Text = s.ToString();
        }
    }
}
