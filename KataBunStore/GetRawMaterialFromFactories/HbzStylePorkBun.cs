namespace GetRawMaterialFromFactories
{
    public class HbzStylePorkBun : Bun
    {
        public HbzStylePorkBun(BunIngredientFactory hbzIngredientFactory)
        {
            Stuffing = hbzIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.Desc;

            Flour = hbzIngredientFactory.CreateFlour();
            StepDesc += Flour.Desc;
        }

    }
}