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
    /// Interaction logic for Income_Expenditure.xaml
    /// </summary>
    public partial class Income_Expenditure : Window
    {
        public int Groceries; //This variable holds te grocery amount
        public int WaterAndLights; //This variable holds the Water and Lights amount
        public int TravelCosts; //This variable holds the travel costs
        public int CellphoneAndTelephone; //This variable holds the Cell phone and Telephone amount

        public String UserInput; //this holds the user input


        public int MonthlyRentalAmount;

        public double OriginalPropertyPrice; //this holds the value of the original property price
        public double TotalDeposit; //This holds the value of the total deposit

        public double InterestRate; //This holds the interest rate from the user
        public double FinalInterestRate; // This is a placeholder for the interest calculation

        public double MonthlyPayment; //This holds the amount of months the user has entered

        double MonthlyTimePeriod; //This is a place holder used for the monthly calculations

        double MonthlyHomeLoan; // This is a placeholder the monthly home loan amount

        int GrossMonthlyIncome;
       public int MonthlyTax;

        public int ExpenseTotal;

        public string UserInput2;
        public string UserInput4;

        int OtherExpenses;
        String ExpenseName;

        double MoneyAvaliable; //This variable holds the total amount of money available after all the deductions

        

        List<WorkerClass> AllExpenses = new List<WorkerClass>(); //This object is my list that holds my expenses

        //---------------------------------------------------------------------------------------------------------------------------------------------//

        

        public Income_Expenditure()
        {
            InitializeComponent();
        }

        private void GrossMonthlyIncomeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = GrossMonthlyIncomeBox.Text.ToString();
        }

        private void MonthlyTaxBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = MonthlyTaxBox.Text.ToString();
        }

        private void MonthlyGroceriesBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = MonthlyGroceriesBox.Text.ToString();
        }

        private void WaterAndLightsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = WaterAndLightsBox.Text.ToString();
        }

        private void TravelCostsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = TravelCostsBox.Text.ToString();
        }

        private void CellphoneAndTelephoneBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = CellphoneAndTelephoneBox.Text.ToString();
        }

        private void OtherExpensesBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInput = OtherExpensesBox.Text.ToString();
        }

        private void TotalAddittion(object sender, RoutedEventArgs e)
        {
            

            GrossMonthlyIncome = int.Parse(GrossMonthlyIncomeBox.Text);
            MonthlyTax = int.Parse(MonthlyTaxBox.Text);
            Groceries = int.Parse(MonthlyGroceriesBox.Text);
            WaterAndLights = int.Parse(WaterAndLightsBox.Text);
            TravelCosts = int.Parse(TravelCostsBox.Text);
            CellphoneAndTelephone = int.Parse(CellphoneAndTelephoneBox.Text);
            OtherExpenses = int.Parse(OtherExpensesBox.Text);

            ExpenseTotal = MonthlyTax + Groceries + WaterAndLights + TravelCosts + CellphoneAndTelephone + OtherExpenses;

            BudgetLedger.Text = ("\n****************************************************************************\t" +
                $"\n Gross Monthly Income: \t          R{GrossMonthlyIncomeBox.Text}  \nMonthly tax deducted: \t         R{MonthlyTaxBox.Text}  \nGroceries: \t     R{MonthlyGroceriesBox}" +
                $"\n WaterAndLights: \t      R{WaterAndLightsBox.Text}         R{TravelCostsBox.Text} \n Cellphone and Telephone:  \t    R{OtherExpensesBox.Text} \n Total_Expenses:  \t  R{ExpenseTotal.ToString()}");
        }

        private void Vehicle(object sender, RoutedEventArgs e)
        {
            Vehicle Cars = new Vehicle();
            Cars.Show();
        }

        private void BuyHouse(object sender, RoutedEventArgs e)
        {
            RentAndProperty buyPlace = new RentAndProperty();
            buyPlace.Show();
        }

        private void Property(object sender, RoutedEventArgs e)
        {
            RentAndProperty rentProperty = new RentAndProperty();
            rentProperty.Show();
        }
    }
}
