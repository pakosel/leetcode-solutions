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
            var dp = new long[size];
            long prevRowDiag = 0;
            for (int i = 0; i < N; i++)
            {
                prevRowDiag = dp[i];
                for (int j = i + 1; j < size; j++)
                {
                    var prev = (i > 0 ? prevRowDiag : 0);  //for 0-th row no pervious MIN value
                    long val = min + j;
                    long curr = (val < R[i] ? (R[i] - val) * B : (val - R[i]) * A);
                    prevRowDiag = dp[j];
                    dp[j] = prev + curr;
                    if (j > i + 1)  //first value in a row has to be calculated
                        dp[j] = Math.Min(dp[j - 1], dp[j]);
                }
            }
            return dp[size - 1];
        }
    }
}