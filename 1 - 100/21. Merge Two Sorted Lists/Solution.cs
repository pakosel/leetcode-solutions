using System.Collections.Generic;
using System.Linq;
using System;

namespace MergeTwoSortedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            ListNode head = new ListNode(MinNode(ref l1, ref l2));
            ListNode curr = head;
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    curr.next = l2;
                    break;
                }

                if (l2 == null)
                {
                    curr.next = l1;
                    break;
                }

                curr.next = new ListNode(MinNode(ref l1, ref l2));
                curr = curr.next;
            }

            return head;
        }

        private int MinNode(ref ListNode l1, ref ListNode l2)
        {
            int min = 0;
            if (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    min = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    min = l2.val;
                    l2 = l2.next;
                }
            }
            else if (l1 == null)
            {
                min = l2.val;
                l2 = l2.next;
            }
            else
            {
                min = l1.val;
                l1 = l1.next;
            }

            return min;
        }
    }
}