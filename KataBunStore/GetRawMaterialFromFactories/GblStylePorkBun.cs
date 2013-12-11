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
            return "Got mixed stuffing of Pork bun from GBL Ingredient Factory. Got flour from GBL Ingredient Factory. Prepared stuffing. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns.";
        }
    }
}