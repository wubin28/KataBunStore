namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkBun : Bun
    {
        public QfStyleGreenOnionAndPorkBun(BunIngredientFactory bunIngredientFactory)
        {
            Stuffing = bunIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.GetDesc();
            
            Flour = bunIngredientFactory.CreateFlour();
            StepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return StepDesc;
        }
    }
}