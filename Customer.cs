using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureApp
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone_number { get; set; }

        override public string ToString()
        {
            return Name 
                + " | " + Address
                + " | " + Phone_number;
        }
    }    

    class Manufacturer
    {
        public string OGRN { get; set; }
        public string Name { get; set; }

        override public string ToString()
        {
            return OGRN
                + " | " + Name;
        }
    }

    class Contract
    {
        public int ID_customer { get; set; }
        public DateTime Date_of_issue { get; set; }
        public DateTime Due_date { get; set; }
        public string IsVisible { get; set; }

        override public string ToString()
        {
            return ID_customer
                + " | " + Date_of_issue
                + " | " + Due_date
                + " | " + IsVisible
                ;
        }
    }

    class Model
    {
        public string ID_model { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }

        override public string ToString()
        {
            return ID_model
                + " | " + Name
                + " | " + Cost
                + " | " + Manufacturer
                + " | " + Description
                ;
        }
    }

    class Sale
    {
        public int ID_contract { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }

        override public string ToString()
        {
            return ID_contract
                + " | " + Model
                + " | " + Amount
                ;
        }
    }
}
