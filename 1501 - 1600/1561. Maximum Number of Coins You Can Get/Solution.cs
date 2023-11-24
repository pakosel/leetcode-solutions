using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumNumberOfCoinsYouCanGet
{
    public class Solution
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles, (x, y) => y.CompareTo(x));
            var res = 0;
            for (int i = 0; i < 2 * piles.Length / 3; i++)
                if (i % 2 != 0)
                    res += piles[i];
            return res;
        }
    }
}