namespace GetRawMaterialFromFactories
{
    public class QfStyleGreenOnionAndPorkBun : Bun
    {
        private BunIngredientFactory bunIngredientFactory;

        public QfStyleGreenOnionAndPorkBun(BunIngredientFactory bunIngredientFactory)
        {
            this.bunIngredientFactory = bunIngredientFactory;
            
            Stuffing = this.bunIngredientFactory.CreateStuffing();
            StepDesc += Stuffing.GetDesc();
            
            Flour = this.bunIngredientFactory.CreateFlour();
            StepDesc += Flour.GetDesc();
        }

        public override string GetStepDesc()
        {
            return StepDesc;
        }
    }
}