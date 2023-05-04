namespace OHCE
{
    public  class Operation
    {
        public  int Somme(int x, int y)
        {
          return x+y ;
        }

        public int Produit(int x, int y)
        {
            return x * y;
        }
        public (int quotient, int reste) Division(int x, int y)
        {
           int quotient = x / y;
            int reste = x % y;
            return (quotient, reste);
        }

        public int Difference(int x, int y)
        {
           
            return x - y;
        }

    }
 
}