using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Побудова_графіків
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double x1;
            double y;
            double y1;
            double a =0;
            double b=6;
            double h=0.6;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            x = a;
            x1 = a;
            while (x <= b)
            {
                y = x * (Math.Atan(x));
                chart1.Series[0].Points.AddXY(x, y);
                x += h;

            }
            while (x1 <= b)
            {
                if (x1 < 0)
                {
                    x1 *= -1;
                }
                y1 = x1 * (Math.Atan(x1));
                
                chart1.Series[1].Points.AddXY(x1, y1);
                x1 += h;

            }

        }
    }
}
