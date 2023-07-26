using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumSpeedToArriveOnTime
{
    public class Solution
    {
        const int MAX = 10_000_000;
        public int MinSpeedOnTime(int[] dist, double hour)
        {
            int left = 1, right = MAX, res = MAX;
            if (!Check(res))
                return -1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (left >= res)
                    break;
                if (Check(mid))
                {
                    res = mid;
                    right = mid;
                }
                else
                    left = mid + 1;
            }
            return res;

            bool Check(int val)
            {
                var i = 0;
                var t = 0d;
                while (i < dist.Length && t < hour)
                    if (i == dist.Length - 1)
                        t += dist[i++] / (double)val;
                    else
                        t += Math.Ceiling(dist[i++] / (double)val);

                return i == dist.Length && t <= hour;
            }
        }
    }
}