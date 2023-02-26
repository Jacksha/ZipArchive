namespace ZipArchive
{
    partial class ZipUnzip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zip = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZipFiles = new System.Windows.Forms.Button();
            this.btnFileNames = new System.Windows.Forms.Button();
            this.txtFileNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.textDestFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Zip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zip
            // 
            this.Zip.Controls.Add(this.tabPage1);
            this.Zip.Controls.Add(this.tabPage2);
            this.Zip.Location = new System.Drawing.Point(12, 12);
            this.Zip.Name = "Zip";
            this.Zip.SelectedIndex = 0;
            this.Zip.Size = new System.Drawing.Size(575, 391);
            this.Zip.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnDestFolder);
            this.tabPage1.Controls.Add(this.textDestFolder);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zip";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Progress:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnZipFiles);
            this.groupBox1.Controls.Add(this.btnFileNames);
            this.groupBox1.Controls.Add(this.txtFileNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnZipFolder);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 163);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose Folder/Files to unzip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "OR";
            // 
            // btnZipFiles
            // 
            this.btnZipFiles.Location = new System.Drawing.Point(477, 113);
            this.btnZipFiles.Name = "btnZipFiles";
            this.btnZipFiles.Size = new System.Drawing.Size(68, 23);
            this.btnZipFiles.TabIndex = 26;
            this.btnZipFiles.Text = "Zip";
            this.btnZipFiles.UseVisualStyleBackColor = true;
            this.btnZipFiles.Click += new System.EventHandler(this.btnZipFiles_Click);
            // 
            // btnFileNames
            // 
            this.btnFileNames.Location = new System.Drawing.Point(416, 113);
            this.btnFileNames.Name = "btnFileNames";
            this.btnFileNames.Size = new System.Drawing.Size(46, 24);
            this.btnFileNames.TabIndex = 25;
            this.btnFileNames.Text = "...";
            this.btnFileNames.UseVisualStyleBackColor = true;
            this.btnFileNames.Click += new System.EventHandler(this.btnFileNames_Click);
            // 
            // txtFileNames
            // 
            this.txtFileNames.Location = new System.Drawing.Point(105, 114);
            this.txtFileNames.Name = "txtFileNames";
            this.txtFileNames.ReadOnly = true;
            this.txtFileNames.Size = new System.Drawing.Size(305, 23);
            this.txtFileNames.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Chose Files:";
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Location = new System.Drawing.Point(477, 37);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(68, 23);
            this.btnZipFolder.TabIndex = 22;
            this.btnZipFolder.Text = "Zip";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            this.btnZipFolder.Click += new System.EventHandler(this.btnZipFolder_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(416, 37);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(46, 24);
            this.btnFolder.TabIndex = 21;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(105, 38);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(305, 23);
            this.txtFolder.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chose Folder:";
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Location = new System.Drawing.Point(416, 196);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(46, 24);
            this.btnDestFolder.TabIndex = 21;
            this.btnDestFolder.Text = "...";
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // textDestFolder
            // 
            this.textDestFolder.Location = new System.Drawing.Point(105, 197);
            this.textDestFolder.Name = "textDestFolder";
            this.textDestFolder.ReadOnly = true;
            this.textDestFolder.Size = new System.Drawing.Size(305, 23);
            this.textDestFolder.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Destonation:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(105, 302);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(305, 23);
            this.progressBar.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UnZip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ZipUnzip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.Zip);
            this.Name = "ZipUnzip";
            this.Text = "Zip/Unzip";
            this.Zip.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Zip;
        private TabPage tabPage1;
        private ProgressBar progressBar;
        private TabPage tabPage2;
        private Button btnDestFolder;
        private TextBox textDestFolder;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnZipFiles;
        private Button btnFileNames;
        private TextBox txtFileNames;
        private Label label2;
        private Button btnZipFolder;
        private Button btnFolder;
        private TextBox txtFolder;
        private Label label1;
    }
}