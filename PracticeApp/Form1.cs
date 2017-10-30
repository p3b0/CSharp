using PracticeLib;
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

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtTele.Text == "" || pkDate.Text == "")
                MessageBox.Show("Du måste fylla i alla fält för att kunna spara!");
            else
            {
                var fileHandler = new FileHandler()
                {
                    Name = txtName.Text,
                    Number = txtTele.Text,
                    Birthday = pkDate.Text
                };

                File.WriteAllText(txtName.Text + ".txt", fileHandler.WriteFile());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ChkConvert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConvert.Checked)
            {
                txtName.Enabled = false;
                txtTele.Enabled = false;
                pkDate.Enabled = false;
                btnSave.Enabled = false;
                this.Height = 290;
            }
            else
            {
                txtName.Enabled = true;
                txtTele.Enabled = true;
                pkDate.Enabled = true;
                btnSave.Enabled = true;
                this.Height = 190;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            lblPath.Text = ofdOpenFile.FileName;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string textToConvert = "";
            string result = "";
            var fileHandler = new FileHandler();
             
            result = fileHandler.ConvertText(textToConvert);




            //StringWriter sw = new StringWriter();
            //string[] lines = File.ReadAllLines(ofdOpenFile.FileName);
            //foreach (var line in lines)
            //{
            //    string transformedLine = Transform(line);
            //    sw.Write($"{transformedLine}\n");
            //}
            //File.WriteAllText(dlgSaveFile.FileName, sw.ToString());
        }
    }
}
