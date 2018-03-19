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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SEM_cw2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int id = 1;
        public MainWindow()
        {
            InitializeComponent();
            Road.Background = Brushes.White;
            Mountain.Background = Brushes.White;
            Small.Background = Brushes.White;
            medium.Background = Brushes.White;
            large.Background = Brushes.White;
            wheels_large.Background = Brushes.White;
            wheels_small.Background = Brushes.White;
        }

        Bike bike = new Bike();

        private void Road_Click(object sender, RoutedEventArgs e)
        {
            Road.Background = Brushes.LightBlue;
            Mountain.Background = Brushes.White;

            bike.Type = "road";
        }

        private void Mountain_Click(object sender, RoutedEventArgs e)
        {
            Mountain.Background = Brushes.LightBlue;
            Road.Background = Brushes.White;

            bike.Type = "mountain";
        }

        private void wheels_small_Click(object sender, RoutedEventArgs e)
        {
            wheels_small.Background = Brushes.LightBlue;
            wheels_large.Background = Brushes.White;

            bike.Wheels = "small";
        }

        private void wheels_large_Click(object sender, RoutedEventArgs e)
        {
            wheels_large.Background = Brushes.LightBlue;
            wheels_small.Background = Brushes.White;

            bike.Wheels = "large";
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            Small.Background = Brushes.LightBlue;
            medium.Background = Brushes.White;
            large.Background = Brushes.White;

            bike.Size = "small";
        }

        private void medium_Click(object sender, RoutedEventArgs e)
        {
            medium.Background = Brushes.LightBlue;
            Small.Background = Brushes.White;
            large.Background = Brushes.White;

            bike.Size = "medium";
        }

        private void large_Click(object sender, RoutedEventArgs e)
        {
            large.Background = Brushes.LightBlue;
            Small.Background = Brushes.White;
            medium.Background = Brushes.White;

            bike.Size = "large";
        }

        private void grey_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "grey";

            grey.Content = "Ok";
            blue.Content = "";
            green.Content = "";
            orange.Content = "";
            yellow.Content = "";
            red.Content = "";
            purple.Content = "";
        }

        private void blue_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "blue";

            grey.Content = "";
            blue.Content = "Ok";
            green.Content = "";
            orange.Content = "";
            yellow.Content = "";
            red.Content = "";
            purple.Content = "";
        }

        private void green_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "green";

            grey.Content = "";
            blue.Content = "";
            green.Content = "Ok";
            orange.Content = "";
            yellow.Content = "";
            red.Content = "";
            purple.Content = "";
        }

        private void orange_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "orange";

            grey.Content = "";
            blue.Content = "";
            green.Content = "";
            orange.Content = "Ok";
            yellow.Content = "";
            red.Content = "";
            purple.Content = "";
        }

        private void yellow_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "yellow";

            grey.Content = "";
            blue.Content = "";
            green.Content = "";
            orange.Content = "";
            yellow.Content = "Ok";
            red.Content = "";
            purple.Content = "";
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "red";

            grey.Content = "";
            blue.Content = "";
            green.Content = "";
            orange.Content = "";
            yellow.Content = "";
            red.Content = "Ok";
            purple.Content = "";
        }

        private void purple_Click(object sender, RoutedEventArgs e)
        {
            bike.Colour = "purple";

            grey.Content = "";
            blue.Content = "";
            green.Content = "";
            orange.Content = "";
            yellow.Content = "";
            red.Content = "";
            purple.Content = "Ok";
        }

        private void gears_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string type = gears.SelectedValue.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "");
            bike.Gears = type;
        }

        private void handlebars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string type = handlebars.SelectedValue.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "");
            bike.Handlebars = type;
        }

        private void brakes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string type = brakes.SelectedValue.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "");
            bike.Brakes = type;
        }

        private void saddle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string type = saddle.SelectedValue.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "");
            bike.Saddle = type;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bike.ExtendedWarranty = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            bike.ExtendedWarranty = false;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (bike.Type == null 
                || bike.Wheels == null
                || bike.Size == null
                || bike.Size == null
                || bike.Colour == null
                || bike.Gears == null
                || bike.Brakes == null
                || bike.Handlebars == null
                || bike.Saddle == null)
            {
                MessageBox.Show("pls enter all details");
            }
            else
            {
                bike.ID = id;
                id++;

                Order_Details od = new Order_Details(bike);
                od.Show();
                this.Close();
            }
        }

       
    }
}
