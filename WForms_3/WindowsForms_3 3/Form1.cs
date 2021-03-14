using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_3_3
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
            double[] a = new double[n];
            double[] b = new double[n];
            double[] c = new double[n];
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = n;

            Console.WriteLine("Введіть елементи вектору:A");
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-100, 100);
            }
            Console.WriteLine("Введіть елементи вектору:B");
            for (int i = 0; i < n; i++)
            {
                b[i] = rand.Next(-100, 100);
            }
            Console.WriteLine("Введіть елементи вектору:C");
            for (int i = 0; i < n; i++)
            {
                c[i] = rand.Next(-100, 100);
            }
            for (int i = 0; i < n; i++)
            {
                c[i] = (2 * (a[i] + c[i])) - b[i];
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = c[i];
            }
        }
    }
}
