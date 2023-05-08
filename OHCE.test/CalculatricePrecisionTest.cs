

namespace OHCE.test
{
    public class CalculatricePrecisionTest
    {
        [Theory]
        [InlineData("2.3 plus 4.73", "fr", 2, 7.03)]
        [InlineData("2.56 plus 4.78", "en", 1, 7.3)]
        [InlineData("4.43 plus \n8.99", "en", 3, 13.420)]
        public void TestCalculerSommedecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerSommedecimaux(valeurs);
         

            Assert.Equal(expected, res);
        }



        [Theory]
        [InlineData("2.3 fois 4.73", "fr", 2, 10.88)]
        [InlineData("2.56 times 4.78", "en", 2, 12.24)]
        [InlineData("4.43 times \n8.99", "en", 2, 39.83)]
        public void TestCalculerProduitdecimaux(string valeurs, string langue, int precision, double expected)
        {
         
            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);

           
            double res = calculator.CalculerProduitdecimaux(valeurs);
           
   
           Assert.Equal(expected, res);
        }



        [Theory]
        [InlineData("2.3 divisépar 4.73", "fr", 2, 0.49)]
        [InlineData("2.56 dividedby 4.78", "en", 2, 0.54)]
        [InlineData("4.43 divided by \n8.99", "en", 2, 0.49)]
        public void TestCalculerDivisiondecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerDivisiondecimaux(valeurs);
           

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("2.3 moins 4.73", "fr", 1, -2.4)]
        [InlineData("2.56 minus 4.78", "en", 2, -2.22)]
        [InlineData("8.999 minus \n 4.43", "en", 3, 4.569)]
        public void TestCalculerDifferencedecimaux(string valeurs, string langue, int precision, double expected)
        {

            CalculatricePrecision calculator = new CalculatricePrecision(precision, langue);


            double res = calculator.CalculerDifferencedecimaux(valeurs);
          

            Assert.Equal(expected, res);
        }



    }
}
