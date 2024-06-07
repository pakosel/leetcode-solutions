using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace HandOfStraights
{
    public class Solution
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;
            var dict = new Dictionary<int, int>();
            foreach (var h in hand)
                if (dict.ContainsKey(h))
                    dict[h]++;
                else
                    dict[h] = 1;
            var pq = new PriorityQueue<(int n, int cnt), int>();
            foreach (var kvp in dict)
                pq.Enqueue((kvp.Key, kvp.Value), kvp.Key);
            var stack = new Stack<(int n, int cnt)>();

            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                var prev = curr.n;
                if (curr.cnt > 1)
                    stack.Push((curr.n, curr.cnt - 1));
                for (int i = 1; i < groupSize; i++)
                {
                    if (pq.Count == 0)
                        return false;
                    curr = pq.Dequeue();
                    if (curr.n - prev != 1)
                        return false;
                    prev = curr.n;
                    if (curr.cnt > 1)
                        stack.Push((curr.n, curr.cnt - 1));
                }
                while (stack.Any())
                {
                    var pop = stack.Pop();
                    pq.Enqueue((pop.n, pop.cnt), pop.n);
                }
            }
            return true;
        }
    }
}