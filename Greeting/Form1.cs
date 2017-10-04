using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maleOrFemale = int.Parse(textBox3.Text.Substring(9,1));
            if ((maleOrFemale % 1) != 0)
                MessageBox.Show("Hej! fru " + textBox2.Text + ".");
            else
                MessageBox.Show("Hej! herr " + textBox2.Text + ".");
        }
    }
}
