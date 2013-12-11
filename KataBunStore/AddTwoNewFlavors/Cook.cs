namespace AddTwoNewFlavors
{
    public abstract class Cook
    {
        protected abstract Bun CreateBun(string bunName);

        public Bun MakeBun(string bunName)
        {
            Bun bun = CreateBun(bunName);
            MixStuffing(bun, bunName);
            KneadIntoDough(bun);
            WrapBun(bun);
            return bun;
        }
    }
}