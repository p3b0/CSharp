namespace PracticeApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.pkDate = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.chkConvert = new System.Windows.Forms.CheckBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 20);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(31, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(31, 64);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(180, 20);
            this.txtTele.TabIndex = 2;
            // 
            // pkDate
            // 
            this.pkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkDate.Location = new System.Drawing.Point(30, 103);
            this.pkDate.Name = "pkDate";
            this.pkDate.Size = new System.Drawing.Size(95, 20);
            this.pkDate.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Namn";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(28, 48);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(80, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Telefonnummer";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(28, 87);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(62, 13);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Födelsedag";
            // 
            // chkConvert
            // 
            this.chkConvert.AutoSize = true;
            this.chkConvert.Location = new System.Drawing.Point(30, 129);
            this.chkConvert.Name = "chkConvert";
            this.chkConvert.Size = new System.Drawing.Size(78, 17);
            this.chkConvert.TabIndex = 7;
            this.chkConvert.Text = "Konvertera";
            this.chkConvert.UseVisualStyleBackColor = true;
            this.chkConvert.CheckedChanged += new System.EventHandler(this.ChkConvert_CheckedChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(29, 154);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(78, 24);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Välj fil";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(28, 181);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 13);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "label1";
            this.lblPath.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(29, 216);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(182, 24);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "Konvertera";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 251);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.chkConvert);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pkDate);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticeApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.DateTimePicker pkDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.CheckBox chkConvert;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

