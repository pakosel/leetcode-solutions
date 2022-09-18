using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumMatchingOfPlayersWithTrainers
{
    public class Solution
    {
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);
            var res = 0;
            int i = 0, j = 0;
            while (i < players.Length && j < trainers.Length)
            {
                if (players[i] <= trainers[j])
                {
                    i++;
                    res++;
                }
                j++;
            }
            return res;
        }
    }
}