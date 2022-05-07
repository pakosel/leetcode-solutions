using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LinkedListCycleII
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            var set = new HashSet<ListNode>();
            var curr = head;
            while (curr != null)
            {
                if (set.Contains(curr))
                    return curr;
                else
                    set.Add(curr);
                curr = curr.next;
            }
            return null;
        }
    }
}