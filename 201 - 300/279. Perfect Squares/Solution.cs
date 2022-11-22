using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace PerfectSquares
{
    public class Solution
    {
        public int NumSquares(int n)
        {
            var squares = GetPerfectSquares(n);
            var arr = new int[n + 1];
            for (int i = 1; i <= n; i++)
                arr[i] = i;
            foreach (var sq in squares.Skip(1))
                for (int i = sq; i <= n; i++)
                    arr[i] = Math.Min(arr[i], arr[i - sq] + 1);

            return arr[n];

            List<int> GetPerfectSquares(int n)
            {
                var res = new List<int>(n);

                for (int i = 1; i < n; i++)
                {
                    var sq = i * i;
                    if (sq <= n)
                        res.Add(sq);
                    else
                        break;
                }
                return res;
            }
        }
    }
}