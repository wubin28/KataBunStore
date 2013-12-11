namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkBun : Bun
    {
        private BunIngredientFactory bunIngredientFactory;

        public QfStyleGreenOnionAndPorkBun(BunIngredientFactory bunIngredientFactory)
        {
            this.bunIngredientFactory = bunIngredientFactory;
            
            Stuffing = this.bunIngredientFactory.createStuffing();
            stepDesc += "Got mixed stuffing of Green Onion and Pork bun from QF Ingredient Factory.";
            
            Flour = this.bunIngredientFactory.createFlour();
            stepDesc += " Got flour from QF Ingredient Factory.";
        }

        public override string GetStepDesc()
        {
            return stepDesc;
        }
    }
}