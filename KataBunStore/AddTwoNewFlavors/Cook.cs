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

        protected abstract void WrapBun(Bun bun);

        protected abstract void KneadIntoDough(Bun bun);

        protected abstract void MixStuffing(Bun bun, string bunName);
    }
}