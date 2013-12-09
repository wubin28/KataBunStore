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
            Assert.AreEqual("Mixed stuffing of Sam Sum and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.", splitResponsibilitiesTestFacade.getOutputForTest(), "Failure - the output was not 'Mixed stuffing of Sam Sum and Pork bun. Kneaded into dough. Wrapped buns. Steamed buns. Dished out buns.'");
        }
    }
}
