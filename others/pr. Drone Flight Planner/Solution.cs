using System;
using System.Collections;
using System.Collections.Generic;

namespace DroneFlightPlanner
{
    public class Solution
    {
        public static int CalcDroneMinEnergy(int[,] route)
        {
            int matrixWidth = route.GetLength(1);
            int matrixHeight = route.GetLength(0);
            if (matrixHeight == 0)
                return 0;

            int minFuel = 0;
            int sum = 0;
            var row = 1;
            while (row < matrixHeight)
            {
                var previousHeight = route[row - 1, matrixWidth - 1];
                var currentHeight = route[row, matrixWidth - 1];
                sum += previousHeight - currentHeight;
                minFuel = Math.Min(minFuel, sum);
                row++;
            }
            return Math.Abs(minFuel);
        }
    }
}