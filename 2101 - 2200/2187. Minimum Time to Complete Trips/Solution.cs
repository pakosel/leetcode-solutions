using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumTimeToCompleteTrips
{
    public class Solution
    {
        public long MinimumTime(int[] time, int totalTrips)
        {
            long end = (long)time.Max() * (long)totalTrips;
            var res = Bin(1, end);
            while (Check(res - 1) >= totalTrips)
                res--;

            return res;

            long Bin(long start, long end)
            {
                if (end - start <= 1)
                    return end;

                long mid = start + (end - start) / 2;
                var check = Check(mid);
                if (check < totalTrips)
                    return Bin(mid, end);
                else if (check > totalTrips)
                    return Bin(start, mid);
                else //==
                    return mid;
            }

            long Check(long trips)
            {
                long sum = 0;
                foreach (var t in time)
                    sum += trips / t;
                return sum;
            }
        }
    }
}