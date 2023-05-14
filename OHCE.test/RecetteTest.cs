

using System.Linq.Expressions;

namespace OHCE.test
{
    public class RecetteTest
    {
        [Theory]
        [InlineData("3.1415\n plus 2.7182", 4, "fr", 5.8597)]
        [InlineData("3.1415 moins \n2.7182", 4, "fr", 0.4233)]
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
        [InlineData(5, 3, 2)]
        [InlineData(2, 3, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 10, 0)]
        [InlineData(-4, 5, -20)]
        [InlineData(2, -7, 9)]
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
        [InlineData("2 plus\n 3", "en", 5)]
        [InlineData("5 plus 6", "en", 11)]
        [InlineData("0\n plus 10", "en", 10)]
        [InlineData("6 dividedby 2", "en", 3)]
        [InlineData("15 \ndivided by 5", "en", 3)]
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
