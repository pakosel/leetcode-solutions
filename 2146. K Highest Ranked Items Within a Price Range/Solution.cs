using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace KHighestRankedItemsWithinPriceRange
{
    public class Solution
    {
        public IList<IList<int>> HighestRankedKItems(int[][] grid, int[] pricing, int[] start, int k)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;

            var res = new List<IList<int>>();
            var queue = new Queue<(int row, int col)>();
            queue.Enqueue((start[0], start[1]));

            while (queue.Count > 0)
            {
                var list = new List<(int row, int col, int price)>();
                var qc = queue.Count;
                for (int i = 0; i < qc; i++)
                {
                    var e = queue.Dequeue();

                    var price = grid[e.row][e.col];
                    if (price == 0)
                        continue;
                    if (price > 1 && price >= pricing[0] && price <= pricing[1])
                        list.Add((e.row, e.col, price));
                    grid[e.row][e.col] = 0;

                    if (e.row + 1 < rows && grid[e.row + 1][e.col] != 0)
                        queue.Enqueue((e.row + 1, e.col));
                    if (e.row - 1 >= 0 && grid[e.row - 1][e.col] != 0)
                        queue.Enqueue((e.row - 1, e.col));
                    if (e.col + 1 < cols && grid[e.row][e.col + 1] != 0)
                        queue.Enqueue((e.row, e.col + 1));
                    if (e.col - 1 >= 0 && grid[e.row][e.col - 1] != 0)
                        queue.Enqueue((e.row, e.col - 1));
                }
                var sorted = list.OrderBy(e => e.price).ThenBy(e => e.row).ThenBy(e => e.col);
                foreach (var e in sorted)
                    if (res.Count < k)
                        res.Add(new int[] { e.row, e.col });
                    else
                        break;

                if (res.Count == k)
                    break;
            }
            return res;
        }
    }
}