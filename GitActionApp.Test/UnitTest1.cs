using GitActionApp.Engine;

namespace GitActionApp.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10,5,15)]
        [InlineData(10, 10, 20)]
        public void Test1(double x, double y, double expected)
        {
            CalculateEngine ce = new CalculateEngine();
            double result = ce.AddNum(x, y);

            Assert.Equal(expected, result);
        }
    }
}