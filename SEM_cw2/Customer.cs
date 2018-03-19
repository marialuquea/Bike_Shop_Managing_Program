using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_cw2
{
    public class Customer : Person
    {
        private List<Bike> _bikes;
        private int _cardNumber;
        private Boolean _accepted;

        private string _address;
        private string _email;
        
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

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
