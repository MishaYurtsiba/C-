using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Модуль
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private Db _db = new Db();
        private void Show(List<Auction> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Нема що виводити");
                return;
            }
            dataGridView1.RowCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].name;
                dataGridView1.Rows[i].Cells[1].Value = list[i].start_date;
                dataGridView1.Rows[i].Cells[2].Value = list[i].end_date;
                dataGridView1.Rows[i].Cells[3].Value = list[i].start_price;
                dataGridView1.Rows[i].Cells[4].Value = list[i].end_prise;
               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Auction newAu = new Auction(
                textBox1.Text,
                Convert.ToInt32( textBox2.Text),
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox5.Text)


                );
            _db.Add(newAu);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;
            StreamWriter sw = new StreamWriter("text.txt", true);
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox5.Text);
            sw.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                dataGridView1.ColumnCount = Convert.ToInt32(sr.ReadLine());
                dataGridView1.RowCount = 1;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1[i, 0].Value = Convert.ToInt32(sr.ReadLine());

                }
                sr.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            
            for (int i = 1; i <= n; i++) 
            {
                chart1.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[3].Value, i);
                    }
        }
    }
}
