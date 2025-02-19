using Xunit;

namespace lab_9
{
    public class MathTests
    {
        [Fact]
        public void Test_With_Negative_Number()
        {
            double a = -1, b = 2, c = 3, x = 4;
            double result = MathFunctions.Result(a, b, c, x);
            double expected = a * Math.Pow(x, 2) + Math.Pow(b, 2) * x;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_With_Zero()
        {
            double a = 1, b = 2, c = 3, x = 0;
            double result = MathFunctions.Result(a, b, c, x);
            double expected = x - a / (x - c);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_All_Zero()
        {
            double a = 0, b = 0, c = 0, x = 0;
            double result = MathFunctions.Result(a, b, c, x);
            double expected = 1 + x / c;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Other()
        {
            double a = 1, b = 2, c = 3, x = 4;
            Assert.Throws<DivideByZeroException>(() => MathFunctions.Result(a, b, c, x));
        }
    }
}
