using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace RotateList
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)
                return head;

            var last = head;
            var cnt = 1;
            while (last.next != null)
            {
                last = last.next;
                cnt++;
            }
            k %= cnt;
            k = cnt - k;

            var curr = head;
            while (--k > 0)
                curr = curr.next;

            last.next = head;
            head = curr.next;
            curr.next = null;

            return head;
        }
    }
}