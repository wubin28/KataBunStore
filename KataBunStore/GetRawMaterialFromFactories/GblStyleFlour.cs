namespace GetRawMaterialFromFactories
{
    public class GblStyleFlour : Flour
    {
        public GblStyleFlour()
        {
            Desc += " Got flour from GBL Ingredient Factory.";
        }
        public override string GetDesc()
        {
            return Desc;
        }
    }
}