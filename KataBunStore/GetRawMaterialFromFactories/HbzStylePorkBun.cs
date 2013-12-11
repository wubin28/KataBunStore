namespace GetRawMaterialFromFactories
{
    public class HbzStylePorkBun : Bun
    {
        private BunIngredientFactory hbzIngredientFactory;

        public HbzStylePorkBun(BunIngredientFactory hbzIngredientFactory)
        {
            this.hbzIngredientFactory = hbzIngredientFactory;

            Stuffing = hbzIngredientFactory.CreateStuffing();
            stepDesc += Stuffing.GetDesc();

            Flour = hbzIngredientFactory.CreateFlour();
            stepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return stepDesc;
        }
    }
}