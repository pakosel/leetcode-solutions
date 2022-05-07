using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace BinaryTreeRightSideView
{
    public class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
                return res;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode r = null;
            while (queue.Count > 0)
            {
                var len = queue.Count;

                for (int i = 0; i < len; i++)
                {
                    r = queue.Dequeue();
                    if (r.left != null) queue.Enqueue(r.left);
                    if (r.right != null) queue.Enqueue(r.right);
                }
                res.Add(r.val);
            }
            return res;
        }
    }
}