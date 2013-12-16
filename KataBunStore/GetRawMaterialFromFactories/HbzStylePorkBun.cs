namespace GetRawMaterialFromFactories
{
    public class HbzStylePorkBun : Bun
    {
        public HbzStylePorkBun(BunIngredientFactory hbzIngredientFactory)
        {
            Stuffing = hbzIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.GetDesc();

            Flour = hbzIngredientFactory.CreateFlour();
            StepDesc += Flour.GetDesc();
        }

    }
}