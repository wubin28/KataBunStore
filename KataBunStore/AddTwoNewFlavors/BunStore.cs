namespace AddTwoNewFlavors
{
    public class BunStore
    {
        public Bun orderQfStyleBun(string bunName)
        {
            Waiter waiter = new Waiter(qfStyleCook);
            return waiter.dishOut(bunName);
        }

        public Bun orderGblStyleBun(string bunName)
        {
            return new Bun();
        }
    }
}