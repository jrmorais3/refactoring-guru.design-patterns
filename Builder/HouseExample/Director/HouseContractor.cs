using Builder.HouseExample.Builder;
using Builder.HouseExample.Product;

namespace Builder.HouseExample.Director
{
    public class HouseContractor
    {
        public HouseBuilder houseBuilder { get; set; }

        public HouseContractor(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public void Order()
        {
            houseBuilder.BuildNewHouse();
            houseBuilder.HousePreferences();
        }

        public House GetNewHouse()
        {
            return houseBuilder.GetHouse();
        }

    }
}
