using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox6.Text);
            double b = double.Parse(textBox5.Text);
            double c = double.Parse(textBox4.Text);
            double d = a;
            for (double i = a; i <= b; i += c)
            {
                d *= i;
            }
            label5.Text = d.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox16.Text);
            double b = double.Parse(textBox15.Text);
            double c = a + b;
            label15.Text = c.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox14.Text);
            double b = double.Parse(textBox13.Text);
            double c = a - b;
            label13.Text = c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox12.Text);
            double b = double.Parse(textBox11.Text);
            double c = a * b;
            label11.Text = c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox10.Text);
            double b = double.Parse(textBox9.Text);
            double c = a / b;
            label9.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w = double.Parse(textBox1.Text);
            double h = double.Parse(textBox3.Text);
            h = h / 100;
            double b = w / (h * h);
            label4.Text = b.ToString();
        }


    }
}
