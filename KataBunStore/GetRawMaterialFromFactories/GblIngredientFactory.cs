namespace GetRawMaterialFromFactories
{
    public class GblIngredientFactory : BunIngredientFactory
    {
        public override Stuffing CreateStuffing()
        {
            return new GblStylePorkStuffing();
        }

        public override Flour CreateFlour()
        {
            return new GblStyleFlour();
        }
    }
}