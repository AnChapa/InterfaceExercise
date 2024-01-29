using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public double TrunkSize {  get; set; }
        public double ZeroToSixty { get; set; }
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
            Console.WriteLine($"The {Manufacturer} {Model} is a great Car on {NumOfWheels} wheels.\nHaving {NumOfSeats} number of seats a trunk capacity of {TrunkSize} cubic feet, its a great family car.");
            Console.WriteLine($"With {Mileage} mpg and a zero to sixty time of {ZeroToSixty} seconds, it combines the best of sport and efficency!\nWith the {Logo} leading you, you can't go wrong!");
        }

        public Car()
        {

        }

    }
}
