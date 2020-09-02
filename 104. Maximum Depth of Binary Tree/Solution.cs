using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumDepthBinaryTree
{
    public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        int maxLeft = root.left != null ? MaxDepth(root.left) : 0;
        int maxRight = root.right != null ? MaxDepth(root.right) : 0;

        return Math.Max(maxLeft, maxRight) + 1;
    }
}
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}