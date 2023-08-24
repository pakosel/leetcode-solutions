using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReorganizeString
{
    public class Solution
    {
        public string ReorganizeString(string s)
        {
            var arr = new int[26];
            foreach (var c in s)
                arr[c - 'a']++;
            var pq = new PriorityQueue<(char c, int q), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            for (int i = 0; i < 26; i++)
                if (arr[i] > 0)
                    pq.Enqueue(((char)('a' + i), arr[i]), arr[i]);
            if (pq.Peek().q > (s.Length + 1) / 2)
                return "";
            var sb = new StringBuilder();
            while (pq.Count > 0)
                Take();

            return sb.ToString();

            void Take()
            {
                var (c, q) = pq.Dequeue();
                if (sb.Length > 0 && c == sb[^1])
                {
                    Take();
                    pq.Enqueue((c, q), q);
                }
                else
                {
                    sb.Append(c);
                    if (q > 1)
                        pq.Enqueue((c, q - 1), q - 1);
                }
            }
        }
    }
}