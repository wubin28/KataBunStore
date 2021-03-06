﻿using System.IO;

namespace AddTwoNewFlavors
{
    public class HbzStyleCook : Cook
    {
        protected override Bun CreateBun(string bunName)
        {
            if (bunName == "Pork")
            {
                return new HbzStylePorkBun();
            }
            else
            {
                throw new InvalidDataException("Invalid bun name: " + bunName);
            }
        }

        protected override void WrapBun(Bun bun)
        {
            bun.AppendStepDesc(" Wrapped buns in HBZ style.");
        }

        protected override void KneadIntoDough(Bun bun)
        {
            bun.AppendStepDesc(" Kneaded into dough in HBZ style.");
        }

        protected override void MixStuffing(Bun bun, string bunName)
        {
            bun.AppendStepDesc("Mixed stuffing of " + bunName + " bun in HBZ style.");
        }
    }
}