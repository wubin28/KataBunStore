﻿namespace GetRawMaterialFromFactories
{
    public class QfIngredientFactory : BunIngredientFactory
    {
        public override Stuffing CreateStuffing()
        {
            return new QfStyleGreenOnionAndPorkStuffing();
        }

        public override Flour CreateFlour()
        {
            return new QfStyleFlour();
        }
    }
}