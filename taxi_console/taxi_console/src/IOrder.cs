using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi.src
{
    internal interface IOrder
    {
        public int Price { get; set; }
        public StartPoint StartPoint { get; set; }
        public Address DestinationPoint { get; set; }
    }
}
