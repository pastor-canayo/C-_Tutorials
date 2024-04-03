using System.Security.AccessControl;

namespace CreateFolderBackUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void originalBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                original.Text = ofd.SelectedPath;
            }
        }

        private void backupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                backup.Text = ofd.SelectedPath;
            }
        }

        private void createBackupFolder_Click(object sender, EventArgs e)
        {
            // Make dest directory if it does not exist
            string source = original.Text;
            string dest = backup.Text;
            string dataBase = "ImportantDocuments";
            string sourceDatabaseDirectory = Path.Combine(source, dataBase);
            string destinationDatabaseDirectory = Path.Combine(dest, dataBase);

            DirectoryInfo di = new DirectoryInfo(sourceDatabaseDirectory);
            DirectoryInfo dis = new DirectoryInfo(destinationDatabaseDirectory);

            if (di.Exists == true)
            {
                if (dis.Exists == false)
                {
                    Directory.CreateDirectory(destinationDatabaseDirectory);
                }
               
            }
        }
    }
}