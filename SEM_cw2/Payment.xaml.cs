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

namespace SEM_cw2
{
    /// <summary>
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        Bike bike;
        Customer customer;
        double left;

        public Payment(Bike _bike, Customer _customer)
        {
            InitializeComponent();
            bike = _bike;
            customer = _customer;
            leftToPay.Content = "£ " + _bike.TotalPrice;
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            if (cardnumber == null)
            {
                MessageBox.Show("enter card details");
            }
            else if (IsDigitsOnly(cardnumber.Text) == true)
            {
                customer.CardNumber = Convert.ToInt32(cardnumber.Text);

                // If the bank accepts payment
                customer.Accepted = true;
            }
            else
            {
                MessageBox.Show("do not leave spaces between the numbers");
            }
        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("printing paper receipt");

            double percent10 = bike.TotalPrice * 0.10;
            left = bike.TotalPrice - percent10;

            leftToPay.Content = "£ " + left;
        }

        private void viewDetails_Click(object sender, RoutedEventArgs e)
        {
            Receipt r = new Receipt(bike, left);
            r.Show();
        }
    }
}
