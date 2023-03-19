using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckCompletenessOfBinaryTree
{
    public class Solution
    {
        public bool IsCompleteTree(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var exp = 1;

            while (q.Count > 0)
            {
                if (q.Count != exp)
                    return q.All(n => n.left == null && n.right == null);
                var finished = false;
                for (int i = 0; i < exp; i++)
                {
                    var node = q.Dequeue();
                    if (node.left != null)
                        if (finished)
                            return false;
                        else
                            q.Enqueue(node.left);
                    else
                        finished = true;

                    if (node.right != null)
                        if (finished)
                            return false;
                        else
                            q.Enqueue(node.right);
                    else
                        finished = true;
                }
                exp *= 2;
            }
            return true;
        }
    }
}