using Builder.HouseExample.Product;

namespace Builder.HouseExample.Builder
{
    public abstract class HouseBuilder
    {
        protected House newHouse;

        public void BuildNewHouse()
        {
            this.newHouse = new House();
        }
        public abstract void HousePreferences();

        public abstract void FinalHouse();

        public House GetHouse()
        {
            return newHouse;
        }
    }
}
