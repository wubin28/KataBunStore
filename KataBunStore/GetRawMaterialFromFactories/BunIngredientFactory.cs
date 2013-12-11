namespace GetRawMaterialFromFactories
{
    public abstract class BunIngredientFactory
    {
        public abstract Stuffing CreateStuffing();
        public abstract Flour CreateFlour();
    }
}