namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkBun : Bun
    {
        private BunIngredientFactory bunIngredientFactory;

        public QfStyleGreenOnionAndPorkBun(BunIngredientFactory bunIngredientFactory)
        {
            this.bunIngredientFactory = bunIngredientFactory;
            
            Stuffing = this.bunIngredientFactory.CreateStuffing();
            stepDesc += Stuffing.GetDesc();
            
            Flour = this.bunIngredientFactory.CreateFlour();
            stepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return stepDesc;
        }
    }
}