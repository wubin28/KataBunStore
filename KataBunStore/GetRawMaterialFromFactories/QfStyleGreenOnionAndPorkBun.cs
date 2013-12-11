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
            return "Got mixed stuffing of Green Onion and Pork bun from QF Bun Factory. Got flour from QF Bun Factory. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.";
        }
    }
}