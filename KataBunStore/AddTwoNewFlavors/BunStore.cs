namespace AddTwoNewFlavors
{
    public class BunStore
    {
        public static Bun OrderQfStyleBun(string bunName)
        {
            Cook qfStyleCook = new QfStyleCook();
            Waiter waiter = new Waiter(qfStyleCook);
            return waiter.DishOut(bunName);
        }

        public static Bun OrderGblStyleBun(string bunName)
        {
            Cook gblStyleCook = new GblStyleCook();
            Waiter waiter = new Waiter(gblStyleCook);
            return waiter.DishOut(bunName);
        }

        public static Bun OrderHbzStyleBun(string bunName)
        {
            Cook hbzStyleCook = new HbzStyleCook();
            Waiter waiter = new Waiter(hbzStyleCook);
            return waiter.DishOut(bunName);
        }
    }
}