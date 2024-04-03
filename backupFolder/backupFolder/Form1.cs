namespace backupFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void original_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string source = original.Text;
            string dest = textBox2.Text;
            string important = "ImportantDocuments";
            string sourceImportDirectory = Path.Combine(source, important);
            string destImportDirectory = Path.Combine(dest, important);

            DirectoryInfo di = new DirectoryInfo(sourceImportDirectory);
            DirectoryInfo dis = new DirectoryInfo(destImportDirectory);

            if(di.Exists == true)
            {
                if(dis.Exists == false) 
                {
                    Directory.CreateDirectory(destImportDirectory);
                }
            }
        }

        private void originalButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                original.Text = ofd.SelectedPath;
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.SelectedPath;
            }
        }
    }
}