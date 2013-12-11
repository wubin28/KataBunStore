namespace GetRawMaterialFromFactories
{
    public abstract class Cook
    {
        protected abstract Bun CreateBun(string bunName);

        public Bun MakeBun(string bunName)
        {
            Bun bun = CreateBun(bunName);
            PrepareStuffing(bun);
            KneadIntoDough(bun);
            WrapBun(bun);
            return bun;
        }

        protected abstract void PrepareStuffing(Bun bun);

        protected abstract void KneadIntoDough(Bun bun);

        protected abstract void WrapBun(Bun bun);

    }
}