using Builder.CarExample.Builder;
using Builder.CarExample.Product;

namespace Builder.CarExample.ConcreteBuilder
{
    public class HeroBuilder : IVehicleBuilder
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
            vehicle.Model = "Hero";
        }

        public void SetTransmission()
        {
            vehicle.Transmission = "120 km/hr";
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
        }
    }
}
