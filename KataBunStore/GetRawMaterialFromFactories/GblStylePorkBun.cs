namespace GetRawMaterialFromFactories
{
    public class GblStylePorkBun : Bun
    {
        private BunIngredientFactory gblIngredientFactory;

        public GblStylePorkBun(BunIngredientFactory gblIngredientFactory)
        {
            this.gblIngredientFactory = gblIngredientFactory;

            Stuffing = this.gblIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.GetDesc();

            Flour = this.gblIngredientFactory.CreateFlour();
            StepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return StepDesc;
        }
    }
}