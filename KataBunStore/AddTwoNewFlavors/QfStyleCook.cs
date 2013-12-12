using System.IO;

namespace AddTwoNewFlavors
{
    public class QfStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            if (bunName == "Green Onion and Pork")
            {
                return new QfStyleGreenOnionAndPorkBun();
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
        }

        protected override void WrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns in QF style.");
        }

        protected override void KneadIntoDough(Bun bun)
        {
            bun.AppendStepDesc(" Kneaded into dough in QF style.");
        }

        protected override void MixStuffing(Bun bun, string bunName)
        {
            if (bunName == "Green Onion and Pork")
            {
                bun.AppendStepDesc("Mixed stuffing of " + bunName + " bun in QF style.");
            }
        }
    }
}