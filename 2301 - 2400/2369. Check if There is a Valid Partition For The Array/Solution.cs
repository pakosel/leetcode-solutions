using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckIfThereIsValidPartitionForTheArray
{
    public class Solution
    {
        public bool ValidPartition(int[] nums)
        {
            var len = nums.Length;
            var memo = new bool?[len];

            return Check(0);

            bool Check(int pos)
            {
                if (pos >= len)
                    return true;
                if (memo[pos].HasValue)
                    return memo[pos].Value;
                var res = false;

                if (pos + 2 < len)
                    if ((nums[pos] == nums[pos + 1] && nums[pos] == nums[pos + 2]) ||
                       (nums[pos + 1] - nums[pos] == 1 && nums[pos + 2] - nums[pos + 1] == 1))
                        res = Check(pos + 3);
                if (!res && pos + 1 < len && nums[pos] == nums[pos + 1])
                    res = Check(pos + 2);

                memo[pos] = res;
                return res;
            }
        }
    }
}