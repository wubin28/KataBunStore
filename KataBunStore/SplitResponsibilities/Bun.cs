namespace SplitResponsibilities
{
    public class Bun
    {
        private string outputForTest;

        public Bun(string outputForTest)
        {
            this.outputForTest = outputForTest;
        }

        protected Bun()
        {
        }

        public string getOutputForTest()
        {
            return this.outputForTest;
        }
    }
}