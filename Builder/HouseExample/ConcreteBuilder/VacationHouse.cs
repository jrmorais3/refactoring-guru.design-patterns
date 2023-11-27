using Builder.HouseExample.Builder;
using Builder.HouseExample.Product;

namespace Builder.HouseExample.ConcreteBuilder
{
    public class VacationHouse : HouseBuilder
    {
        public override void HousePreferences()
        {
            newHouse.Size = "300m²";
            newHouse.Rooms = 5;
            newHouse.ParkingSpaces = 8;
        }

        public override void FinalHouse()
        {
            Console.WriteLine($"Size: {newHouse.Size}");
            Console.WriteLine($"Rooms: {newHouse.Rooms}");
            Console.WriteLine($"ParkingSpaces: {newHouse.ParkingSpaces}");
        }
    }
}
