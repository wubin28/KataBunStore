namespace SplitResponsibilities
{
    public class Waiter
    {
        private Cook cook;

        public Waiter(Cook cook)
        {
            this.cook = cook;
        }


        public Bun dishOut(string bunName)
        {
            Bun bun = cook.makeBun(bunName);
            steam(bun);
            bun.appendStepDesc(" Dished out buns.");
            return bun;
        }

        private void steam(Bun bun)
        {
            bun.appendStepDesc(" Steamed buns.");
        }
    }
}