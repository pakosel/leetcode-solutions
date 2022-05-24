using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace StackStabilization
{
    class Solution
    {
        public long getMinimumSecondsRequired(int N, int[] R, int A, int B)
        {
            var min = Math.Max(0, R.Min() - N);
            var max = R.Max();
            var size = max - min + N;
            var dp = Enumerable.Range(0, N).Select(_ => new long[size]).ToArray();

            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < size; j++)
                {
                    var prev = (i > 0 ? dp[i - 1][j - 1] : 0);  //for 0-th row no pervious MIN value
                    var val = min + j;
                    var curr = (val < R[i] ? (R[i] - val) * B : (val - R[i]) * A);
                    dp[i][j] = prev + curr;
                    if (j > i + 1)  //first value in a row has to be calculated
                        dp[i][j] = Math.Min(dp[i][j - 1], dp[i][j]);
                }
            // foreach(var row in arr)
            //     Console.WriteLine(string.Join('\t', row));
            return dp[N - 1][size - 1];
        }
    }
}