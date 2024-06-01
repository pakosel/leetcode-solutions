using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ScoreOfString
{
    public class Solution
    {
        public int ScoreOfString(string s)
        {
            var res = 0;
            for (int i = 1; i < s.Length; i++)
                res += Math.Abs(s[i] - s[i - 1]);
            return res;
        }
    }
}