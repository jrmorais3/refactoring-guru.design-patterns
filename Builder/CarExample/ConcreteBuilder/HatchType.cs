using Builder.CarExample.Builder;

namespace Builder.CarExample.ConcreteBuilder
{
    public sealed class HatchType : CarBuilder
    {
        public override void CarPreferences()
        {
            newCar.Engine = 1.0M;
            newCar.HasMedia = true;
            newCar.Seats = 5;
            newCar.HasTracking = false;

        }
    }
}
