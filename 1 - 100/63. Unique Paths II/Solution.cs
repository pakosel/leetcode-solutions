using System.Collections.Generic;
using System.Linq;
using System;

namespace UniquePathsII
{
    public class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if(obstacleGrid[0][0] == 1)
                return 0;
            var m = obstacleGrid.Length;
            var n = obstacleGrid[0].Length;
            var queue = new Queue<(int x, int y)>();
            var res = Enumerable.Range(0, m).Select(_ => new int[n]).ToArray();
            
            queue.Enqueue((0, 0));
            res[0][0] = 1;
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                
                if (curr.x == m - 1 && curr.y == n - 1)
                    continue;

                if (curr.x < m - 1 && obstacleGrid[curr.x + 1][curr.y] != 1)
                {
                    res[curr.x + 1][curr.y] += res[curr.x][curr.y];
                    if(!queue.Contains((curr.x + 1, curr.y)))
                        queue.Enqueue((curr.x + 1, curr.y));
                }
                if (curr.y < n - 1 && obstacleGrid[curr.x][curr.y + 1] != 1)
                {
                    res[curr.x][curr.y + 1] += res[curr.x][curr.y];
                    if(!queue.Contains((curr.x, curr.y + 1)))
                        queue.Enqueue((curr.x, curr.y + 1));
                }
            }
            return res[m-1][n-1];
        }
    }
    public class Solution_Backtrack
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            obstacleGrid[m - 1][n - 1] += 1;
            obstacleGrid[m - 1][n - 1] %= 2;

            for (int i = m - 2; i >= 0; i--)
                if (obstacleGrid[i][n - 1] == 1)
                    obstacleGrid[i][n - 1] = 0;
                else
                    obstacleGrid[i][n - 1] = obstacleGrid[i + 1][n - 1];

            for (int j = n - 2; j >= 0; j--)
                if (obstacleGrid[m - 1][j] == 1)
                    obstacleGrid[m - 1][j] = 0;
                else
                    obstacleGrid[m - 1][j] = obstacleGrid[m - 1][j + 1];

            for (int i = m - 2; i >= 0; i--)
                for (int j = n - 2; j >= 0; j--)
                    if (obstacleGrid[i][j] == 1)
                        obstacleGrid[i][j] = 0;
                    else
                        obstacleGrid[i][j] += obstacleGrid[i + 1][j] + obstacleGrid[i][j + 1];

            return obstacleGrid[0][0];
        }
    }
}