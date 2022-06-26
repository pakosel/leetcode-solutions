using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumPointsYouCanObtainFromCards
{
    public class Solution
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            var sum = cardPoints.Take(k).Sum();
            var res = sum;
            int j = cardPoints.Length - 1;
            for (int i = k - 1; i >= 0; i--, j--)
            {
                sum -= cardPoints[i];
                sum += cardPoints[j];
                res = Math.Max(res, sum);
            }
            return res;
        }
    }
}