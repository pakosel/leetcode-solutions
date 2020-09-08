using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KthSmallestElementInBst
{
    public class Solution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        public int KthSmallest(TreeNode root, int k)
        {
            TraverseToMin(root);

            TreeNode node = null;

            while(true)
            {
                node = stack.Pop();
                if(--k == 0)
                    break;
                
                TraverseToMin(node.right);
            }

            return node.val;
        }

        private void TraverseToMin(TreeNode node)
        {
            while(node != null)
            {
                stack.Push(node);
                node = node.left;
            }
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