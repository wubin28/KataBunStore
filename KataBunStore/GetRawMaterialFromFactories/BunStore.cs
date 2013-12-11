namespace GetRawMaterialFromFactories
{
    public class BunStore
    {
        public Bun OrderQfStyleBun(string bunName)
        {
            Waiter waiter = new Waiter(qfStyleCook);
            return waiter.dishOut(bunName);
        }

        public Bun OrderGblStyleBun(string bunName)
        {
            return new GblStylePorkBun();
        }
    }
}