using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            Matrix mx = new Matrix(b);
            dataGridView1.RowCount = b;
            dataGridView1.ColumnCount = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            dataGridView2.RowCount = b;
            dataGridView2.ColumnCount = b;
            int[,] matrix = new int[b, b];
            for(int i = 0; i < b; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    matrix[i,j] = Convert.ToInt32( dataGridView1.Rows[i].Cells[j].Value);
                }
            }
            TMatrix tmx = new TMatrix(matrix);
            int[,] matrix1 = tmx.Print();
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = matrix1[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            int[,] matrix2 = new int[b, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
            TMatrix tmx = new TMatrix(matrix2);
            textBox2.Text = Convert.ToString( tmx.Max());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);

            int[,] matrix3 = new int[b, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix3[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            TMatrix tmx = new TMatrix(matrix3);
            textBox3.Text = Convert.ToString(tmx.Min());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);

            int[,] matrix4 = new int[b, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix4[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            TMatrix tmx = new TMatrix(matrix4);
            textBox4.Text = Convert.ToString(tmx.Sum());
        }
    }
}
