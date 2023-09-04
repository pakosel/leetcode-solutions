using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LinkedListCycle
{
    public class Solution_2023
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head?.next;
            while (slow != null && fast != null)
            {
                if (slow == fast)
                    return true;
                slow = slow.next;
                fast = fast.next?.next;
            }
            return false;
        }
    }
    
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var set = new HashSet<ListNode>();
            var curr = head;
            while (curr != null)
            {
                if (set.Contains(curr))
                    return true;
                set.Add(curr);
                curr = curr.next;
            }
            return false;
        }
    }

    public class Solution_O1
    {
        public bool HasCycle(ListNode head)
        {
            while (head != null)
            {
                if (head.val == int.MinValue)
                    return true;
                head.val = int.MinValue;
                head = head.next;
            }
            return false;
        }
    }
}