using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinaryTreePostorderTraversal
{
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            return PostorderTraversal(root.left).Concat(PostorderTraversal(root.right)).Append(root.val).ToList();
        }
    }
}