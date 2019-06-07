using System;
namespace Bigman.LeetCodeSolution
{
    public class MedianOfTwoSortedArrays
    {
        public double RunOne(int[] nums1, int[] nums2)
        {
            int cursor1 = 0, cursor2 = 0;
            int total = nums1.Length + nums2.Length;
            int[] nums3 = new int[total];
            for (int i = 0; i < total / 2 + 1; i++)
            {
                if (cursor2 >= nums2.Length  || (cursor1 <= nums1.Length - 1 && nums1[cursor1] < nums2[cursor2]))
                {
                    nums3[cursor1 + cursor2] = nums1[cursor1];
                    cursor1++;
                }
                else
                {
                    nums3[cursor1 + cursor2] = nums2[cursor2];
                    cursor2++;
                };

            }

            if (total % 2 == 0)
            {
                return (nums3[total / 2] + nums3[total / 2 - 1]) / 2.0d;
            }
            else
            {
                return nums3[total / 2];
            }
        }
    }

}