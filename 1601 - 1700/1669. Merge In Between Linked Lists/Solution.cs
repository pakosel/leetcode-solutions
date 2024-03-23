using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MergeInBetweenLinkedLists
{
    public class Solution2024
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            b -= a;
            var currA = list1;
            while (--a > 0)
                currA = currA.next;
            var toDel = currA.next;
            while (b-- > 0)
                toDel = toDel.next;
            currA.next = list2;
            while (currA.next != null)
                currA = currA.next;
            currA.next = toDel.next;
            return list1;
        }
    }
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