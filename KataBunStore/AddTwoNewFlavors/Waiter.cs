namespace AddTwoNewFlavors
{
    public class Waiter
    {
        private Cook qfStyleCook;

        public Waiter(Cook qfStyleCook)
        {
            this.qfStyleCook = qfStyleCook;
        }

        public Bun dishOut(string bunName)
        {
            Bun bun = qfStyleCook.MakeBun(bunName);
            steamBun(bun);
            bun.appendStepDesc(" Dished out buns.");
        }
    }
}