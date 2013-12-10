using NUnit.Framework;
using System;

namespace SplitResponsibilities
{
    [TestFixture]
    public class SplitResponsibilitiesTest
    {
        private BunStore bunStore = null;

        [SetUp]
        protected void SetUp()
        {
            // Given
            bunStore = new BunStore();
        }

        [Test]
        public void TestOrderGreenOnionAndPorkBun()
        {
            // When
            Bun bun = bunStore.orderBun("Green Onion and Pork");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.getStepDesc()
                , "Failure - the output was not 'Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderSamSunAndPorkBun()
        {
            // When
            Bun bun = bunStore.orderBun("Sam Sun and Pork");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.getStepDesc()
                , "Failure - the output was not 'Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderSuSamSunBun()
        {
            // When
            Bun bun = bunStore.orderBun("Su Sam Sun");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.getStepDesc()
                , "Failure - the output was not 'Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }
    }
}
