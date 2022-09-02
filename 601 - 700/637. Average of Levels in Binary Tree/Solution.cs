using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AverageOfLevelsInBinaryTree
{
    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var res = new List<double>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var cnt = q.Count;
                double sum = 0;
                for (int i = 0; i < cnt; i++)
                {
                    var node = q.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                res.Add(Math.Round(sum / cnt, 5));
            }
            return res;
        }
    }
}