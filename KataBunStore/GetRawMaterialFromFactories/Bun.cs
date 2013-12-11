namespace GetRawMaterialFromFactories
{
    public abstract class Bun
    {
        protected Stuffing Stuffing;
        protected Flour Flour;

        protected string stepDesc = "";
        public abstract string GetStepDesc();

        public void AppendStepDesc(string stepDesc)
        {
            this.stepDesc += stepDesc;
        }
    }
}