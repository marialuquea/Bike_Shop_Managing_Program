using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Customer_Details.xaml
    /// </summary>
    public partial class Customer_Details : Window
    {
        Bike bike;
        Customer customer = new Customer();

        public Customer_Details(Bike _bike)
        {
            InitializeComponent();
            bike = _bike;
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            if (findEmail == null)
            {
                MessageBox.Show("enter email to find customer");
            }
            else if(IsValidEmail(findEmail.Text) == true)
            {
                // if everything is right
                MessageBox.Show("customer found");
                findEmail.Text = "Tom";
                find.IsEnabled = false;
                add.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("email format not correct");
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (name == null
                || address == null
                || email == null
                || postcode == null)
            {
                MessageBox.Show("enter all details");
            }
            else
            {
                if (IsValidEmail(email.Text) == false)
                {
                    MessageBox.Show("email is wrong");
                }
                else
                {
                    if (ValidateUkPostcode(postcode.Text) == false)
                    {
                        MessageBox.Show("Postcode is wrong");
                    }
                    else
                    {
                        // Everything is correct
                        customer.Name = name.Text;
                        customer.Address = address.Text + " " + postcode.Text;
                        customer.Email = email.Text;

                        add.IsEnabled = false;
                    }
                }
            }
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public static bool ValidateUkPostcode(string postcode)
        {
            return Regex.Match(postcode, "(^gir\\s?0aa$)|(^[a-z-[qvx]](\\d{1,2}|[a-hk-y]\\d{1,2}|\\d[a-hjks-uw]|[a-hk-y]\\d[abehmnprv-y])\\s?\\d[a-z-[cikmov]]{2}$)", RegexOptions.IgnoreCase).Success;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Payment p = new Payment(bike, customer);
            p.Show();
            this.Close();
        }
    }
}
