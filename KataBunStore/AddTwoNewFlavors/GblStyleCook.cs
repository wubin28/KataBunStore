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
        }

        protected override void WrapBun(Bun bun)
        {
            throw new System.NotImplementedException();
        }

        protected override void KneadIntoDough(Bun bun)
        {
            throw new System.NotImplementedException();
        }

        protected override void MixStuffing(Bun bun, string bunName)
        {
            bun.appendStepDesc("Mixed stuffing of " + bunName + " bun in GBL style.");
        }
    }
}