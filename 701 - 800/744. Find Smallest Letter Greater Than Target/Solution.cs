using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindSmallestLetterGreaterThanTarget
{
    public class Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            var idx = Array.BinarySearch(letters, target);
            if (idx < 0)
                idx = ~idx;
            while (idx < letters.Length && letters[idx] <= target)
                idx++;
            return idx < letters.Length ? letters[idx] : letters[0];
        }
    }
}