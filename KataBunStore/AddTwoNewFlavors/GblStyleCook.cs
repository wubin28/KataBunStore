using System.IO;

namespace AddTwoNewFlavors
{
    public class GblStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            if (bunName == "Pork")
            {
                return new GblStylePorkBun();
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
        }

        protected override void WrapBun(Bun bun)
        {
            throw new System.NotImplementedException();
        }

        protected override void KneadIntoDough(Bun bun)
        {
            bun.appendStepDesc(" Kneaded into dough in GBL style.");
        }

        protected override void MixStuffing(Bun bun, string bunName)
        {
            bun.appendStepDesc("Mixed stuffing of " + bunName + " bun in GBL style.");
        }
    }
}