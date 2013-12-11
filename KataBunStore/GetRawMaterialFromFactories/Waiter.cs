namespace GetRawMaterialFromFactories
{
    public class Waiter
    {
        private Cook cook;

        public Waiter(Cook cook)
        {
            this.cook = cook;
        }

        public Bun DishOut(string bunName)
        {
            return this.cook.MakeBun(bunName);
        }
    }
}