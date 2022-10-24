using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumLengthOfConcatenatedStringWithUniqueCharacters
{
    public class Solution
    {
        public int MaxLength(IList<string> arr)
        {
            var lst = arr.Where(str => str.Distinct().Count() == str.Length).ToList();
            var len = lst.Count;
            var letters = new bool[len][];
            for (int i = len - 1; i >= 0; i--)
            {
                letters[i] = new bool[26];
                foreach (var c in lst[i])
                    letters[i][c - 'a'] = true;
            }

            var max = 0;
            var empty = new bool[26];
            for (int i = 0; i < len; i++)
            {
                Array.Fill(empty, false);
                Take(empty, i);
            }
            return max;

            void Take(bool[] curr, int start)
            {
                if (!CanConcat(curr, letters[start]))
                    return;
                for (int i = 0; i < curr.Length; i++)
                    curr[i] |= letters[start][i];
                max = Math.Max(max, curr.Count(e => e));
                
                var nested = new bool[26];
                for (int i = start + 1; i < len; i++)
                {
                    Array.Copy(curr, nested, nested.Length);
                    Take(nested, i);
                }
            }

            bool CanConcat(bool[] arr1, bool[] arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                    if (arr1[i] == true && arr2[i] == true)
                        return false;
                return true;
            }
        }
    }
}