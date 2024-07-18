using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheWinnerOfTheCircularGame
{
    public class Solution
    {
        public int FindTheWinner(int n, int k)
        {
            var head = new ListNode(1, null);
            var curr = head;
            for (int i = 2; i <= n; i++)
            {
                var node = new ListNode(i, curr);
                curr.next = node;
                curr = curr.next;
            }
            curr.next = head;
            head.prev = curr;
            curr = head;

            while (n-- > 1)
            {
                for (int i = 0; i < k - 1; i++)
                    curr = curr.next;
                (curr.prev.next, curr.next.prev) = (curr.next, curr.prev);
                curr = curr.next;
            }
            return curr.Val;
        }

        public class ListNode
        {
            public int Val;
            public ListNode next;
            public ListNode prev;
            public ListNode(int val, ListNode p)
            {
                Val = val;
                prev = p;
            }
        }
    }
}