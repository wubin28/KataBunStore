using System;
using NUnit.Framework;


namespace AddTwoNewFlavors
{
    [TestFixture]
    public class AddTwoNewFlavorsTest
    {
        [Test]
        public void TestOrderQfStyleGreenOnionAndPorkBun()
        {
            // Then
            Assert.AreEqual("Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns."
                , bun.getStepDesc("Green Onion and Pork")
                , "Failure - the output was not 'Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.'");
        }
    }
}
