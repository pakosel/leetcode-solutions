using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CopyListWithRandomPointer
{
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            var dict = new Dictionary<Node, Node>();
            Node res = null;
            Node currNew = null;
            var curr = head;
            while (curr != null)
            {
                var n = new Node(curr.val);
                n.random = curr.random;
                if (currNew != null)
                    currNew.next = n;
                else
                    res = n;
                dict.Add(curr, n);
                curr = curr.next;
                currNew = n;
            }
            currNew = res;
            while (currNew != null)
            {
                if (currNew.random != null)
                    currNew.random = dict[currNew.random];
                currNew = currNew.next;
            }
            return res;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}