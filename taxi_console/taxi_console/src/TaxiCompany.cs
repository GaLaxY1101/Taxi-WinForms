using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Taxi
{
    [Serializable]
    [XmlInclude(typeof(TaxiCompany))]
    [XmlRoot("TaxiCompany")]
    public class TaxiCompany
    {
        public delegate void TaxiCompanyHadnler(string message);
        public event TaxiCompanyHadnler CarsNotFoundEvent;

        private void PrintMessage(string message) => Console.WriteLine(message);

        public List<Auto> CarsList { get; set; }
        public List<Order> OrderList { get; set; }

        public void AddTaxiOrder(TaxiOrder order)
        {
            SetCarToTaxiOrder(order);
            if (order.Auto != null)
            { 
                OrderList.Add(order);
            }
        }

        public void AddDeliveryOrder(DeliveryOrder order)
        {
            SetCarToDeliveryOrder(order);
            if (order.Auto != null)
            {
                OrderList.Add(order);
            }
        }

        public void SetCarToTaxiOrder(TaxiOrder order)
        { 

            if (order.NeedBabyChair == false && order.NeedAnimalCage == false)
            {
                var suitableCars = CarsList.Where(Auto => Auto.IsAvailable == true && Auto.CarClass == order.DemandCarClass);

                try 
                {
                    
                    order.Auto = suitableCars.First();
                    order.Auto.IsAvailable = false;
                }
                catch(System.InvalidOperationException ex)
                {
                    CarsNotFoundEvent?.Invoke("There're no available cars. Please try again later.");
                }
                
                    

            }
            else if (order.NeedBabyChair == true && order.NeedAnimalCage == false)
            {
                var suitableCars = CarsList.Where(Auto => Auto.IsAvailable == true && Auto.CarClass == order.DemandCarClass && Auto.HaveBabyСhair == true && Auto.HaveAnimalCage == true);

                
                try
                {
                    
                    order.Auto = suitableCars.First();
                    order.Auto.IsAvailable = false;
                }
                catch (System.InvalidOperationException ex)
                {
                    CarsNotFoundEvent?.Invoke("There're no available cars. Please try again later.");
                }
            }
            else
            {
                var suitableCars = CarsList.Where(Auto => Auto.IsAvailable == true && Auto.CarClass == order.DemandCarClass && Auto.HaveAnimalCage == true);

                try
                {
                    order.Auto = suitableCars.First();
                    order.Auto.IsAvailable = false;
                   
                }
                catch (System.InvalidOperationException ex)
                {
                    CarsNotFoundEvent?.Invoke("There're no available cars. Please try again later.");
                }
            }
        }

        public void SetCarToDeliveryOrder(DeliveryOrder order)
        {
            IEnumerable<Auto> suitableCars;
            if (order.VehicleType == DeliveryOrder.vehicleTypes.car)
            { 
                suitableCars = CarsList.Where(Auto => Auto.IsAvailable == true && Auto.CarClass != Taxi.Auto.carClasses.MiniBus);
            }
            else
            {
                suitableCars = CarsList.Where(Auto => Auto.IsAvailable == true && Auto.CarClass == Taxi.Auto.carClasses.MiniBus);
            }

            try
            {

                order.Auto = suitableCars.First();
                order.Auto.IsAvailable = false;
            }
            catch (System.InvalidOperationException ex)
            {
                CarsNotFoundEvent?.Invoke("There're no available cars. Please try again later.");
            }
        }


        public TaxiCompany()
        {
            CarsList = new List<Auto>();
            OrderList = new List<Order>();
            
            //CarsNotFoundEvent += (String message) => Console.WriteLine(message);
        }

        public void toXmlFile(String path)
        {
            Type[] types = new Type[] { typeof(TaxiOrder), typeof(DeliveryOrder) };

            XmlSerializer serializer = new XmlSerializer(typeof(TaxiCompany), types);
            
            

            using (Stream writer = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static TaxiCompany ReadFromFile(String path)
        {
            Type[] types = new Type[] { typeof(TaxiOrder), typeof(DeliveryOrder) };
            XmlSerializer serializer = new XmlSerializer(typeof(TaxiCompany), types);

            using (Stream reader = new FileStream(path, FileMode.Open))
            {
                return (TaxiCompany)serializer.Deserialize(reader);
            }
        }
    }
}
