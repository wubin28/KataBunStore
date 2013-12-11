namespace GetRawMaterialFromFactories
{
    public class QfStyleFlour : Flour
    {
        public QfStyleFlour()
        {
            Desc += " Got flour from QF Ingredient Factory.";
        }
        public override string GetDesc()
        {
            return Desc;
        }
    }
}