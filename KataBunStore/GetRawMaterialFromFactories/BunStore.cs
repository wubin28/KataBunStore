namespace GetRawMaterialFromFactories
{
    public class BunStore
    {
        public Bun OrderQfStyleBun(string bunName)
        {
            Cook qfStyleCook = new QfStyleCook();
            Waiter waiter = new Waiter(qfStyleCook);
            return waiter.DishOut(bunName);
        }

        public Bun OrderGblStyleBun(string bunName)
        {
            Cook gblStyleCook = new GblStyleCook();
            Waiter waiter = new Waiter(gblStyleCook);
            return waiter.DishOut(bunName);
        }

        public Bun OrderHbzStyleBun(string bunName)
        {
            Waiter waiter = new Waiter(hbzStyleCook);
            return waiter.DishOut(bunName);
        }
    }
}