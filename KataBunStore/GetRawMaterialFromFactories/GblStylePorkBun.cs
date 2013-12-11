namespace GetRawMaterialFromFactories
{
    public class GblStylePorkBun : Bun
    {
        private BunIngredientFactory gblIngredientFactory;

        public GblStylePorkBun(BunIngredientFactory gblIngredientFactory)
        {
            this.gblIngredientFactory = gblIngredientFactory;

            Stuffing = this.gblIngredientFactory.CreateStuffing();
            stepDesc += Stuffing.GetDesc();

            Flour = this.gblIngredientFactory.CreateFlour();
            stepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return stepDesc;
        }
    }
}