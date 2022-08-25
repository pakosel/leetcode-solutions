using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var arrNote = new int[26];
            var arrMag = new int[26];
            foreach (var c in magazine)
                arrMag[c - 'a']++;
            foreach (var c in ransomNote)
                arrNote[c - 'a']++;

            for (int i = 0; i < 26; i++)
                if (arrNote[i] > arrMag[i])
                    return false;
            return true;
        }
    }
}