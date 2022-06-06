using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace IntersectionOfTwoLinkedLists
{
    public class Solution_Smart : ISolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var a = headA;
            var b = headB;
            while(a != b)
            {
                a = (a == null ? headA : a.next);
                b = (b == null ? headB : b.next);
            }
            return a;
        }
    }

    public class Solution : ISolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var a = headA;
            var b = headB;
            var set = new HashSet<ListNode>();
            while (a != null)
            {
                set.Add(a);
                a = a.next;
            }
            while (b != null)
            {
                if (set.Contains(b))
                    return b;
                b = b.next;
            }
            return null;
        }
    }

    public interface ISolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB);
    }
}