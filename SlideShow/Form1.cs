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

namespace SlideShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var path = folderBrowserDialog1.SelectedPath;
            label1.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo d = new DirectoryInfo(path);

            foreach (var file in d.GetFiles("*.jpg"))
            {
                listBox1.Items.Add(file);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(folderBrowserDialog1.SelectedPath + "/" + listBox1.SelectedItem.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            listBox1.SetSelected(listBox1.SelectedIndex +=1,true);
            pictureBox1.Load(folderBrowserDialog1.SelectedPath + "/" + listBox1.SelectedIndex.ToString());
        }
    }
}
