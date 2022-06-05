using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinMaxGame
{
    public class Solution
    {
        public int MinMaxGame(int[] nums)
        {
            var work = nums.ToList();
            while (work.Count > 1)
                work = Enumerable.Range(0, work.Count / 2)
                            .Select(i => (i % 2 == 0 ? 
                                            Math.Min(work[2 * i], work[2 * i + 1]) : 
                                            Math.Max(work[2 * i], work[2 * i + 1]))).ToList();
            return work.First();
        }
    }
}