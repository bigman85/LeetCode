using System;
namespace Bigman.LeetCodeSolution
{
    public class AddTwoNumbers
    {
        public ListNode Run(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode cursor = null;
            int extra = 0;
            while (l1 != null || l2 != null || extra > 0)
            {
                if (result == null)
                {
                    result = new ListNode(0);
                    cursor = result;
                }
                else
                {
                    cursor.next = new ListNode(0);
                    cursor = cursor.next;
                }
                extra += (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                cursor.val = extra % 10;
                extra = extra / 10;

                l1 = l1?.next;
                l2 = l2?.next;
            }
            return result;
        }
    }


    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}