using Builder.CarExample.ConcreteBuilder;
using Builder.CarExample.Director;
using Builder.HouseExample.ConcreteBuilder;
using Builder.HouseExample.Director;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car Example
            var chevrolet = new CarFactory(new HatchType());
            chevrolet.Order();
            var onix = chevrolet.GetNewCar();
            onix.FinalCar("Onix");

            //House Example
            var newOrder = new RoutineHouse();
            var mouraDubex = new HouseContractor(newOrder);
            mouraDubex.Order();
            mouraDubex.houseBuilder.FinalHouse();

            Console.ReadKey();
        }
    }
}
