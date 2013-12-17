namespace SplitResponsibilities
{
    public static class Waiter
    {
        public static Bun DishOut(string bunName)
        {
            Bun bun = Cook.MakeBun(bunName);
            Steam(bun);
            bun.AppendStepDesc(" Dished out buns.");
            return bun;
        }

        private static void Steam(Bun bun)
        {
            bun.AppendStepDesc(" Steamed buns.");
        }
    }
}