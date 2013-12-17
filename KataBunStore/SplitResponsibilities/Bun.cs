using System;

[assembly: CLSCompliant(true)]
namespace SplitResponsibilities
{
    public class Bun
    {
        private string outputForTest;
        private string stepDesc = "";

        public Bun(string outputForTest)
        {
            this.outputForTest = outputForTest;
        }

        protected Bun()
        {
        }

        public void AppendStepDesc(string stepDesc)
        {
            this.stepDesc += stepDesc;
        }

        public string StepDesc
        {
            get { return this.stepDesc; }
        }
    }
}