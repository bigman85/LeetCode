using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class TwoSum_test
    {
        [Theory]
        [InlineData(new int[]{2, 7, 11, 15}, 9 , new int[]{0,1})]
        [InlineData(new int[]{1, 2, 5, 5, 7, 11, 15}, 10 , new int[]{2,3})]
        public void Test_Algorithm_one(int[] nums, int target,int[] expect)
        {
            TwoSum algorithm = new TwoSum();

            var result = algorithm.RunOne(nums,target);

            Assert.True(new ArrayExtense().SameArray(result, expect));
        }

        
        [Theory]
        [InlineData(new int[]{2, 7, 11, 15}, 9 , new int[]{0,1})]
        [InlineData(new int[]{1, 2, 5, 5, 7, 11, 15}, 10 , new int[]{2,3})]
        public void Test_Algorithm_two(int[] nums, int target,int[] expect)
        {
            TwoSum algorithm = new TwoSum();

            var result = algorithm.RunTwo(nums,target);

            Assert.True(new ArrayExtense().SameArray(result, expect));
        }
    }
}
