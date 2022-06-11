using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumOperationsToReduceXToZero
{
    public class Solution
    {
        public int MinOperations(int[] nums, int x)
        {
            var prefixSum = new Dictionary<int, int>();
            prefixSum.Add(0, 0);
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum <= x)
                    prefixSum.Add(sum, i + 1);
                else
                    break;
            }

            var res = prefixSum.ContainsKey(x) ? prefixSum[x] : int.MaxValue;
            sum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                sum += nums[i];
                if (sum <= x)
                {
                    var lookup = x - sum;
                    if(prefixSum.ContainsKey(lookup))
                    {
                        var operations = prefixSum[lookup] + nums.Length - i;
                        if(operations <= nums.Length)
                            res = Math.Min(res, operations);
                    }
                }
                else
                    break;
            }

            return res != int.MaxValue ? res : -1;
        }
    }
}