namespace GetRawMaterialFromFactories
{
    public class GblStylePorkBun : Bun
    {
        public GblStylePorkBun(BunIngredientFactory gblIngredientFactory)
        {
            Stuffing = gblIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.Desc;

            Flour = gblIngredientFactory.CreateFlour();
            StepDesc += Flour.Desc;
        }

    }
}