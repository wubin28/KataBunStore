namespace SplitResponsibilities
{
    public class SplitResponsibilitiesTestFacade
    {

        public Bun orderBun(string bunName)
        {
            BunStore bunStore = new BunStore();
            return bunStore.orderBun(bunName);
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