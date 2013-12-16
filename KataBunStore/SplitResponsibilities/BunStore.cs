namespace SplitResponsibilities
{
    public class BunStore
    {
        public static Bun orderBun(string bunName)
        {
            Cook cook = new Cook();
            Waiter waiter = new Waiter(cook);
            return waiter.DishOut(bunName);

        }
    }
}