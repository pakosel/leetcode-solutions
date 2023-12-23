using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumScoreAfterSplittingString
{
    public class Solution
    {
        public int MaxScore(string s)
        {
            var len = s.Length;
            var zeros = new int[len];
            var ones = new int[len];
            zeros[0] = s[0] == '0' ? 1 : 0;
            ones[len - 1] = s[len - 1] == '1' ? 1 : 0;

            for (int i = 1; i < len; i++)
                zeros[i] = zeros[i - 1] + (s[i] == '0' ? 1 : 0);
            for (int i = len - 2; i >= 0; i--)
                ones[i] = ones[i + 1] + (s[i] == '1' ? 1 : 0);

            var res = 0;
            for (int i = 0; i < len - 1; i++)
                res = Math.Max(res, zeros[i] + ones[i + 1]);
            return res;
        }
    }
}