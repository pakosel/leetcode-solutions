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
        
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));
        int maxDepth = 0;

        while(queue.Any())
        {
            var elem = queue.Dequeue();
            var node = elem.Item1;
            int level = elem.Item2;
            if(level > maxDepth)
                maxDepth = level;
                
            if(node.left != null)
                queue.Enqueue((node.left, level+1));
            if(node.right != null)
                queue.Enqueue((node.right, level+1));
        }

        return maxDepth;
    }

    public int MaxDepthRecursive(TreeNode root) 
    {
        if(root == null)
            return 0;
        
        int maxLeft = root.left != null ? MaxDepthRecursive(root.left) : 0;
        int maxRight = root.right != null ? MaxDepthRecursive(root.right) : 0;

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