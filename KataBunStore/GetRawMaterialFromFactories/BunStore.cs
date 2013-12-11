namespace GetRawMaterialFromFactories
{
    public class BunStore
    {
        public Bun OrderQfStyleBun(string bunName)
        {
            return new QfStyleGreenOnionAndPorkBun();
        }
    }
}