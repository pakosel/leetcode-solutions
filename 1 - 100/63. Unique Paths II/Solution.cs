using System.Collections.Generic;
using System.Linq;
using System;

namespace UniquePathsII
{
    public class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid) 
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            obstacleGrid[m-1][n-1] += 1;
            obstacleGrid[m-1][n-1] %= 2;

            for(int i=m-2; i>=0; i--)
                if(obstacleGrid[i][n-1] == 1)
                    obstacleGrid[i][n-1] = 0;
                else
                    obstacleGrid[i][n-1] = obstacleGrid[i+1][n-1];

            for(int j=n-2; j>=0; j--)
                if(obstacleGrid[m-1][j] == 1)
                    obstacleGrid[m-1][j] = 0;
                else
                    obstacleGrid[m-1][j] = obstacleGrid[m-1][j+1];
            
            for(int i=m-2; i>=0; i--)
                for(int j=n-2; j>=0; j--)
                    if(obstacleGrid[i][j] == 1)
                        obstacleGrid[i][j] = 0;
                    else
                        obstacleGrid[i][j] += obstacleGrid[i+1][j] + obstacleGrid[i][j+1];

            return obstacleGrid[0][0];
        }
    }
}