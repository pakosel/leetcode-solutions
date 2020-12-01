using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindTheMostCompetitiveSubsequence
{
    public class Solution
    {
        public int[] MostCompetitive(int[] nums, int k)
        {
            int len = nums.Length;
            int[] res = new int[k];

            int prev = -1;
            int prevIdx = -1;

            for (int r = 0; r < k; r++)
            {
                prev = int.MaxValue;
                for (int i = prevIdx + 1; i < len - (k - r - 1); i++)
                    if (nums[i] < prev)
                    {
                        prev = nums[i];
                        prevIdx = i;
                        if (prev == 0)
                            break;
                    }

                res[r] = prev;
            }

            return res;
        }
    }
}