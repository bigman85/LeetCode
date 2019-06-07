using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class MedianOfTwoSortedArraysTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0d)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5d)]
        public void Test_Algorithm_one(int[] nums1, int[] nums2, double expect)
        {
            var algorithm = new MedianOfTwoSortedArrays();

            var actual = algorithm.RunOne(nums1, nums2);

            Assert.Equal(expect, actual);
        }
    }
}