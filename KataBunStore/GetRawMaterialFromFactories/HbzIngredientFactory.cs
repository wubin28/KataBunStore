namespace GetRawMaterialFromFactories
{
    public class HbzIngredientFactory : BunIngredientFactory
    {
        public override Stuffing CreateStuffing()
        {
            return new HbzStylePorkStuffing();
        }

        public override Flour CreateFlour()
        {
            return new HbzStyleFlour();
        }
    }
}