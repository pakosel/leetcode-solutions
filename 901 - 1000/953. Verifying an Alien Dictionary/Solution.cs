using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace VerifyingAlienDictionary
{
    public class Solution
    {
        int[] dict = new int[26];

        public bool IsAlienSorted(string[] words, string order)
        {
            for (int i = 0; i < order.Length; i++)
                dict[order[i] - 'a'] = i;

            for (int i = 1; i < words.Length; i++)
                if (!CheckOrder(words[i - 1], words[i]))
                    return false;

            return true;
        }

        private bool CheckOrder(string first, string second)
        {
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                int one = dict[first[i] - 'a'];
                int two = dict[second[i] - 'a'];
                if (one < two)
                    return true;
                else if (one == two)
                    continue;
                else
                    return false;
            }

            return first.Length <= second.Length;
        }
    }
}