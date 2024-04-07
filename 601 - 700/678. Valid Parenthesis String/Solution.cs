using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidParenthesisString
{
    public class Solution
    {
        public bool CheckValidString(string s)
        {
            var memo = new Dictionary<(int pos, int bal), bool>();

            return Check(0, 0);

            bool Check(int pos, int bal)
            {
                if (pos == s.Length)
                    return bal == 0;
                if (bal < 0)
                    return false;

                var key = (pos, bal);
                if (memo.ContainsKey(key))
                    return memo[key];
                var res = false;
                if (s[pos] == '(')
                    res = Check(pos + 1, bal + 1);
                else if (s[pos] == ')')
                    res = Check(pos + 1, bal - 1);
                else
                    res = Check(pos + 1, bal + 1) || Check(pos + 1, bal - 1) || Check(pos + 1, bal);
                memo[key] = res;

                return res;
            }
        }
    }
}