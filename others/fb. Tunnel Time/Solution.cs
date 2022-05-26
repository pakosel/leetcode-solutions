using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TunnelTime
{
    class Solution
    {

        public long getSecondsElapsed(long C, int N, long[] A, long[] B, long K)
        {
            //tunnels are non-overlapping so we can sort both arrays independently
            Array.Sort(A);
            Array.Sort(B);
            long trackTunnelTime = 0;
            for (long i = 0; i < N; i++)
                trackTunnelTime += (B[i] - A[i]);
            long div = K / trackTunnelTime;
            long mod = K % trackTunnelTime;
            long res = C * div;
            if(mod == 0)
                res -= (C - B[B.Length-1]);

            for (long i = 0; i < N && mod > 0; i++)
                if (B[i] - A[i] < mod)
                    mod -= B[i] - A[i];
                else
                {
                    res += (A[i] + mod);
                    mod = 0;
                }
            return res + mod;
        }
    }
}