using System.IO;

namespace GetRawMaterialFromFactories
{
    public class HbzStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            BunIngredientFactory hbzIngredientFactory = new HbzIngredientFactory();
            if (bunName == "Pork")
            {
                return new HbzStylePorkBun(hbzIngredientFactory);
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
            bun.AppendStepDesc(" Kneaded into dough in HBZ style.");
        }

        protected override void WrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns in HBZ style.");
        }
    }
}