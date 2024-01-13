using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi
{

    public class Auto
    {
        public enum carClasses
            {
                Business,
                Comfort,
                Econom,
                MiniBus
            }
        public String Model { get; set; }
        public String CarNumber { get; set; }
        public String Colour { get; set; }
        
        public carClasses CarClass { get; set; }
        public bool HaveBabyСhair { get; set; }
        public bool HaveAnimalCage { get; set; }
        public bool IsAvailable { get; set; }

        public Auto() { }
        public Auto(String model, String carNumber, String colour, carClasses carClass, 
            bool haveBabyСhair = false, bool haveAnimalCage = false, bool isAvailable = false)
        {
            Model = model;
            CarNumber = carNumber;
            Colour = colour;
            CarClass = carClass;
            HaveBabyСhair = haveBabyСhair;
            HaveAnimalCage = haveAnimalCage;
            IsAvailable = isAvailable;
        }


    }
}
