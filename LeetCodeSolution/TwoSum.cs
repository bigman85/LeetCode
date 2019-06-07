using System;
using System.Collections;

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
            Hashtable hs = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                hs[nums[i]]=i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(hs.Contains(target-nums[i])){
                    return new int[]{i, Convert.ToInt32( hs[target-nums[i]])};
                }
            }

            return new int[] { };
        }
    }
}