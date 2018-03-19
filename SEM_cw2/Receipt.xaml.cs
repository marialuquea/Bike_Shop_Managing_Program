using System;
using System.Windows;

namespace SEM_cw2
{
    /// <summary>
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Window
    {

        public Receipt(Bike _bike, Double _left)
        {
            InitializeComponent();
            type.Content = _bike.Type;
            wheels.Content = _bike.Wheels;
            size.Content = _bike.Size;
            colour.Content = _bike.Colour;
            gears.Content = _bike.Gears;
            brakes.Content = _bike.Brakes;
            handlebars.Content = _bike.Handlebars;
            saddle.Content = _bike.Saddle;
            id.Content = _bike.ID;
            totalCost.Content = "£ " + _bike.TotalPrice;
            leftToPay.Content = "£ " + _left;
            days.Content = _bike.EstimatedDays;
            warranty.Content = _bike.ExtendedWarranty;

        }
    }
}
