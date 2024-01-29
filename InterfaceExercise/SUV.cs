using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public double GroundClerance { get; set; }
        public double TowingCapacity { get; set; }
        //IVehicle
        public string Model { get; set; }
        public double Mileage { get; set; }
        public int NumOfSeats { get; set; }
        public int NumOfWheels { get; set; }
        //ICompany
        public string Manufacturer { get; set; }
        public string Logo { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"The {Manufacturer} {Model} is a great SUV on {NumOfWheels} wheels.\nHaving {NumOfSeats} number of seats and {TowingCapacity} pounds of towing capacity, it is perfect for long roadtrips with a camper.");
            Console.WriteLine($"The {GroundClerance} inches of ground clearence help with this, and at {Mileage} mpg, there is not much stopping you!\nWith the {Logo} leading you, you can't go wrong!");
        }
    }
}
