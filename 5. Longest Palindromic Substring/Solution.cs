using System.Collections.Generic;
using System.Linq;
using System;

namespace LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var len = s.Length;
            if (len < 2)
                return s;

            string longest = "";

            for (int i = 0; i < len - 1; i++)   //len - 1 to avoid OutOfRange exception in ln. 20
            {
                var long1 = findLongest(s, i, i); //detect case "abcba"
                var long2 = findLongest(s, i, i + 1); //detect case "acbbca"

                if (long1.Length > longest.Length)
                    longest = long1;
                if (long2.Length > longest.Length)
                    longest = long2;

                if (longest.Length == s.Length)
                    break;  //found best solution
            }

            return longest;
        }

        private string findLongest(string s, int startIdx, int endIdx)
        {
            var len = s.Length;

            while (startIdx >= 0 && endIdx < len)
            {
                if (s[startIdx] == s[endIdx])
                {
                    startIdx--;
                    endIdx++;
                }
                else
                    break;
            }
            //restore previous values with potential longest value
            startIdx++;
            endIdx--;

            if (startIdx > endIdx)  //in case we never entered 'if' statement above
                return "";

            return s.Substring(startIdx, endIdx - startIdx + 1);
        }
    }
}