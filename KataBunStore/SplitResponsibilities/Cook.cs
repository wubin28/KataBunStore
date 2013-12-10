namespace SplitResponsibilities
{
    public class Cook
    {
        public Bun makeBun(string bunName)
        {
            if (bunName == "Green Onion and Pork")
            {
                return new GreenOnionAndPorkBun("Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.");
            }
            else if (bunName == "Sam Sun and Pork")
            {
                return new SamSunAndPorkBun("Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.");
            }
            else
            {
                return new SuSamSunBun("Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.");
            }
        }
    }
}