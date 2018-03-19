using System;
using System.Windows;

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
        double percent10;

        public Payment(Bike _bike, Customer _customer)
        {
            InitializeComponent();
            bike = _bike;
            customer = _customer;
            leftToPay.Content = "£ " + _bike.TotalPrice;
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            if (cardnumber.Text == null)
            {
                MessageBox.Show("enter card details");
            }
            else if (onlyDigits(cardnumber.Text) == true)
            {
                customer.CardNumber = Convert.ToInt32(cardnumber.Text);

                // If the bank accepts payment
                customer.Accepted = true;

                percent10 = bike.TotalPrice * 0.10;
                left = bike.TotalPrice - percent10;
                leftToPay.Content = "£ " + left;
            }
            else
            {
                MessageBox.Show("do not leave spaces between the numbers");
            }
        }

        public bool onlyDigits(string str)
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
            Receipt r = new Receipt(bike, left);
            r.Show();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Customer_Details cd = new Customer_Details(bike);
            cd.Show();
            this.Close();
        }
    }
}
