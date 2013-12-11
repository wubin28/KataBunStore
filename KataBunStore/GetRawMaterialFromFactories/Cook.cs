namespace GetRawMaterialFromFactories
{
    public abstract class Cook
    {
        protected abstract Bun CreateBun(string bunName);

        public Bun MakeBun(string bunName)
        {
            Bun bun = CreateBun(bunName);
            prepareStuffing(bun, bunName);
            KneadIntoDough(bun);
            WrapBun(bun);
            return bun;
        }
    }
}