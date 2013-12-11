namespace AddTwoNewFlavors
{
    public class BunStore
    {
        public Bun orderQfStyleBun(string bunName)
        {
            return waiter.dishOut(bunName);
        }

        public Bun orderGblStyleBun(string bunName)
        {
            return new Bun();
        }
    }
}