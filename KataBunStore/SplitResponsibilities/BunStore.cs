namespace SplitResponsibilities
{
    public class BunStore
    {
        public static Bun orderBun(string bunName)
        {
            Waiter waiter = new Waiter();
            return waiter.DishOut(bunName);

        }
    }
}