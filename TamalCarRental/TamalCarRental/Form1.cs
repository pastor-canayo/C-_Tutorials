using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamalCarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = "Lamborghini per day - $80 \n Ferrari per day - $50\n" +
                "Tesla per day - $35 \nBuggatti per day - $200";
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string carType = textBox2.Text;
            string outDate = dateTimePicker1.Value.ToString();
            string inDate = dateTimePicker2.Value.ToString();
            MessageBox.Show($"Full Name: \t{text}\nCar Type: \t{carType}\n" +
                $"\nDate Rent: \t{outDate}\n Date Return: \t{inDate}");
        }

       
    }
}
