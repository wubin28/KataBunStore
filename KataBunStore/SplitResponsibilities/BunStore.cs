namespace SplitResponsibilities
{
    public class BunStore
    {
        public static Bun orderBun(string bunName)
        {
            return Waiter.DishOut(bunName);

        }
    }
}