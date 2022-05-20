using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace UniquePathsIII
{
    public class Solution
    {
        public int UniquePathsIII(int[][] grid)
        {
            var m = grid.Length;
            int n = grid[0].Length;
            (int x, int y) start = (0, 0);
            (int x, int y) end = (0, 0);
            var set = new HashSet<(int, int)>();
            ScanGrid();

            var res = 0;
            var queue = new Queue<(int x, int y, HashSet<(int, int)> path)>();
            queue.Enqueue((start.x, start.y, new HashSet<(int, int)>()));
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (curr.path.Contains((curr.x, curr.y)) || !set.Contains((curr.x, curr.y)))
                    continue;
                curr.path.Add((curr.x, curr.y));
                if ((curr.x, curr.y) == end)
                {
                    if (curr.path.Count == set.Count)
                        res++;
                    continue;
                }
                queue.Enqueue((curr.x + 1, curr.y, new HashSet<(int, int)>(curr.path)));
                queue.Enqueue((curr.x - 1, curr.y, new HashSet<(int, int)>(curr.path)));
                queue.Enqueue((curr.x, curr.y + 1, new HashSet<(int, int)>(curr.path)));
                queue.Enqueue((curr.x, curr.y - 1, new HashSet<(int, int)>(curr.path)));
            }
            return res;

            void ScanGrid()
            {
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        switch (grid[i][j])
                        {
                            case 0:
                                set.Add((i, j));
                                break;
                            case 1:
                                start = (i, j);
                                set.Add((i, j));
                                break;
                            case 2:
                                end = (i, j);
                                set.Add((i, j));
                                break;
                            default:
                                break;
                        }
            }
        }
    }
}