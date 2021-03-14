using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_3_1
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
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = n;
            double[] arr = new double[n];
            double max = 0;
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100,100);
            }
            for (int i = 0; i < n; i += 2)

            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = arr[i].ToString();

            }
            textBox2.Text = max.ToString();
        }
    }
}
