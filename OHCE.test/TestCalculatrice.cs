

namespace OHCE.test
{
    using Xunit;
    using static OHCE.Operation;
    public class TestCalculatrice
    {
        //Langue francaise 
        [Theory]
        [InlineData("10 plus 3", 6)]
        [InlineData("1plus 7", 15)]
        [InlineData(" 9    plus   4", 10)]
        [InlineData("1\nplus\n9", 20)]

        public void TestSomme(string valeurs, int resultatAttenduSomme)
        {

            CalculatriceEnfant calculatrice = new CalculatriceEnfant();
            calculatrice.SetLangue("fr");

            int res = calculatrice.CalculerSomme(valeurs);
            Assert.Equal(resultatAttenduSomme, res);
        }

        [Theory]
        [InlineData("5 fois 4", 20)]
        [InlineData("43fois6", 18)]
        [InlineData("12\nfois\n8", 8)]
        [InlineData(" 4    fois   1", 45)]
        public void TestProduit(string valeurs, int resultatAttenduProduit)
        {

            CalculatriceEnfant calc = new CalculatriceEnfant();
            calc.SetLangue("fr");


            int res = calc.CalculerProduit(valeurs);
            Assert.Equal(resultatAttenduProduit, res);
        }



        [Theory]
        [InlineData("6 divisé par 2", 2)]
        [InlineData("4divisépar5", 2)]
        [InlineData("3\ndivisé\n3", 2)]
        [InlineData(" 20    divisé   2", 100)]
        public void TestDivision(string valeurs, int resultatAttenduDivison)
        {

            CalculatriceEnfant calculatrice = new CalculatriceEnfant();
            calculatrice.SetLangue("fr");


            int res = calculatrice.CalculerDivision(valeurs);
            Assert.Equal(resultatAttenduDivison, res);
        }




        [Theory]
        [InlineData("400 moins 3", 1)]
        [InlineData("4moins 7", -6)]
        [InlineData("4\nmoins\n7", 7)]
        [InlineData(" 1    moins   10", 0)]
        public void TestSoustraction(string valeurs, int resultatAttenduDifference)
        {

            CalculatriceEnfant calculatrice = new CalculatriceEnfant();
            calculatrice.SetLangue("fr");


            int res = calculatrice.CalculerDifference(valeurs);


            Assert.Equal(resultatAttenduDifference, res);
        }





    }
}
