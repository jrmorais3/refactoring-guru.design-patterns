using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarExample.Product
{
    public class Car
    {
        public int Seats { get; set; }
        public decimal Engine { get; set; }
        public bool HasMedia { get; set; }
        public bool HasTracking { get; set; }

        public void FinalCar(string carModel)
        {
            Console.WriteLine(carModel);
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Has Media: {HasMedia}");
            Console.WriteLine($"Has Tracking: {HasTracking}");
        }
    }
}
