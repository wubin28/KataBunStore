﻿using System;
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
            // When
            Bun bun = BunStore.OrderQfStyleBun("Green Onion and Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Green Onion and Pork bun in QF style. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderGblStylePorkBun()
        {
            // Given
            // When
            Bun bun = BunStore.OrderGblStyleBun("Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Pork bun in GBL style. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Pork bun in GBL style. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderHbzStylePorkBun()
        {
            // Given
            // When
            Bun bun = BunStore.OrderHbzStyleBun("Pork");

            // Then
            Assert.AreEqual("Mixed stuffing of Pork bun in HBZ style. Kneaded into dough in HBZ style. Wrapped buns in HBZ style. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the output was not 'Mixed stuffing of Pork bun in HBZ style. Kneaded into dough in HBZ style. Wrapped buns in HBZ style. Steamed buns. Dished out buns.'");
        }
    }
}
