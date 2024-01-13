using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi
{
    public class StartPoint : Address
    {
        public int EntranceNumber { get; set; }

        public StartPoint() { }

        public StartPoint(String street, int houseNumber, int entranceNumber = 1)
            :base(street, houseNumber)
        {
            EntranceNumber = entranceNumber;
        }
    }
}
