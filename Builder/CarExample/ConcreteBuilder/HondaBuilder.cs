using Builder.CarExample.Builder;
using Builder.CarExample.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarExample.ConcreteBuilder
{
    public sealed class HondaBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            return vehicle;
        }

        public void SetEngine()
        {
            vehicle.Engine = "4 Stroke";
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }

        public void SetModel()
        {
            vehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            vehicle.Transmission = "125 km/hr";
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
            vehicle.Accessories.Add("Helmet");
        }
    }
}
