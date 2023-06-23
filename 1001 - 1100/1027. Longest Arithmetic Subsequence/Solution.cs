using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestArithmeticSubsequence
{
    public class Solution
    {
        public int LongestArithSeqLength(int[] nums)
        {
            var dict = new Dictionary<int, int>[nums.Length];

            var res = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                dict[i] = new();
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var diff = nums[j] - nums[i];
                    var val = dict[j].ContainsKey(diff) ? 1 + dict[j][diff] : 1;
                    if (dict[i].ContainsKey(diff))
                        dict[i][diff] = Math.Max(dict[i][diff], val);
                    else
                        dict[i].Add(diff, val);
                    res = Math.Max(res, dict[i][diff]);
                }
            }
            return res + 1;
        }
    }
}