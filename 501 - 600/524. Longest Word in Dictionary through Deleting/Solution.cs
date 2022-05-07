using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestWordInDictionaryThroughDeleting
{
    public class Solution
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            var arr = d.ToArray();
            Array.Sort(arr, (e1, e2) => e1.Length != e2.Length ? e2.Length.CompareTo(e1.Length) : e1.CompareTo(e2));

            foreach (var w in arr)
                if (CanTransform(s, w))
                    return w;

            return "";
        }

        private bool CanTransform(string w1, string w2)
        {
            int p1 = 0;
            int p2 = 0;
            int len1 = w1.Length;
            int len2 = w2.Length;

            while (p1 < len1 && p2 < len2)
                if (w1[p1++] == w2[p2])
                    p2++;

            return p2 == len2;
        }
    }
}