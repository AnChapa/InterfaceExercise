using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Model {  get; set; }
        public double Mileage { get; set; }
        public int NumOfSeats { get; set; }
        public int NumOfWheels { get; set; }

        public void DisplayInfo();
    }
}
