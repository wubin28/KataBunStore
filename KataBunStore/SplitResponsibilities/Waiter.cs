namespace SplitResponsibilities
{
    public class Waiter
    {
        public Waiter()
        {
        }


        public static Bun DishOut(string bunName)
        {
            Bun bun = Cook.MakeBun(bunName);
            steam(bun);
            bun.AppendStepDesc(" Dished out buns.");
            return bun;
        }

        private static void steam(Bun bun)
        {
            bun.AppendStepDesc(" Steamed buns.");
        }
    }
}