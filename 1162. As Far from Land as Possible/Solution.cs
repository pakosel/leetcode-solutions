using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AsFarFromLandAsPossible
{
    public class Solution
    {
        int[][] Distances;
        public int MaxDistance(int[][] grid)
        {
            int max = -1;
            int size = grid[0].Length;
            InitDistances(grid);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (Distances[i][j] == 0)
                        BFS((i, j));

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if(Distances[i][j] != int.MaxValue && Distances[i][j] > max)
                        max = Distances[i][j];

            return max == 0 ? -1 : max;
        }

        private void BFS((int, int) point)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            HashSet<(int, int)> visited = new HashSet<(int, int)>();
            queue.Enqueue((point.Item1, point.Item2));

            while (queue.Count > 0)
            {
                var next = queue.Dequeue();
                int x = next.Item1;
                int y = next.Item2;
                if (visited.Contains((x, y)))
                    continue;
                else
                    visited.Add((x, y));
                int calcDist = ManhattanDist(point, (x, y));
                if (calcDist > Distances[x][y])
                    continue;
                Distances[x][y] = calcDist;

                if (x > 0)
                    queue.Enqueue((x - 1, y));
                if (x < Distances.Length - 1)
                    queue.Enqueue((x + 1, y));
                if (y > 0)
                    queue.Enqueue((x, y - 1));
                if (y < Distances.Length - 1)
                    queue.Enqueue((x, y + 1));
            }
        }

        private void InitDistances(int[][] grid)
        {
            int size = grid[0].Length;

            Distances = new int[size][];
            for (int i = 0; i < size; i++)
            {
                Distances[i] = new int[size];
                for (int j = 0; j < size; j++)
                    Distances[i][j] = grid[i][j] == 1 ? 0 : int.MaxValue;
            }
        }

        private int ManhattanDist((int, int) p1, (int, int) p2) => Math.Abs(p1.Item1 - p2.Item1) + Math.Abs(p1.Item2 - p2.Item2);
    }
}