using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumAbsoluteDifferenceInBST
{
    public class Solution
    {
        public int GetMinimumDifference(TreeNode root)
        {
            var pq = new PriorityQueue<int, int>();
            Traverse(root);
            var min = int.MaxValue;
            var el = pq.Dequeue();
            while (pq.Count > 0)
            {
                min = Math.Min(min, pq.Peek() - el);
                el = pq.Dequeue();
            }
            return min;

            void Traverse(TreeNode node)
            {
                if (node != null)
                {
                    pq.Enqueue(node.val, node.val);
                    Traverse(node.left);
                    Traverse(node.right);
                }
            }
        }
    }
}