using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RestoreIpAddresses
{
    public class Solution_2022
    {
        public IList<string> RestoreIpAddresses(string s, int pos = 0, int blocks = 4)
        {
            var res = new List<string>();

            if (blocks > s.Length - pos || s.Length - pos > 3 * blocks)
                return res;

            if (blocks == 1)    //last block
            {
                var val = Parse(pos, s.Length - 1);
                if (val != string.Empty)
                    res.Add(val);
                return res;
            }

            for (int i = pos; i < pos + 3 && i < s.Length; i++)
            {
                var val = Parse(pos, i);
                if (val != string.Empty)
                    foreach (var el in RestoreIpAddresses(s, i + 1, blocks - 1))
                        res.Add($"{val}.{el}");
            }

            return res;

            string Parse(int start, int end)
            {
                int len = end - start + 1;
                if (s[start] == '0')
                    return len != 1 ? string.Empty : "0";
                var sub = s.Substring(start, len);
                var val = int.Parse(sub);
                if (val <= 255)
                    return sub;
                    
                return string.Empty;
            }
        }
    }

    public class Solution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var res = new List<string>();
            if (s.Length < 4 || s.Length > 12)
                return res;

            RestoreIpHelper("", 0, s, res);

            return res;
        }

        private void RestoreIpHelper(string candidate, int segment, string s, IList<string> res)
        {
            if (segment == 3)
            {
                if (IsValidIpPart(s))
                    res.Add($"{candidate}.{s}");
                return;
            }

            for (int i = 1; i <= 3; i++)
            {
                if (s.Length < i)
                    return;

                var subs = s.Substring(0, i);
                if (IsValidIpPart(subs))
                {
                    var prefix = candidate.Length > 0 ? $"{candidate}." : "";
                    RestoreIpHelper($"{prefix}{subs}", segment + 1, s.Substring(i), res);
                }
            }
        }

        private bool IsValidIpPart(string s)
        {
            var len = s.Length;
            if (len == 0 || len > 3)
                return false;

            if (s[0] == '0')
                if (len > 1)
                    return false; //leading zeros are invalid
                else
                    return true;

            if (int.TryParse(s, out var res))
                return res <= 255;

            return false;
        }
    }
}