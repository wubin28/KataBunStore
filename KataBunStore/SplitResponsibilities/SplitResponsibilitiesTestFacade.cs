namespace SplitResponsibilities
{
    public class SplitResponsibilitiesTestFacade
    {
        private string outputForTest = "";

        public void orderBun(string bunName)
        {
            if (bunName == "Green Onion and Pork")
            {
                outputForTest =
                    "Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.";
            }
            else
            {
                outputForTest =
                    "Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.";
            }
            
        }

        public string getOutputForTest()
        {
            return outputForTest;
        }
    }
}