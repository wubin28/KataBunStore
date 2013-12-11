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
            // When
            Bun bun = bunStore.OrderQfStyleBun("Green Onion and Pork");

            // Then
            Assert.AreEqual("Got mixed stuffing of Green Onion and Pork bun from QF Bun Factory. Got flour from QF Bun Factory. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns."
                , bun.getStepDesc()
                , "Failure - the step description was not 'Got mixed stuffing of Green Onion and Pork bun from QF Bun Factory. Got flour from QF Bun Factory. Kneaded into dough in QF style. Wrapped buns in QF style. Steamed buns. Dished out buns.'");
        }
    }
}