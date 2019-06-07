using System;
using System.Collections;
using System.Collections.Generic;

namespace Bigman.LeetCodeSolution
{
    public class TwoSum
    {
        public int[] RunOne(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        public int[] RunTwo(int[] nums, int target)
        {
            Dictionary<int, int> hs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(hs.Count>0&&hs.ContainsKey(target-nums[i]))
                {
                    return new int[] { (hs[target - nums[i]]), i };
                }
                hs[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}