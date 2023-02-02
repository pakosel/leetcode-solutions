using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace VerifyingAlienDictionary
{
    public class Solution_2022
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var dict = new Dictionary<char, int>(26);
            for (int i = 0; i < order.Length; i++)
                dict.Add(order[i], i);

            for (int i = 0; i < words.Length - 1; i++)
                if (!Ordered(words[i], words[i + 1]))
                    return false;

            return true;

            bool Ordered(string w1, string w2)
            {
                int i1 = -1, i2 = -1;
                while (++i1 < w1.Length && ++i2 < w2.Length)
                    if (dict[w1[i1]] < dict[w2[i2]])
                        return true;
                    else if (dict[w1[i1]] > dict[w2[i2]])
                        return false;
                return w1.Length <= w2.Length;
            }
        }
    }
    
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