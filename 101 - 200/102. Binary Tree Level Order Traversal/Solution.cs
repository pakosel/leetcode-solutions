using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinaryTreeLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            if (root != null)
                queue.Enqueue(root);

            while (queue.Count() > 0)
            {
                var cnt = queue.Count;
                var arr = new int[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    var node = queue.Dequeue();
                    arr[i] = node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                res.Add(arr);
            }

            return res;
        }
    }
}