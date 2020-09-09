using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Builder(new List<int>(preorder), new List<int>(inorder));
        }

        private TreeNode Builder(List<int> preorder, List<int> inorder)
        {
            int count = preorder.Count;
            if(count == 0)
                return null;
            else if(count == 1)
                return new TreeNode(preorder[0]);

            TreeNode root = new TreeNode(preorder[0]);
            int rootIdx = inorder.IndexOf(root.val);
            root.left = Builder(preorder.GetRange(1, rootIdx), inorder.GetRange(0, rootIdx));
            root.right = Builder(preorder.GetRange(rootIdx + 1, count-rootIdx-1), inorder.GetRange(rootIdx + 1, count-rootIdx-1));

            return root;
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