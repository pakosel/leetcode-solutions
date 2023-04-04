using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace OptimalPartitionOfString
{
    public class Solution
    {
        public int PartitionString(string s)
        {
            var arr = new int[26];
            var res = 0;
            foreach (var c in s)
            {
                if (arr[c - 'a'] > 0)
                {
                    res++;
                    Array.Fill(arr, 0);
                }
                arr[c - 'a']++;
            }
            return res + 1;
        }
    }
}