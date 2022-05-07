using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace EvenOddTree
{
    public class Solution
    {
        public bool IsEvenOddTree(TreeNode root)
        {
            var oddLevel = false;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var cnt = q.Count;
                var prev = oddLevel ? int.MaxValue : 0;
                for (int i = 0; i < cnt; i++)
                {
                    var e = q.Dequeue();
                    if (oddLevel && (e.val % 2 == 1 || e.val >= prev))
                        return false;
                    if (!oddLevel && (e.val % 2 == 0 || e.val <= prev))
                        return false;
                    prev = e.val;
                    if (e.left != null)
                        q.Enqueue(e.left);
                    if (e.right != null)
                        q.Enqueue(e.right);
                }

                oddLevel = !oddLevel;
            }
            return true;
        }
    }
}