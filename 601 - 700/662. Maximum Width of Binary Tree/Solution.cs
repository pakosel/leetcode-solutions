using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumWidthOfBinaryTree
{
    public class Solution_2023
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            var q = new Queue<(TreeNode node, long order)>();
            long res = 0;

            q.Enqueue((root, 1));

            while (q.Count > 0)
            {
                var cnt = q.Count;
                long min = q.Peek().order, max = min;
                for (int i = 0; i < cnt; i++)
                {
                    var curr = q.Dequeue();
                    min = Math.Min(min, curr.order);
                    max = Math.Max(max, curr.order);
                    res = Math.Max(res, max - min + 1);
                    if (curr.node.left != null) q.Enqueue((curr.node.left, 2 * curr.order - 1));
                    if (curr.node.right != null) q.Enqueue((curr.node.right, 2 * curr.order));
                }
            }
            return (int)res;
        }
    }
    public class Solution
    {
        Dictionary<long, List<long>> dict = new Dictionary<long, List<long>>();
        public int WidthOfBinaryTree(TreeNode root)
        {
            long max = 0;
            Traverse(root, 0, 1);
            foreach (var kvp in dict)
                max = Math.Max(max, kvp.Value.Max() - kvp.Value.Min() + 1);
            return (int)max;
        }

        private void Traverse(TreeNode node, long level, long order)
        {
            if (!dict.ContainsKey(level))
                dict.Add(level, new List<long>());
            dict[level].Add(order);
            if (node.left != null)
                Traverse(node.left, level + 1, 2 * order - 1);
            if (node.right != null)
                Traverse(node.right, level + 1, 2 * order);
        }
    }

    //Same solution without recursion - Queue based
    public class Solution_NoRecursion
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            var arr = new (long min, long max)[3000];
            long max = 0;
            var queue = new Queue<(TreeNode node, long level, long order)>();
            queue.Enqueue((root, 0, 1));

            while (queue.Count > 0)
            {
                var el = queue.Dequeue();
                if (arr[el.level].min == 0)
                    arr[el.level] = (long.MaxValue, long.MinValue);

                arr[el.level] = (Math.Min(arr[el.level].min, el.order), Math.Max(arr[el.level].max, el.order));
                max = Math.Max(max, arr[el.level].max - arr[el.level].min + 1);

                if (el.node.left != null)
                    queue.Enqueue((el.node.left, el.level + 1, 2 * el.order - 1));
                if (el.node.right != null)
                    queue.Enqueue((el.node.right, el.level + 1, 2 * el.order));
            }
            return (int)max;
        }
    }
}