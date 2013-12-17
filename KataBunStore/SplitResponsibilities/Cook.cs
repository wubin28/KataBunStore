using System.IO;

namespace SplitResponsibilities
{
    public static class Cook
    {
        public static Bun MakeBun(string bunName)
        {
            Bun bun = null;
            if (bunName == "Green Onion and Pork")
            {
                bun = new GreenOnionAndPorkBun();
                MixStuffing(bun, bunName);
                KneadIntoDough(bun);
                WrapBun(bun);
            }
            else if (bunName == "Sam Sun and Pork")
            {
                bun = new SamSunAndPorkBun();
                MixStuffing(bun, bunName);
                KneadIntoDough(bun);
                WrapBun(bun);
            }
            else if (bunName == "Su Sam Sun")
            {
                bun = new SuSamSunBun();
                MixStuffing(bun, bunName);
                KneadIntoDough(bun);
                WrapBun(bun);
            }
            else if (bunName == "Shrimp")
            {
                bun = new ShrimpBun();
                MixStuffing(bun, bunName);
                KneadIntoDough(bun);
                WrapBun(bun);
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
            return bun;
        }

        private static void WrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns.");
        }

        private static void KneadIntoDough(Bun bun)
        {
            bun.AppendStepDesc(" Kneaded into dough.");
        }

        private static void MixStuffing(Bun bun, string bunName)
        {
            bun.AppendStepDesc("Mixed stuffing of " + bunName + " bun.");
        }
    }
}