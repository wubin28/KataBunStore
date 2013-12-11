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
            qfStyleCook.MakeBun(bunName);

        }
    }
}