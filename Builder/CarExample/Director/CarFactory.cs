using Builder.CarExample.Builder;
using Builder.CarExample.Product;

namespace Builder.CarExample.Director
{
    public class CarFactory
    {
        private readonly CarBuilder carBuilder;

        public CarFactory(CarBuilder builder)
        {
            carBuilder = builder;
        }

        public Car GetNewCar()
        {
            return carBuilder.GetCar();
        }

        public void Order()
        {
            carBuilder.BuildCar();
            carBuilder.CarPreferences();
        }
    }
}
