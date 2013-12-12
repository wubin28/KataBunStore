namespace SplitResponsibilities
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
            Bun bun = cook.MakeBun(bunName);
            steam(bun);
            bun.AppendStepDesc(" Dished out buns.");
            return bun;
        }

        private void steam(Bun bun)
        {
            bun.AppendStepDesc(" Steamed buns.");
        }
    }
}