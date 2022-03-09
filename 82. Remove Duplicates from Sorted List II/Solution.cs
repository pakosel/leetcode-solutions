using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemoveDuplicatesFromSortedListII
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var dict = new Dictionary<int, int>();
            var curr = head;
            while (curr != null)
            {
                if (!dict.ContainsKey(curr.val))
                    dict.Add(curr.val, 0);
                dict[curr.val]++;
                curr = curr.next;
            }
            curr = head;
            while (curr != null)
            {
                var nextVal = curr.next == null ? int.MinValue : curr.next.val;
                if (!dict.ContainsKey(nextVal) || dict[nextVal] == 1)
                    curr = curr.next;
                else
                    curr.next = curr.next.next;
            }
            while (head != null && dict[head.val] > 1)
                head = head.next;

            return head;
        }
    }
}