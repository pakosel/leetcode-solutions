using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestPalindromeByConcatenatingTwoLetterWords
{
    public class Solution2022
    {
        public int LongestPalindrome(string[] words)
        {
            var sb = new StringBuilder();
            var dict = new Dictionary<string, int>();
            var rev = new Dictionary<string, string>();
            foreach (var w in words)
                if (w[0] != w[1] && !rev.ContainsKey(w))
                    rev.Add(w, Rev(w));

            foreach (var w in words)
                if (dict.ContainsKey(w))
                    dict[w]++;
                else
                    dict.Add(w, 1);
            var res = 0;
            
            var hadSingle = false;
            foreach (var w in words)
                if (w[0] == w[1])
                {
                    var cnt = 2 * (dict[w] / 2);
                    res += 2 * cnt;
                    dict[w] -= cnt;
                    if (dict[w] > 0)
                        hadSingle = true;
                }
                else if (dict.ContainsKey(w) && dict.ContainsKey(rev[w]) && dict[w] > 0 && dict[rev[w]] > 0)
                {
                    var min = Math.Min(dict[w], dict[rev[w]]);
                    res += 4 * min;
                    dict[w] -= min;
                    dict[rev[w]] -= min;
                }

            if (hadSingle)
                res += 2;

            return res;

            string Rev(string s)
            {
                sb.Clear();
                sb.Append(s[1]);
                sb.Append(s[0]);
                return sb.ToString();
            }
        }
    }

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