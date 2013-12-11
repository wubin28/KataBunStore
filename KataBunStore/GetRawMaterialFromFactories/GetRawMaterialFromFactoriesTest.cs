using System;
using NUnit.Framework;


namespace GetRawMaterialFromFactories
{
    [TestFixture]
    public class GetRawMaterialFromFactoriesTest
    {
        [Test]
        public void TestOrderQfStyleGreenOnionAndPorkBun()
        {
            // Given
            BunStore bunStore = new BunStore();

            // When
            Bun bun = bunStore.OrderQfStyleBun("Green Onion and Pork");

            // Then
            Assert.AreEqual("Got mixed stuffing of Green Onion and Pork bun from QF Bun Factory. Got flour from QF Bun Factory. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns."
                , bun.GetStepDesc()
                , "Failure - the step description was not 'Got mixed stuffing of Green Onion and Pork bun from QF Bun Factory. Got flour from QF Bun Factory. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderGblStylePorkBun()
        {
            // When
            Bun bun = bunStore.OrderGblStyleBun("Pork");

            // Then
            Assert.AreEqual("Got mixed stuffing of Pork bun in GBL style. Got flour from GBL Bun Factory. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns."
                , bun.GetStepDesc()
                , "Failure - the step description was not 'Got mixed stuffing of Pork bun in GBL style. Got flour from GBL Bun Factory. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns.'");
        }
    }
}
