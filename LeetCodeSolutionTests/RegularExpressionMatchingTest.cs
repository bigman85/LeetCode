using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class RegularExpressionMathingTest
    {
        [Theory]
        [InlineData("aa","a*",true)]
        [InlineData("aa","a",false)]
        public void Test_Algorithm_one(string source, string expression, bool expect)
        {
            var algorithm = new RegularExpressionMatching();

            var actual = algorithm.RunOne(source,expression);

            Assert.Equal(expect, actual);
        }
    }
}