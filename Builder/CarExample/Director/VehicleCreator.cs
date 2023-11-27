using Builder.CarExample.Builder;
using Builder.CarExample.Product;

namespace Builder.CarExample.Director
{
    public class VehicleCreator
    {
        private readonly IVehicleBuilder vehicleBuilder;

        public VehicleCreator(IVehicleBuilder vehicleBuilder)
        {
            this.vehicleBuilder = vehicleBuilder;
        }

        public void CreateVehicle()
        {
            vehicleBuilder.SetModel();
            vehicleBuilder.SetEngine();
            vehicleBuilder.SetBody();
            vehicleBuilder.SetTransmission();
            vehicleBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return vehicleBuilder.GetVehicle();
        } 

    }
}
