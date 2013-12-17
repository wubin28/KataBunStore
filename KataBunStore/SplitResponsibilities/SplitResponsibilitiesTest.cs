using NUnit.Framework;
using System;

namespace SplitResponsibilities
{
    [TestFixture]
    public class SplitResponsibilitiesTest
    {

        [Test]
        public void TestOrderGreenOnionAndPorkBun()
        {
            // When
            Bun bun = BunStore.OrderBun("Green Onion and Pork");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderSamSunAndPorkBun()
        {
            // When
            Bun bun = BunStore.OrderBun("Sam Sun and Pork");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderSuSamSunBun()
        {
            // When
            Bun bun = BunStore.OrderBun("Su Sam Sun");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderShrimpBun()
        {
            // When
            Bun bun = BunStore.OrderBun("Shrimp");

            // Then
            Assert.AreEqual(
                "Mixed stuffing of Shrimp bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Shrimp bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }
    }
}
