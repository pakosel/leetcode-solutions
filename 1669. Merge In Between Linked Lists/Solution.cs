using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MergeInBetweenLinkedLists
{
    public class Solution
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode head = list1;

            var nodes = FindPrevNextNodes(list1, a, b);
            if (nodes.Item1 == null)
                head = list2;
            else
                nodes.Item1.next = list2;

            LastNode(list2).next = nodes.Item2;

            return head;
        }

        private (ListNode, ListNode) FindPrevNextNodes(ListNode head, int a, int b)
        {
            ListNode curr = head;
            ListNode prev = null;

            while (curr != null)
            {
                if (curr.val == a)
                    break;
                prev = curr;
                curr = curr.next;
            }
            while (curr != null)
            {
                if (curr.val == b)
                    break;
                curr = curr.next;
            }

            return (prev, curr.next);
        }

        private ListNode LastNode(ListNode head)
        {
            ListNode curr = head;
            while (curr.next != null)
                curr = curr.next;
            return curr;
        }
    }
}