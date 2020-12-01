using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumDepthBinaryTree
{
    public class Solution
    {
        public int MaxDepth(TreeNode root) => 
                root == null ? 0 : 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
    public class Solution_Queue
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 1));
            int maxDepth = 0;

            while (queue.Any())
            {
                var elem = queue.Dequeue();
                var node = elem.Item1;
                int level = elem.Item2;
                if (level > maxDepth)
                    maxDepth = level;

                if (node.left != null)
                    queue.Enqueue((node.left, level + 1));
                if (node.right != null)
                    queue.Enqueue((node.right, level + 1));
            }

            return maxDepth;
        }
    }
}