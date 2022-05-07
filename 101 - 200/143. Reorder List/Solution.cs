using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReorderList
{
    public class Solution
    {
        public void ReorderList(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var curr = head;
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.next;
            }
            int cnt = stack.Count() / 2;
            curr = head;
            while (cnt-- > 0)
            {
                var ins = stack.Pop();
                ins.next = curr.next;
                curr.next = ins;
                curr = ins.next;
            }
            curr.next = null;
        }
    }
}