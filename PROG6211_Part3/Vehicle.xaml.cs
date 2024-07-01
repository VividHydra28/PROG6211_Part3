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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        string UserInput3;
        string ModelandMake;
        int PurchasePrice;
        int TotalDeposit;

        int InterestAmount;
        // int InterestRate;

        int InsurancePremium;

        int vehicleMonthlyCost; //This variable is used to hold the total monthly vehicle cost
        public int RepaymentCost;
        int timeperiod = 12; //The 12 month time period for the vehicle
        int value_amount;
        // int totalmonths = 60;

        public double ExpenseCalc;

        //public WorkerClass WC = new WorkerClass()
        public Vehicle()
        {
            InitializeComponent();
        }

        private void EnterInput(object sender, RoutedEventArgs e)
        {
            ModelandMake = ModelandMakeBox.Text;
            PurchasePrice = int.Parse(PurchasePriceBox.Text);
            TotalDeposit = int.Parse(TotalDepositBox.Text);
            InsurancePremium = int.Parse(InsurancePremiumBox.Text);

            vehicleMonthlyCost = PurchasePrice - TotalDeposit;
            int InterestRate = InterestAmount / 100;
            int totalmonths = 60;

            value_amount = vehicleMonthlyCost = (1 + InterestRate * totalmonths);
            RepaymentCost = (value_amount / totalmonths) + InsurancePremium;

            VehicleResultsBox.Text = ("\n************************************************************************************\t" +
                "\nMake And Model Price \t                       " + ModelandMakeBox + "\nPurchase Price\t                 R" +
                PurchasePriceBox.ToString() + "\nTotal Deposit \t                      R" + TotalDepositBox.ToString() + "\n Interest\t" +
                "\nInsurance\t                           R " + InsurancePremiumBox.ToString() + "\n Monthly Repayment \t R" + vehicleMonthlyCost);

        }

        private void ModelandMakeBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PurchasePriceBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TotalDepositBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InsurancePremiumBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
