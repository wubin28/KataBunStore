namespace SplitResponsibilities
{
    public class BunStore
    {
        public Bun orderBun(string bunName)
        {
            Cook cook = new Cook();
            Waiter waiter = new Waiter(cook);
            return waiter.dishOut(bunName);

            if (bunName == "Green Onion and Pork")
            {
                return new Bun("Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.");
            }
            else if (bunName == "Sam Sun and Pork")
            {
                return new Bun("Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.");
            }
            else
            {
                return new Bun("Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.");
            }
        }
    }
}