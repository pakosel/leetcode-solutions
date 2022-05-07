using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountPrefixesOfGivenString
{
    public class Solution
    {
        public int CountPrefixes(string[] words, string s)
            => words.Count(w => s.StartsWith(w));

    }
}