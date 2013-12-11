using System.IO;

namespace GetRawMaterialFromFactories
{
    public class QfStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            BunIngredientFactory qfIngredientFactory = new QfIngredientFactory();
            if (bunName == "Green Onion and Pork")
            {
                return new QfStyleGreenOnionAndPorkBun(qfIngredientFactory);
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
        }

        protected override void PrepareStuffing(Bun bun)
        {
            bun.AppendStepDesc(" Prepared stuffing.");
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