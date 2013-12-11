namespace AddTwoNewFlavors
{
    public class Waiter
    {
        private Cook qfStyleCook;

        public Waiter(Cook qfStyleCook)
        {
            this.qfStyleCook = qfStyleCook;
        }

        public Bun DishOut(string bunName)
        {
            Bun bun = qfStyleCook.MakeBun(bunName);
            steamBun(bun);
            bun.appendStepDesc(" Dished out buns.");
        }

        private void steamBun(Bun bun)
        {
            bun.appendStepDesc(" Steamed buns.");
        }
    }
}