using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RestoreIpAddresses
{
    public class Solution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var res = new List<string>();
            if(s.Length < 4 || s.Length > 12)
                return res;

            RestoreIpHelper("", 0, s, res);
            
            return res;
        }

        private void RestoreIpHelper(string candidate, int segment, string s, IList<string> res)
        {
            if(segment == 3)
            {
                if(IsValidIpPart(s))
                    res.Add($"{candidate}.{s}");
                return;
            }

            for(int i=1; i<=3; i++)
            {
                if(s.Length < i)
                    return;

                var subs = s.Substring(0, i);
                if(IsValidIpPart(subs))
                {
                    var prefix = candidate.Length > 0 ? $"{candidate}." : "";
                    RestoreIpHelper($"{prefix}{subs}", segment+1, s.Substring(i), res);
                }
            }
        }

        private bool IsValidIpPart(string s)
        {
            var len = s.Length;
            if(len == 0 || len > 3)
                return false;

            if(s[0] == '0')
                if(len > 1)
                    return false; //leading zeros are invalid
                else
                    return true;

            if(int.TryParse(s, out var res))
                return res <= 255;

            return false;
        }
    }
}