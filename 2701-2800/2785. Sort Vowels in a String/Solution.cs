using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortVowelsInString
{
    public class Solution
    {
        public string SortVowels(string s)
        {
            var q = new Queue<int>();
            var pq = new PriorityQueue<char, char>();
            for (int i = 0; i < s.Length; i++)
                if (IsVowel(s[i]))
                {
                    q.Enqueue(i);
                    pq.Enqueue(s[i], s[i]);
                }

            var res = new StringBuilder(s);
            while(q.Count > 0)
                res[q.Dequeue()] = pq.Dequeue();

            return res.ToString();

            static bool IsVowel(char c)
            {
                c = char.ToLower(c);
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }
        }
    }
}