namespace CerteficateAuthority
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
            this.TB_SubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_OpenFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_SigntureAlgorthem = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_IssuerName = new System.Windows.Forms.TextBox();
            this.B_GetCertificate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Verifieing_Certifiacte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_SubjectName
            // 
            this.TB_SubjectName.Location = new System.Drawing.Point(148, 66);
            this.TB_SubjectName.Name = "TB_SubjectName";
            this.TB_SubjectName.Size = new System.Drawing.Size(200, 20);
            this.TB_SubjectName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date Validate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date Validate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Give me Public Key";
            // 
            // B_OpenFile
            // 
            this.B_OpenFile.Location = new System.Drawing.Point(148, 180);
            this.B_OpenFile.Name = "B_OpenFile";
            this.B_OpenFile.Size = new System.Drawing.Size(200, 23);
            this.B_OpenFile.TabIndex = 7;
            this.B_OpenFile.Text = "Open File";
            this.B_OpenFile.UseVisualStyleBackColor = true;
            this.B_OpenFile.Click += new System.EventHandler(this.B_OpenFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Signature Algorithm ";
            // 
            // CB_SigntureAlgorthem
            // 
            this.CB_SigntureAlgorthem.FormattingEnabled = true;
            this.CB_SigntureAlgorthem.Items.AddRange(new object[] {
            "RSA&MD5",
            "RSA&SH1"});
            this.CB_SigntureAlgorthem.Location = new System.Drawing.Point(148, 220);
            this.CB_SigntureAlgorthem.Name = "CB_SigntureAlgorthem";
            this.CB_SigntureAlgorthem.Size = new System.Drawing.Size(200, 21);
            this.CB_SigntureAlgorthem.TabIndex = 9;
            this.CB_SigntureAlgorthem.Text = "RSA&SH1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Issuer Name";
            // 
            // TB_IssuerName
            // 
            this.TB_IssuerName.Location = new System.Drawing.Point(148, 33);
            this.TB_IssuerName.Name = "TB_IssuerName";
            this.TB_IssuerName.ReadOnly = true;
            this.TB_IssuerName.Size = new System.Drawing.Size(200, 20);
            this.TB_IssuerName.TabIndex = 16;
            this.TB_IssuerName.Text = "our corporation";
            this.TB_IssuerName.TextChanged += new System.EventHandler(this.TB_IssuerName_TextChanged);
            // 
            // B_GetCertificate
            // 
            this.B_GetCertificate.Location = new System.Drawing.Point(22, 259);
            this.B_GetCertificate.Name = "B_GetCertificate";
            this.B_GetCertificate.Size = new System.Drawing.Size(220, 23);
            this.B_GetCertificate.TabIndex = 10;
            this.B_GetCertificate.Text = "Save Certificate To file";
            this.B_GetCertificate.UseVisualStyleBackColor = true;
            this.B_GetCertificate.Click += new System.EventHandler(this.B_GetCertificate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Verifieing_Certifiacte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_IssuerName);
            this.groupBox1.Controls.Add(this.TB_SubjectName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B_GetCertificate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_SigntureAlgorthem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.B_OpenFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 344);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cerificate Creation ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Geerate Public/Private Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Verifieing_Certifiacte
            // 
            this.Verifieing_Certifiacte.Location = new System.Drawing.Point(248, 259);
            this.Verifieing_Certifiacte.Name = "Verifieing_Certifiacte";
            this.Verifieing_Certifiacte.Size = new System.Drawing.Size(119, 23);
            this.Verifieing_Certifiacte.TabIndex = 20;
            this.Verifieing_Certifiacte.Text = "Verify_Certifiacte";
            this.Verifieing_Certifiacte.UseVisualStyleBackColor = true;
            this.Verifieing_Certifiacte.Click += new System.EventHandler(this.Verifieing_Certifiacte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCertificateToolStripMenuItem,
            this.saveCertificateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCertificateToolStripMenuItem
            // 
            this.newCertificateToolStripMenuItem.Name = "newCertificateToolStripMenuItem";
            this.newCertificateToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newCertificateToolStripMenuItem.Text = "New Certificate";
            this.newCertificateToolStripMenuItem.Click += new System.EventHandler(this.newCertificateToolStripMenuItem_Click);
            // 
            // saveCertificateToolStripMenuItem
            // 
            this.saveCertificateToolStripMenuItem.Name = "saveCertificateToolStripMenuItem";
            this.saveCertificateToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveCertificateToolStripMenuItem.Text = "Save Certificate";
            this.saveCertificateToolStripMenuItem.Click += new System.EventHandler(this.saveCertificateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Certificate Authority ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_SubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_OpenFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_SigntureAlgorthem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_IssuerName;
        private System.Windows.Forms.Button B_GetCertificate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Verifieing_Certifiacte;
    }
}

