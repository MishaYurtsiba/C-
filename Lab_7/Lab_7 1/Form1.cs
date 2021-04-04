using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            Plural p = new Plural(arr);
            
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 5;

            for (int i = 0; i < 5; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = arr[i];
            }
            textBox2.Text = Convert.ToString(p.Sum());
            textBox1.Text = Convert.ToString(p.Max());
        }
    }
}
