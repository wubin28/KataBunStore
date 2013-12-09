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
            // Given
            SplitResponsibilitiesTestFacade splitResponsibilitiesTestFacade = new SplitResponsibilitiesTestFacade();

            // When
            splitResponsibilitiesTestFacade.orderBun("Green Onion and Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.", splitResponsibilitiesTestFacade.getOutputForTest(), "Failure - the output was not 'Mixed stuffing of Green Onion and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderSamSunAndPorkBun()
        {
            // Given
            SplitResponsibilitiesTestFacade splitResponsibilitiesTestFacade = new SplitResponsibilitiesTestFacade();

            // When
            splitResponsibilitiesTestFacade.orderBun("Sam Sun and Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.", splitResponsibilitiesTestFacade.getOutputForTest(), "Failure - the output was not 'Mixed stuffing of Sam Sun and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderSuSamSunBun()
        {
            // Given
            SplitResponsibilitiesTestFacade splitResponsibilitiesTestFacade = new SplitResponsibilitiesTestFacade();

            // When
            splitResponsibilitiesTestFacade.orderBun("Su Sam Sun");

            // Then
            Assert.AreEqual("Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.", splitResponsibilitiesTestFacade.getOutputForTest(), "Failure - the output was not 'Mixed stuffing of Su Sam Sun bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }
    }
}
