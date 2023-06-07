using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CheckIfItIsStraightLine
{
    public class Solution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            var a = CalcA(0, 1);

            for (int i = 2; i < coordinates.Length; i++)
                if (a != CalcA(0, i))
                    return false;
            return true;

            double CalcA(int i1, int i2)
                => coordinates[i2][0] == coordinates[i1][0] ? int.MaxValue :
                (double)(coordinates[i2][1] - coordinates[i1][1]) / (double)(coordinates[i2][0] - coordinates[i1][0]);
        }
    }
}