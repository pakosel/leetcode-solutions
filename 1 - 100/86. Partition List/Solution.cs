using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PartitionList
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode res = null;
            var q = new Queue<int>();
            ListNode curr = null;
            while (head != null)
            {
                if (head.val < x)
                    Append(head.val);
                else
                    q.Enqueue(head.val);
                head = head.next;
            }
            while (q.Count > 0)
                Append(q.Dequeue());

            return res;

            void Append(int val)
            {
                if (curr == null)
                {
                    curr = new ListNode(val);
                    res = curr;
                }
                else
                {
                    curr.next = new ListNode(val);
                    curr = curr.next;
                }
            }
        }
    }
}