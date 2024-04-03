namespace SplittingStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foods = "apple banana cherry durian eggplant fig grape  honey";
            textBox1.Text += $"{foods}\r\n";

            var foodArray = foods.Split();
            foreach ( var food in foodArray )
            {
                textBox1.Text += $"{food}\r\n";
            }

        }
    }
}