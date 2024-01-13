using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Taxi
{
    public class Customer
    {
        public String Name {get; set;}
        public String PhoneNumber {get; set;}

        public Customer(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public Customer() { }
    }
}
