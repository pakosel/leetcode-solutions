using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WildcardMatching
{
    public class Solution
    {
        Dictionary<Tuple<string, string>, bool> dictChecked = new Dictionary<Tuple<string, string>, bool>();

        public bool IsMatch(string s, string p)
        {
            while (p.Contains("**"))
                p = p.Replace("**", "*");

            var key = new Tuple<string, string>(s, p);
            if (dictChecked.ContainsKey(key))
                return dictChecked[key];

            if (s == "")
                return IsEmptyMatch(p);
            if (p == "")
                return s == "";

            var c = p[0];
            var p1 = p.Substring(1);

            if (c == '*')
            {
                if (p.Length == 1)
                {
                    dictChecked.Add(key, true);
                    return true;
                }

                var s_idx = 0;
                while (s_idx < s.Length)
                {
                    if (IsMatch(s.Substring(s_idx), p1))
                    {
                        dictChecked.Add(key, true);
                        return true;
                    }
                    s_idx++;
                }
            }
            else if (c == '?')
                return IsMatch(s.Substring(1), p1);
            else
            {
                if (s[0] != c)
                {
                    dictChecked.Add(key, false);
                    return false;
                }
                return IsMatch(s.Substring(1), p1);
            }
            dictChecked.Add(key, false);
            return false;
        }

        private bool IsEmptyMatch(string pattern)
        {
            foreach (var c in pattern)
                if (c != '*')
                    return false;
            return true;
        }
    }
}