using Builder.CarExample.Product;

namespace Builder.CarExample.Builder
{
    public abstract class CarBuilder
    {
        protected Car newCar;

        public void BuildCar()
        {
            newCar = new Car();
        }

        public Car GetCar()
        {
            return newCar;
        }

        public abstract void CarPreferences();

    }
}
