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
            bun.AppendStepDesc(" Kneaded into dough in QF style.");
        }

        protected override void WrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns in QF style.");
        }
    }
}