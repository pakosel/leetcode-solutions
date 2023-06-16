using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumLevelSumOfBinaryTree
{
    public class Solution
    {
        public int MaxLevelSum(TreeNode root)
        {
            var max = root.val;
            var res = 1;
            var level = 1;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var cnt = q.Count;
                var sum = 0;
                for (int i = 0; i < cnt; i++)
                {
                    var dq = q.Dequeue();
                    sum += dq.val;
                    if (dq.left != null)
                        q.Enqueue(dq.left);
                    if (dq.right != null)
                        q.Enqueue(dq.right);
                }
                if (sum > max)
                {
                    max = sum;
                    res = level;
                }
                level++;
            }
            return res;
        }
    }
}