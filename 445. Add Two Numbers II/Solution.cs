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
            var stack1 = BuildStack(l1);
            var stack2 = BuildStack(l2);
            
            ListNode head = null;
            int carry = 0;
            while(stack1.Count > 0 || stack2.Count > 0 || carry > 0)
            {
                int e1 = stack1.Count > 0 ? stack1.Pop() : 0;
                int e2 = stack2.Count > 0 ? stack2.Pop() : 0;

                int curval = e1 + e2 + carry;
                carry = curval / 10;
                head = new ListNode(curval % 10, head);
            }

            return head;
        }

        private Stack<int> BuildStack(ListNode head)
        {
            Stack<int> res = new Stack<int>();
            while (head != null)
            {
                res.Push(head.val);
                head = head.next;
            }

            return res;
        }
    }

    public class Solution_Partial
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