namespace AddTwoNewFlavors
{
    public class HbzStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            if (bunName == "Pork")
            {
                return new HbzStylePorkBun();
            }
        }

        protected override void WrapBun(Bun bun)
        {
            throw new System.NotImplementedException();
        }

        protected override void KneadIntoDough(Bun bun)
        {
            bun.appendStepDesc(" Kneaded into dough in HBZ style.");
        }

        protected override void MixStuffing(Bun bun, string bunName)
        {
            bun.appendStepDesc("Mixed stuffing of " + bunName + " bun in HBZ style.");
        }
    }
}