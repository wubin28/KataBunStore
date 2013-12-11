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
            // Given
            BunStore bunStore = new BunStore();

            // When
            Bun bun = bunStore.orderQfStyleBun("Green Onion and Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns."
                , bun.getStepDesc()
                , "Failure - the output was not 'Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderGblStylePorkBun()
        {
            // Given
            BunStore bunStore = new BunStore();

            // When
            Bun bun = bunStore.orderGblStyleBun("Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Pork bun in GBL style. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns."
                , bun.getStepDesc()
                , "Failure - the output was not 'Mixed stuffing of Pork bun in GBL style. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns.'");
        }
    }
}
