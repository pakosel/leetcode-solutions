using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DetectCapital
{
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (word[0] >= 'A' && word[0] <= 'Z')
                return word.Skip(1).All(c => c >= 'a' && c <= 'z') || word.All(c => c >= 'A' && c <= 'Z');
            else
                return word.All(c => c >= 'a' && c <= 'z');
        }
    }
}