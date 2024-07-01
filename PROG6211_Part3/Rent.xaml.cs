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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        public int MonthlyRentalAmount;
        public Rent()
        {
            InitializeComponent();
        }

        private void RentInputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MonthlyRentalAmount = int.Parse(RentInputBox.Text);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("R"  + RentInputBox.Text);

        }
    }
}
