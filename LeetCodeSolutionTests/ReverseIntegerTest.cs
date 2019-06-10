using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class ReverserIntegerTest
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1534236469, 0)]
        [InlineData(-2147483648, 0)]
        public void Test_Algorithm_One(int num, int expect)
        {
            var algorithm = new ReverserInteger();

            var actual = algorithm.RunOne(num);

            Assert.Equal(expect, actual);
        }
    }
}