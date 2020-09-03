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
                    if (Distances[i][j] == -1)
                    {
                        int maxDist = DFS((i, j));
                        if (maxDist > max)
                            max = maxDist;
                    }
                    
            return max;
        }

        private void InitDistances(int[][] grid)
        {
            int size = grid[0].Length;

            Distances = new int[size][];
            for (int i = 0; i < size; i++)
            {
                Distances[i] = new int[size];
                for (int j = 0; j < size; j++)
                    Distances[i][j] = grid[i][j] == 1 ? 0 : -1;
            }
        }

        private int DFS((int, int) point)
        {
            int min = int.MaxValue;
            
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            HashSet<(int, int)> visited = new HashSet<(int, int)>();
            queue.Enqueue((point.Item1, point.Item2, 0));

            while(queue.Count > 0)
            {
                var next = queue.Dequeue();
                int x = next.Item1;
                int y = next.Item2;
                int dist = next.Item3;
                if(visited.Contains((x, y)))
                    continue;
                else
                    visited.Add((x, y));

                if(Distances[x][y] >= 0)
                    min = Math.Min(min, Distances[x][y] + dist);
                else
                {
                    if(x > 0)
                        queue.Enqueue((x-1, y, dist + 1));
                    if(x < Distances.Length - 1)
                        queue.Enqueue((x+1, y, dist + 1));
                    if(y > 0)
                        queue.Enqueue((x, y-1, dist + 1));
                    if(y < Distances.Length - 1)
                        queue.Enqueue((x, y+1, dist + 1));
                }
            }

            if(min == int.MaxValue)
                min = -1;
            Distances[point.Item1][point.Item2] = min;

            return min;
        }
    }
}