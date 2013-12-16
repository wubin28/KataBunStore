namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkBun : Bun
    {
        public QfStyleGreenOnionAndPorkBun(BunIngredientFactory bunIngredientFactory)
        {
            Stuffing = bunIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.Desc;
            
            Flour = bunIngredientFactory.CreateFlour();
            StepDesc += Flour.Desc;
        }

    }
}