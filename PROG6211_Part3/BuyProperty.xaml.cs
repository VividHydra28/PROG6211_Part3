using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG6211_Part3
{
    /// <summary>
    /// Interaction logic for BuyProperty.xaml
    /// </summary>
    public partial class BuyProperty : Window
    {
        public int UserInput; //this holds the user input


        public int MonthlyRentalAmount;

        public double OriginalPropertyPrice; //this holds the value of the original property price
        public double TotalDeposit; //This holds the value of the total deposit

        public double InterestRate; //This holds the interest rate from the user
        public double FinalInterestRate; // This is a placeholder for the interest calculation

        public double MonthlyPayment; //This holds the amount of months the user has entered

        double MonthlyTimePeriod; //This is a place holder used for the monthly calculations

        double MonthlyHomeLoan; // This is a placeholder the monthly home loan amount

        double GrossMonthlyIncome;
        double MonthlyTax;

        public double ExpenseTotal;

        public int UserInput2;
        public string UserInput4;

        double OtherExpenses;
        String ExpenseName;
        //---------------------------------------------------------------------------------------------------------------------------------------------//
        public BuyProperty()
        {
            InitializeComponent();
        }

        private void OriginalPropertyPriceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OriginalPropertyPrice = int.Parse(OriginalPropertyPriceBox.Text);
        }

        private void TotalDepositBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TotalDeposit = int.Parse(TotalDepositBox.Text);
        }

        private void InterestRateBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            InterestRate = int.Parse(InterestRateBox.Text);
        }

        
        private void PropertyResultsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OriginalPropertyPrice = int.Parse(OriginalPropertyPriceBox.Text);
            TotalDeposit = int.Parse(TotalDepositBox.Text);
            MonthlyTimePeriod = int.Parse(MonthlyPaymentBox.Text);
            InterestRate = int.Parse(InterestRateBox.Text);

            PropertyResultsBox.Text = ("\n*****************************************************************\t" +
                "\n OriginalPurchasePrice\t                   R" + OriginalPropertyPrice + "\nDeposit\t                     R" +
                TotalDeposit.ToString() + "\nMonthsToPay \t                          R" + MonthlyTimePeriod.ToString() + "\n Interest rate\t");
        }

        private void MonthlyPaymentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MonthlyTimePeriod = int.Parse(MonthlyPaymentBox.Text);
        }
    }
}
