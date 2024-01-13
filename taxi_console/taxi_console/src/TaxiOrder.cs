using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using static Taxi.Auto;

namespace Taxi
{

    
    public class TaxiOrder : Order
    {
        
        public carClasses DemandCarClass { get; set; }
        public bool NeedBabyChair { get; set; }
        public bool NeedAnimalCage { get; set; }

        public TaxiOrder():base() { }
        public TaxiOrder(StartPoint startPoint, Address destinationPoint,
                            carClasses demandCarClass, Customer customer, bool needBabyChair = false, bool needAnimalCage = false)
            : base(startPoint, destinationPoint, customer)
        {
 
            
            switch(demandCarClass)
            {
                case carClasses.Econom:
                    Price = 100;
                    break;

                case carClasses.Comfort:
                    Price = 150;
                    break;

                case carClasses.Business:
                    Price = 250;
                    break;

                case carClasses.MiniBus:
                     Price = 150;
                     break;

                }

            if (needAnimalCage) Price += 50;

            if (needBabyChair) Price += 50;




            DemandCarClass = demandCarClass;
            NeedBabyChair = needBabyChair;
            NeedAnimalCage = needAnimalCage;
        }
    }
}
