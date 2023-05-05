namespace OHCE
{
    public class Operation
    {
        //etape1:lesbases
        public int Somme(int x, int y)
        {
            return x + y;
        }

        public int Produit(int x, int y)
        {
            return x * y;
        }
        public (int quotient, int reste) Division(int x, int y)
        {
            int quotient = x / y;
            int reste = x % y;
            return (quotient, reste);
        }

        public int Difference(int x, int y)
        {

            return x - y;
        }

        //etape2:lesdécimaux
        public double PrecisionSomme(double x, double y, int precision)
        {
            return Math.Round(x + y, precision);
        }
        public double PrecisionProduit(double x, double y, int precision)
        {
            return Math.Round(x * y, precision);
        }

        public class PrecisionDivision{
            private int precision;
            public PrecisionDivision(int precision)
            {
                this.precision = precision;
            }
            public double Diviser(double x, double y)
            {
                return Math.Round(x / y, precision);
            }

        }

        public class PrecisionDifference
        {
            private int precision;
            public PrecisionDifference(int precision)
            {
               this.precision = precision;
            }
            public double Difference(double x, double y)
            {
                return Math.Round(x - y, precision);
            }

        }


        //etape3:tolérance

        public int SommeTolerance(string saisi )
        {
            saisi = saisi.Replace(" ", "").Replace("\n", "");
            string[] valeurs = saisi.Split('+');
            int x = int.Parse(valeurs[0]);
            int y = int.Parse(valeurs[1]);
            int z = x + y;
            return z;

        }














    }

}