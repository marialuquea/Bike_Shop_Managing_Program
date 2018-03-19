using System;
using System.Collections.Generic;

namespace SEM_cw2
{
    public class Customer : Person
    {
        private List<Bike> _bikes;
        private int _cardNumber;
        private Boolean _accepted;
        
        public List<Bike> Bikes
        {
            get { return _bikes; }
            set { _bikes = value; }
        }

        public int CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public Boolean Accepted
        {
            get { return _accepted; }
            set { _accepted = value; }
        }
        
    }
}
