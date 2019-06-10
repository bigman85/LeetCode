using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class StringToIntegerAtoiTest
    {
        [Theory]
        [InlineData("123", 123)]
        [InlineData("       -123", -123)] 
        [InlineData("4193 with words", 4193)] 
        [InlineData("words and 987", 0)] 
        [InlineData("-91283472332", -2147483648)] 
        public void Test_Algorithm_One(string num, int expect)
        {
            var algorithm = new StringToIntegerAtoi();

            var actual = algorithm.RunOne(num);

            Assert.Equal(expect, actual);
        }
    }
}