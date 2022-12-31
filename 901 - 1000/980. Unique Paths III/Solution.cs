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
            Point start = new(0, 0);
            Point end = new(0, 0);
            var moves = new Point[] {new(1,0), new(0,1), new(-1,0), new(0,-1)};
            var set = new HashSet<Point>();
            ScanGrid();

            var res = 0;
            var queue = new Queue<(Point point, HashSet<Point> path)>();
            queue.Enqueue((start, new HashSet<Point>()));

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (curr.path.Contains(curr.point) || !set.Contains(curr.point))
                    continue;

                curr.path.Add(curr.point);
                if (curr.point == end)
                {
                    if (curr.path.Count == set.Count)
                        res++;
                    continue;
                }
                foreach(var m in moves)
                    queue.Enqueue((curr.point + m, new HashSet<Point>(curr.path)));
            }
            return res;

            void ScanGrid()
            {
                for (int i = 0; i < grid.Length; i++)
                    for (int j = 0; j < grid[0].Length; j++)
                        switch (grid[i][j])
                        {
                            case 0:
                                set.Add(new(i, j));
                                break;
                            case 1:
                                start = new(i, j);
                                set.Add(new(i, j));
                                break;
                            case 2:
                                end = new(i, j);
                                set.Add(new(i, j));
                                break;
                            default:
                                break;
                        }
            }
        }
    }
}