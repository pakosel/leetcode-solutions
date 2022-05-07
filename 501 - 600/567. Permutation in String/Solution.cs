using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PermutationInString
{
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int len = s1.Length;
            var letters = new int[26];
            foreach (var c in s1)
                letters[c - 'a']++;

            int i = 0;
            int found = 0;
            while (i < s2.Length)
            {
                if (len == found)
                    return true;
                var letter = s2[i];
                var pos = letter - 'a';
                if (letters[pos] > 0)
                {
                    letters[pos]--;
                    found++;
                }
                else
                {
                    //try to find this letter from the first hit position until current pos
                    while (found > 0)
                    {
                        var prevLetter = s2[i - found];
                        if (prevLetter == letter)
                            break;
                        else
                        {
                            letters[prevLetter - 'a']++;
                            found--;
                        }
                    }
                }
                i++;
            }
            return len == found;
        }
    }
}