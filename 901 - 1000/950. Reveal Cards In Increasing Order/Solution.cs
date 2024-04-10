using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RevealCardsInIncreasingOrder
{
    public class Solution
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            var n = deck.Length;
            var pos = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
                pos[deck[i]] = i;
            var q = new Queue<int>(deck);
            var deq = new List<int>();
            while (q.Count > 0)
            {
                deq.Add(q.Dequeue());
                if (q.Count > 0)
                    q.Enqueue(q.Dequeue());
            }
            
            Array.Sort(deck);
            var res = new int[n];
            for (int i = 0; i < n; i++)
                res[pos[deq[i]]] = deck[i];
            return res;
        }
    }
}