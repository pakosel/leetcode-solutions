using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RedistributeCharactersToMakeAllStringsEqual
{
    public class Solution
    {
        public bool MakeEqual(string[] words)
        {
            var len = words.Length;
            if (len == 1)
                return true;
            var arr = new int[26];
            foreach (var w in words)
                foreach (var c in w)
                    arr[c - 'a']++;
            foreach (var c in arr)
                if (c > 0 && c % len != 0)
                    return false;
            return true;
        }
    }
}