namespace GetRawMaterialFromFactories
{
    public class HbzStylePorkBun : Bun
    {
        private BunIngredientFactory hbzIngredientFactory;

        public HbzStylePorkBun(BunIngredientFactory hbzIngredientFactory)
        {
            this.hbzIngredientFactory = hbzIngredientFactory;

            Stuffing = hbzIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.GetDesc();

            Flour = hbzIngredientFactory.CreateFlour();
            StepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return StepDesc;
        }
    }
}