﻿namespace GetRawMaterialFromFactories
{
    public class HbzStyleFlour : Flour
    {
        public HbzStyleFlour()
        {
            Desc += " Got flour from HBZ Ingredient Factory.";
        }
        public override string GetDesc()
        {
            return Desc;
        }
    }
}