using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace UniqueLength3PalindromicSubsequences
{
    public class Solution
    {
        public int CountPalindromicSubsequence(string s)
        {
            var ranges = new List<int>[27];
            for (int i = 0; i < s.Length; i++)
                if (ranges[s[i] - 'a'] == null)
                    ranges[s[i] - 'a'] = new List<int>() { i };
                else if (ranges[s[i] - 'a'].Count < 2)
                    ranges[s[i] - 'a'].Add(i);
                else
                    ranges[s[i] - 'a'][1] = i;

            var res = 0;
            foreach (var r in ranges)
                if (r != null && r.Count > 1)
                    res += AddRange(r[0], r[1]);
            return res;

            int AddRange(int start, int end)
            {
                var set = new HashSet<char>();
                for (int i = start + 1; i < end; i++)
                    set.Add(s[i]);
                return set.Count;
            }
        }
    }
}