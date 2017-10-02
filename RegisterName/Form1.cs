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

namespace RegisterName
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

        private void btnSpara_Click(object sender, EventArgs e)
        {
            string content = "";
            //saveFileDialog1.ShowDialog();
            content = txtName.Text + ";";
            content += dteDate.Text + ";";
            content += txtTele.Text + ";";
            File.WriteAllText(txtName.Text + ".txt", content);
        }
    }
}
