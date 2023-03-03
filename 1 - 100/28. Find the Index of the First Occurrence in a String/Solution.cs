using System.Collections.Generic;
using System.Linq;
using System;

namespace FindTheIndexOfTheFirstOccurrenceInString
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
                if(Check(i))
                    return i;
            return -1;

            bool Check(int pos)
            {
                int j = 0;
                for(int i=pos; i<haystack.Length && j < needle.Length; i++, j++)
                    if(haystack[i] != needle[j])
                        return false;
                return j == needle.Length;
            }
        }
    }
}