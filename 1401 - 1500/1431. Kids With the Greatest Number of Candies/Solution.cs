using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace KidsWithTheGreatestNumberOfCandies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = candies.Max();

            return candies.Select(c => c + extraCandies >= max).ToList();
        }
    }
}