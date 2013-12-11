namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkStuffing : Stuffing
    {
        public QfStyleGreenOnionAndPorkStuffing()
        {
            Desc += "Got mixed stuffing of Green Onion and Pork bun from QF Ingredient Factory.";
        }
        public override string GetDesc()
        {
            return Desc;
        }
    }
}