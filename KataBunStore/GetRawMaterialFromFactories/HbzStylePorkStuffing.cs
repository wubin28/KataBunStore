namespace GetRawMaterialFromFactories
{
    public class HbzStylePorkStuffing : Stuffing
    {
        public HbzStylePorkStuffing()
        {
            Desc += "Got mixed stuffing of Pork bun from HBZ Ingredient Factory.";
        }
        public override string GetDesc()
        {
            return Desc;
        }
    }
}