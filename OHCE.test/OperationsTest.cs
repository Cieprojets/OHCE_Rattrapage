namespace OHCE.test


{
    using Xunit;
    public class OperationsTest
    {
        [Theory]
        [InlineData(4,7,11)]
        [InlineData(8, 8, 16)]
        public void TestAddition(int x, int y , int resAttendu)
        {

            Operation operation = new Operation();
            int res = operation.Somme(x,y);
            
            Assert.Equal(resAttendu, res);
           
        }
    }

}