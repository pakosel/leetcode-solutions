using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConstructBinaryTreeFromInorderAndPostorderTraversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return GetNode(inorder.ToList(), postorder.ToList());
        }

        private TreeNode GetNode(List<int> inorder, List<int> postorder)
        {
            if (inorder.Count == 0)
                return null;
            var root = new TreeNode(postorder.Last());
            postorder.RemoveAt(postorder.Count - 1);
            var rootIdx = inorder.IndexOf(root.val);
            root.left = GetNode(inorder.Take(rootIdx).ToList(), postorder.Take(rootIdx).ToList());
            var rightSubTreeSize = postorder.Count - rootIdx;
            root.right = GetNode(inorder.TakeLast(rightSubTreeSize).ToList(), postorder.TakeLast(rightSubTreeSize).ToList());
            return root;
        }

    }
}