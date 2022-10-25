using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckIfTwoStringArraysAreEquivalent
{
    public class Solution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
                        => string.Join("", word1) == string.Join("", word2);
    }

    public class SolutionSB
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            foreach (var w in word1)
                sb1.Append(w);
            foreach (var w in word2)
                sb2.Append(w);

            return sb1.ToString() == sb2.ToString();
        }
    }
}