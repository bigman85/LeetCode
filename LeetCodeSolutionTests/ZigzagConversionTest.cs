using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class ZigzagConversionTest
    {
        [Theory]
        [InlineData("LEETCODEISHIRING",3,"LCIRETOESIIGEDHN")]
        [InlineData("LEETCODEISHIRING",4,"LDREOEIIECIHNTSG")]
        public void Test_Algorithm_one(string source, int nums, string expect)
        {
            var algorithm = new LongestPalindromicSubstring();

            var actual = algorithm.RunOne(source);

            Assert.Equal(expect, actual);
        }
    }
}