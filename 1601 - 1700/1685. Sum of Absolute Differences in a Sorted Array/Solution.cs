using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SumAbsoluteDifferencesInSortedArray
{
    public class Solution
    {
        public int[] GetSumAbsoluteDifferences(int[] nums)
        {
            int[] res = new int[nums.Length];
            int sum = SumForLast(nums);
            res[nums.Length - 1] = sum;

            int done = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                int diff = nums[i + 1] - nums[i];
                sum += done * diff;
                sum -= (i + 1) * diff;
                done++;
                res[i] = sum;
            }
            return res;
        }

        private int SumForLast(int[] nums)
        {
            int idx = nums.Length - 1;
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
                res += Math.Abs(nums[idx] - nums[i]);

            return res;
        }
    }
}