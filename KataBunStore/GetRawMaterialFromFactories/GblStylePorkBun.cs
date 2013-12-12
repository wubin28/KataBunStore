namespace GetRawMaterialFromFactories
{
    public class GblStylePorkBun : Bun
    {
        public GblStylePorkBun(BunIngredientFactory gblIngredientFactory)
        {
            Stuffing = gblIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.GetDesc();

            Flour = gblIngredientFactory.CreateFlour();
            StepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return StepDesc;
        }
    }
}