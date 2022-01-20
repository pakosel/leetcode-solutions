using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace KokoEatingBananas
{
    public class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            var len = piles.Length;
            Array.Sort(piles);
            var res = piles[len - 1];
            if (h == len)
                return res;
            var right = res;
            var left = 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (CanEat(piles, h, mid))
                {
                    res = mid;
                    right = mid;
                }
                else
                    left = mid + 1;
            }
            return res;
        }

        private bool CanEat(int[] piles, int h, int k)
        {
            int i = piles.Length - 1;
            while (i >= 0 && h > 0)
            {
                var div = piles[i] / k;
                var mod = piles[i] % k;
                h -= div;
                if (mod > 0)
                    h--;
                i--;

                if (i >= h)
                    return false;
            }
            return h >= 0;
        }
    }
}