namespace SplitResponsibilities
{
    public class Bun
    {
        private string outputForTest;

        public Bun(string outputForTest)
        {
            this.outputForTest = outputForTest;
        }

        public string getOutputForTest()
        {
            return this.outputForTest;
        }
    }
}