using System;

[assembly: CLSCompliant(true)]
namespace AddTwoNewFlavors
{
    public class Bun
    {
        private string stepDesc;

        public void AppendStepDesc(string desc)
        {
            this.stepDesc += desc;
        }

        public string StepDesc
        {
            get { return this.stepDesc; }
        }
    }
}