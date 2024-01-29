using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(new Car()
            {
                Manufacturer = "Subaru",
                Model = "Impreza",
                Mileage = 36,
                NumOfSeats = 5,
                NumOfWheels = 4,
                TrunkSize = 12.3,
                ZeroToSixty = 8.5,
                Logo = "Six stars"
            });
            vehicles.Add(new SUV()
            {
                Manufacturer = "Volvo",
                Model = "XC90",
                Mileage = 30,
                NumOfSeats = 7,
                NumOfWheels = 4,
                GroundClerance = 9.4,
                TowingCapacity = 5000,
                Logo = "Circle with arrow"
            });
            vehicles.Add(new Truck()
            {
                Manufacturer = "Chevrolet",
                Model = "Silverado",
                Mileage = 23,
                NumOfSeats = 6,
                NumOfWheels = 4,
                BedArea = 8,
                Torque = 383,
                Logo = "Gold bowtie"
            });

            foreach( var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
