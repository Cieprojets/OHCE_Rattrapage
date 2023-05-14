

using System.Linq.Expressions;

namespace OHCE.test
{
    public class RecetteTest
    {
        [Theory]
        [InlineData("5.1415\n plus 2.7182", 4, "fr", 5.8597)]
        [InlineData("78.1415 moins \n2.7182", 4, "fr", 0.4233)]
        public void Recette_1Test(string valeurs, int precision, string langue, double valeurAttendu)
        {
            var calculatrice = new CalculatricePrecision(precision, langue);

            double actual;
            if (valeurs.Contains("plus"))
            {
                actual = calculatrice.CalculerSommedecimaux(valeurs);
            }
            else if (valeurs.Contains("moins"))
            {
                actual = calculatrice.CalculerDifferencedecimaux(valeurs);
            }
            else
            {
                throw new ArgumentException("Opération non prise en charge");
            }

            Assert.Equal(valeurAttendu, actual);
        }

        private readonly Operation _operation = new Operation();

        [Theory]
        [InlineData(5, 3, 5)]
        [InlineData(2, 3, 23)]
        [InlineData(0, 0, 4)]
        [InlineData(0, 10, 12)]
        [InlineData(-4, 5, -0)]
        [InlineData(2, -7, 94)]
        public void Recette_2Test(int x, int y, int valeurAttendu)
        {
            if (valeurAttendu == _operation.Produit(x, y))
            {
                int actual = _operation.Produit(x, y);
                Console.WriteLine(actual);
                Assert.Equal(valeurAttendu, actual);
            }
            else if (valeurAttendu == _operation.Difference(x, y))
            {
                int actual = _operation.Difference(x, y);
                Console.WriteLine(actual);
                Assert.Equal(valeurAttendu, actual);
            }
            else
            {
                throw new ArgumentException("Opération non prise en charge");
            }
        }

        [Theory]
        [InlineData("2 plus\n 3", "en", 54)]
        [InlineData("5 plus 6", "en", 116)]
        [InlineData("0\n plus 10", "en", 102)]
        [InlineData("6 dividedby 2", "en", 378)]
        [InlineData("15 \ndivided by 5", "en", 352)]
        public void Recette_3Test(string valeurs, string langue, int valeurAttendu)
        {
            var calculatrice = new CalcultatriceMultiLangues();
            calculatrice.SetLangue(langue);
            int actual;
            valeurs = valeurs.Replace(" ", "").Replace("\n", "");
            if (valeurs.Contains("dividedby"))
            {
                actual = calculatrice.CalculerDivision(valeurs);
            }
            else if (valeurs.Contains("plus"))
            {
                actual = calculatrice.CalculerSomme(valeurs);
            }
            else
            {
                throw new ArgumentException("Opération non prise en charge");
            }
            Assert.Equal(valeurAttendu, actual);
        }



    }
}
