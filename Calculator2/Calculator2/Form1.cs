using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator2
{
    public partial class Form1 : Form
    {
        private string red;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            




        }
        private void calculateButton_Click(object sender, EventArgs e)
        {

            Random dimension = new Random();

            int a, b, add, subs, mult, div, add1, subs1, mult1, div1;

            a = Convert.ToInt32(displayFirst.Text);
            //b = Convert.ToInt32(displayTwo.Text);
            //add = a + b;
            //subs = a - b;
            //mult = a * b;
            //div = a / b;
            add1 = dimension.Next(1, 100);
            add =  add1 + a;
            label6.Text = "The random Number is: ";
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Text = add1.ToString();

            subs1 = dimension.Next(1, 100);
            subs = subs1 - a;
            label8.Text = "The random Number is: ";
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Text = subs1.ToString();


            mult1 = dimension.Next(1, 100);
            mult = mult1 * a;
            label10.Text = "The random Number is: ";
            label11.ForeColor = System.Drawing.Color.Red;
            label11.Text = mult1.ToString();

            div1 = dimension.Next(1, 100);
            div = div1 / a;
            label12.Text = "The random Number is: ";
            label13.ForeColor = System.Drawing.Color.Red;
            label13.Text = div1.ToString();

            additioBoxDisplay.Text = add.ToString();
            substractioBoxDisplay.Text = subs.ToString();
            multiplicationBoxDisplay.Text = mult.ToString();
            divisionBoxDisplay.Text = div.ToString();
        }
        

       
    }
}
