namespace AddTwoNewFlavors
{
    public class BunStore
    {
        public Bun orderQfStyleBun(string bunName)
        {
            Cook qfStyleCook = new QfStyleCook();
            Waiter waiter = new Waiter(qfStyleCook);
            return waiter.DishOut(bunName);
        }

        public Bun orderGblStyleBun(string bunName)
        {
            Waiter waiter = new Waiter(gblStyleCook);
            return waiter.DishOut(bunName);
        }
    }
}