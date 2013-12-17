using System.IO;

namespace SplitResponsibilities
{
    public class Cook
    {
        public static Bun MakeBun(string bunName)
        {
            Bun bun = null;
            if (bunName == "Green Onion and Pork")
            {
                bun = new GreenOnionAndPorkBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else if (bunName == "Sam Sun and Pork")
            {
                bun = new SamSunAndPorkBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else if (bunName == "Su Sam Sun")
            {
                bun = new SuSamSunBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else if (bunName == "Shrimp")
            {
                bun = new ShrimpBun();
                mixStuffing(bun, bunName);
                kneadIntoDough(bun);
                wrapBun(bun);
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
            return bun;
        }

        private static void wrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns.");
        }

        private static void kneadIntoDough(Bun bun)
        {
            bun.AppendStepDesc(" Kneaded into dough.");
        }

        private static void mixStuffing(Bun bun, string bunName)
        {
            bun.AppendStepDesc("Mixed stuffing of " + bunName + " bun.");
        }
    }
}