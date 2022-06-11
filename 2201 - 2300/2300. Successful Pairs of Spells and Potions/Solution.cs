using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SuccessfulPairsOfSpellsAndPotions
{
    public class Solution
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var res = new int[spells.Length];
            var pq = new PriorityQueue<(int spell, int pos), int>();
            for (int i = 0; i < spells.Length; i++)
                pq.Enqueue((spells[i], i), spells[i]);
            Array.Sort(potions, (x, y) => y.CompareTo(x));
            
            var potionPos = 0;
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();

                while (potionPos < potions.Length && (long)curr.spell * potions[potionPos] >= success)
                    potionPos++;
                res[curr.pos] = potionPos;
            }
            return res;
        }
    }
}