namespace SplitResponsibilities
{
    public class BunStore
    {
        public Bun orderBun(string bunName)
        {
            Cook cook = new Cook();
            Waiter waiter = new Waiter(cook);
            return waiter.dishOut(bunName);

        }
    }
}