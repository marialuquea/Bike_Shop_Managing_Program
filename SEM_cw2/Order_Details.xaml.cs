using System;
using System.Windows;

namespace SEM_cw2
{
    /// <summary>
    /// Interaction logic for Order_Details.xaml
    /// </summary>
    public partial class Order_Details : Window
    {
        Bike bike;
        int totalPrice = 0;
        double daysLeft = 0;

        public Order_Details(Bike _bike)
        {
            InitializeComponent();
            bike = _bike;
            type.Content = bike.Type;
            wheels.Content = bike.Wheels;
            size.Content = bike.Size;
            colour.Content = bike.Colour;
            gears.Content = bike.Gears;
            brakes.Content = bike.Brakes;
            handlebars.Content = bike.Handlebars;
            saddle.Content = bike.Saddle;
            id.Content = bike.ID;
            warranty.Content = bike.ExtendedWarranty;

            //calculate total price
            calculateCost();
            totalCost.Content = "£ " + totalPrice;

            //calculate estimated time
            calculateEstimatedTime();
            days.Content = daysLeft + " days";

            bike.TotalPrice = totalPrice;
            bike.EstimatedDays = daysLeft;

        }

        public void calculateCost()
        {
            // TYPE
            if (bike.Type == "road")
                totalPrice = totalPrice + 150;
            else if (bike.Type == "mountain")
                totalPrice = totalPrice + 300;

            // WHEELS
            if (bike.Wheels == "small")
                totalPrice = totalPrice + 70;
            else if (bike.Wheels == "large")
                totalPrice = totalPrice + 90;

            // GEARS
            if (bike.Gears == "Type A")
                totalPrice = totalPrice + 30;
            else if (bike.Gears == "Type B")
                totalPrice = totalPrice + 50;

            // BRAKES
            if (bike.Brakes == "Type A")
                totalPrice = totalPrice + 20;
            else if (bike.Brakes == "Type B")
                totalPrice = totalPrice + 40;

            // HANDLEBARS
            if (bike.Handlebars == "Type A")
                totalPrice = totalPrice + 25;
            else if (bike.Handlebars == "Type B")
                totalPrice = totalPrice + 30;

            // SADDLE
            if (bike.Saddle == "Type A")
                totalPrice = totalPrice + 30;
            else if (bike.Saddle == "Type B")
                totalPrice = totalPrice + 35;

            // WARRANTY
            if (bike.ExtendedWarranty == true)
                totalPrice += 50;

            // FOR BUILDING AND TESTING
            totalPrice += 100;
            
        } 

        public void calculateEstimatedTime()
        {
            Boolean inStock = true;

            if (inStock == true)
            {
                // If all items are in stock
                daysLeft += 3;
            }
            else
            {
                // If items are needed
                daysLeft += 8;
            }

            // Add half a day to complete a bike
            daysLeft += 0.5;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Customer_Details cd = new Customer_Details(bike);
            cd.Show();
            this.Close();
        }
    }
}
