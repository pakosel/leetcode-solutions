using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfLaserBeamsInBank
{
    public class Solution
    {
        public int NumberOfBeams(string[] bank)
        {
            var res = 0;
            var counts = bank.Where(r => r.Contains('1')).Select(x => x.Count(c => c == '1')).ToList();
            for (int i = 1; i < counts.Count; i++)
                res += counts[i - 1] * counts[i];
            return res;
        }
    }
}