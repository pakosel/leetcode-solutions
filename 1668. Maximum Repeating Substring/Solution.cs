using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumRepeatingSubstring
{
    public class Solution
    {
        public int MaxRepeating(string sequence, string word)
        {
            int len = word.Length;
            int k = 0;
            int maxK = 0;
            int i = 0;
            int j = 0;
            while (j < sequence.Length)
            {
                var c = sequence[j];
                if (c == word[i])
                {
                    i++;
                    j++;
                    if (i == len)
                    {
                        i = 0;
                        k++;
                        maxK = Math.Max(k, maxK);
                    }
                }
                else if (i > 0 || k > 0)
                {
                    j = j - i + 1;
                    i = 0;
                    k = 0;
                }
                else
                    j++;
            }
            return maxK;
        }
    }
}