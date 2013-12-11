using System.IO;

namespace GetRawMaterialFromFactories
{
    public class GblStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            BunIngredientFactory gblIngredientFactory = new GblIngredientFactory();
            if (bunName == "Pork")
            {
                return new GblStylePorkBun(gblIngredientFactory);
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
        }

        protected override void PrepareStuffing(Bun bun)
        {
            throw new System.NotImplementedException();
        }

        protected override void KneadIntoDough(Bun bun)
        {
            throw new System.NotImplementedException();
        }

        protected override void WrapBun(Bun bun)
        {
            throw new System.NotImplementedException();
        }
    }
}