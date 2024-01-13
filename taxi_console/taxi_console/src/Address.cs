using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi
{
    public class Address
    {
        public String Street { get; set; }
        public int HouseNumber { get; set; }

        public Address() { }
        public Address(String street, int houseNumber) 
        {
            Street = street;
            HouseNumber = houseNumber;
        }


        
    }
}
