namespace SplitResponsibilities
{
    public class SplitResponsibilitiesTestFacade
    {

        public Bun orderBun(string bunName)
        {
            BunStore bunStore = new BunStore();
            return bunStore.orderBun(bunName);
            
        }

    }
}