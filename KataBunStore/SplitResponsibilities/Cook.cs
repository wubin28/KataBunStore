namespace SplitResponsibilities
{
    public class Cook
    {
        public Bun makeBun(string bunName)
        {
            Bun bun = null;
            if (bunName == "Green Onion and Pork")
            {
                // " Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                bun = new GreenOnionAndPorkBun();
                mixStuffing(bun);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else if (bunName == "Sam Sun and Pork")
            {
                // "Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                bun = new SamSunAndPorkBun();
                mixStuffing(bun);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else
            {
                // "Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                bun = new SuSamSunBun();
                mixStuffing(bun);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            return bun;
        }

        private void mixStuffing(Bun bun)
        {
            bun.appendStepDesc("Mixed stuffing of Green Onion and Pork bun.");
        }
    }
}