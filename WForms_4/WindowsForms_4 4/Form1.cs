using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(textBox1.Text);
            
            int b = int.Parse(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            int namber = 1;
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = b;

            double[] fh = new double[a];

            double[,] matrix = new double[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a; i++)
            {
                fh[i] = matrix[i, (b - namber)];
                namber++;
            }
            
            Array.Sort(fh);
            Array.Reverse(fh);
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = fh[i];
            }
        }
    }
}
