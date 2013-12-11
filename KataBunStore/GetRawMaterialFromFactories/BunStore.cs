namespace GetRawMaterialFromFactories
{
    public class BunStore
    {
        public Bun OrderQfStyleBun(string bunName)
        {
            return new QfStyleGreenOnionAndPorkBun();
        }

        public Bun OrderGblStyleBun(string bunName)
        {
            return new GblStylePorkBun();
        }
    }
}