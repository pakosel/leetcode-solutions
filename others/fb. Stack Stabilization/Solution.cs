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
            var arr = Enumerable.Range(0, N).Select(_ => new long[size]).ToArray();
            arr[0][0] = int.MaxValue;

            for(int i=0; i<N; i++)
                for(int j=i+1; j<size; j++)
                {
                    var val = min+j;
                    var prev = (i > 0 ? arr[i-1][j-1] : 0);
                    arr[i][j] = prev + (val < R[i] ? (R[i] - val)*B : (val - R[i])*A);
                    if(j > i+1)
                        arr[i][j] = Math.Min(arr[i][j-1], arr[i][j]);
                }
            // foreach(var row in arr)
            //     Console.WriteLine(string.Join('\t', row));
            return arr[N-1][size-1];
        }
    }
}