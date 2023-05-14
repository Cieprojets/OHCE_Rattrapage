

namespace OHCE.test
{
    using System;
    using System.Globalization;
    using Xunit;


    public class CalculatriceMultiLanguesTest
    {

        [Theory]
        [InlineData("7 plus 3", "fr", 5)]
        [InlineData("7 plus 3", "fr", 0)]
        [InlineData("1 plus 20", "en", 34)]
        [InlineData("1 plus 20", "en", 0)]
        [InlineData("54 plus\n7", "en",12)]
        [InlineData("54 plus\n7", "fr", 1)]
        public void CalculerSommeTest(string valeurs, string langue, int valeurAttendu)
        {

            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);


            var res = calc.CalculerSomme(valeurs);


            Assert.Equal(valeurAttendu, res);
        }


        [Theory]
        [InlineData("2fois4", "en", 8)]
        [InlineData("5times6", "en", 0)]
        [InlineData(" 7   fois \n  3  \n ", "fr", 1)]
        [InlineData("  9     times  \n    8", "en", 2)]
        public void CalculerProduitTest(string valeurs, string langue, int valeurAttendu)
        {

            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);


            var res = calc.CalculerProduit(valeurs);


            Assert.Equal(valeurAttendu, res);
        }

        [Theory]
        [InlineData("7divisépar2", "fr", 270)]
        [InlineData("7dividedby \n5 ", "en", 100)]
        [InlineData(" 17   divisé par \n  1  \n ", "en", 170)]
        [InlineData("  80    divided by  \n    2", "en", 470)]
        public void CalculerDivisionTest(string valeurs, string langue, int valeurAttendu)
        {

            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);


            var res = calc.CalculerDivision(valeurs);


            Assert.Equal(valeurAttendu, res);
        }

        [Theory]
        [InlineData("7minus4", "en", -42)]
        [InlineData("7moins3", "en", 27)]
        [InlineData(" 7   moins \n  3  \n ", "fr", 40)]
        [InlineData("  4     minus  \n    8", "fr", 10)]
        public void CalculerDifferenceTest(string valeurs, string langue, int valeurAttendu)
        {

            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);


            var res = calc.CalculerDifference(valeurs);


            Assert.Equal(valeurAttendu, res);
        }


    }
}
