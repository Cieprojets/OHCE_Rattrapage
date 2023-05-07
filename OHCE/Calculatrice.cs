

namespace OHCE
{
    using System.Net;
    using Xunit;

    public class CalculatriceEnfant
    {
        //Avec la langue francaise 
        private string langue;

        public void SetLangue(string langue)
        {
            this.langue = langue;
        }

        public int CalculerSomme(string valeurs)
        {

            valeurs = valeurs.Replace(" ", "").Replace("\n", "");


            string[] parties = valeurs.Split("plus");
            int x = int.Parse(parties[0]);
            int y = int.Parse(parties[1]);


            int somme = x + y;

            return somme;
        }
        public int CalculerProduit(string valeurs)
        {

            valeurs = valeurs.Replace(" ", "").Replace("\n", "");
            string[] parties = valeurs.Split(new string[] { "fois" }, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(parties[0]);
            int y = int.Parse(parties[1]);


            int produit = x * y;

            return produit;
        }

        public int CalculerDivision(string valeurs)
        {

            valeurs = valeurs.Replace(" ", "").Replace("\n", "");


            string[] parties = valeurs.Split(new string[] { "divisépar", "divisé" }, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(parties[0]);
            int y = int.Parse(parties[1]);

            if (y == 0)
            {
                throw new ArgumentException("Le diviseur ne peut pas être zéro");
            }

            int quotient = x / y;

            return quotient;
        }



        public int CalculerDifference(string valeurs)
        {

            valeurs = valeurs.Replace(" ", "").Replace("\n", "");
            string[] parties = valeurs.Split(new string[] { "moins" }, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(parties[0]);
            int y = int.Parse(parties[1]);


            int difference = x - y;

            return difference;
        }

        


    }
        




}
