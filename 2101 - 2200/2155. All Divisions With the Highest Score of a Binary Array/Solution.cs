using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AllDivisionsWithTheHighestScoreOfBinaryArray
{
    public class Solution
    {
        public IList<int> MaxScoreIndices(int[] nums)
        {
            var ones = nums.Count(e => e == 1);
            var zeros = 0;
            var res = new List<int>();
            var max = -1;

            for (int i = 0; i <= nums.Length; i++)
            {
                var score = zeros + ones;
                if (score >= max)
                {
                    if (score > max)
                    {
                        max = score;
                        res.Clear();
                    }
                    res.Add(i);
                }

                if (i < nums.Length && nums[i] == 1)
                    ones--;
                else
                    zeros++;
            }

            return res;
        }
    }
}