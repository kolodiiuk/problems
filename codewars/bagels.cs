using System.Reflection;

namespace Solution
{
    class BagelSolver
    {
        public static Bagel Bagel
        {
            get
            {
                var bagel = new Bagel();
                var b = typeof(Bagel).GetProperty("Value");
                b.SetValue(bagel, 4);

                return bagel;
            }
        }
    }
}
