using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Taxi
{
    [Serializable]
    [XmlInclude(typeof(DeliveryOrder))]
    public class DeliveryOrder : Order
    {
        public enum vehicleTypes
        {
            lorry,
            car
        }
        public vehicleTypes VehicleType { get; set; }

        public DeliveryOrder():base() { }
        public DeliveryOrder(StartPoint startPoint, Address destinationPoint, vehicleTypes vehicleType, Customer customer) 
            : base(startPoint, destinationPoint, customer)
        {
            VehicleType = vehicleType;
            if (vehicleType == vehicleTypes.lorry) Price = 500;
            else Price = 100;
        }
    }
}
