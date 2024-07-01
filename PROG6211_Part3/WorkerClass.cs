using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6211_Part3
{
    public class WorkerClass
    {
        public double Groceries; //This variable holds te grocery amount
        public double WaterAndLights; //This variable holds the Water and Lights amount
        public double TravelCosts; //This variable holds the travel costs
        public double CellphoneAndTelephone; //This variable holds the Cell phone and Telephone amount

        //This constructor is used to hold all the expense variables
        public WorkerClass(double groceries, double waterAndLights, double travelCosts, double cellphoneAndTelephone, double OtherExpenses)
        {
            Groceries = groceries;
            WaterAndLights = waterAndLights;
            TravelCosts = travelCosts;
            CellphoneAndTelephone = cellphoneAndTelephone;
        }

        public WorkerClass()
        {
        }

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

        public string UserInput2;
        public string UserInput4;

        double OtherExpenses;
        String ExpenseName;

        double MoneyAvaliable; //This variable holds the total amount of money available after all the deductions

        List<WorkerClass> AllExpenses = new List<WorkerClass>(); //This object is my list that holds my expenses
    }


}
