using Builder.CarExample.Builder;

namespace Builder.CarExample.ConcreteBuilder
{
    public sealed class SUVType : CarBuilder
    {
        public override void CarPreferences()
        {
            newCar.Engine = 3.0M;
            newCar.HasMedia = true;
            newCar.Seats = 9;
            newCar.HasTracking = true;
        }
    }
}
