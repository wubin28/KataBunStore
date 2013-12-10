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

        public void appendStepDesc(string stepDesc)
        {
            this.stepDesc += stepDesc;
        }

        public string getStepDesc()
        {
            return this.stepDesc;
        }
    }
}