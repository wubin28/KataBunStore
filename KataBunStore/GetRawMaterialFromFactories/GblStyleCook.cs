using System.ComponentModel;
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
            bun.AppendStepDesc(" Prepared stuffing.");
        }

        protected override void KneadIntoDough(Bun bun)
        {
            bun.AppendStepDesc(" Kneaded into dough in GBL style.");
        }

        protected override void WrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns in GBL style.");
        }
    }
}