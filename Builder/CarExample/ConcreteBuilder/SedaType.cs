using Builder.CarExample.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarExample.ConcreteBuilder
{
    public sealed class SedaType : CarBuilder
    {
        public override void CarPreferences()
        {
            newCar.Engine = 1.8M;
            newCar.HasMedia = true;
            newCar.Seats = 7;
            newCar.HasTracking = true;
        }
    }
}
