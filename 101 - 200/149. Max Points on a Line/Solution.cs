using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaxPointsOnLine
{
    public class Solution
    {
        public int MaxPoints(int[][] points)
        {
            var n = points.Length;
            if (n < 3)
                return n;

            var res = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    var fun = GetFun(points[i], points[j]);
                    var max = 2;
                    for (int k = j + 1; k < n; k++)
                        if (fun.a == 0 && fun.b == 0)
                            max += points[k][0] == points[i][0] ? 1 : 0;
                        else
                            max += Check(fun, points[k]) ? 1 : 0;
                    res = Math.Max(res, max);
                }

            return res;

            //function eq. by 2 points: y = ax + b
            (double a, double b) GetFun(int[] p1, int[] p2)
            {
                if (p1[0] == p2[0])
                    return (0, 0);
                if (p1[1] == p2[1])
                    return (0, p1[1]);
                var a = (double)(p2[1] - p1[1]) / (double)(p2[0] - p1[0]);
                var b = (double)p1[1] - a * p1[0];

                return (a, b);
            }

            //check if a point fulfils the function def. by a and b
            bool Check((double a, double b) fun, int[] p) =>
                (double)p[1] == Math.Round(fun.a * p[0] + fun.b, 9);
        }
    }
}