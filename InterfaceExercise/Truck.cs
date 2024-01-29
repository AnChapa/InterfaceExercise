using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public double BedArea { get; set; }
        public double Torque { get; set; }
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
            Console.WriteLine($"The {Manufacturer} {Model} is a great Truck on {NumOfWheels} wheels.\nHaving {NumOfSeats} number of seats a bed area of {BedArea} feet, its a reliable workhorse!");
            Console.WriteLine($"With {Mileage} mpg and {Torque} lb-ft of torque, it can pull a heavy load while sipping gas!\nWith the {Logo} leading you, you can't go wrong!");
        }
    }
}
