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
            set
            {
                if (value == "mountain" || value == "road")
                {
                    _type = value;
                }
                else
                    throw new ArgumentException("type is wrong");
            }
        }
        public string Wheels
        {
            get { return _wheels; }
            set
            {
                if (value == "small" || value == "large")
                {
                    _wheels = value;
                }
                else
                    throw new ArgumentException("wheel is wrong");
            }
        }
        public string Size
        {
            get { return _size; }
            set
            {
                if (value == "small" || value == "medium" || value == "large")
                {
                    _size = value;
                }
                else
                    throw new ArgumentException("type is wrong");
            }
        }
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public string Gears
        {
            get { return _gears; }
            set
            {
                if (value == "Type A" || value == "Type B")
                {
                    _gears = value;
                }
                else
                    throw new ArgumentException("gear is wrong");
            }
        }
        public string Brakes
        {
            get { return _brakes; }
            set
            {
                if (value == "Type A" || value == "Type B")
                {
                    _brakes = value;
                }
                else
                    throw new ArgumentException("brakes is wrong");
            }
        }
        public string Handlebars
        {
            get { return _handlebars; }
            set
            {
                if (value == "Type A" || value == "Type B")
                {
                    _handlebars = value;
                }
                else
                    throw new ArgumentException("handlebars are wrong");
            }
        }
        public string Saddle
        {
            get { return _saddle; }
            set
            {
                if (value == "Type A" || value == "Type B")
                {
                    _saddle = value;
                }
                else
                    throw new ArgumentException("saddle is wrong");
            }
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
