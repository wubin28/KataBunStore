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
            return cook.makeBun(bunName);
        }
    }
}