using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Taxi.src;

namespace Taxi
{


    public class Order : IOrder
    {
        public int Price { get; set; }
        public StartPoint StartPoint { get; set; }
        public Address DestinationPoint { get; set; }

        public Auto Auto { get; set; }

        

        public Customer Customer { get; set; }
        public Order(){}

        public Order(StartPoint startPoint, Address destinationPoint, Customer customer)
        {
            Price = 100;
            StartPoint = startPoint;
            DestinationPoint = destinationPoint;
            Customer = customer;
        }
    }
}
