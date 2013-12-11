namespace GetRawMaterialFromFactories
{
    public class GblStylePorkStuffing : Stuffing
    {
        public GblStylePorkStuffing()
        {
            Desc += "Got mixed stuffing of Pork bun from GBL Ingredient Factory.";
        }
        public override string GetDesc()
        {
            return Desc;
        }
    }
}