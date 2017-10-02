using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListfolderFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var path = folderBrowserDialog1.SelectedPath;
            label1.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo d = new DirectoryInfo(path);

            foreach (var file in d.GetFiles("*.txt"))
            {
                listBox1.Items.Add(file);
            }
        }
    }
}
