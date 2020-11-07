using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AddTwoNumbersII
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long n1 = BuildNumber(l1);
            long n2 = BuildNumber(l2);

            return BuildList(n1 + n2);
        }

        private long BuildNumber(ListNode head)
        {
            long res = 0;
            ListNode curr = head;
            while (curr != null)
            {
                res *= 10;
                res += curr.val;
                curr = curr.next;
            }

            return res;
        }

        private ListNode BuildList(long num)
        {
            ListNode head = new ListNode((int)(num % 10));
            num /= 10;
            while (num != 0)
            {
                head = new ListNode((int)(num % 10), head);
                num /= 10;
            }

            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}