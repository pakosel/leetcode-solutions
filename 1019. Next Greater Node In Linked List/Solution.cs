using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NextGreaterNodeInLinkedList
{
    public class Solution
    {
        //great explanation here: https://youtu.be/uFso48YRRao
        public int[] NextLargerNodes(ListNode head)
        {
            //determine list length
            int len = 0;
            var next = head;
            while(next != null)
            {
                len++;
                next = next.next;
            }

            int[] res = new int[len];

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();

            var curr = head;
            int i=0;
            while (curr != null)
            {
                while(stack.Count > 0 && stack.Peek().Item1 < curr.val)
                {
                    var el = stack.Pop();
                    int idx = el.Item2;
                    res[idx] = curr.val;
                }
                stack.Push(new Tuple<int, int>(curr.val, i++));
                curr = curr.next;
            }

            return res;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}