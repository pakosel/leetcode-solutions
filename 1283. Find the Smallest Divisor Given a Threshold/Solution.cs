using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindSmallestDivisorGivenThreshold
{
    public class Solution
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int max = nums.Max();
            int start = 1;
            int end = max;
            while (start + 1 < end)
            {
                int next = start + (end - start) / 2;
                int temp = GetSum(nums, next);
                if (temp <= threshold)
                    end = next;
                else
                    start = next;
            }

            return GetSum(nums, start) <= threshold ? start : end;
        }

        private int GetSum(int[] nums, int divisor)
        {
            int res = 0;
            foreach (var n in nums)
                res += Ceiling(n, divisor);

            return res;
        }

        private int Ceiling(int num, int div) => num % div == 0 ? num / div : num / div + 1;
    }
}