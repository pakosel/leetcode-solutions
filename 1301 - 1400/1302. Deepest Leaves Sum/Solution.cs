using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DeepestLeavesSum
{
    public class Solution_BFS
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var sum = 0;
            while (queue.Count > 0)
            {
                sum = 0;
                var cnt = queue.Count;
                for (int i = 0; i < cnt; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return sum;
        }
    }

    public class Solution_DFS
    {
        public int DeepestLeavesSum(TreeNode root, int level = 0) => Helper(root, 0).sum;

        private (int sum, int level) Helper(TreeNode root, int level)
        {
            (int sum, int level) left = root.left != null ? Helper(root.left, level+1) : (0, -1);
            (int sum, int level) right = root.right != null ? Helper(root.right, level+1) : (0, -1);
            
            if(left.level == right.level)
                if(left.level == -1)
                    return (root.val, level);
                else
                    return (left.sum + right.sum, left.level);

            if(left.level > right.level)
                return left;
            else
                return right;
        }
    }
}