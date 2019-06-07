using System;
using Xunit;
using Bigman.LeetCodeSolution;
using Bigman.LeetCodeSolutionTests.Utilities;

namespace Bigman.LeetCodeSolutionTests
{
    public class AddTwoNumbersTest
    {
        [Theory]
        [InlineData(new int[] { 5 }, new int[] { 5 }, new int[] { 0,1 })]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        public void Test_Algorithm_One(int[] l1, int[] l2, int[] expect)
        {
            AddTwoNumbers algorithm = new AddTwoNumbers();
            ListNode ln1 = Convert(l1);
            ListNode ln2 = Convert(l2);
            ListNode lnExpect = Convert(expect);

            ListNode result = algorithm.Run(ln1, ln2);

            Assert.True(SameNodeList(result, lnExpect));

        }

        public bool SameNodeList(ListNode ln1, ListNode ln2)
        {
            bool res = true;

            do
            {
                if (ln1.val != ln2.val)
                {
                    res = false;
                    break;
                }
                else if (ln1.next == null && ln2.next != null)
                {
                    res = false;
                    break;
                }
                else if (ln1.next != null && ln2.next == null)
                {
                    res = false;
                    break;
                }

                ln1 = ln1.next;
                ln2 = ln2.next;

            } while (ln1 != null && ln2 != null);

            return res;
        }

        ListNode Convert(int[] arr)
        {
            ListNode result;
            if (arr.Length > 0)
            {
                result = new ListNode(arr[0]);
                ListNode current = result;

                for (int i = 1; i < arr.Length; i++)
                {
                    current.next = new ListNode(arr[i]);
                    current = current.next;
                }
            }
            else
            {
                result = new ListNode(0);
            }
            return result;
        }
    }
}
