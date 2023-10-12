using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Payment_Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                double purchasePrice = double.Parse(txtPurchasePrice.Text);
                double downPayment = double.Parse(txtDownPayment.Text);
                double annualInterestRate = double.Parse(txtAnnualInterestRate.Text) / 100; // Convert to decimal.
                int loanTerm = int.Parse(txtLoanTerm.Text);

                double amountToFinance = purchasePrice - downPayment;
                double monthlyInterestRate = annualInterestRate / 12;
                int totalPayments = loanTerm;

                double monthlyPayment = (amountToFinance * monthlyInterestRate) *(Math.Pow(1+ monthlyInterestRate, totalPayments)) /(Math.Pow(1+ monthlyInterestRate, totalPayments) -1) ;

                txtAmountToFinance.Text = amountToFinance.ToString("C");
               txtMonthlyPayment.Text = monthlyPayment.ToString("C");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text) || string.IsNullOrWhiteSpace(txtDownPayment.Text) || string.IsNullOrWhiteSpace(txtAnnualInterestRate.Text) || string.IsNullOrWhiteSpace(txtLoanTerm.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double result;
            if (!double.TryParse(txtPurchasePrice.Text, out result) || !double.TryParse(txtDownPayment.Text, out result) || !double.TryParse(txtAnnualInterestRate.Text, out result) || !int.TryParse(txtLoanTerm.Text, out _))
            {
                MessageBox.Show("Numeric fields must contain valid numeric values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}






