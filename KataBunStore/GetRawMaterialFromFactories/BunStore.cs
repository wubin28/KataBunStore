namespace GetRawMaterialFromFactories
{
    public class BunStore
    {
        public Bun OrderQfStyleBun(string bunName)
        {
            return waiter.dishOut(bunName);
        }

        public Bun OrderGblStyleBun(string bunName)
        {
            return new GblStylePorkBun();
        }
    }
}