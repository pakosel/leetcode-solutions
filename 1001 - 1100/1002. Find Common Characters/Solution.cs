using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindCommonCharacters
{
    public class Solution
    {
        public IList<string> CommonChars(string[] words)
        {
            var res = Check(words[0]);
            foreach (var word in words)
            {
                var arr = Check(word);
                for (int i = 0; i < 26; i++)
                    res[i] = Math.Min(arr[i], res[i]);
            }

            var strList = new List<string>();
            for (int i = 0; i < 26; i++)
                for (int x = 0; x < res[i]; x++)
                    strList.Add(new string((char)(i + 'a'), 1));
            return strList;

            IList<int> Check(string s)
            {
                var res = new int[26];
                foreach (var c in s)
                    res[c - 'a']++;
                return res;
            }
        }
    }
}