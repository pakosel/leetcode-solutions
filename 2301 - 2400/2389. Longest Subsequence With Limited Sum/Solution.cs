using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestSubsequenceWithLimitedSum
{
    public class Solution
    {
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            Array.Sort(nums);
            for (int i = 0; i < queries.Length; i++)
            {
                var idx = 0;
                var sum = 0;
                while (idx < nums.Length && sum <= queries[i])
                    sum += nums[idx++];
                queries[i] = sum > queries[i] ? idx - 1 : idx;
            }
            return queries;
        }
    }
}