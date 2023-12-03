using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindWordsThatCanBeFormedByCharacters
{
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            var letters = Count(chars);
            return words.Where(w => FitAll(Count(w))).Sum(w => w.Length);

            int[] Count(string s)
            {
                var res = new int[26];
                foreach (var c in s)
                    res[c - 'a']++;
                return res;
            }

            bool FitAll(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (letters[i] < arr[i])
                        return false;
                return true;
            }
        }
    }
}