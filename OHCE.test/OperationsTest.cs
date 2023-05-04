namespace OHCE.test


{
    using Xunit;
    public class OperationsTest
    {
        [Fact]
       public void TestAddition()
        {
            int x = 2;
            int y = 8;
            int resAttendu = 10;

            Operation operation = new Operation();
            int res = operation.Somme(x,y);
            
            Assert.Equal(resAttendu, res);
           
        }
    }

}