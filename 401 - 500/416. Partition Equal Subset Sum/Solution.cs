using System.Collections.Generic;
using System.Linq;
using System;

namespace PartitionEqualSum
{
    public class Solution
    {
        public bool CanPartition(int[] nums)
        {
            var sum = nums.ToList().Sum();

            if (sum % 2 == 0)
                return SubsetSum(nums, sum / 2);
            else
                return false;
        }

        private bool SubsetSum(int[] nums, int target)
        {
            var len = nums.Length;
            Array.Sort(nums);

            var arr = new bool[len][];
            for (int i = 0; i < len; i++)
            {
                arr[i] = new bool[target + 1];
                arr[i][0] = true;
            }

            if(nums[0] <= target)
                arr[0][nums[0]] = true;

            for (int i = 1; i < len; i++)
            {
                var val = nums[i];
                for (int j = 1; j <= target; j++)
                    arr[i][j] = j < val ? arr[i - 1][j] : arr[i - 1][j] || arr[i - 1][j - val];
            }

            return arr[len - 1][target];
        }
    }
}