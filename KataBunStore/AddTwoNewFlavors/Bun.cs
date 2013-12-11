﻿namespace AddTwoNewFlavors
{
    public class Bun
    {
        private string stepDesc;

        public string getStepDesc(string descType)
        {
            if (descType == "QfStyleGreenOnionAndPork")
            {
                return
                    "Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.";
            }
            else
            {
                return
                    "Mixed stuffing of Pork bun in GBL style. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns.";
            }
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