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
        [InlineData("A",1,"A")]
        public void Test_Algorithm_one(string source, int nums, string expect)
        {
            var algorithm = new ZigzagConversion();

            var actual = algorithm.RunOne(source,nums);

            Assert.Equal(expect, actual);
        }
    }
}