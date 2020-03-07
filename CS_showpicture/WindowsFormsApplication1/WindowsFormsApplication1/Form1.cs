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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        FileInfo[] F;
        private void 開啟目錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                F = d.GetFiles("*jpg");
                if (F.Length>0)
                {
                    pictureBox1.Load(F[0].FullName);
                  
                }
            }
        }
        int n = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.PageDown:
                    n += 1;
                    if(n>F.Length-1)
                    {
                        n = 0;
                    }
                    break;
                case Keys.PageUp:
                    n -= 1;
                    if(n<0)
                    {
                        n = F.Length - 1;
                    }
                    break;
            }
            pictureBox1.Load(F[0].FullName);
        }
    }
}
