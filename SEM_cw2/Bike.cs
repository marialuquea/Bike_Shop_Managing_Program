using System;

namespace SEM_cw2
{
    public class Bike
    {
        private int _id;
        private string _type;
        private string _wheels;
        private string _size;
        private string _colour;
        private string _gears;
        private string _brakes;
        private string _handlebars;
        private string _saddle;

        private Boolean _extendedWarranty;

        private double _totalPrice;

        private double _estimatedDays;

        private Customer _customer;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type  = value; }
        }
        public string Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public string Gears
        {
            get { return _gears; }
            set { _gears = value; }
        }
        public string Brakes
        {
            get { return _brakes; }
            set { _brakes = value; }
        }
        public string Handlebars
        {
            get { return _handlebars; }
            set { _handlebars = value; }
        }
        public string Saddle
        {
            get { return _saddle; }
            set { _saddle = value; }
        }
        public Boolean ExtendedWarranty
        {
            get { return _extendedWarranty; }
            set { _extendedWarranty = value; }
        }
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        public double EstimatedDays
        {
            get { return _estimatedDays; }
            set { _estimatedDays = value; }
        }
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

    }
}
