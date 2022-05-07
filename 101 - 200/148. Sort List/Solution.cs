using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortList
{
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null)
                return null;
            var sorted = ToSortedList(head);
            return BuildList(sorted);
        }

        private List<int> ToSortedList(ListNode head)
        {
            var res = new List<int>();
            while (head != null)
            {
                res.Add(head.val);
                head = head.next;
            }
            res.Sort();
            return res;
        }

        private ListNode BuildList(List<int> list)
        {
            var root = new ListNode(list[0]);
            var curr = root;
            for (int i = 1; i < list.Count; i++)
            {
                curr.next = new ListNode(list[i]);
                curr = curr.next;
            }
            return root;
        }
    }
}