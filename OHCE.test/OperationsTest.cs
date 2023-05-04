namespace OHCE.test


{
    using Xunit;
    using static OHCE.Operation;

    public class OperationsTest
    {
        [Theory]
        [InlineData(4,7,11)]
        [InlineData(8, 8, 16)]
        public void TestAddition(int x, int y , int resAttendu)
        {

            Operation operation = new Operation();
            int res = operation.Somme(x,y);
            
            Assert.Equal(resAttendu, res);
           
        }


        [Theory]
        [InlineData(5,4,20)]
        [InlineData(1,80,80)]
        public void TestProduit(int x, int y, int resAttenduProduit)
        {

            Operation operation = new Operation();
            int res = operation.Produit(x, y);

            Assert.Equal(resAttenduProduit, res);

        }

        [Theory]
        [InlineData(20, 5, 4,0)]
        [InlineData(1, 1, 1, 0)]
        public void TestDivision(int x, int y, int resAttenduQuotient ,int resAttenduReste)
        {

            Operation operation = new Operation();
            (int quotient, int reste) res = operation.Division(x, y);

            Assert.Equal(resAttenduQuotient, res.quotient);
            Assert.Equal(resAttenduReste, res.reste);

        }

        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(2, 8, -6)]
        public void TestDifference(int x, int y, int resAttenduDifference)
        {

            Operation operation = new Operation();
            int res = operation.Difference(x, y);

            Assert.Equal(resAttenduDifference, res);

        }

        [Theory]
        [InlineData(2.3, 4.7,1, 7.0)]
        [InlineData(2.56, 4.78,2, 7.34)]
       public void TestAdditionPrecision(double x, double y,int precision, double resPrecisAttendu)
        {

            Operation operation = new Operation();
            double res = operation.PrecisionSomme(x, y, precision);

            Assert.Equal(resPrecisAttendu, res, precision);

        }

        [Theory]
        [InlineData(4.3, 8.7, 2, 37.41)]
        [InlineData(7.11, 5.555, 3, 39.496)]
        public void TestProduitPrecision(double x, double y, int precision, double resPrecisProduitAttendu)
        {

            Operation operation = new Operation();
            double res = operation.PrecisionProduit(x, y, precision);

            Assert.Equal(resPrecisProduitAttendu, res);

        }

        [Theory]
        [InlineData(12.5, 5.6, 3, 2.232)]
        [InlineData(17.56, 89.999, 6, 0.195113)]

        public void TestDivisionPrecision(double x, double y, int precision, double resPrecisDivisionAttendu)
        {

            var operation = new PrecisionDivision(precision);
            double res = operation.Diviser(x, y);

            Assert.Equal(resPrecisDivisionAttendu, res);

        }

        [Theory]
        [InlineData(2.5, 1.3,1, 1.2)]
        [InlineData(7.9, 4.562, 3, 3.338)]
        public void TestDifferencePrecision(double x, double y, int precision, double resPrecisDifferenceAttendu)
        {
            var calculator = new PrecisionDifference(precision);

            
            var res = calculator.Difference(x, y);

            
            Assert.Equal(resPrecisDifferenceAttendu, res);
        }




    }

}