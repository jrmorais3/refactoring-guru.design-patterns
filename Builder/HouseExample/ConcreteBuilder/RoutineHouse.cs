using Builder.HouseExample.Builder;

namespace Builder.HouseExample.ConcreteBuilder
{
    public class RoutineHouse : HouseBuilder
    {
        public override void HousePreferences()
        {
            newHouse.Size = "160m²";
            newHouse.Rooms = 2;
            newHouse.ParkingSpaces = 2;
        }

        public override void FinalHouse()
        {
            Console.WriteLine($"Size: {newHouse.Size}");
            Console.WriteLine($"Rooms: {newHouse.Rooms}");
            Console.WriteLine($"ParkingSpaces: {newHouse.ParkingSpaces}");
        }
    }
}
