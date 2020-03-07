using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w = double.Parse(textBox1.Text);
            double h = double.Parse(textBox2.Text);
            h = h /100;
            double b = w / (h * h);
            label3.Text = b.ToString();
        }
    }
}
