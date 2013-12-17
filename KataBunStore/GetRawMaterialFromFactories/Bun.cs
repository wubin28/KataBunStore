using System;

[assembly: CLSCompliant(true)]
namespace GetRawMaterialFromFactories
{
    public abstract class Bun
    {
        protected Stuffing Stuffing { get; set; }
        protected Flour Flour { get; set; }
        public string StepDesc { get; set; }

        public void AppendStepDesc(string stepDesc)
        {
            this.StepDesc += stepDesc;
        }
    }
}