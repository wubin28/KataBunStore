namespace GetRawMaterialFromFactories
{
    public abstract class Bun
    {
        private string stepDesc;
        public abstract string GetStepDesc();

        public void AppendStepDesc(string stepDesc)
        {
            this.stepDesc += stepDesc;
        }
    }
}