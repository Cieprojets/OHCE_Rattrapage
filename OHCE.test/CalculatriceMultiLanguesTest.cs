

namespace OHCE.test
{
    using System;
    using System.Globalization;
    using Xunit;


    public class CalculatriceMultiLanguesTest
    {

        [Theory]
        [InlineData("2 plus 3", "en", 5)]
        [InlineData("2 plus 3", "fr", 5)]
        [InlineData("10 plus 20", "en", 30)]
        [InlineData("10 plus 20", "fr", 30)]
        [InlineData("5 plus\n7", "en", 12)]
        [InlineData("5 plus\n7", "fr", 12)]
        public void CalculerSommeTest(string valeurs, string langue, int valeurAttendu)
        {
    
            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);

           
            var res = calc.CalculerSomme(valeurs);

     
            Assert.Equal(valeurAttendu, res);
        }


        [Theory]
        [InlineData("2fois4", "fr", 8)]
        [InlineData("5times6", "en", 30)]
        [InlineData(" 7   fois \n  3  \n ", "fr", 21)]
        [InlineData("  9     times  \n    8", "en", 72)]
        public void CalculerProduitTest(string valeurs, string langue, int valeurAttendu)
        {
            
            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);

          
            var res = calc.CalculerProduit(valeurs);

           
            Assert.Equal(valeurAttendu, res);
        }

        [Theory]
        [InlineData("4divisépar2", "fr", 2)]
        [InlineData("5dividedby \n5 ", "en", 1)]
        [InlineData(" 1   divisé par \n  1  \n ", "fr", 1)]
        [InlineData("  8     divided by  \n    2", "en", 4)]
        public void CalculerDivisionTest(string valeurs, string langue, int valeurAttendu)
        {

            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);


            var res = calc.CalculerDivision(valeurs);


            Assert.Equal(valeurAttendu, res);
        }

        [Theory]
        [InlineData("2minus4", "en", -2)]
        [InlineData("5moins3", "fr", 2)]
        [InlineData(" 7   moins \n  3  \n ", "fr", 4)]
        [InlineData("  9     minus  \n    8", "en", 1)]
        public void CalculerDifferenceTest(string valeurs, string langue, int valeurAttendu)
        {

            var calc = new CalcultatriceMultiLangues();
            calc.SetLangue(langue);


            var res = calc.CalculerDifference(valeurs);


            Assert.Equal(valeurAttendu, res);
        }


    }
}
