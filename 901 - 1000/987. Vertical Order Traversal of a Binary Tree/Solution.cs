using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace VerticalOrderTraversalOfBinaryTree
{
    public class Solution
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {

            var pq = new PriorityQueue<(int val, int col, int row), (int, int, int)>(
                                Comparer<(int val, int col, int row)>.Create(
                                            (x, y) => x.col != y.col ?
                                                        x.col.CompareTo(y.col) :
                                                        x.row != y.row ? x.row.CompareTo(y.row) : x.val.CompareTo(y.val)));

            var queue = new Queue<(TreeNode node, int col)>();
            queue.Enqueue((root, 0));
            int row = 0;
            while (queue.Count > 0)
            {
                var cnt = queue.Count;
                while (cnt-- > 0)
                {
                    var curr = queue.Dequeue();
                    var p = (curr.node.val, curr.col, row);
                    pq.Enqueue(p, p);
                    if (curr.node.left != null)
                        queue.Enqueue((curr.node.left, curr.col - 1));
                    if (curr.node.right != null)
                        queue.Enqueue((curr.node.right, curr.col + 1));
                }
                row++;
            }

            var res = new List<IList<int>>();
            var col = int.MaxValue;
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                var list = (curr.col == col ? res.Last() : new List<int>());
                list.Add(curr.val);
                if (curr.col != col)
                {
                    res.Add(list);
                    col = curr.col;
                }
            }
            return res;
        }
    }
}