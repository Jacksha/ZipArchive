using System;
using System.Diagnostics;
using System.IO.Compression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ZipArchive
{
    public partial class ZipUnzip : Form
    {
        List<String> sourceFileDirectory = new List<String>();
        List<String> sourceFilePaths = new List<String>();
        public ZipUnzip()
        {
            InitializeComponent();
        }

        private void deleteIfExists(string zipFileName)
        {

            //MessageBox.Show("Delete if exists: " + zipFileName);
            if (File.Exists(zipFileName))
            {
                File.Delete(zipFileName);
            }
        }

        IEnumerable<string> GetFilePaths(List<string> paths)
        {
            List<string> filesPaths = new List<string>();
            foreach (string path in paths)
            {
                filesPaths.AddRange(Directory.GetFiles(path));
            }

            return filesPaths;
        }


        // Chose all files in folder
        private void btnFolder_Click(object sender, EventArgs e)
        {
            lblZipDone.Visible = false;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
                sourceFileDirectory.Add(@fbd.SelectedPath);
            }
        }

        //Chose specific files in folder
        private void btnFileNames_Click(object sender, EventArgs e)
        {
            lblZipDone.Visible = false;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceFilePaths = ofd.FileNames.ToList();
                    foreach (string path in ofd.FileNames)
                    {
                        txtFileNames.Text += Path.GetFileName(path) + ", ";
                    }
                }
            }
        }

        // Zip selected folder
        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            IEnumerable<string> filePaths = GetFilePaths(sourceFileDirectory);

            string zipFileName = (txtFolder.Text + ".zip");
            deleteIfExists(zipFileName);
            using var zip = ZipFile.Open(zipFileName, ZipArchiveMode.Create);

            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                zip.CreateEntryFromFile(filePath, fileName);
            }
            lblZipDone.Visible = true;
            Process.Start("explorer.exe", Path.GetDirectoryName(txtFolder.Text) + "");
        }

        //Zip selected files
        private void btnZipFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileNames.Text))
            {
                MessageBox.Show("Please select your files.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string dirPath = Path.GetDirectoryName(sourceFilePaths.First()) + "";
            string zipFileName = dirPath + ".zip";
            deleteIfExists(zipFileName);
            using var zip = ZipFile.Open(zipFileName, ZipArchiveMode.Create);

            foreach (string filePath in sourceFilePaths)
            {
                string fileName = Path.GetFileName(filePath);
                zip.CreateEntryFromFile(filePath, fileName);
            }
            lblZipDone.Visible = true;
            Process.Start("explorer.exe", Path.GetDirectoryName(dirPath)+"");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Chose Zip file to unzip
        private void btnChsZipFile_Click(object sender, EventArgs e)
        {
            lblUnzipDone.Visible = false;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.zip", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtChsZipFile.Text = ofd.FileName;
                    txtUnzipDest.Text = Path.GetDirectoryName(ofd.FileName);
                }
            }
        }

        //Unzip selected file
        private void btnUnzipFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChsZipFile.Text))
            {
                MessageBox.Show("Please select your files.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            ZipFile.ExtractToDirectory(txtChsZipFile.Text, txtUnzipDest.Text, true);
            lblUnzipDone.Visible = true;
            Process.Start("explorer.exe", txtUnzipDest.Text);
        }

        private void btnDestUnzip_Click(object sender, EventArgs e)
        {
            lblUnzipDone.Visible = false;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your destination path.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtUnzipDest.Text = fbd.SelectedPath;
            }
        }
    }
}