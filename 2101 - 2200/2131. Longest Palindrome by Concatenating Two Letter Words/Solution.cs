using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestPalindromeByConcatenatingTwoLetterWords
{
    public class Solution
    {
        public int LongestPalindrome(string[] words)
        {
            int[,] count = new int[26, 26];

            foreach (var w in words)
                count[w[0] - 'a', w[1] - 'a']++;

            var res = 0;
            //1st pass - get left and right side of palindrome
            //by finding corresponding mirror strings
            for (int i = 0; i < 26; i++)
                for (int j = 0; j < 26; j++)
                {
                    var min = Math.Min(count[i, j], count[j, i]);

                    if (i == j && min < 2)
                        continue; //will take same letter repeats in the 2nd loop below

                    if (min > 1 && (min % 2 == 1))
                        min--;  //it has to be the same count of elements on both sides

                    if (i == j)
                        res += min;
                    else
                        res += 2 * min;

                    count[i, j] -= min;
                    if (i != j)
                        count[j, i] -= min;
                }

            //2nd pass - get longest repeating letters to fit inside
            var maxSame = 0;
            for (int i = 0; i < 26; i++)
                maxSame = Math.Max(maxSame, count[i, i]);
            res += maxSame;

            //all matching strings has length == 2
            return 2 * res;
        }
    }
}