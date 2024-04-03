namespace CheckBoxBackgroundImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\pasto\Desktop\images\lambo.jpg");
            this.BackgroundImage = myImage;
            if (!checkBox1.Checked)
            {
                this.BackgroundImage = null;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\pasto\Desktop\images\ferrari.jpg");
            this.BackgroundImage = myImage;
            if (!checkBox2.Checked)
            {
                this.BackgroundImage = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\pasto\Desktop\images\tesla.jpg");
            this.BackgroundImage = myImage;
            if (!checkBox3.Checked)
            {
                this.BackgroundImage = null;
            }
        }
    }
}