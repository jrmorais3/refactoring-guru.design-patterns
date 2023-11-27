using Builder.CarExample.Product;

namespace Builder.CarExample.Builder
{
    public interface IVehicleBuilder
    {
        public void SetModel();
        public void SetEngine();
        public void SetTransmission();
        public void SetBody();
        public void SetAccessories();

        Vehicle GetVehicle();

    }
}
