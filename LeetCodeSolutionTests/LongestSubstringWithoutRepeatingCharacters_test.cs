using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class LongestSubstringWithoutRepeatingCharacters_test
    {

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        public void Test_Algorithm_One(string src, int expect)
        {
            LongestSubstringWithoutRepeatingCharacters algorithm = new LongestSubstringWithoutRepeatingCharacters();

            int actual = algorithm.RunOne(src);

            Assert.Equal(expect,actual);
        }
    }
}