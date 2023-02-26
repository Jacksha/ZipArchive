using System.IO.Compression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ZipArchive
{
    public partial class ZipUnzip : Form
    {
        List<String> sourceFileDirectory = new List<String>();
        public ZipUnzip()
        {
            InitializeComponent();
        }

        private void deleteIfExists (string zipFileName)
        {
            foreach (string path in sourceFileDirectory)
            {
                MessageBox.Show("Chosen folder: " + zipFileName);
                if (File.Exists(zipFileName))
                {
                    File.Delete(zipFileName);
                }
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

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path.";
            if(fbd.ShowDialog() == DialogResult.OK )
            {
                txtFolder.Text = fbd.SelectedPath;
                textDestFolder.Text = fbd.SelectedPath;
                sourceFileDirectory.Add(@fbd.SelectedPath);
            }
        }

        private void btnFileNames_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames=true, Multiselect=true}) 
            { 
                if(ofd.ShowDialog() == DialogResult.OK )
                {
                    foreach(string path in ofd.FileNames)
                    {
                        txtFileNames.Text += path;
                    }
                }
            }
        }

        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            //MessageBox.Show("Chosen folder: " + txtFolder.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IEnumerable<string> filePaths = GetFilePaths(sourceFileDirectory);

            var zipFileName = (textDestFolder.Text + ".zip");
            //MessageBox.Show("textDestFolder.Text: " + textDestFolder.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deleteIfExists(zipFileName);
            using var zip = ZipFile.Open(zipFileName, ZipArchiveMode.Create);

            foreach(string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                zip.CreateEntryFromFile(filePath, fileName);
            }
        }

        private void btnZipFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileNames.Text))
            {
                MessageBox.Show("Please select your files.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string path = txtFileNames.Text;
            MessageBox.Show("Chosen files: " + txtFileNames.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnDestFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your destination path.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textDestFolder.Text = fbd.SelectedPath;
            }
        }

    }
}