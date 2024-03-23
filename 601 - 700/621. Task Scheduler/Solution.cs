using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace TaskScheduler
{
    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            var arr = new int[26];
            foreach (var c in tasks)
                arr[c - 'A']++;
            var pq = new PriorityQueue<char, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < 26; i++)
                if (arr[i] > 0)
                    pq.Enqueue((char)('A' + i), arr[i]);

            var q = new Queue<char>();
            var res = 0;
            var total = tasks.Length;
            while (total > 0)
            {
                if (pq.Count > 0)
                {
                    res++;
                    total--;
                    var c = pq.Dequeue();
                    if (--arr[c - 'A'] > 0)
                        q.Enqueue(c);
                    else
                        q.Enqueue('*');
                }
                else
                {
                    res++;
                    q.Enqueue('*');
                }
                while (q.Count > n)
                {
                    var c = q.Dequeue();
                    if (c != '*')
                        pq.Enqueue(c, arr[c - 'A']);
                }
            }
            return res;
        }
    }
}