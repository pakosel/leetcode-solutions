using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountNumberOfNiceSubarrays
{
    public class Solution
    {
        public int NumberOfSubarrays(int[] nums, int k)
        {
            var len = nums.Length;
            var memo = new int[len + 1];
            Array.Fill(memo, -1);

            int left = NextOdd(0), right = left, odds = 1, res = 0;
            int evenOnTheLeft = left;
            while (right < len)
            {
                while (odds < k && right < len)
                {
                    right = NextOdd(right + 1);
                    if (right < len)
                        odds++;
                }
                if (odds == k)
                {
                    var evenOnTheRight = NextOdd(right + 1) - right - 1;
                    res += (evenOnTheLeft + 1) * (evenOnTheRight + 1);
                    evenOnTheLeft = NextOdd(left + 1) - left - 1;
                    left = NextOdd(left + 1);
                    right = NextOdd(right + 1);
                }
            }
            return res;

            int NextOdd(int pos)
            {
                if (memo[pos] != -1)
                    return memo[pos];

                var res = len;
                for (int i = pos; i < len && res == len; i++)
                    if (nums[i] % 2 == 1)
                        res = i;
                memo[pos] = res;

                return res;
            }
        }
    }
}