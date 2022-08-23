using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PalindromeLinkedList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            var stack = new Stack<int>();
            var curr = head;
            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }
            curr = head;
            var cnt = stack.Count / 2;
            while (stack.Count > cnt)
                if (stack.Pop() != curr.val)
                    return false;
                else
                    curr = curr.next;
            return true;
        }
    }
}