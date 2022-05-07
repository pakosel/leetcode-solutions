using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumCostToMoveChips
{
    public class Solution
    {
        public int MinCostToMoveChips(int[] position)
        {
            int sum_odd = 0;
            int sum_even = 0;

            for (int i = 0; i < position.Length; i++)
                if(position[i] % 2 == 0)
                    sum_even++;
                else
                    sum_odd++;

            return Math.Min(sum_odd, sum_even);
        }
    }
}