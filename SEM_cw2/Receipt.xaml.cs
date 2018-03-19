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

        }
    }
}
