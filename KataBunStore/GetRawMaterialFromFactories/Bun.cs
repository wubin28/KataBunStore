namespace GetRawMaterialFromFactories
{
    public abstract class Bun
    {
        protected Stuffing Stuffing { get; set; }
        protected Flour Flour { get; set; }

        protected string StepDesc = "";
        public abstract string GetStepDesc();

        public void AppendStepDesc(string stepDesc)
        {
            this.StepDesc += stepDesc;
        }
    }
}