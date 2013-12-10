namespace SplitResponsibilities
{
    public class Cook
    {
        public Bun makeBun(string bunName)
        {
            Bun bun = null;
            if (bunName == "Green Onion and Pork")
            {
                // " Steamed buns. Dished out buns."
                bun = new GreenOnionAndPorkBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else if (bunName == "Sam Sun and Pork")
            {
                // "Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                bun = new SamSunAndPorkBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else
            {
                // "Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                bun = new SuSamSunBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            return bun;
        }

        private void wrapBun(Bun bun)
        {
            bun.appendStepDesc(" Wrapped buns.");
        }

        private void kneadIntoDough(Bun bun)
        {
            bun.appendStepDesc(" Kneaded into dough.");
        }

        private void mixStuffing(Bun bun, string bunName)
        {
            bun.appendStepDesc("Mixed stuffing of " + bunName + " bun.");
        }
    }
}