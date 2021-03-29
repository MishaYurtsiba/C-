using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interval2D int2d = new Interval2D(
                 Convert.ToDouble(textBox1.Text),
                 Convert.ToDouble(textBox2.Text),
                 Convert.ToDouble(textBox3.Text),
                 Convert.ToDouble(textBox4.Text));
                 textBox5.Text = int2d.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interval2D int2d = new Interval2D(
                Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text),
                Convert.ToDouble(textBox4.Text));
            textBox6.Text=Convert.ToString( int2d.Length());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interval2D int2d = new Interval2D(
               Convert.ToDouble(textBox1.Text),
               Convert.ToDouble(textBox2.Text),
               Convert.ToDouble(textBox3.Text),
               Convert.ToDouble(textBox4.Text));
            textBox7.Text = Convert.ToString(int2d.Middle());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interval intd = new Interval(
               Convert.ToDouble(textBox11.Text),
               Convert.ToDouble(textBox10.Text),
               Convert.ToDouble(textBox9.Text),
               Convert.ToDouble(textBox8.Text),
               Convert.ToDouble(textBox13.Text)
               );
            textBox12.Text = Convert.ToString(intd.Sum());
            textBox14.Text = Convert.ToString(intd.Add());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] arr = textBox15.Text.Split(' ');
            int[] arr2 = new int[arr.Length];
            for(int i=0;i< arr.Length; i++)
            {
                arr2[i] = Convert.ToInt32(arr[i]);
            }
            Array.Sort(arr2);
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = arr2[i];
            }

        }
    }
}
