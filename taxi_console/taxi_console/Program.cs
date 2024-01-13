using System;
using static Taxi.DeliveryOrder;
using static Taxi.TaxiOrder;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {

            TaxiCompany taxiCompany1 = new TaxiCompany();

            Auto auto1 = new Auto("Kia Rio", "KA2632НР", "White", Auto.carClasses.Econom, isAvailable: true);
            Auto auto2 = new Auto("Skoda Octavia", "AI2284НВ", "Blue", Auto.carClasses.Econom, isAvailable: true);
            Auto auto3 = new Auto("Kia Optima", "КА3516НР", "White", Auto.carClasses.Econom, isAvailable: true);

            Auto auto4 = new Auto("VW Transporter", "CВ9375НВ", "White", Auto.carClasses.MiniBus, isAvailable: true);

            Auto auto5 = new Auto("Toyota Camry", "КА8831", "Grey", Auto.carClasses.Comfort, isAvailable: true);
            Auto auto6 = new Auto("Hyundai Elantra", "КА0380", "Blue", Auto.carClasses.Comfort, isAvailable: true);

            Auto auto7 = new Auto("Mercedes-Maybach S-Class", "КИ8888ЕВ", "Black", Auto.carClasses.Business, isAvailable: true);
            Auto auto8 = new Auto("BMW 7 Series", "КА7777НР", "Black", Auto.carClasses.Business, isAvailable: true);

            Auto auto9 = new Auto("Skoda fabia", "КА4253НК", "Black", Auto.carClasses.Econom, isAvailable: true, haveAnimalCage:true,haveBabyСhair:true);

            taxiCompany1.CarsList.AddRange(new List<Auto>() { auto1, auto2, auto3, auto4, auto5, auto6, auto7, auto8, auto9 });

            //StartPoint sp = new StartPoint("Yanhelya", 7);
            //Address address = new Address("Lomonosova", 28);
            //Customer customer = new Customer("Illia", "0508529087");


            //TaxiOrder order = new TaxiOrder(sp, address, Auto.carClasses.MiniBus, customer, needAnimalCage: true, needBabyChair: true) ; 
            //TaxiOrder order2 = new TaxiOrder(sp, address, Auto.carClasses.MiniBus, customer);

            //taxiCompany1.AddOrder(order);
            //taxiCompany1.AddOrder(order2);

            //Console.WriteLine(order2.Price.ToString());

            string file = @"D:\Education\Programming\Term3\Саша\Taxi\taxi_console\taxi_console\xml\TaxiCompany.xml";

            taxiCompany1.toXmlFile(file);

            
            TaxiCompany taxiCompany2 = TaxiCompany.ReadFromFile(file);

            Console.WriteLine(taxiCompany2.CarsList[7].Model);
        }
    }
}
