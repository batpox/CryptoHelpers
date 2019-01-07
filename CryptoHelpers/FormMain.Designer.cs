namespace CryptoHelpers
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCertificates = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textCertificate = new System.Windows.Forms.TextBox();
            this.buttonLoadExe = new System.Windows.Forms.Button();
            this.textSignedExeFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCreateCertificateFile = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.listFileFormats = new System.Windows.Forms.ListView();
            this.groupCreateCertificateFile = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCertificates.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupCreateCertificateFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 813);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1223, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCertificates);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 785);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCertificates
            // 
            this.tabCertificates.Controls.Add(this.panel1);
            this.tabCertificates.Location = new System.Drawing.Point(4, 25);
            this.tabCertificates.Name = "tabCertificates";
            this.tabCertificates.Padding = new System.Windows.Forms.Padding(3);
            this.tabCertificates.Size = new System.Drawing.Size(1215, 756);
            this.tabCertificates.TabIndex = 0;
            this.tabCertificates.Text = "Create Certificate Files";
            this.tabCertificates.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupCreateCertificateFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textCertificate);
            this.panel1.Controls.Add(this.buttonLoadExe);
            this.panel1.Controls.Add(this.textSignedExeFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 750);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Certificate Information within the EXE file";
            // 
            // textCertificate
            // 
            this.textCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCertificate.Location = new System.Drawing.Point(5, 323);
            this.textCertificate.Multiline = true;
            this.textCertificate.Name = "textCertificate";
            this.textCertificate.ReadOnly = true;
            this.textCertificate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textCertificate.Size = new System.Drawing.Size(1181, 414);
            this.textCertificate.TabIndex = 4;
            // 
            // buttonLoadExe
            // 
            this.buttonLoadExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadExe.Location = new System.Drawing.Point(1114, 34);
            this.buttonLoadExe.Name = "buttonLoadExe";
            this.buttonLoadExe.Size = new System.Drawing.Size(72, 35);
            this.buttonLoadExe.TabIndex = 3;
            this.buttonLoadExe.Text = "...";
            this.toolTip1.SetToolTip(this.buttonLoadExe, "Locate a signed EXE file");
            this.buttonLoadExe.UseVisualStyleBackColor = true;
            this.buttonLoadExe.Click += new System.EventHandler(this.buttonLoadExe_Click);
            // 
            // textSignedExeFile
            // 
            this.textSignedExeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSignedExeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSignedExeFile.Location = new System.Drawing.Point(5, 33);
            this.textSignedExeFile.Name = "textSignedExeFile";
            this.textSignedExeFile.ReadOnly = true;
            this.textSignedExeFile.Size = new System.Drawing.Size(1075, 30);
            this.textSignedExeFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed EXE";
            // 
            // tabLogs
            // 
            this.tabLogs.Location = new System.Drawing.Point(4, 25);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1166, 608);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // buttonCreateCertificateFile
            // 
            this.buttonCreateCertificateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateCertificateFile.Location = new System.Drawing.Point(962, 26);
            this.buttonCreateCertificateFile.Name = "buttonCreateCertificateFile";
            this.buttonCreateCertificateFile.Size = new System.Drawing.Size(208, 55);
            this.buttonCreateCertificateFile.TabIndex = 6;
            this.buttonCreateCertificateFile.Text = "Create Certificate File...";
            this.toolTip1.SetToolTip(this.buttonCreateCertificateFile, "Create the file, prompting for the location");
            this.buttonCreateCertificateFile.UseVisualStyleBackColor = true;
            this.buttonCreateCertificateFile.Click += new System.EventHandler(this.buttonCreateCertificateFile_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Format";
            // 
            // listFileFormats
            // 
            this.listFileFormats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFileFormats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFileFormats.FullRowSelect = true;
            this.listFileFormats.GridLines = true;
            this.listFileFormats.Location = new System.Drawing.Point(157, 26);
            this.listFileFormats.Name = "listFileFormats";
            this.listFileFormats.Size = new System.Drawing.Size(785, 175);
            this.listFileFormats.TabIndex = 8;
            this.listFileFormats.UseCompatibleStateImageBehavior = false;
            this.listFileFormats.View = System.Windows.Forms.View.Details;
            this.listFileFormats.SelectedIndexChanged += new System.EventHandler(this.listFileFormats_SelectedIndexChanged);
            // 
            // groupCreateCertificateFile
            // 
            this.groupCreateCertificateFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCreateCertificateFile.Controls.Add(this.listFileFormats);
            this.groupCreateCertificateFile.Controls.Add(this.buttonCreateCertificateFile);
            this.groupCreateCertificateFile.Controls.Add(this.label3);
            this.groupCreateCertificateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCreateCertificateFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupCreateCertificateFile.Location = new System.Drawing.Point(9, 79);
            this.groupCreateCertificateFile.Name = "groupCreateCertificateFile";
            this.groupCreateCertificateFile.Size = new System.Drawing.Size(1176, 207);
            this.groupCreateCertificateFile.TabIndex = 9;
            this.groupCreateCertificateFile.TabStop = false;
            this.groupCreateCertificateFile.Text = "Create Certificate File";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 835);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "CryptoHelpers";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCertificates.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupCreateCertificateFile.ResumeLayout(false);
            this.groupCreateCertificateFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCertificates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoadExe;
        private System.Windows.Forms.TextBox textSignedExeFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCertificate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonCreateCertificateFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listFileFormats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupCreateCertificateFile;
    }
}

