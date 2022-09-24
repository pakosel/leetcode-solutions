using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace IsomorphicStrings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var replacementsS = new Dictionary<char, char>(26);
            var replacementsT = new Dictionary<char, char>(26);
            for (int i = 0; i < s.Length; i++)
            {
                var cs = s[i];
                var ct = t[i];

                if (!replacementsS.ContainsKey(cs))
                    replacementsS.Add(cs, ct);
                else if (replacementsS[cs] != ct)
                    return false;

                if (!replacementsT.ContainsKey(ct))
                    replacementsT.Add(ct, cs);
                else if (replacementsT[ct] != cs)
                    return false;
            }
            return true;
        }
    }
}