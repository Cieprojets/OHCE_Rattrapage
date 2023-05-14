

using System.Diagnostics;
using System.Globalization;

namespace OHCE
{
    public class CalculatricePrecision
    {
        private int _precision;
        private string _langue;


        public CalculatricePrecision(int precision, string langue)
        {
            _precision = precision;
            _langue = langue;
        }

        public double CalculerSommedecimaux(string expression)
        {
            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties = new string[2];
            decimal x, y;
            if (_langue == "fr")
            {
                parties = expression.Split(new string[] { "plus" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else if (_langue == "en")
            {
                parties = expression.Split(new string[] { "plus" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }

            decimal somme = decimal.Round(x + y, _precision, MidpointRounding.AwayFromZero);
            return (double)somme;
        }

        public double CalculerProduitdecimaux(string expression)
        {
            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties = new string[2];
            decimal x, y;
            if (_langue == "fr")
            {
                parties = expression.Split(new string[] { "fois" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else if (_langue == "en")
            {
                parties = expression.Split(new string[] { "times" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }

            decimal produit = decimal.Round(x * y, _precision, MidpointRounding.AwayFromZero);
            return (double)produit;
        }


        public double CalculerDivisiondecimaux(string expression)
        {
            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties = new string[2];
            decimal x, y;
            if (_langue == "fr")
            {
                parties = expression.Split(new string[] { "divisépar" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else if (_langue == "en")
            {
                parties = expression.Split(new string[] { "dividedby" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }

            decimal division = decimal.Round(x / y, _precision, MidpointRounding.AwayFromZero);
            return (double)division;
        }


        public double CalculerDifferencedecimaux(string expression)
        {
            expression = expression.Replace(" ", "").Replace("\n", "");

            string[] parties = new string[2];
            decimal x, y;
            if (_langue == "fr")
            {
                parties = expression.Split(new string[] { "moins" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else if (_langue == "en")
            {
                parties = expression.Split(new string[] { "minus" }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
                if (!decimal.TryParse(parties[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x)
                    || !decimal.TryParse(parties[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                {
                    throw new FormatException("Format de la chaîne incorrect");
                }
            }
            else
            {
                throw new ArgumentException("Langue non prise en charge");
            }

            decimal division = decimal.Round(x - y, _precision, MidpointRounding.AwayFromZero);
            return (double)division;
        }

    }
}
