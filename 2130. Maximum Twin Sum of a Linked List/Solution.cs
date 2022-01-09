using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumTwinSumOfLinkedList
{
    public class Solution
    {
        public int PairSum(ListNode head)
        {
            var list = new List<int>();
            var next = head;
            while (next != null)
            {
                list.Add(next.val);
                next = next.next;
            }
            var max = 0;
            for (int i = 0; i < list.Count / 2; i++)
                max = Math.Max(max, list[i] + list[list.Count - i - 1]);
            return max;
        }
    }
}