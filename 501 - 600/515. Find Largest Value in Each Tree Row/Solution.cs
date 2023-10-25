using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindLargestValueInEachTreeRow
{
    public class Solution
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var res = new List<int>();
            if (root != null)
            {
                var q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    var cnt = q.Count;
                    var max = q.Peek().val;
                    for (int i = 0; i < cnt; i++)
                    {
                        var curr = q.Dequeue();
                        max = Math.Max(max, curr.val);
                        if (curr.left != null)
                            q.Enqueue(curr.left);
                        if (curr.right != null)
                            q.Enqueue(curr.right);
                    }
                    res.Add(max);
                }
            }
            return res;
        }
    }
}