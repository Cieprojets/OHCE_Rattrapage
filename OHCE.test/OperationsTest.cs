namespace OHCE.test


{
    using Xunit;
    using static OHCE.Operation;

    public class OperationsTest
    {
        
        //etape1:lesbases

        [Theory]
        [InlineData(4,7,12)]
        [InlineData(8, 8, 18)]
        public void TestAddition(int x, int y , int resAttendu)
        {

            Operation operation = new Operation();
            int res = operation.Somme(x,y);
            
            Assert.Equal(resAttendu, res);
           
        }


        [Theory]
        [InlineData(5,4,25)]
        [InlineData(1,80,87)]
        public void TestProduit(int x, int y, int resAttenduProduit)
        {

            Operation operation = new Operation();
            int res = operation.Produit(x, y);

            Assert.Equal(resAttenduProduit, res);

        }

        [Theory]
        [InlineData(20, 5, 4,1)]
        [InlineData(1, 1, 1, 1)]
        public void TestDivision(int x, int y, int resAttenduQuotient ,int resAttenduReste)
        {

            Operation operation = new Operation();
            (int quotient, int reste) res = operation.Division(x, y);

            Assert.Equal(resAttenduQuotient, res.quotient);
            Assert.Equal(resAttenduReste, res.reste);

        }

        [Theory]
        [InlineData(7, 4, 9)]
        [InlineData(2, 8, -12)]
        public void TestDifference(int x, int y, int resAttenduDifference)
        {

            Operation operation = new Operation();
            int res = operation.Difference(x, y);

            Assert.Equal(resAttenduDifference, res);

        }

        

    }



}