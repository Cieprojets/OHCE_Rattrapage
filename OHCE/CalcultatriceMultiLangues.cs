


namespace OHCE
{
    using System;
    using System.Globalization;
    using System.Net;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Channels;
    using Xunit;
    public class CalcultatriceMultiLangues
        {
        

        private string langue;

        public void SetLangue(string langue)
        {
            this.langue = langue;
        }
        public int CalculerSomme(string expression)
        {
           
            expression = expression.Replace(" ", "").Replace("\n", "");

            
            string[] parties;
            int x, y;
            if (langue == "fr")
            {
                parties = expression.Split(new string[] { "plus" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else if (langue == "en")
            {
                parties = expression.Split(new string[] { "plus" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }

            int somme = x + y;

            return somme;
        }






        public int CalculerProduit(string expression)
        {
          
            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties;
            int x, y;
            if (langue == "fr")
            {
                parties = expression.Split(new string[] { "fois" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else if (langue == "en")
            {
                parties = expression.Split(new string[] { "times" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }

           
            int produit = x * y;

            return produit;
        }



        public int CalculerDivision(string expression)
        {

            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties;
            int x, y;
            if (langue == "fr")
            {
                parties = expression.Split(new string[] { "divisépar" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else if (langue == "en")
            {
                parties = expression.Split(new string[] { "dividedby" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }


            int division = x / y;

            return division;
        }


        public int CalculerDifference(string expression)
        {

            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties;
            int x, y;
            if (langue == "fr")
            {
                parties = expression.Split(new string[] { "moins" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else if (langue == "en")
            {
                parties = expression.Split(new string[] { "minus" }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parties[0]);
                y = int.Parse(parties[1]);
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }


            int difference = x - y;

            return difference;
        }

    }
   






}
