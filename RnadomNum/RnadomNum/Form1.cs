using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RnadomNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Random operations = new Random();

            int a, add, subs, mult, div, add2, subs2, mult2, div2;

            a = Convert.ToInt32(displayUser.Text);

            add2 = operations.Next(1, 100);
            add = add2 + a;
            label6.Text = "The random number is: ";
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Text = add2.ToString();

            subs2 = operations.Next(1, 100);
            subs = subs2 - a;
            label8.Text = "The random number is: ";
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Text = subs2.ToString();

            mult2 = operations.Next(1, 100);
            mult = mult2 * a;
            label10.Text = "The random number is: ";
            label11.ForeColor = System.Drawing.Color.Red;
            label11.Text = mult2.ToString();

            div2 = operations.Next(1, 100);
            div = div2 / a;
            label12.Text = "The random number is: ";
            label13.ForeColor = System.Drawing.Color.Red;
            label13.Text = div2.ToString();

            displayAdds.Text = add.ToString();
            displaySubs.Text = subs.ToString();
            displayMult.Text = mult.ToString();
            displayDivs.Text = div.ToString();
        }

    }
}
