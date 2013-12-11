namespace GetRawMaterialFromFactories
{
    public class HbzStylePorkBun : Bun
    {
        private BunIngredientFactory hbzIngredientFactory;

        public HbzStylePorkBun(BunIngredientFactory hbzIngredientFactory)
        {
            this.hbzIngredientFactory = hbzIngredientFactory;

        }

        public override string GetStepDesc()
        {
            throw new System.NotImplementedException();
        }
    }
}