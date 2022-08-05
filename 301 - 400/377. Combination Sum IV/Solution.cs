using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace CombinationSumIV
{
    public class Solution
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var memo = new int[target + 1];
            Array.Fill(memo, -1);
            Array.Sort(nums);
            return Count(target);

            int Count(int tgt)
            {
                if (memo[tgt] != -1)
                    return memo[tgt];

                var res = 0;
                foreach (var n in nums)
                    if (n >= tgt)
                    {
                        res += (n == tgt ? 1 : 0);
                        break;
                    }
                    else
                        res += Count(tgt - n);
                memo[tgt] = res;
                return res;
            }
        }
    }
}