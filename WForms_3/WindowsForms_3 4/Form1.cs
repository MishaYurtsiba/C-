using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_3_4
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
            double[] arr = new double[n];
            double New = 0;
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = n;
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100,100);
            }
            for (int i = 0; i < (n / 2); i++)
            {
                if (i % 2 == 0)
                {

                }
                else
                {
                    New = arr[i];
                    arr[i] = arr[(n / 2) + i];
                    arr[(n / 2) + i] = New;
                }

            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }
        }
    }
}
