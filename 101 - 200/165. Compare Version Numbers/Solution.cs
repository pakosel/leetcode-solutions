using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace CompareVersionNumbers
{
    public class Solution
    {
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');
            var len = Math.Max(v1.Length, v2.Length);
            for (int i = 0; i < len; i++)
            {
                var r1 = i < v1.Length ? int.Parse(v1[i]) : 0;
                var r2 = i < v2.Length ? int.Parse(v2[i]) : 0;
                var cmp = r1.CompareTo(r2);
                if (cmp != 0)
                    return cmp;
            }
            return 0;
        }
    }
}