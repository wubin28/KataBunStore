using System.IO;

namespace GetRawMaterialFromFactories
{
    public class HbzStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
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