namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkBun : Bun
    {
        private BunIngredientFactory _bunIngredientFactory;

        public QfStyleGreenOnionAndPorkBun(BunIngredientFactory bunIngredientFactory)
        {
            this._bunIngredientFactory = bunIngredientFactory;
        }

        public override string GetStepDesc()
        {
            return stepDesc;
        }
    }
}