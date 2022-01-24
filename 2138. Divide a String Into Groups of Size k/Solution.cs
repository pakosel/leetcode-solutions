using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DivideStringIntoGroupsOfSizek
{
    public class Solution
    {
        public string[] DivideString(string s, int k, char fill)
        {
            var res = new List<string>();
            int i = 0;
            var curr = "";
            while (i < s.Length)
            {
                for (int j = 0; j < k && i < s.Length; j++)
                    curr += s[i++];
                res.Add(curr);
                curr = "";
            }
            var len = res.Count;
            while (res[len - 1].Length < k)
                res[len - 1] += fill;
            return res.ToArray();
        }
    }
}