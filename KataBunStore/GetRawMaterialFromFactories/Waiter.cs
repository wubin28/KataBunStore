namespace GetRawMaterialFromFactories
{
    public class Waiter
    {
        private Cook cook;

        public Waiter(Cook cook)
        {
            this.cook = cook;
        }

        public Bun DishOut(string bunName)
        {
            Bun bun = this.cook.MakeBun(bunName);
            SteamBun(bun);
            bun.AppendStepDesc(" Dished out buns.");
            return bun;
        }

        private static void SteamBun(Bun bun)
        {
            bun.AppendStepDesc(" Steamed buns.");
        }
    }
}