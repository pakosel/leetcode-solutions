using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KthSmallestElementInBst
{
    public class Solution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        HashSet<int> visited = new HashSet<int>();
        public int KthSmallest(TreeNode root, int k)
        {
            TraverseToMin(root);

            TreeNode node = null;

            while(k > 0)
            {
                node = stack.Peek();
                if(node.left == null || (node.left != null && visited.Contains(node.left.val)))
                {
                    stack.Pop();
                    k--;
                    visited.Add(node.val);
                }
                
                if(k == 0)
                    break;
                else if(node.left != null && !visited.Contains(node.left.val))
                    TraverseToMin(node.left);
                else if(node.right != null && !visited.Contains(node.right.val))
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