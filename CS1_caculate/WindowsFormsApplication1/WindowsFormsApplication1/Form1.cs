using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
           double c = a + b;
            label2.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox4.Text);
            double b = double.Parse(textBox3.Text);
            double c = a - b;
            label3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox6.Text);
            double b = double.Parse(textBox5.Text);
            double c = a * b;
            label5.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox8.Text);
            double b = double.Parse(textBox7.Text);
            double c = a / b;
            label7.Text = c.ToString();
        }
    }
}
