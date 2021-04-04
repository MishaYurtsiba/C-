using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle cir = new Circle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text),Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            textBox4.Text = Convert.ToString(cir.S());
            textBox7.Text = cir.Distanse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ball ball = new Ball(Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox3.Text));
            textBox10.Text = Convert.ToString(ball.V());
            textBox11.Text = ball.TDistanse();
        }
    }
}
