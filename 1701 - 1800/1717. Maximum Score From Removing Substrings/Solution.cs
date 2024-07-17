using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumScoreFromRemovingSubstrings
{
    public class Solution
    {
        public int MaximumGain(string s, int x, int y)
        {
            var res = 0;
            while (true)
            {
                var len = s.Length;

                if (x > y)
                    s = s.Replace("ab", "");
                else
                    s = s.Replace("ba", "");

                if (len > s.Length)
                {
                    res += ((len - s.Length) / 2) * (x > y ? x : y);
                    continue;
                }
                if (x > y)
                    s = s.Replace("ba", "");
                else
                    s = s.Replace("ab", "");
                if (len > s.Length)
                {
                    res += ((len - s.Length) / 2) * (x > y ? y : x);
                    continue;
                }
                break;
            }

            return res;
        }
    }
}