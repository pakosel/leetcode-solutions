using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortEncodingOfWords
{
    public class Solution
    {
        public int MinimumLengthEncoding(string[] words)
        {
            var hSet = new HashSet<string>();
            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));

            foreach (var w in words)
                if (!hSet.Any(e => w == e.Substring(e.Length - w.Length, w.Length)))
                    hSet.Add(w);

            return hSet.Sum(e => e.Length) + hSet.Count();
        }
    }
}