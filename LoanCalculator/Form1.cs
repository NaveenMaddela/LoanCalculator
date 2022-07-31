using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal loan_amount = 0.0m;
            int number_of_months = 0;
            decimal interest_rate=0.0m;

            try
            {
                loan_amount = decimal.Parse(txt_amount.Text);
                number_of_months = int.Parse(txt_months.Text);
                interest_rate = decimal.Parse(text_interest.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a valid number");
            }

            MessageBox.Show("Amount= " + loan_amount + "|| Number of months = " + number_of_months + " || Interest Rate = " + interest_rate);
            int counter = 0;

            while (counter <= number_of_months)
            //for (counter = 1;  counter<=number_of_months; counter++)

            {
             
                loan_amount = loan_amount + loan_amount * interest_rate;
                
                //if (counter == 0)
                //{
                //    continue;
                //}
                listBox1.Items.Add("At month " + counter + "  The loan is " + loan_amount.ToString("c"));
                counter = counter + 1;
            }

            textBox1.Text = loan_amount.ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_months.Text = "";
            text_interest.Text = "";
            textBox1.Text = "";
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
