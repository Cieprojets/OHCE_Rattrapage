

namespace OHCE.test
{
    public class CalculatricePrecisionTest
    {
        [Theory]
        [InlineData("2.3 plus 4.73", "fr", 2, 45.03)]
        [InlineData("2.56 plus 4.78", "en", 23, 7.3)]
        [InlineData("4.43 plus \n8.99", "en", 37, 3.420)]
        public void TestCalculerSommedecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerSommedecimaux(valeurs);


            Assert.Equal(expected, res);
        }



        [Theory]
        [InlineData("2.3 fois 4.73", "fr", 2, 10.7)]
        [InlineData("2.76 times 4.78", "en", 2, 12.24)]
        [InlineData("4.73 times \n8.99", "en", 6, 39.83)]
        public void TestCalculerProduitdecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerProduitdecimaux(valeurs);


            Assert.Equal(expected, res);
        }



        [Theory]
        [InlineData("2.3 divisépar 4.73", "fr", 2, 0)]
        [InlineData("2.56 dividedby 4.78", "en", 2, 0)]
        [InlineData("4.43 divided by \n8.99", "en", 2, 0)]
        public void TestCalculerDivisiondecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerDivisiondecimaux(valeurs);


            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("27 moins 4.73", "fr", 1, -2.4)]
        [InlineData("256 minus 4.78", "en", 2, -2.22)]
        [InlineData("8999 minus \n 4.43", "en", 3, 4.569)]
        public void TestCalculerDifferencedecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerDifferencedecimaux(valeurs);


            Assert.Equal(expected, res);
        }



    }
}
