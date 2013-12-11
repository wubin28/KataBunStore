namespace GetRawMaterialFromFactories
{
    public abstract class Bun
    {
        protected string stepDesc;
        public abstract string GetStepDesc();

        public void AppendStepDesc(string stepDesc)
        {
            this.stepDesc += stepDesc;
        }
    }
}