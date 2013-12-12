namespace AddTwoNewFlavors
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
            steamBun(bun);
            bun.AppendStepDesc(" Dished out buns.");
            return bun;
        }

        private void steamBun(Bun bun)
        {
            bun.AppendStepDesc(" Steamed buns.");
        }
    }
}