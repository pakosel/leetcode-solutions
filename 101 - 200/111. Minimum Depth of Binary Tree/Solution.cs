using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumDepthOfBinaryTree
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return Dfs(root, 1);

            int Dfs(TreeNode node, int depth)
            {
                if (node.left == null && node.right == null)
                    return depth;
                if (node.left != null && node.right != null)
                    return Math.Min(Dfs(node.left, depth + 1), Dfs(node.right, depth + 1));

                if (node.left != null)
                    return Dfs(node.left, depth + 1);

                return Dfs(node.right, depth + 1);
            }
        }
    }
}