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
    /// Interaction logic for RentAndProperty.xaml
    /// </summary>
    public partial class RentAndProperty : Window
    {
        public RentAndProperty()
        {
            InitializeComponent();
        }

        private void RentButton(object sender, RoutedEventArgs e)
        {
            Rent RB = new Rent();
            RB.Show();
        }

        private void BuyButton(object sender, RoutedEventArgs e)
        {
            BuyProperty BP = new BuyProperty();
            BP.Show();
        }
    }
}
