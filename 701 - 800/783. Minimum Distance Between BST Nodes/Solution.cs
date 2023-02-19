using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumDistanceBetweenBstNodes
{
    public class Solution
    {
        public int MinDiffInBST(TreeNode root)
        {
            var pq = new PriorityQueue<int, int>();
            Visit(root);

            var res = int.MaxValue;
            var prev = pq.Dequeue();
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                if (curr - prev < res)
                    res = curr - prev;
                prev = curr;
            }
            return res;

            void Visit(TreeNode node)
            {
                if (node == null)
                    return;
                pq.Enqueue(node.val, node.val);
                Visit(node.left);
                Visit(node.right);
            }
        }
    }
}