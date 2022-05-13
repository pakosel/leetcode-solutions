using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PopulatingNextRightPointersEachNodeII
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return null;
            var res = root;
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var cnt = queue.Count;
                Node prev = null;
                while (cnt-- > 0)
                {
                    var curr = queue.Dequeue();
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    curr.next = prev;
                    prev = curr;
                }
            }
            return res;
        }
    }

    public class Solution_Recursive
    {
        Dictionary<int, Node> dict = new Dictionary<int, Node>();

        public Node Connect(Node root)
        {
            Build(root, 0);

            return root;
        }

        private void Build(Node node, int level)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(level))
                dict.Add(level, node);
            else
            {
                dict[level].next = node;
                dict[level] = node;
            }

            Build(node.left, level + 1);
            Build(node.right, level + 1);
        }
    }
}