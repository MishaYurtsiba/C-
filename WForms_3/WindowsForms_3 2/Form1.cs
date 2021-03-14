using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(textBox1.Text);
            
            double x = Convert.ToDouble(textBox2.Text);
            double NewElement = 0;
            double MaxElement = 0;
            double[] arr = new double[n];
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                double add = (i + 1) * (Math.Sin(x * (i + 1)) + Math.Cos(x * (i + 1)));
                NewElement += add;
                arr[i] = NewElement;
            }
            for (int i = 0; i < n; i++)
            {
                if (MaxElement < arr[i])
                {
                    MaxElement = arr[i];
                }

            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }
            ;
            textBox3.Text = MaxElement.ToString();

        }
    }
}
