using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckIfTheSentenceIsPangram
{
    public class Solution
    {
        public bool CheckIfPangram(string sentence)
        {
            var set = new HashSet<char>();
            int i = 0;
            while (i < sentence.Length && set.Count < 26)
                set.Add(sentence[i++]);
            return set.Count == 26;
        }
    }
}