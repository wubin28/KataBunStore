﻿using System;
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
            // When
            Bun bun = BunStore.OrderQfStyleBun("Green Onion and Pork");

            // Then
            Assert.AreEqual("Got mixed stuffing of Green Onion and Pork bun from QF Ingredient Factory. Got flour from QF Ingredient Factory. Prepared stuffing. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the step description was not 'Got mixed stuffing of Green Onion and Pork bun from QF Ingredient Factory. Got flour from QF Ingredient Factory. Prepared stuffing. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderGblStylePorkBun()
        {
            // Given
            // When
            Bun bun = BunStore.OrderGblStyleBun("Pork");

            // Then
            Assert.AreEqual("Got mixed stuffing of Pork bun from GBL Ingredient Factory. Got flour from GBL Ingredient Factory. Prepared stuffing. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the step description was not 'Got mixed stuffing of Pork bun from GBL Ingredient Factory. Got flour from GBL Ingredient Factory. Prepared stuffing. Kneaded into dough in GBL style. Wrapped buns in GBL style. Steamed buns. Dished out buns.'");
        }

        [Test]
        public void TestOrderHbzStylePorkBun()
        {
            // Given
            // When
            Bun bun = BunStore.OrderHbzStyleBun("Pork");

            // Then
            Assert.AreEqual("Got mixed stuffing of Pork bun from HBZ Ingredient Factory. Got flour from HBZ Ingredient Factory. Prepared stuffing. Kneaded into dough in HBZ style. Wrapped buns in HBZ style. Steamed buns. Dished out buns."
                , bun.StepDesc
                , "Failure - the step description was not 'Got mixed stuffing of Pork bun from HBZ Ingredient Factory. Got flour from HBZ Ingredient Factory. Prepared stuffing. Kneaded into dough in HBZ style. Wrapped buns in HBZ style. Steamed buns. Dished out buns.'");
        }
    }
}
